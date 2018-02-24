﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Certes.Cli {
    using System;
    using System.Reflection;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Strings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Strings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Certes.Cli.Strings", typeof(Strings).GetTypeInfo().Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No account available for ACME server &apos;{0}&apos;..
        /// </summary>
        internal static string ErrorNoAccountKey {
            get {
                return ResourceManager.GetString("ErrorNoAccountKey", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Option &apos;--{0}&apos; is required..
        /// </summary>
        internal static string ErrorOptionMissing {
            get {
                return ResourceManager.GetString("ErrorOptionMissing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Parameter &apos;{0}&apos; is required..
        /// </summary>
        internal static string ErrorParameterMissing {
            get {
                return ResourceManager.GetString("ErrorParameterMissing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Manage ACME accounts..
        /// </summary>
        internal static string HelpCommandAccount {
            get {
                return ResourceManager.GetString("HelpCommandAccount", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Create new ACME account..
        /// </summary>
        internal static string HelpCommandAccountNew {
            get {
                return ResourceManager.GetString("HelpCommandAccountNew", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Get the ACME account..
        /// </summary>
        internal static string HelpCommandAccountShow {
            get {
                return ResourceManager.GetString("HelpCommandAccountShow", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Update ACME account..
        /// </summary>
        internal static string HelpCommandAccountUpdate {
            get {
                return ResourceManager.GetString("HelpCommandAccountUpdate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Set the default ACME account..
        /// </summary>
        internal static string HelpCommandAccountSet {
            get {
                return ResourceManager.GetString("HelpCommandAccountSet", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Manage ACME servers..
        /// </summary>
        internal static string HelpCommandServer {
            get {
                return ResourceManager.GetString("HelpCommandServer", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Configure the default ACME server..
        /// </summary>
        internal static string HelpCommandServerSet {
            get {
                return ResourceManager.GetString("HelpCommandServerSet", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Get the details of a ACME server..
        /// </summary>
        internal static string HelpCommandServerShow {
            get {
                return ResourceManager.GetString("HelpCommandServerShow", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The E-mail for ACME account..
        /// </summary>
        internal static string HelpEmail {
            get {
                return ResourceManager.GetString("HelpEmail", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Path to the ACME account key..
        /// </summary>
        internal static string HelpKey {
            get {
                return ResourceManager.GetString("HelpKey", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The dictionary URI to an ACME server..
        /// </summary>
        internal static string HelpServer {
            get {
                return ResourceManager.GetString("HelpServer", resourceCulture);
            }
        }
    }
}