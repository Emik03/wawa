// <auto-generated/>
// Emik.SourceGenerators.Tattoo, v2.0.7
#pragma warning disable
global using global::System;
global using global::System.CodeDom;
global using global::System.CodeDom.Compiler;
global using global::System.Collections;
global using global::System.Collections.Generic;
global using global::System.Collections.ObjectModel;
global using global::System.Collections.Specialized;
global using global::System.ComponentModel;
global using global::System.ComponentModel.Design;
global using global::System.ComponentModel.Design.Serialization;
global using global::System.Configuration;
global using global::System.Configuration.Assemblies;
global using global::System.Data;
global using global::System.Data.Common;
global using global::System.Data.Odbc;
global using global::System.Data.OleDb;
global using global::System.Data.Sql;
global using global::System.Data.SqlClient;
global using global::System.Data.SqlTypes;
global using global::System.Deployment;
global using global::System.Deployment.Internal;
global using global::System.Diagnostics;
global using global::System.Diagnostics.CodeAnalysis;
global using global::System.Diagnostics.Eventing;
global using global::System.Diagnostics.Eventing.Reader;
global using global::System.Diagnostics.PerformanceData;
global using global::System.Diagnostics.SymbolStore;
global using global::System.Drawing;
global using global::System.Drawing.Design;
global using global::System.Drawing.Drawing2D;
global using global::System.Drawing.Imaging;
global using global::System.Drawing.Printing;
global using global::System.Drawing.Text;
global using global::System.Globalization;
global using global::System.IO;
global using global::System.IO.Compression;
global using global::System.IO.IsolatedStorage;
global using global::System.IO.Pipes;
global using global::System.IO.Ports;
global using global::System.Linq;
global using global::System.Linq.Expressions;
global using global::System.Management;
global using global::System.Management.Instrumentation;
global using global::System.Media;
global using global::System.Net;
global using global::System.Net.Cache;
global using global::System.Net.Configuration;
global using global::System.Net.Mail;
global using global::System.Net.Mime;
global using global::System.Net.NetworkInformation;
global using global::System.Net.Security;
global using global::System.Net.Sockets;
global using global::System.Reflection;
global using global::System.Reflection.Emit;
global using global::System.Resources;
global using global::System.Runtime;
global using global::System.Runtime.CompilerServices;
global using global::System.Runtime.ConstrainedExecution;
global using global::System.Runtime.Hosting;
global using global::System.Runtime.InteropServices;
global using global::System.Runtime.InteropServices.ComTypes;
global using global::System.Runtime.InteropServices.Expando;
global using global::System.Runtime.Remoting;
global using global::System.Runtime.Remoting.Activation;
global using global::System.Runtime.Remoting.Channels;
global using global::System.Runtime.Remoting.Contexts;
global using global::System.Runtime.Remoting.Lifetime;
global using global::System.Runtime.Remoting.Messaging;
global using global::System.Runtime.Remoting.Metadata;
global using global::System.Runtime.Remoting.Metadata.W3cXsd2001;
global using global::System.Runtime.Remoting.Proxies;
global using global::System.Runtime.Remoting.Services;
global using global::System.Runtime.Serialization;
global using global::System.Runtime.Serialization.Configuration;
global using global::System.Runtime.Serialization.Formatters;
global using global::System.Runtime.Serialization.Formatters.Binary;
global using global::System.Runtime.Versioning;
global using global::System.Security;
global using global::System.Security.AccessControl;
global using global::System.Security.Authentication;
global using global::System.Security.Authentication.ExtendedProtection;
global using global::System.Security.Authentication.ExtendedProtection.Configuration;
global using global::System.Security.Cryptography;
global using global::System.Security.Cryptography.X509Certificates;
global using global::System.Security.Permissions;
global using global::System.Security.Policy;
global using global::System.Security.Principal;
global using global::System.Text;
global using global::System.Text.RegularExpressions;
global using global::System.Threading;
global using global::System.Timers;
global using global::System.Web;
global using global::System.Xml;
global using global::System.Xml.Linq;
global using global::System.Xml.Linq.ComponentModel;
global using global::System.Xml.Schema;
global using global::System.Xml.Serialization;
global using global::System.Xml.Serialization.Advanced;
global using global::System.Xml.Serialization.Configuration;
global using global::System.Xml.XPath;
global using global::System.Xml.Xsl;
global using global::AOT;
global using global::Assets;
global using global::Assets.OVR;
global using global::Assets.OVR.Scripts;
global using global::Assets.Prototype;
global using global::Assets.Prototype.GasVent;
global using global::Assets.Scripts;
global using global::Assets.Scripts.AutomatedTesting;
global using global::Assets.Scripts.AutomatedTesting.Reports;
global using global::Assets.Scripts.AutomatedTesting.Solvers;
global using global::Assets.Scripts.AutomatedTesting.TestFixtures;
global using global::Assets.Scripts.BombBinder;
global using global::Assets.Scripts.Components;
global using global::Assets.Scripts.Components.VennWire;
global using global::Assets.Scripts.DemoRecorder;
global using global::Assets.Scripts.DossierMenu;
global using global::Assets.Scripts.Input;
global using global::Assets.Scripts.Leaderboards;
global using global::Assets.Scripts.Lightmapping;
global using global::Assets.Scripts.Logging;
global using global::Assets.Scripts.Manual;
global using global::Assets.Scripts.Menu;
global using global::Assets.Scripts.Menu.Animations;
global using global::Assets.Scripts.Menu.ControlsTutorial;
global using global::Assets.Scripts.Missions;
global using global::Assets.Scripts.Mods;
global using global::Assets.Scripts.Mods.Mission;
global using global::Assets.Scripts.Mods.Screens;
global using global::Assets.Scripts.Pacing;
global using global::Assets.Scripts.Platform;
global using global::Assets.Scripts.Platform.Common;
global using global::Assets.Scripts.Platform.Common.IO;
global using global::Assets.Scripts.Platform.IOS;
global using global::Assets.Scripts.Platform.IOS.IO;
global using global::Assets.Scripts.Platform.Linux;
global using global::Assets.Scripts.Platform.Linux.IO;
global using global::Assets.Scripts.Platform.OSX;
global using global::Assets.Scripts.Platform.OSX.IO;
global using global::Assets.Scripts.Platform.PC;
global using global::Assets.Scripts.Platform.PC.IO;
global using global::Assets.Scripts.Platform.PS4;
global using global::Assets.Scripts.Platform.PS4.IO;
global using global::Assets.Scripts.Progression;
global using global::Assets.Scripts.Props;
global using global::Assets.Scripts.Records;
global using global::Assets.Scripts.Rules;
global using global::Assets.Scripts.Rules.JsonConverters;
global using global::Assets.Scripts.Services;
global using global::Assets.Scripts.Services.Android;
global using global::Assets.Scripts.Services.IOS;
global using global::Assets.Scripts.Services.OculusServices;
global using global::Assets.Scripts.Services.Steam;
global using global::Assets.Scripts.Services.XBoxOne;
global using global::Assets.Scripts.Settings;
global using global::Assets.Scripts.Stats;
global using global::Assets.Scripts.Test;
global using global::Assets.Scripts.Tournaments;
global using global::Assets.Scripts.UI;
global using global::Assets.Scripts.UserManagement;
global using global::Assets.Scripts.Utility;
global using global::Assets.Scripts.VR;
global using global::Assets.Scripts.VR.Null;
global using global::Assets.Scripts.VR.Oculus;
global using global::BasicExample;
global using global::BindingsExample;
global using global::BombGame;
global using global::DarkTonic;
global using global::DarkTonic.MasterAudio;
global using global::DigitalOpus;
global using global::DigitalOpus.MB;
global using global::DigitalOpus.MB.Core;
global using global::Emik;
global using global::Events;
global using global::Gvr;
global using global::Gvr.Internal;
global using global::I2;
global using global::I2.Loc;
global using global::I2.Loc.SimpleJSON;
global using global::InControl;
global using global::InControl.Internal;
global using global::InControl.NativeProfile;
global using global::InlineMethod;
global using global::InterfaceMovement;
global using global::JetBrains;
global using global::JetBrains.Annotations;
global using global::KeyboardAndMouseExample;
global using global::Microsoft;
global using global::Microsoft.CSharp;
global using global::Microsoft.CodeAnalysis;
global using global::Microsoft.Contracts;
global using global::Microsoft.SqlServer;
global using global::Microsoft.SqlServer.Server;
global using global::Microsoft.VisualBasic;
global using global::Microsoft.Win32;
global using global::Microsoft.Win32.SafeHandles;
global using global::MultiplayerBasicExample;
global using global::MultiplayerWithBindingsExample;
global using global::Newtonsoft;
global using global::Newtonsoft.Json;
global using global::Newtonsoft.Json.Bson;
global using global::Newtonsoft.Json.Converters;
global using global::Newtonsoft.Json.Linq;
global using global::Newtonsoft.Json.Linq.JsonPath;
global using global::Newtonsoft.Json.Serialization;
global using global::Newtonsoft.Json.Shims;
global using global::Newtonsoft.Json.Utilities;
global using global::NullGuard;
global using global::OVR;
global using global::OVR.OpenVR;
global using global::OVRSimpleJSON;
global using global::Oculus;
global using global::Oculus.Platform;
global using global::Oculus.Platform.Models;
global using global::Oculus.Platform.Samples;
global using global::Oculus.Platform.Samples.EntitlementCheck;
global using global::Oculus.Platform.Samples.NetChat;
global using global::Oculus.Platform.Samples.SimplePlatformSample;
global using global::Oculus.Platform.Samples.VrBoardGame;
global using global::Oculus.Platform.Samples.VrHoops;
global using global::Oculus.Platform.Samples.VrVoiceChat;
global using global::SimpleJson;
global using global::SimpleJson.Reflection;
global using global::TMPro;
global using global::TMPro.SpriteAssetUtilities;
global using global::TouchExample;
global using global::UnitGenerator;
global using global::UnityEditor;
global using global::UnityEditor.AI;
global using global::UnityEditor.Accessibility;
global using global::UnityEditor.Advertisements;
global using global::UnityEditor.Analytics;
global using global::UnityEditor.AnimatedValues;
global using global::UnityEditor.Animations;
global using global::UnityEditor.Audio;
global using global::UnityEditor.Build;
global using global::UnityEditor.BuildReporting;
global using global::UnityEditor.Callbacks;
global using global::UnityEditor.CloudBuild;
global using global::UnityEditor.Collaboration;
global using global::UnityEditor.Compilation;
global using global::UnityEditor.Connect;
global using global::UnityEditor.CrashReporting;
global using global::UnityEditor.DeploymentTargets;
global using global::UnityEditor.Events;
global using global::UnityEditor.Experimental;
global using global::UnityEditor.Experimental.Animations;
global using global::UnityEditor.Experimental.AssetImporters;
global using global::UnityEditor.Experimental.Build;
global using global::UnityEditor.Experimental.Build.AssetBundle;
global using global::UnityEditor.Experimental.Build.Player;
global using global::UnityEditor.Experimental.U2D;
global using global::UnityEditor.Experimental.UIElements;
global using global::UnityEditor.Experimental.UIElements.Debugger;
global using global::UnityEditor.Experimental.UIElements.GraphView;
global using global::UnityEditor.Hardware;
global using global::UnityEditor.IMGUI;
global using global::UnityEditor.IMGUI.Controls;
global using global::UnityEditor.Macros;
global using global::UnityEditor.Media;
global using global::UnityEditor.MemoryProfiler;
global using global::UnityEditor.Modules;
global using global::UnityEditor.Networking;
global using global::UnityEditor.Networking.PlayerConnection;
global using global::UnityEditor.PackageManager;
global using global::UnityEditor.PackageManager.Requests;
global using global::UnityEditor.ProjectWindowCallback;
global using global::UnityEditor.Purchasing;
global using global::UnityEditor.Rendering;
global using global::UnityEditor.RestService;
global using global::UnityEditor.SceneManagement;
global using global::UnityEditor.Scripting;
global using global::UnityEditor.Scripting.Compilers;
global using global::UnityEditor.Scripting.ScriptCompilation;
global using global::UnityEditor.Scripting.Serialization;
global using global::UnityEditor.Sprites;
global using global::UnityEditor.StyleSheets;
global using global::UnityEditor.TreeViewExamples;
global using global::UnityEditor.U2D;
global using global::UnityEditor.U2D.Common;
global using global::UnityEditor.U2D.Interface;
global using global::UnityEditor.Utils;
global using global::UnityEditor.VersionControl;
global using global::UnityEditor.VisualStudioIntegration;
global using global::UnityEditor.Web;
global using global::UnityEditor.XR;
global using global::UnityEditor.XR.Daydream;
global using global::UnityEditorInternal;
global using global::UnityEditorInternal.VR;
global using global::UnityEditorInternal.VersionControl;
global using global::UnityEngine;
global using global::UnityEngine.AI;
global using global::UnityEngine.Accessibility;
global using global::UnityEngine.Advertisements;
global using global::UnityEngine.Analytics;
global using global::UnityEngine.Animations;
global using global::UnityEngine.Apple;
global using global::UnityEngine.Apple.ReplayKit;
global using global::UnityEngine.Apple.TV;
global using global::UnityEngine.Assertions;
global using global::UnityEngine.Assertions.Comparers;
global using global::UnityEngine.Assertions.Must;
global using global::UnityEngine.Audio;
global using global::UnityEngine.Bindings;
global using global::UnityEngine.CSSLayout;
global using global::UnityEngine.Collections;
global using global::UnityEngine.Connect;
global using global::UnityEngine.CrashReportHandler;
global using global::UnityEngine.Diagnostics;
global using global::UnityEngine.EventSystems;
global using global::UnityEngine.Events;
global using global::UnityEngine.Experimental;
global using global::UnityEngine.Experimental.Playables;
global using global::UnityEngine.Experimental.Rendering;
global using global::UnityEngine.Experimental.U2D;
global using global::UnityEngine.Experimental.UIElements;
global using global::UnityEngine.Experimental.UIElements.StyleEnums;
global using global::UnityEngine.Experimental.UIElements.StyleSheets;
global using global::UnityEngine.Experimental.Video;
global using global::UnityEngine.Experimental.XR;
global using global::UnityEngine.Internal;
global using global::UnityEngine.Internal.VR;
global using global::UnityEngine.Networking;
global using global::UnityEngine.Networking.Match;
global using global::UnityEngine.Networking.PlayerConnection;
global using global::UnityEngine.Networking.Types;
global using global::UnityEngine.Playables;
global using global::UnityEngine.Profiling;
global using global::UnityEngine.Rendering;
global using global::UnityEngine.SceneManagement;
global using global::UnityEngine.Scripting;
global using global::UnityEngine.Scripting.APIUpdating;
global using global::UnityEngine.Serialization;
global using global::UnityEngine.SocialPlatforms;
global using global::UnityEngine.SocialPlatforms.GameCenter;
global using global::UnityEngine.SocialPlatforms.Impl;
global using global::UnityEngine.Sprites;
global using global::UnityEngine.StyleSheets;
global using global::UnityEngine.Tilemaps;
global using global::UnityEngine.Tizen;
global using global::UnityEngine.U2D;
global using global::UnityEngine.U2D.Interface;
global using global::UnityEngine.VR;
global using global::UnityEngine.Video;
global using global::UnityEngine.WSA;
global using global::UnityEngine.Windows;
global using global::UnityEngine.Windows.Speech;
global using global::UnityEngine.XR;
global using global::UnityEngine.XR.Tango;
global using global::UnityEngine.XR.WSA;
global using global::UnityEngine.XR.WSA.Input;
global using global::UnityEngine.XR.WSA.Persistence;
global using global::UnityEngine.XR.WSA.Sharing;
global using global::UnityEngine.XR.WSA.WebCam;
global using global::UnityEngine.iOS;
global using global::UnityEngineInternal;
global using global::UnityEngineInternal.Input;
global using global::VirtualDeviceExample;
global using global::Wawa;
global using global::Wawa.Editors;
global using global::Wawa.Editors.Internals;
global using global::nn;
global using global::nn.nifm;
global using global::proto;
global using global::proto.Proto;

