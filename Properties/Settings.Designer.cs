﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Clemakro.MailCheckClient.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.9.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("John Doe")]
        public string smtpFromName {
            get {
                return ((string)(this["smtpFromName"]));
            }
            set {
                this["smtpFromName"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("john.doe@example.com")]
        public string smtpFromAddress {
            get {
                return ((string)(this["smtpFromAddress"]));
            }
            set {
                this["smtpFromAddress"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("johndoe")]
        public string smtpLoginUsername {
            get {
                return ((string)(this["smtpLoginUsername"]));
            }
            set {
                this["smtpLoginUsername"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string smtpLoginPassword {
            get {
                return ((string)(this["smtpLoginPassword"]));
            }
            set {
                this["smtpLoginPassword"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("localhost")]
        public string smtpHost {
            get {
                return ((string)(this["smtpHost"]));
            }
            set {
                this["smtpHost"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool smtpSSL {
            get {
                return ((bool)(this["smtpSSL"]));
            }
            set {
                this["smtpSSL"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("johndoe")]
        public string imapLoginUsername {
            get {
                return ((string)(this["imapLoginUsername"]));
            }
            set {
                this["imapLoginUsername"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string imapLoginPassword {
            get {
                return ((string)(this["imapLoginPassword"]));
            }
            set {
                this["imapLoginPassword"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("localhost")]
        public string imapHost {
            get {
                return ((string)(this["imapHost"]));
            }
            set {
                this["imapHost"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("993")]
        public decimal imapPort {
            get {
                return ((decimal)(this["imapPort"]));
            }
            set {
                this["imapPort"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool imapSSL {
            get {
                return ((bool)(this["imapSSL"]));
            }
            set {
                this["imapSSL"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("587")]
        public decimal smtpPort {
            get {
                return ((decimal)(this["smtpPort"]));
            }
            set {
                this["smtpPort"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("john.doe@example.com")]
        public string smtpToAddress {
            get {
                return ((string)(this["smtpToAddress"]));
            }
            set {
                this["smtpToAddress"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("20")]
        public decimal smtpNetworkTimeout {
            get {
                return ((decimal)(this["smtpNetworkTimeout"]));
            }
            set {
                this["smtpNetworkTimeout"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("20")]
        public decimal imapNetworkTimeout {
            get {
                return ((decimal)(this["imapNetworkTimeout"]));
            }
            set {
                this["imapNetworkTimeout"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool upgradeRequired {
            get {
                return ((bool)(this["upgradeRequired"]));
            }
            set {
                this["upgradeRequired"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("300")]
        public decimal sendInterval {
            get {
                return ((decimal)(this["sendInterval"]));
            }
            set {
                this["sendInterval"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("300")]
        public decimal receiveTimeout {
            get {
                return ((decimal)(this["receiveTimeout"]));
            }
            set {
                this["receiveTimeout"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool smtpLoggingEnabled {
            get {
                return ((bool)(this["smtpLoggingEnabled"]));
            }
            set {
                this["smtpLoggingEnabled"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool imapLoggingEnabled {
            get {
                return ((bool)(this["imapLoggingEnabled"]));
            }
            set {
                this["imapLoggingEnabled"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string smtpLoggingFile {
            get {
                return ((string)(this["smtpLoggingFile"]));
            }
            set {
                this["smtpLoggingFile"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string imapLoggingFile {
            get {
                return ((string)(this["imapLoggingFile"]));
            }
            set {
                this["imapLoggingFile"] = value;
            }
        }
    }
}
