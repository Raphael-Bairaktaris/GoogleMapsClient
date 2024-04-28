namespace GoogleMapsClient
{
    /// <summary>
    /// Provides enumeration of status code type
    /// </summary>
    public enum StatusCodeType
    {
        /// <summary>
        /// Indicating the API request was successful
        /// </summary>
        OK = 0,

        /// <summary>
        /// Indicating that the search was successful but returned no results.
        /// This may occur if the search was passed a latlng (latitude longitude) in a remote location.
        /// </summary>
        ZeroResults = 1,

        /// <summary>
        /// indicating the API request was malformed, generally due to missing required 
        /// query parameter (location or radius)
        /// </summary>
        InvalidRequest = 2,

        /// <summary>
        /// Indicated the following
        /// <list type="bullet|number|table">
        /// <item>
        ///     <description>You have exceeded the QPS limits.</description>
        /// </item>
        /// <item>
        ///     <description>Billing has not been enabled on your account.</description>
        /// </item>
        /// <item>
        ///     <description>The monthly 200$ credit, or self imposed usage cap has been exceeded</description>
        /// </item>
        /// <item>
        ///     <description>The provided method of payment is no longer valid.(i.e expired credit)</description>
        /// </item>
        /// </list>
        /// </summary>
        OverQueryLimit = 3,

        /// <summary>
        /// Indicates that your request was denied, generally because:
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
        UnknownError = 5,
    }
}