// Polyfills of namespaces in case dependencies are conditional.
namespace System { }

namespace System.CodeDom { }

namespace System.CodeDom.Compiler { }

namespace System.Collections { }

namespace System.Collections.Generic { }

namespace System.Collections.ObjectModel { }

namespace System.Collections.Specialized { }

namespace System.ComponentModel { }

namespace System.ComponentModel.Design { }

namespace System.ComponentModel.Design.Serialization { }

namespace System.Configuration { }

namespace System.Configuration.Assemblies { }

namespace System.Data { }

namespace System.Data.Common { }

namespace System.Data.Odbc { }

namespace System.Data.OleDb { }

namespace System.Data.Sql { }

namespace System.Data.SqlClient { }

namespace System.Data.SqlTypes { }

namespace System.Deployment { }

namespace System.Deployment.Internal { }

namespace System.Diagnostics { }

namespace System.Diagnostics.CodeAnalysis { }

namespace System.Diagnostics.Eventing { }

namespace System.Diagnostics.Eventing.Reader { }

namespace System.Diagnostics.PerformanceData { }

namespace System.Diagnostics.SymbolStore { }

namespace System.Drawing { }

namespace System.Drawing.Design { }

namespace System.Drawing.Drawing2D { }

namespace System.Drawing.Imaging { }

