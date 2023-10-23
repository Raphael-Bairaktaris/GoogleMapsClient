using Microsoft.AspNetCore.WebUtilities;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Net.Http.Headers;
using System.Reflection;

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
        public Task<WebRequestResult<GoogleResultResponseModel<PlaceFindAttributesResponseModel>>> TextSearchAsync(TextSearchAPIArgs args) 
            => WebRequestsClient.Instance.GetAsync<GoogleResultResponseModel<PlaceFindAttributesResponseModel>>(GetRouteWithAPIKey(RouteHelpers.AttachParameters(GoogleMapsAPIRoutes.TextSearchAPIRoute, args)), null);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public Task<WebRequestResult<PlaceSearchNearbySearchResponseModel>> NearbySearchAsync(NearbySearchAPIArgs args) 
            => WebRequestsClient.Instance.GetAsync<PlaceSearchNearbySearchResponseModel>(GetRouteWithAPIKey(RouteHelpers.AttachParameters(GoogleMapsAPIRoutes.NearbySearchAPIRoute, args)), null);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public Task<WebRequestResult<GoogleResultResponseModel<PlaceAutocompleteResponseModel>>> PlaceAutoCompletePredictionAsync(PlaceAutocompletePredictionAPIArgs args) 
            => WebRequestsClient.Instance.GetAsync<GoogleResultResponseModel<PlaceAutocompleteResponseModel>>(GetRouteWithAPIKey(RouteHelpers.AttachParameters(GoogleMapsAPIRoutes.PlaceAutoCompleteAPIRoute, args)), null);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public Task<WebRequestResult<PlaceDetailResponseModel>> PlaceDetailAsync(PlaceDetailAPIArgs args) 
            => WebRequestsClient.Instance.GetAsync<PlaceDetailResponseModel>(GetRouteWithAPIKey(RouteHelpers.AttachParameters(GoogleMapsAPIRoutes.PlaceDetailsAPIRoute, args)), null);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public Task<WebRequestResult<GoogleResultResponseModel<PlaceQueryAutocompleteResponseModel>>> PlaceQueryAutocompleteAsync(QueryAutocompleteAPIArgs args) 
            => WebRequestsClient.Instance.GetAsync<GoogleResultResponseModel<PlaceQueryAutocompleteResponseModel>>(GetRouteWithAPIKey(RouteHelpers.AttachParameters(GoogleMapsAPIRoutes.QueryAutocompleteAPIRoute, args)), null);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public Task<WebRequestResult<GoogleResultResponseModel<PlaceFindAttributesResponseModel>>> PlaceFindAsync(PlaceFindAPIArgs args) 
            => WebRequestsClient.Instance.GetAsync<GoogleResultResponseModel<PlaceFindAttributesResponseModel>>(GetRouteWithAPIKey(RouteHelpers.AttachParameters(GoogleMapsAPIRoutes.FindPlaceAPIRoute, args)), null);

        #endregion

        #region Private Methods

        /// <summary>
        /// Attaches the <see cref="APIKey"/> to the specified <paramref name="url"/>
        /// </summary>
        /// <param name="url">The URL</param>
        /// <returns></returns>
        private string GetRouteWithAPIKey(string url) => QueryHelpers.AddQueryString(url, "key", APIKey);

        #endregion
    }
}
