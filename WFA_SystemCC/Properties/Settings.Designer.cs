﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WFA_SystemCC.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=FORTUNATO-PC\\SQLSERVER;Initial Catalog=db_01894_1_B_2_2014;Persist Se" +
            "curity Info=True;User ID=sa;Password=358352124")]
        public string db_01894_1_B_2_2014ConnectionString {
            get {
                return ((string)(this["db_01894_1_B_2_2014ConnectionString"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=MOTORHEAD\\DATA;Initial Catalog=db_01894_1_B_2_2014;Persist Security I" +
            "nfo=True;User ID=01894_1_B_2_2014;Password=358352124")]
        public string db_01894_1_B_2_2014ConnectionString1 {
            get {
                return ((string)(this["db_01894_1_B_2_2014ConnectionString1"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int NivelUsuarioLogado {
            get {
                return ((int)(this["NivelUsuarioLogado"]));
            }
            set {
                this["NivelUsuarioLogado"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string NomeUsuarioLogado {
            get {
                return ((string)(this["NomeUsuarioLogado"]));
            }
            set {
                this["NomeUsuarioLogado"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=CENTRALBOX;Initial Catalog=db_01894_1_B_2_2014;Integrated Security=Tr" +
            "ue")]
        public string db_01894_1_B_2_2014ConnectionString2 {
            get {
                return ((string)(this["db_01894_1_B_2_2014ConnectionString2"]));
            }
        }
    }
}
