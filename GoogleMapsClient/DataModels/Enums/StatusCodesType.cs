using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleMapsClient
{ 
    /// <summary>
    /// Provides enumeration of status code type
    /// </summary>
    public enum StatusCodesType
    {
        /// <summary>
        /// Indicating the API request was succesful
        /// </summary>
        Ok = 0,

        /// <summary>
        /// Indicating that the search was succesful but returned no results.
        /// This may occur if the search was passed a latlng in a remote location.
        /// </summary>
        ZeroResults = 1,

        /// <summary>
        /// indicating the API request was malformed, generally due to missing required 
        /// query parameter (location or radius)
        /// </summary>
        InvalidRequest = 2,

        /// <summary>
        /// indicated the following
        /// <list type="bullet|number|table">
        /// <item>
        ///     <description>You have exceeded the QPS limits.</description>
        /// </item>
        /// <item>
        ///     <description>Billing has not been enabled on your account.</description>
        /// </item>
        /// <item>
        ///     <description>The monthly 200$ credit, or self imposed usage cap has ben exceeded</description>
        /// </item>
        /// <item>
        ///     <description>The provided method of payment is no longer valid.(i.e expired credit)</description>
        /// </item>
        /// </list>
        /// </summary>
        OverQueryLimit = 3,

        /// <summary>
        /// Idicates that your erquest was denied, generally because:
        /// <list type="bullet|number|table">
        /// <item>
        ///     <description>The request is missing an API key.</description>
        /// </item>
        /// <item>
        ///     <description>The key parameter is invalid</description>
        /// </item>
        /// </list>
        /// </summary>
        RequestDenied = 4,

        /// <summary>
        /// Indicating an unknown error.
        /// </summary>
        UnknownError =5,
    }
}
