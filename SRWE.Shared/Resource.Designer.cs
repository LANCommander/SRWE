﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SWRE.Shared {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resource {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resource() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("SWRE.Shared.Resource", typeof(Resource).Assembly);
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
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot; ?&gt;
        ///&lt;SRWE Version=&quot;2.3&quot;&gt;
        ///	&lt;Settings&gt;
        ///		&lt;UpdateInterval Value=&quot;1000&quot; /&gt;
        ///		&lt;ForceExitSizeMoveMessage Value=&quot;false&quot;/&gt;
        ///		&lt;AutoAttachToLastKnownProcess Value=&quot;false&quot;/&gt;
        ///	&lt;/Settings&gt;
        ///	&lt;RecentProcesses&gt;
        ///	&lt;/RecentProcesses&gt;
        ///	&lt;RecentProfiles&gt;
        ///	&lt;/RecentProfiles&gt;
        ///	&lt;HotKeys&gt;
        ///		&lt;!--
        ///      CTRL=&quot;1&quot; = Means you should hold CTRL key down when pressing a hot key.
        ///      CTRL=&quot;0&quot; = Means you can press a hot key without CTRL key combination.
        ///      ALT and SHIFT work in the same [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Settings {
            get {
                return ResourceManager.GetString("Settings", resourceCulture);
            }
        }
    }
}