﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KryptonToolkitUpdater.Settings {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.7.0.0")]
    internal sealed partial class UpdaterSettings : global::System.Configuration.ApplicationSettingsBase {
        
        private static UpdaterSettings defaultInstance = ((UpdaterSettings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new UpdaterSettings())));
        
        public static UpdaterSettings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool AlwaysCheckInternetConnection {
            get {
                return ((bool)(this["AlwaysCheckInternetConnection"]));
            }
            set {
                this["AlwaysCheckInternetConnection"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool AlwaysAskForDownloadLocation {
            get {
                return ((bool)(this["AlwaysAskForDownloadLocation"]));
            }
            set {
                this["AlwaysAskForDownloadLocation"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool ShowProgressBarInTaskbar {
            get {
                return ((bool)(this["ShowProgressBarInTaskbar"]));
            }
            set {
                this["ShowProgressBarInTaskbar"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool VerifyDownload {
            get {
                return ((bool)(this["VerifyDownload"]));
            }
            set {
                this["VerifyDownload"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool LaunchUpdatePackageUponDownload {
            get {
                return ((bool)(this["LaunchUpdatePackageUponDownload"]));
            }
            set {
                this["LaunchUpdatePackageUponDownload"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool AlwaysShowTrayNotificationIcon {
            get {
                return ((bool)(this["AlwaysShowTrayNotificationIcon"]));
            }
            set {
                this["AlwaysShowTrayNotificationIcon"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool UseGarbageCollection {
            get {
                return ((bool)(this["UseGarbageCollection"]));
            }
            set {
                this["UseGarbageCollection"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool IsConnectedToTheInternet {
            get {
                return ((bool)(this["IsConnectedToTheInternet"]));
            }
            set {
                this["IsConnectedToTheInternet"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string DownloadLocation {
            get {
                return ((string)(this["DownloadLocation"]));
            }
            set {
                this["DownloadLocation"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string PingAddress {
            get {
                return ((string)(this["PingAddress"]));
            }
            set {
                this["PingAddress"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::System.DateTime DateOfLastCheck {
            get {
                return ((global::System.DateTime)(this["DateOfLastCheck"]));
            }
            set {
                this["DateOfLastCheck"] = value;
            }
        }
    }
}