namespace System.Drawing.Printing { }

namespace System.Drawing.Text { }

namespace System.Globalization { }

namespace System.IO { }

namespace System.IO.Compression { }

namespace System.IO.IsolatedStorage { }

namespace System.IO.Pipes { }

namespace System.IO.Ports { }

namespace System.Linq { }

namespace System.Linq.Expressions { }

namespace System.Management { }

namespace System.Management.Instrumentation { }

namespace System.Media { }

namespace System.Net { }

namespace System.Net.Cache { }

namespace System.Net.Configuration { }

namespace System.Net.Mail { }

namespace System.Net.Mime { }

namespace System.Net.NetworkInformation { }

namespace System.Net.Security { }

namespace System.Net.Sockets { }

namespace System.Reflection { }

namespace System.Reflection.Emit { }

namespace System.Resources { }

namespace System.Runtime { }

namespace System.Runtime.CompilerServices { }

namespace System.Runtime.ConstrainedExecution { }

namespace System.Runtime.Hosting { }

namespace System.Runtime.InteropServices { }

namespace System.Runtime.InteropServices.ComTypes { }

namespace System.Runtime.InteropServices.Expando { }

namespace System.Runtime.Remoting { }

namespace System.Runtime.Remoting.Activation { }

namespace System.Runtime.Remoting.Channels { }

