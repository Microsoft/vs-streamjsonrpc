﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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
                global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Resources", typeof(Resources).Assembly);
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
    ///   Looks up a localized string similar to Both readable and writable are null..
    /// </summary>
    internal static string BothReadableWritableAreNull {
        get {
            return ResourceManager.GetString("BothReadableWritableAreNull", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Got a request to execute &apos;{0}&apos; but have no callback object. Dropping the request..
    /// </summary>
    internal static string DroppingRequestDueToNoTargetObject {
        get {
            return ResourceManager.GetString("DroppingRequestDueToNoTargetObject", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Error writing JSON RPC Result: {0}: {1}.
    /// </summary>
    internal static string ErrorWritingJsonRpcResult {
        get {
            return ResourceManager.GetString("ErrorWritingJsonRpcResult", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Failure deserializing incoming JSON RPC &apos;{0}&apos;: {1}.
    /// </summary>
    internal static string FailureDeserializingJsonRpc {
        get {
            return ResourceManager.GetString("FailureDeserializingJsonRpc", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to The buffer is empty. Call the async method to fill it first..
    /// </summary>
    internal static string FillBufferFirst {
        get {
            return ResourceManager.GetString("FillBufferFirst", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to This formatter already belongs to another JsonRpc instance. Create a new instance of this formatter for each new JsonRpc instance..
    /// </summary>
    internal static string FormatterAlreadyInUseError {
        get {
            return ResourceManager.GetString("FormatterAlreadyInUseError", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Failed parsing Content-Length header into a positive integer..
    /// </summary>
    internal static string HeaderContentLengthNotParseable {
        get {
            return ResourceManager.GetString("HeaderContentLengthNotParseable", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to The size of the message header exceeds the maximum supported size..
    /// </summary>
    internal static string HeaderValueTooLarge {
        get {
            return ResourceManager.GetString("HeaderValueTooLarge", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to JSON RPC must not be null..
    /// </summary>
    internal static string JsonRpcCannotBeNull {
        get {
            return ResourceManager.GetString("JsonRpcCannotBeNull", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to {0} has ref or out parameter(s), which is not supported.
    /// </summary>
    internal static string MethodHasRefOrOutParameters {
        get {
            return ResourceManager.GetString("MethodHasRefOrOutParameters", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to {0} is not public.
    /// </summary>
    internal static string MethodIsNotPublic {
        get {
            return ResourceManager.GetString("MethodIsNotPublic", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to &apos;{0}&apos; method name has different case from requested &apos;{1}&apos;.
    /// </summary>
    internal static string MethodNameCaseIsDifferent {
        get {
            return ResourceManager.GetString("MethodNameCaseIsDifferent", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to {0} parameter(s): {1}, but the request supplies {2}.
    /// </summary>
    internal static string MethodParameterCountDoesNotMatch {
        get {
            return ResourceManager.GetString("MethodParameterCountDoesNotMatch", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to {0} parameters are not compatible with the request: {1}.
    /// </summary>
    internal static string MethodParametersNotCompatible {
        get {
            return ResourceManager.GetString("MethodParametersNotCompatible", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to More than one target method found: {0}..
    /// </summary>
    internal static string MoreThanOneMethodFound {
        get {
            return ResourceManager.GetString("MoreThanOneMethodFound", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to A non-negative integer is required..
    /// </summary>
    internal static string NonNegativeIntegerRequired {
        get {
            return ResourceManager.GetString("NonNegativeIntegerRequired", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to A positive integer is required..
    /// </summary>
    internal static string PositiveIntegerRequired {
        get {
            return ResourceManager.GetString("PositiveIntegerRequired", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Reached end of stream..
    /// </summary>
    internal static string ReachedEndOfStream {
        get {
            return ResourceManager.GetString("ReachedEndOfStream", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Reading JSON RPC from the stream failed with {0}: {1}.
    /// </summary>
    internal static string ReadingJsonRpcStreamFailed {
        get {
            return ResourceManager.GetString("ReadingJsonRpcStreamFailed", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Response is not error..
    /// </summary>
    internal static string ResponseIsNotError {
        get {
            return ResourceManager.GetString("ResponseIsNotError", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Stream has been disposed.
    /// </summary>
    internal static string StreamDisposed {
        get {
            return ResourceManager.GetString("StreamDisposed", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to The stream must be readable..
    /// </summary>
    internal static string StreamMustBeReadable {
        get {
            return ResourceManager.GetString("StreamMustBeReadable", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to The stream must be writeable..
    /// </summary>
    internal static string StreamMustBeWriteable {
        get {
            return ResourceManager.GetString("StreamMustBeWriteable", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to The {0] and {1} parameters exceed length of array..
    /// </summary>
    internal static string SumOfTwoParametersExceedsArrayLength {
        get {
            return ResourceManager.GetString("SumOfTwoParametersExceedsArrayLength", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to The task is not completed..
    /// </summary>
    internal static string TaskNotCompleted {
        get {
            return ResourceManager.GetString("TaskNotCompleted", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to The task was cancelled..
    /// </summary>
    internal static string TaskWasCancelled {
        get {
            return ResourceManager.GetString("TaskWasCancelled", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Unable to find method &apos;{0}/{1}&apos; on {2} for the following reasons: {3}.
    /// </summary>
    internal static string UnableToFindMethod {
        get {
            return ResourceManager.GetString("UnableToFindMethod", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Unexpected error processing JSON RPC &apos;{0}&apos;: {1}.
    /// </summary>
    internal static string UnexpectedErrorProcessingJsonRpc {
        get {
            return ResourceManager.GetString("UnexpectedErrorProcessingJsonRpc", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Unexpected token &apos;{0}&apos; while parsing header..
    /// </summary>
    internal static string UnexpectedTokenReadingHeader {
        get {
            return ResourceManager.GetString("UnexpectedTokenReadingHeader", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Unrecognized incoming JSON RPC &apos;{0}&apos;.
    /// </summary>
    internal static string UnrecognizedIncomingJsonRpc {
        get {
            return ResourceManager.GetString("UnrecognizedIncomingJsonRpc", resourceCulture);
        }
    }
}
