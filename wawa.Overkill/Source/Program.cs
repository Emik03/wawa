// SPDX-License-Identifier: MPL-2.0
using Mono.Cecil.Cil;
using OpCodes = Mono.Cecil.Cil.OpCodes;

args = new[]
{
    "/home/emik/.steam/steam/steamapps/common/Keep Talking and Nobody Explodes/ktane_Data/Managed/Assembly-CSharp.dll",
    "/mnt/d/gerrymandering/Assets/Editor/Plugins/Managed/wawa.Overkill.dll",
};

if (args is not [{ } gamePath, { } destPath])
    throw Exit.Usage(Usage());

var assemblyName = Assembly.GetExecutingAssembly().GetName();
using var game = AssemblyDefinition.ReadAssembly(gamePath);
var module = game.MainModule;
var name = assemblyName.Name;
var version = assemblyName.Version;

game.Name = new(name, version);
module.Name = name;
module.AssemblyReferences.Where(IsLegal).For(x => module.AssemblyReferences.Remove(x));
module.ModuleReferences.Clear();
module.ManyOrEmpty(ModuleDefinitionRocks.GetAllTypes).For(ChangeType);
game.Write(destPath);

// module.Types.Where(x => x.FullName is "SteamVR_Controller" or "GvrAudio").For(x => module.Types.Remove(x));

static void ChangeType(TypeDefinition type)
{
    if (type.FullName is "SteamVR_Controller")
        Clear(type);

    Clear(type);

    type.Namespace = Namespace(type.Namespace);
    type.Name = $"_{type.Name}";
    type.Methods.For(ReplaceImplementation).Where(x => x.IsPInvokeImpl).For(x => type.Methods.Remove(x));
}

static void Clear(TypeDefinition type)
{
    type.CustomAttributes.Clear();
    type.Interfaces.Clear();
    type.Events.Clear();
    type.Fields.Clear();
    type.GenericParameters.Clear();
    type.Methods.Clear();
    type.NestedTypes.For(Clear);
    type.Properties.Clear();
    type.SecurityDeclarations.Clear();
}

static void ReplaceImplementation(MethodDefinition method)
{
    if (method.Body is not { } body)
        return;

    var il = body.GetILProcessor();

    body.Variables.Clear();
    il.Clear();

    (method.ReturnType.FullName == typeof(void).FullName ? (Action<ILProcessor>)EmitVoid :
        method.ReturnType.IsValueType ? EmitValueType : EmitReferenceType)(il);

    il.Emit(OpCodes.Ret);
}

static void EmitReferenceType(ILProcessor il)
{
    il.Body.MaxStackSize = 8;
    il.Emit(OpCodes.Ldnull);
}

static void EmitVoid(ILProcessor il) => il.Body.MaxStackSize = 8;

static void EmitValueType(ILProcessor il)
{
    var body = il.Body;
    var ret = body.Method.ReturnType;

    body.MaxStackSize = 1;
    body.Variables.Add(new(ret));

    il.Emit(OpCodes.Ldloca_S, (byte)0);
    il.Emit(OpCodes.Initobj, ret);
    il.Emit(OpCodes.Ldloc_0);
}

static bool IsLegal(IMetadataScope metadata) =>
    metadata.Name is
        not "KMFramework" and
        not "mscorlib" and
        not "Newtonsoft.Json" and
        not "System" and
        not "System.Core" and
        not "System.Xml" and
        not "UnityEngine" and
        not "UnityEngine.CoreModule";

static string Namespace(string space) => space.IsNullOrEmpty() ? "Wawa.Overkill" : $"Wawa.Overkill.{space}";

static string Usage() =>
    $"Usage: {Assembly.GetExecutingAssembly().Location} <Read:Assembly-CSharp.dll> <Read:UnityEngine.dll> <Write:wawa.Overkill.dll>";