namespace System.Runtime.Remoting.Contexts { }

namespace System.Runtime.Remoting.Lifetime { }

namespace System.Runtime.Remoting.Messaging { }

namespace System.Runtime.Remoting.Metadata { }

namespace System.Runtime.Remoting.Metadata.W3cXsd2001 { }

namespace System.Runtime.Remoting.Proxies { }

namespace System.Runtime.Remoting.Services { }

namespace System.Runtime.Serialization { }

namespace System.Runtime.Serialization.Configuration { }

namespace System.Runtime.Serialization.Formatters { }

namespace System.Runtime.Serialization.Formatters.Binary { }

namespace System.Runtime.Versioning { }

namespace System.Security { }

namespace System.Security.AccessControl { }

namespace System.Security.Authentication { }

namespace System.Security.Authentication.ExtendedProtection { }

namespace System.Security.Authentication.ExtendedProtection.Configuration { }

namespace System.Security.Cryptography { }

namespace System.Security.Cryptography.X509Certificates { }

namespace System.Security.Permissions { }

namespace System.Security.Policy { }

namespace System.Security.Principal { }

namespace System.Text { }

namespace System.Text.RegularExpressions { }

namespace System.Threading { }

namespace System.Timers { }

namespace System.Web { }

namespace System.Xml { }

