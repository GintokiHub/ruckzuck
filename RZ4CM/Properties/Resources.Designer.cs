﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RuckZuck_Tool.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("RuckZuck_Tool.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to using System.Reflection;
        ///using System.Runtime.CompilerServices;
        ///using System.Runtime.InteropServices;
        ///
        ///[assembly: AssemblyTitle(&quot;RuckZuck Package-Wrapper&quot;)]
        ///[assembly: AssemblyDescription(&quot;Install Software from the RuckZuck.tools Repository&quot;)]
        ///[assembly: AssemblyConfiguration(&quot;&quot;)]
        ///[assembly: AssemblyCompany(&quot;RuckZuck.tools&quot;)]
        ///[assembly: AssemblyProduct(&quot;RZRZRZ&quot;)]
        ///[assembly: AssemblyCopyright(&quot;Copyright ©  2019 by Roger Zander&quot;)]
        ///[assembly: AssemblyTrademark(&quot;&quot;)]
        ///[assembly: AssemblyCulture(&quot;&quot;)]
        ///[ [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Assembly {
            get {
                return ResourceManager.GetString("Assembly", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Icon similar to (Icon).
        /// </summary>
        internal static System.Drawing.Icon RZ {
            get {
                object obj = ResourceManager.GetObject("RZ", resourceCulture);
                return ((System.Drawing.Icon)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to using Microsoft.Win32;
        ///using System;
        ///using System.Collections.Generic;
        ///using System.Diagnostics;
        ///using System.IO;
        ///using System.Linq;
        ///using System.Net;
        ///using System.Net.Http;
        ///using System.Net.Sockets;
        ///using System.Text;
        ///using System.Threading.Tasks;
        ///using System.Web.Script.Serialization;
        ///
        ///namespace RuckZuck.Base
        ///{
        ///    class RZRestAPIv2
        ///    {
        ///        private static string _sURL = &quot;UDP&quot;;
        ///        public static bool DisableBroadcast = false;
        ///        public static string CustomerID = &quot;&quot;;
        ///
        ///    [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string RZRestApi {
            get {
                return ResourceManager.GetString("RZRestApi", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to using System;
        ///using System.Collections.Generic;
        ///using System.Linq;
        ///using System.Net;
        ///using System.IO;
        ///using System.Management.Automation;
        ///using System.Threading.Tasks;
        ///using System.Security.Cryptography.X509Certificates;
        ///using System.Threading;
        ///using System.Web.Script.Serialization;
        ///using System.Diagnostics;
        ///using System.Net.Http;
        ///using RuckZuck.Base;
        ///
        ///namespace RZUpdate
        ///{
        ///    /// &lt;summary&gt;
        ///    /// Updater Class
        ///    /// &lt;/summary&gt;
        ///    public class RZUpdater
        ///    {
        ///        /// &lt;summary&gt;
        /// [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string RZUpdate {
            get {
                return ResourceManager.GetString("RZUpdate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to using RZUpdate;
        ///using System;
        ///using System.Reflection;
        ///using System.Resources;
        ///using System.Text;
        ///using System.Threading;
        ///using System.Net;
        ///
        ///namespace RZWrapper
        ///{
        ///    class RZWrapperClass
        ///    {
        ///        static int Main(string[] args)
        ///        {
        ///            string xmlSW = null;
        ///
        ///            try
        ///            {
        ///                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
        ///                ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };
        ///  [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Source {
            get {
                return ResourceManager.GetString("Source", resourceCulture);
            }
        }
    }
}
