﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.33440
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.Ajax.Utilities {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class ManifestStrings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ManifestStrings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.Ajax.Utilities.ManifestStrings", typeof(ManifestStrings).Assembly);
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
        ///   Looks up a localized string similar to Required manifest &lt;input&gt; file does not exist.
        /// </summary>
        internal static string InputFileNotFound {
            get {
                return ResourceManager.GetString("InputFileNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Resource path must have .RESX or .RESOURCES extension.
        /// </summary>
        internal static string InvalidResourcePath {
            get {
                return ResourceManager.GetString("InvalidResourcePath", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Manifest &lt;input&gt; element missing or invalid path attribute.
        /// </summary>
        internal static string MissingInputPath {
            get {
                return ResourceManager.GetString("MissingInputPath", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Manifest &lt;resource&gt; element missing or invalid path attribute.
        /// </summary>
        internal static string MissingResourcePath {
            get {
                return ResourceManager.GetString("MissingResourcePath", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Required manifest &lt;resource&gt; file does not exist.
        /// </summary>
        internal static string ResourceFileNotFound {
            get {
                return ResourceManager.GetString("ResourceFileNotFound", resourceCulture);
            }
        }
    }
}