namespace System.Xml.Linq { }

namespace System.Xml.Linq.ComponentModel { }

namespace System.Xml.Schema { }

namespace System.Xml.Serialization { }

namespace System.Xml.Serialization.Advanced { }

namespace System.Xml.Serialization.Configuration { }

namespace System.Xml.XPath { }

namespace System.Xml.Xsl { }

namespace AOT { }

namespace Assets { }

namespace Assets.OVR { }

namespace Assets.OVR.Scripts { }

namespace Assets.Prototype { }

namespace Assets.Prototype.GasVent { }

namespace Assets.Scripts { }

namespace Assets.Scripts.AutomatedTesting { }

namespace Assets.Scripts.AutomatedTesting.Reports { }

namespace Assets.Scripts.AutomatedTesting.Solvers { }

namespace Assets.Scripts.AutomatedTesting.TestFixtures { }

namespace Assets.Scripts.BombBinder { }

namespace Assets.Scripts.Components { }

namespace Assets.Scripts.Components.VennWire { }

namespace Assets.Scripts.DemoRecorder { }

namespace Assets.Scripts.DossierMenu { }

namespace Assets.Scripts.Input { }

namespace Assets.Scripts.Leaderboards { }

namespace Assets.Scripts.Lightmapping { }

namespace Assets.Scripts.Logging { }

