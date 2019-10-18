// <auto-generated>
using System.Reflection;


namespace Microsoft.AspNetCore.Server.HttpSys
{
    internal static partial class Resources
    {
        private static global::System.Resources.ResourceManager s_resourceManager;
        internal static global::System.Resources.ResourceManager ResourceManager => s_resourceManager ?? (s_resourceManager = new global::System.Resources.ResourceManager(typeof(Resources)));
        internal static global::System.Globalization.CultureInfo Culture { get; set; }

        [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        internal static string GetResourceString(string resourceKey, string defaultValue = null) =>  ResourceManager.GetString(resourceKey, Culture);

        private static string GetResourceString(string resourceKey, string[] formatterNames)
        {
           var value = GetResourceString(resourceKey);
           if (formatterNames != null)
           {
               for (var i = 0; i < formatterNames.Length; i++)
               {
                   value = value.Replace("{" + formatterNames[i] + "}", "{" + i + "}");
               }
           }
           return value;
        }

        /// <summary>The destination array is too small.</summary>
        internal static string Exception_ArrayTooSmall => GetResourceString("Exception_ArrayTooSmall");
        /// <summary>End has already been called.</summary>
        internal static string Exception_EndCalledMultipleTimes => GetResourceString("Exception_EndCalledMultipleTimes");
        /// <summary>The status code '{0}' is not supported.</summary>
        internal static string Exception_InvalidStatusCode => GetResourceString("Exception_InvalidStatusCode");
        /// <summary>The status code '{0}' is not supported.</summary>
        internal static string FormatException_InvalidStatusCode(object p0)
           => string.Format(Culture, GetResourceString("Exception_InvalidStatusCode"), p0);

        /// <summary>The stream is not seekable.</summary>
        internal static string Exception_NoSeek => GetResourceString("Exception_NoSeek");
        /// <summary>The prefix '{0}' is already registered.</summary>
        internal static string Exception_PrefixAlreadyRegistered => GetResourceString("Exception_PrefixAlreadyRegistered");
        /// <summary>The prefix '{0}' is already registered.</summary>
        internal static string FormatException_PrefixAlreadyRegistered(object p0)
           => string.Format(Culture, GetResourceString("Exception_PrefixAlreadyRegistered"), p0);

        /// <summary>This stream only supports read operations.</summary>
        internal static string Exception_ReadOnlyStream => GetResourceString("Exception_ReadOnlyStream");
        /// <summary>More data written than specified in the Content-Length header.</summary>
        internal static string Exception_TooMuchWritten => GetResourceString("Exception_TooMuchWritten");
        /// <summary>Only the http and https schemes are supported.</summary>
        internal static string Exception_UnsupportedScheme => GetResourceString("Exception_UnsupportedScheme");
        /// <summary>This stream only supports write operations.</summary>
        internal static string Exception_WriteOnlyStream => GetResourceString("Exception_WriteOnlyStream");
        /// <summary>The given IAsyncResult does not match this opperation.</summary>
        internal static string Exception_WrongIAsyncResult => GetResourceString("Exception_WrongIAsyncResult");
        /// <summary>An exception occured while running an action registered with {0}.</summary>
        internal static string Warning_ExceptionInOnResponseCompletedAction => GetResourceString("Warning_ExceptionInOnResponseCompletedAction");
        /// <summary>An exception occured while running an action registered with {0}.</summary>
        internal static string FormatWarning_ExceptionInOnResponseCompletedAction(object p0)
           => string.Format(Culture, GetResourceString("Warning_ExceptionInOnResponseCompletedAction"), p0);


    }
}