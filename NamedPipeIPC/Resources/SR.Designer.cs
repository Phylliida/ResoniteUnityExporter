﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace System.IO {
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
    internal class SR {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal SR() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("NamedPipeIPC.Resources.SR", typeof(SR).Assembly);
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
        ///   Looks up a localized string similar to serverName cannot be an empty string.  Use \\\&quot;.\\\&quot; for current machine..
        /// </summary>
        internal static string Argument_EmptyServerName {
            get {
                return ResourceManager.GetString("Argument_EmptyServerName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid handle..
        /// </summary>
        internal static string Argument_InvalidHandle {
            get {
                return ResourceManager.GetString("Argument_InvalidHandle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Offset and length were out of bounds for the array or count is greater than the number of elements from index to the end of the source collection..
        /// </summary>
        internal static string Argument_InvalidOffLen {
            get {
                return ResourceManager.GetString("Argument_InvalidOffLen", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to pipeName cannot be an empty string..
        /// </summary>
        internal static string Argument_NeedNonemptyPipeName {
            get {
                return ResourceManager.GetString("Argument_NeedNonemptyPipeName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Buffer cannot be null..
        /// </summary>
        internal static string ArgumentNull_Buffer {
            get {
                return ResourceManager.GetString("ArgumentNull_Buffer", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to serverName cannot be null. Use \&quot;.\&quot; for current machine..
        /// </summary>
        internal static string ArgumentNull_ServerName {
            get {
                return ResourceManager.GetString("ArgumentNull_ServerName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The pipeName \&quot;anonymous\&quot; is reserved..
        /// </summary>
        internal static string ArgumentOutOfRange_AnonymousReserved {
            get {
                return ResourceManager.GetString("ArgumentOutOfRange_AnonymousReserved", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to For named pipes, the pipe direction can be PipeDirection.In, PipeDirection.Out or PipeDirection.InOut. For anonymous pipes, the pipe direction can be PipeDirection.In or PipeDirection.Out..
        /// </summary>
        internal static string ArgumentOutOfRange_DirectionModeInOutOrInOut {
            get {
                return ResourceManager.GetString("ArgumentOutOfRange_DirectionModeInOutOrInOut", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Specified file length was too large for the file system..
        /// </summary>
        internal static string ArgumentOutOfRange_FileLengthTooBig {
            get {
                return ResourceManager.GetString("ArgumentOutOfRange_FileLengthTooBig", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to HandleInheritability.None or HandleInheritability.Inheritable required..
        /// </summary>
        internal static string ArgumentOutOfRange_HandleInheritabilityNoneOrInheritable {
            get {
                return ResourceManager.GetString("ArgumentOutOfRange_HandleInheritabilityNoneOrInheritable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to TokenImpersonationLevel.None, TokenImpersonationLevel.Anonymous, TokenImpersonationLevel.Identification, TokenImpersonationLevel.Impersonation or TokenImpersonationLevel.Delegation required..
        /// </summary>
        internal static string ArgumentOutOfRange_ImpersonationInvalid {
            get {
                return ResourceManager.GetString("ArgumentOutOfRange_ImpersonationInvalid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Timeout must be non-negative or equal to -1 (Timeout.Infinite).
        /// </summary>
        internal static string ArgumentOutOfRange_InvalidTimeout {
            get {
                return ResourceManager.GetString("ArgumentOutOfRange_InvalidTimeout", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to maxNumberOfServerInstances must either be a value between 1 and 254, or NamedPipeServerStream.MaxAllowedServerInstances (to obtain the maximum number allowed by system resources)..
        /// </summary>
        internal static string ArgumentOutOfRange_MaxNumServerInstances {
            get {
                return ResourceManager.GetString("ArgumentOutOfRange_MaxNumServerInstances", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Non negative number is required..
        /// </summary>
        internal static string ArgumentOutOfRange_NeedNonNegNum {
            get {
                return ResourceManager.GetString("ArgumentOutOfRange_NeedNonNegNum", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Positive number required..
        /// </summary>
        internal static string ArgumentOutOfRange_NeedPosNum {
            get {
                return ResourceManager.GetString("ArgumentOutOfRange_NeedPosNum", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to options contains an invalid flag..
        /// </summary>
        internal static string ArgumentOutOfRange_OptionsInvalid {
            get {
                return ResourceManager.GetString("ArgumentOutOfRange_OptionsInvalid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The path &apos;{0}&apos; is of an invalid length for use with domain sockets on this platform.  The length must be between 1 and {1} characters, inclusive..
        /// </summary>
        internal static string ArgumentOutOfRange_PathLengthInvalid {
            get {
                return ResourceManager.GetString("ArgumentOutOfRange_PathLengthInvalid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to For named pipes, transmission mode can be TransmissionMode.Byte or PipeTransmissionMode.Message. For anonymous pipes, transmission mode can be TransmissionMode.Byte..
        /// </summary>
        internal static string ArgumentOutOfRange_TransmissionModeByteOrMsg {
            get {
                return ResourceManager.GetString("ArgumentOutOfRange_TransmissionModeByteOrMsg", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Already in a connected state..
        /// </summary>
        internal static string InvalidOperation_PipeAlreadyConnected {
            get {
                return ResourceManager.GetString("InvalidOperation_PipeAlreadyConnected", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Already in a disconnected state..
        /// </summary>
        internal static string InvalidOperation_PipeAlreadyDisconnected {
            get {
                return ResourceManager.GetString("InvalidOperation_PipeAlreadyDisconnected", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Pipe is in a disconnected state..
        /// </summary>
        internal static string InvalidOperation_PipeDisconnected {
            get {
                return ResourceManager.GetString("InvalidOperation_PipeDisconnected", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Pipe handle has not been set.  Did your PipeStream implementation call InitializeHandle?.
        /// </summary>
        internal static string InvalidOperation_PipeHandleNotSet {
            get {
                return ResourceManager.GetString("InvalidOperation_PipeHandleNotSet", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Pipe is not opened in asynchronous mode..
        /// </summary>
        internal static string InvalidOperation_PipeNotAsync {
            get {
                return ResourceManager.GetString("InvalidOperation_PipeNotAsync", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Pipe hasn&apos;t been connected yet..
        /// </summary>
        internal static string InvalidOperation_PipeNotYetConnected {
            get {
                return ResourceManager.GetString("InvalidOperation_PipeNotYetConnected", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ReadMode is not of PipeTransmissionMode.Message..
        /// </summary>
        internal static string InvalidOperation_PipeReadModeNotMessage {
            get {
                return ResourceManager.GetString("InvalidOperation_PipeReadModeNotMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot create \&quot;{0}\&quot; because a file or directory with the same name already exists..
        /// </summary>
        internal static string IO_AlreadyExists_Name {
            get {
                return ResourceManager.GetString("IO_AlreadyExists_Name", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to read beyond the end of the stream..
        /// </summary>
        internal static string IO_EOF_ReadBeyondEOF {
            get {
                return ResourceManager.GetString("IO_EOF_ReadBeyondEOF", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The file &apos;{0}&apos; already exists..
        /// </summary>
        internal static string IO_FileExists_Name {
            get {
                return ResourceManager.GetString("IO_FileExists_Name", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to find the specified file..
        /// </summary>
        internal static string IO_FileNotFound {
            get {
                return ResourceManager.GetString("IO_FileNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not find file &apos;{0}&apos;..
        /// </summary>
        internal static string IO_FileNotFound_FileName {
            get {
                return ResourceManager.GetString("IO_FileNotFound_FileName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid pipe handle..
        /// </summary>
        internal static string IO_InvalidPipeHandle {
            get {
                return ResourceManager.GetString("IO_InvalidPipeHandle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to IO operation was aborted unexpectedly..
        /// </summary>
        internal static string IO_OperationAborted {
            get {
                return ResourceManager.GetString("IO_OperationAborted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not find a part of the path..
        /// </summary>
        internal static string IO_PathNotFound_NoPathName {
            get {
                return ResourceManager.GetString("IO_PathNotFound_NoPathName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not find a part of the path &apos;{0}&apos;..
        /// </summary>
        internal static string IO_PathNotFound_Path {
            get {
                return ResourceManager.GetString("IO_PathNotFound_Path", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The specified file name or path is too long, or a component of the specified path is too long..
        /// </summary>
        internal static string IO_PathTooLong {
            get {
                return ResourceManager.GetString("IO_PathTooLong", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Pipe is broken..
        /// </summary>
        internal static string IO_PipeBroken {
            get {
                return ResourceManager.GetString("IO_PipeBroken", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The process cannot access the file &apos;{0}&apos; because it is being used by another process..
        /// </summary>
        internal static string IO_SharingViolation_File {
            get {
                return ResourceManager.GetString("IO_SharingViolation_File", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The process cannot access the file because it is being used by another process..
        /// </summary>
        internal static string IO_SharingViolation_NoFileName {
            get {
                return ResourceManager.GetString("IO_SharingViolation_NoFileName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Anonymous pipes do not support PipeTransmissionMode.Message ReadMode..
        /// </summary>
        internal static string NotSupported_AnonymousPipeMessagesNotSupported {
            get {
                return ResourceManager.GetString("NotSupported_AnonymousPipeMessagesNotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Anonymous pipes can only be in one direction..
        /// </summary>
        internal static string NotSupported_AnonymousPipeUnidirectional {
            get {
                return ResourceManager.GetString("NotSupported_AnonymousPipeUnidirectional", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Stream does not support reading..
        /// </summary>
        internal static string NotSupported_UnreadableStream {
            get {
                return ResourceManager.GetString("NotSupported_UnreadableStream", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Stream does not support seeking..
        /// </summary>
        internal static string NotSupported_UnseekableStream {
            get {
                return ResourceManager.GetString("NotSupported_UnseekableStream", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Stream does not support writing..
        /// </summary>
        internal static string NotSupported_UnwritableStream {
            get {
                return ResourceManager.GetString("NotSupported_UnwritableStream", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot access a closed pipe..
        /// </summary>
        internal static string ObjectDisposed_PipeClosed {
            get {
                return ResourceManager.GetString("ObjectDisposed_PipeClosed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot access a closed Stream..
        /// </summary>
        internal static string ObjectDisposed_StreamClosed {
            get {
                return ResourceManager.GetString("ObjectDisposed_StreamClosed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Message transmission mode is not supported on this platform..
        /// </summary>
        internal static string PlatformNotSupported_MessageTransmissionMode {
            get {
                return ResourceManager.GetString("PlatformNotSupported_MessageTransmissionMode", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The operating system returned error &apos;{0}&apos; indicating that the operation is not supported..
        /// </summary>
        internal static string PlatformNotSupported_OperatingSystemError {
            get {
                return ResourceManager.GetString("PlatformNotSupported_OperatingSystemError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Access to remote named pipes is not supported on this platform..
        /// </summary>
        internal static string PlatformNotSupported_RemotePipes {
            get {
                return ResourceManager.GetString("PlatformNotSupported_RemotePipes", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The name of a pipe on this platform must only include characters valid in file names..
        /// </summary>
        internal static string PlatformNotSupproted_InvalidNameChars {
            get {
                return ResourceManager.GetString("PlatformNotSupproted_InvalidNameChars", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Access to the path is denied..
        /// </summary>
        internal static string UnauthorizedAccess_IODenied_NoPathName {
            get {
                return ResourceManager.GetString("UnauthorizedAccess_IODenied_NoPathName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Access to the path &apos;{0}&apos; is denied..
        /// </summary>
        internal static string UnauthorizedAccess_IODenied_Path {
            get {
                return ResourceManager.GetString("UnauthorizedAccess_IODenied_Path", resourceCulture);
            }
        }
    }
}