namespace Assets.Scripts.Manual { }

namespace Assets.Scripts.Menu { }

namespace Assets.Scripts.Menu.Animations { }

namespace Assets.Scripts.Menu.ControlsTutorial { }

namespace Assets.Scripts.Missions { }

namespace Assets.Scripts.Mods { }

namespace Assets.Scripts.Mods.Mission { }

namespace Assets.Scripts.Mods.Screens { }

namespace Assets.Scripts.Pacing { }

namespace Assets.Scripts.Platform { }

namespace Assets.Scripts.Platform.Common { }

namespace Assets.Scripts.Platform.Common.IO { }

namespace Assets.Scripts.Platform.IOS { }

namespace Assets.Scripts.Platform.IOS.IO { }

namespace Assets.Scripts.Platform.Linux { }

namespace Assets.Scripts.Platform.Linux.IO { }

namespace Assets.Scripts.Platform.OSX { }

namespace Assets.Scripts.Platform.OSX.IO { }

namespace Assets.Scripts.Platform.PC { }

namespace Assets.Scripts.Platform.PC.IO { }

namespace Assets.Scripts.Platform.PS4 { }

namespace Assets.Scripts.Platform.PS4.IO { }

namespace Assets.Scripts.Progression { }

namespace Assets.Scripts.Props { }

namespace Assets.Scripts.Records { }

namespace Assets.Scripts.Rules { }

namespace Assets.Scripts.Rules.JsonConverters { }

namespace Assets.Scripts.Services { }

namespace Assets.Scripts.Services.Android { }

namespace Assets.Scripts.Services.IOS { }

namespace Assets.Scripts.Services.OculusServices { }

namespace Assets.Scripts.Services.Steam { }

namespace Assets.Scripts.Services.XBoxOne { }

namespace Assets.Scripts.Settings { }

namespace Assets.Scripts.Stats { }

namespace Assets.Scripts.Test { }

namespace Assets.Scripts.Tournaments { }

namespace Assets.Scripts.UI { }

namespace Assets.Scripts.UserManagement { }

namespace Assets.Scripts.Utility { }

namespace Assets.Scripts.VR { }

namespace Assets.Scripts.VR.Null { }

namespace Assets.Scripts.VR.Oculus { }

namespace BasicExample { }

namespace BindingsExample { }

namespace BombGame { }

namespace DarkTonic { }

namespace DarkTonic.MasterAudio { }

namespace DigitalOpus { }

namespace DigitalOpus.MB { }

namespace DigitalOpus.MB.Core { }

namespace Emik { }

namespace Events { }

namespace Gvr { }

namespace Gvr.Internal { }

namespace I2 { }

namespace I2.Loc { }

namespace I2.Loc.SimpleJSON { }

namespace InControl { }

namespace InControl.Internal { }

namespace InControl.NativeProfile { }

namespace InlineMethod { }

namespace InterfaceMovement { }

namespace JetBrains { }

namespace JetBrains.Annotations { }

namespace KeyboardAndMouseExample { }

