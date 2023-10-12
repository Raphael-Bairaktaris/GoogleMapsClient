using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace GoogleMapsClient
{
    /// <summary>
    /// Extension methods
    /// </summary>
    public static class ExtensionMethods
    {
        /// <summary>
        /// Aggregates the <see cref="Exception.Message"/> in the <paramref name="exception"/> exception stack trace
        /// </summary>
        /// <param name="exception">The exception</param>
        /// <returns></returns>
        public static string AggregateExceptionMessages(this Exception exception)
        {
            // If the exception is null...
            if (exception is null)
                // Return an empty string
                return string.Empty;

            // Initialize a string builder
            var builder = new StringBuilder();

            // Append the message
            builder.Append(exception.Message);

            // Get the inner exception
            var innerException = exception.InnerException;

            // While there is an inner exception...
            while (innerException is not null)
            {
                // Append a comma
                builder.Append(", ");

                // Append the inner exception message
                builder.Append(innerException.Message);

                // Get the nested inner exception
                innerException = innerException.InnerException;
            }

            // Return the aggregated message
            return builder.ToString();
        }

        /// <summary>
        /// Checks whether the string is null or empty
        /// </summary>
        /// <param name="value">The value</param>
        /// <returns>Returns true if the string is null or empty, false otherwise</returns>
        public static bool IsNullOrEmpty([NotNullWhen(false)] this string? value)
            => string.IsNullOrEmpty(value);

        /// <summary>
        /// Checks if the specified <paramref name="enumerable"/> is <see cref="null"/> or 
        /// if it doesn't have any items.
        /// </summary>
        /// <param name="enumerable">The enumerable</param>
        /// <returns></returns>
        public static bool IsNullOrEmpty([NotNullWhen(false)] this IEnumerable? enumerable)
        {
            if (enumerable is null)
                return true;

            foreach (var _ in enumerable)
                return false;

            return true;
        }

        /// <summary>
        /// Aggregates the specified <paramref name="source"/> into a <see cref="string"/>
        /// </summary>
        /// <typeparam name="T">The type of the items</typeparam>
        /// <param name="source">The source</param>
        /// <param name="extractor">The string extractor that is used to convert an item to a string</param>
        /// <param name="func">Delegate that places the extracted strings in order</param>
        /// <returns></returns>
        public static string AggregateString<T>(this IEnumerable<T> source, Func<T, string> extractor, Func<string, string, string> func)
        {
            var result = string.Empty;

            foreach (var item in source)
            {
                if (result == string.Empty)
                {
                    result = extractor(item);
                    continue;
                }

                result = func(result, extractor(item));
            }

            return result;
        }

        /// <summary>
        /// Aggregates the specified <paramref name="source"/> into a <see cref="string"/>
        /// </summary>
        /// <typeparam name="T">The type of the items</typeparam>
        /// <param name="source">The source</param>
        /// <param name="extractor">The string extractor that is used to convert an item to a string</param>
        /// <param name="separator">The separator</param>
        /// <returns></returns>
        public static string AggregateString<T>(this IEnumerable<T> source, Func<T, string> extractor, string separator = ", ")
            => AggregateString(source, extractor, (value1, value2) => value1 + separator + value2);

        /// <summary>
        /// Aggregates the specified <paramref name="source"/> into a <see cref="string"/>.
        /// NOTE: This method converts the items of the <paramref name="source"/> to <see cref="string"/>
        ///       using the <see cref="object.ToString()"/> method!
        /// </summary>
        /// <typeparam name="T">The type of the items</typeparam>
        /// <param name="source">The source</param>
        /// <param name="func">Delegate that places the extracted strings in order</param>
        /// <returns></returns>
        public static string AggregateString<T>(this IEnumerable<T> source, Func<string, string, string> func)
            => AggregateString(source, item => item?.ToString() ?? string.Empty, func);

        /// <summary>
        /// Aggregates the specified <paramref name="source"/> into a <see cref="string"/>.
        /// NOTE: This method converts the items of the <paramref name="source"/> to <see cref="string"/>
        ///       using the <see cref="object.ToString()"/> method!
        /// NOTE: This method uses ", " as the items separator!
        /// </summary>
        /// <typeparam name="T">The type of the items</typeparam>
        /// <param name="source">The source</param>
        /// <param name="separator">The separator</param>
        /// <returns></returns>
        public static string AggregateString<T>(this IEnumerable<T> source, string separator = ", ")
            => source.AggregateString((s1, s2) => s1 + separator + s2);

        /// <summary>
        /// Returns a <see cref="WebRequestResult"/> pre-populated with the <see cref="HttpWebResponse"/> information
        /// </summary>
        /// <param name="serverResponse">The server response</param>
        /// <returns></returns>
        public static async Task<WebRequestResult> CreateWebRequestResultAsync(this HttpResponseMessage serverResponse)
        {
            // Create a result
            var result = new WebRequestResult
            {
                // Status code
                StatusCode = serverResponse.StatusCode,

                // Status description
                StatusDescription = serverResponse.ReasonPhrase ?? string.Empty,

                // The headers
                Headers = serverResponse.Headers,

                // The raw server response
                RawServerResponse = await serverResponse.Content.ReadAsStringAsync()
            };

            if (!serverResponse.IsSuccessStatusCode)
                result.ErrorMessage = result.RawServerResponse;

            return result;
        }

        /// <summary>
        /// Returns a <see cref="WebRequestResult{TResult}"/> pre-populated with the <see cref="HttpWebResponse"/> information
        /// read as stream
        /// </summary>
        /// <param name="serverResponse">The server response</param>
        /// <returns></returns>
        public static async Task<WebRequestResult<byte[]>> CreateWebRequestResultFromStreamAsync(this HttpResponseMessage serverResponse)
        {
            var result = new WebRequestResult<byte[]>
            {
                StatusCode = serverResponse.StatusCode,
                StatusDescription = serverResponse.ReasonPhrase ?? string.Empty,
                Headers = serverResponse.Headers,
                RawServerResponse = await serverResponse.Content.ReadAsStringAsync(),
                Result = await serverResponse.Content.ReadAsByteArrayAsync()
            };

            if (!serverResponse.IsSuccessStatusCode)
                result.ErrorMessage = result.RawServerResponse;

            return result;
        }

        /// <summary>
        /// Returns a <see cref="WebRequestResult{T}"/> pre-populated with the <see cref="HttpWebResponse"/> information
        /// </summary>
        /// <typeparam name="TResponse">The type of response to create</typeparam>
        /// <param name="serverResponse">The server response</param>
        /// <returns></returns>
        internal static async Task<WebRequestResult<TResponse>> CreateWebRequestResultAsync<TResponse>(this HttpResponseMessage serverResponse)
        {
            var result = new WebRequestResult<TResponse>
            {
                // Status code
                StatusCode = serverResponse.StatusCode,

                // Status description
                StatusDescription = serverResponse.ReasonPhrase ?? string.Empty,

                // The headers
                Headers = serverResponse.Headers,

                // The raw server response
                RawServerResponse = await serverResponse.Content.ReadAsStringAsync()
            };

            if (!serverResponse.IsSuccessStatusCode)
                result.ErrorMessage = result.RawServerResponse;

            return result;
        }
    }
}
