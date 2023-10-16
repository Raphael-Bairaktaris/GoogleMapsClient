namespace GoogleMapsClient
{
    /// <summary>
    /// 
    /// </summary>
    public class GoogleMapsClient
    {
        #region Public Properties

        /// <summary>
        /// 
        /// </summary>
        public string APIKey { get; }

        #endregion

        #region Constructors

        /// <summary>
        /// 
        /// </summary>
        /// <param name="apiKey"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public GoogleMapsClient(string apiKey)
        {
            APIKey = apiKey ?? throw new ArgumentNullException(nameof(apiKey));
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public Task<WebRequestResult<GoogleResultResponseModel<PlaceFindPlaceAttributesResponseModel>>> FindPlaceTextAsync(string search)
        {
            return WebRequestsClient.Instance.GetAsync<GoogleResultResponseModel<PlaceFindPlaceAttributesResponseModel>>($"https://maps.googleapis.com/maps/api/place/textsearch/json?query={search}&key={APIKey}", null);
        }

        #endregion
    }
}