namespace Microsoft { }

namespace Microsoft.CSharp { }

namespace Microsoft.CodeAnalysis { }

namespace Microsoft.Contracts { }

namespace Microsoft.SqlServer { }

namespace Microsoft.SqlServer.Server { }

namespace Microsoft.VisualBasic { }

namespace Microsoft.Win32 { }

namespace Microsoft.Win32.SafeHandles { }

namespace MultiplayerBasicExample { }

namespace MultiplayerWithBindingsExample { }

namespace Newtonsoft { }

namespace Newtonsoft.Json { }

namespace Newtonsoft.Json.Bson { }

namespace Newtonsoft.Json.Converters { }

namespace Newtonsoft.Json.Linq { }

namespace Newtonsoft.Json.Linq.JsonPath { }

namespace Newtonsoft.Json.Serialization { }

namespace Newtonsoft.Json.Shims { }

namespace Newtonsoft.Json.Utilities { }

namespace NullGuard { }

namespace OVR { }

namespace OVR.OpenVR { }

namespace OVRSimpleJSON { }

namespace Oculus { }

namespace Oculus.Platform { }

namespace Oculus.Platform.Models { }

namespace Oculus.Platform.Samples { }

namespace Oculus.Platform.Samples.EntitlementCheck { }

namespace Oculus.Platform.Samples.NetChat { }

namespace Oculus.Platform.Samples.SimplePlatformSample { }

namespace Oculus.Platform.Samples.VrBoardGame { }

namespace Oculus.Platform.Samples.VrHoops { }

namespace Oculus.Platform.Samples.VrVoiceChat { }

namespace SimpleJson { }

namespace SimpleJson.Reflection { }

namespace TMPro { }

namespace TMPro.SpriteAssetUtilities { }

namespace TouchExample { }

namespace UnitGenerator { }

namespace UnityEditor { }

namespace UnityEditor.AI { }

namespace UnityEditor.Accessibility { }

namespace UnityEditor.Advertisements { }

namespace UnityEditor.Analytics { }

namespace UnityEditor.AnimatedValues { }

namespace UnityEditor.Animations { }

namespace UnityEditor.Audio { }

namespace UnityEditor.Build { }

namespace UnityEditor.BuildReporting { }

namespace UnityEditor.Callbacks { }

namespace UnityEditor.CloudBuild { }

namespace UnityEditor.Collaboration { }

namespace UnityEditor.Compilation { }

namespace UnityEditor.Connect { }

namespace UnityEditor.CrashReporting { }

namespace UnityEditor.DeploymentTargets { }

namespace UnityEditor.Events { }

namespace UnityEditor.Experimental { }

namespace UnityEditor.Experimental.Animations { }

namespace UnityEditor.Experimental.AssetImporters { }

namespace UnityEditor.Experimental.Build { }

namespace UnityEditor.Experimental.Build.AssetBundle { }

namespace UnityEditor.Experimental.Build.Player { }

namespace UnityEditor.Experimental.U2D { }

namespace UnityEditor.Experimental.UIElements { }

namespace UnityEditor.Experimental.UIElements.Debugger { }

namespace UnityEditor.Experimental.UIElements.GraphView { }

namespace UnityEditor.Hardware { }

namespace UnityEditor.IMGUI { }

namespace UnityEditor.IMGUI.Controls { }

namespace UnityEditor.Macros { }

namespace UnityEditor.Media { }

namespace UnityEditor.MemoryProfiler { }

namespace UnityEditor.Modules { }

namespace UnityEditor.Networking { }

namespace UnityEditor.Networking.PlayerConnection { }

namespace UnityEditor.PackageManager { }

namespace UnityEditor.PackageManager.Requests { }

namespace UnityEditor.ProjectWindowCallback { }

namespace UnityEditor.Purchasing { }

namespace UnityEditor.Rendering { }

namespace UnityEditor.RestService { }

namespace UnityEditor.SceneManagement { }

namespace UnityEditor.Scripting { }

namespace UnityEditor.Scripting.Compilers { }

namespace UnityEditor.Scripting.ScriptCompilation { }

namespace UnityEditor.Scripting.Serialization { }

