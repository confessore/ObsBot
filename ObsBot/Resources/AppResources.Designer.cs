﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ObsBot.Resources; 
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
public class AppResources {
    
    private static global::System.Resources.ResourceManager resourceMan;
    
    private static global::System.Globalization.CultureInfo resourceCulture;
    
    [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
    internal AppResources() {
    }
    
    /// <summary>
    ///   Returns the cached ResourceManager instance used by this class.
    /// </summary>
    [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
    public static global::System.Resources.ResourceManager ResourceManager {
        get {
            if (object.ReferenceEquals(resourceMan, null)) {
                global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("ObsBot.Resources.AppResources", typeof(AppResources).Assembly);
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
    public static global::System.Globalization.CultureInfo Culture {
        get {
            return resourceCulture;
        }
        set {
            resourceCulture = value;
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to + new.
    /// </summary>
    public static string add_new {
        get {
            return ResourceManager.GetString("add_new", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to confirm.
    /// </summary>
    public static string button_confirm {
        get {
            return ResourceManager.GetString("button_confirm", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to what is your name?.
    /// </summary>
    public static string caregiver_name {
        get {
            return ResourceManager.GetString("caregiver_name", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to some additional information is required to proceed. we do not sell your private information.
    /// </summary>
    public static string information {
        get {
            return ResourceManager.GetString("information", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to welcome! we&apos;re stoked that you decided to check us out.
    /// </summary>
    public static string welcome {
        get {
            return ResourceManager.GetString("welcome", resourceCulture);
        }
    }
}