namespace UnityEditor.Sprites { }

namespace UnityEditor.StyleSheets { }

namespace UnityEditor.TreeViewExamples { }

namespace UnityEditor.U2D { }

namespace UnityEditor.U2D.Common { }

namespace UnityEditor.U2D.Interface { }

namespace UnityEditor.Utils { }

namespace UnityEditor.VersionControl { }

namespace UnityEditor.VisualStudioIntegration { }

namespace UnityEditor.Web { }

namespace UnityEditor.XR { }

namespace UnityEditor.XR.Daydream { }

namespace UnityEditorInternal { }

namespace UnityEditorInternal.VR { }

namespace UnityEditorInternal.VersionControl { }

namespace UnityEngine { }

namespace UnityEngine.AI { }

namespace UnityEngine.Accessibility { }

namespace UnityEngine.Advertisements { }

namespace UnityEngine.Analytics { }

namespace UnityEngine.Animations { }

namespace UnityEngine.Apple { }

namespace UnityEngine.Apple.ReplayKit { }

namespace UnityEngine.Apple.TV { }

namespace UnityEngine.Assertions { }

namespace UnityEngine.Assertions.Comparers { }

namespace UnityEngine.Assertions.Must { }

namespace UnityEngine.Audio { }

namespace UnityEngine.Bindings { }

namespace UnityEngine.CSSLayout { }

namespace UnityEngine.Collections { }

namespace UnityEngine.Connect { }

namespace UnityEngine.CrashReportHandler { }

namespace UnityEngine.Diagnostics { }

namespace UnityEngine.EventSystems { }

namespace UnityEngine.Events { }

namespace UnityEngine.Experimental { }

namespace UnityEngine.Experimental.Playables { }

namespace UnityEngine.Experimental.Rendering { }

namespace UnityEngine.Experimental.U2D { }

namespace UnityEngine.Experimental.UIElements { }

namespace UnityEngine.Experimental.UIElements.StyleEnums { }

namespace UnityEngine.Experimental.UIElements.StyleSheets { }

namespace UnityEngine.Experimental.Video { }

namespace UnityEngine.Experimental.XR { }

namespace UnityEngine.Internal { }

namespace UnityEngine.Internal.VR { }

namespace UnityEngine.Networking { }

namespace UnityEngine.Networking.Match { }

namespace UnityEngine.Networking.PlayerConnection { }

namespace UnityEngine.Networking.Types { }

namespace UnityEngine.Playables { }

namespace UnityEngine.Profiling { }

namespace UnityEngine.Rendering { }

namespace UnityEngine.SceneManagement { }

namespace UnityEngine.Scripting { }

namespace UnityEngine.Scripting.APIUpdating { }

namespace UnityEngine.Serialization { }

namespace UnityEngine.SocialPlatforms { }

namespace UnityEngine.SocialPlatforms.GameCenter { }

namespace UnityEngine.SocialPlatforms.Impl { }

namespace UnityEngine.Sprites { }

namespace UnityEngine.StyleSheets { }

namespace UnityEngine.Tilemaps { }

namespace UnityEngine.Tizen { }

namespace UnityEngine.U2D { }

namespace UnityEngine.U2D.Interface { }

namespace UnityEngine.VR { }

namespace UnityEngine.Video { }

namespace UnityEngine.WSA { }

namespace UnityEngine.Windows { }

namespace UnityEngine.Windows.Speech { }

namespace UnityEngine.XR { }

namespace UnityEngine.XR.Tango { }

namespace UnityEngine.XR.WSA { }

namespace UnityEngine.XR.WSA.Input { }

namespace UnityEngine.XR.WSA.Persistence { }

namespace UnityEngine.XR.WSA.Sharing { }

namespace UnityEngine.XR.WSA.WebCam { }

namespace UnityEngine.iOS { }

namespace UnityEngineInternal { }

namespace UnityEngineInternal.Input { }

namespace VirtualDeviceExample { }

namespace Wawa { }

namespace Wawa.Editors { }

namespace Wawa.Editors.Internals { }

namespace nn { }

namespace nn.nifm { }

namespace proto { }

namespace proto.Proto { }
