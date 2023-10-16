using Newtonsoft.Json;

namespace GoogleMapsClient
{
    /// <summary>
    /// Represents a nearby search
    /// </summary>
    public class PlaceSearchNearbySearchResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="HTMLAttributions"/> property
        /// </summary>
        private IEnumerable<string>? mHTMLAttributions;

        /// <summary>
        /// The member of the <see cref="Results"/> property
        /// </summary>
        private IEnumerable<PlaceFindPlaceAttributesResponseModel>? mResults;

        /// <summary>
        /// The member of the <see cref="Status"/> property
        /// </summary>
        private PlaceFindPlaceSearchStatusResponseModel? mStatus;

        #endregion

        #region Public Properteis

        /// <summary>
        /// May contain a set of attributions about this listing which must be displayed to the user (some listings may not have attribution).
        /// </summary>
        [JsonProperty("html_attributions")]
        public IEnumerable<string> HTMLAttributions 
        { 
            get => mHTMLAttributions ?? Enumerable.Empty<string>();
            set => mHTMLAttributions = value;
        }

        /// <summary>
        /// Contains an array of places.
        /// </summary>
        [JsonProperty("results")]
        public IEnumerable<PlaceFindPlaceAttributesResponseModel> Results 
        {
            get => mResults ?? Enumerable.Empty<PlaceFindPlaceAttributesResponseModel>();
            set => mResults = value;
        }

        /// <summary>
        /// Contains the status of the request, and may contain debugging information to help you track down why the request failed.
        /// </summary>
        [JsonProperty("status")]
        public string? Status { get; set; }

        /// <summary>
        /// When the service returns a status code other than OK, there may be an additional error_message field within the response object.
        /// This field contains more detailed information about thereasons behind the given status code. This field is not always returned,
        /// and its content is subject to change.
        /// </summary>
        [JsonProperty("error_message")]
        public string? ErrorMessage { get; set; }

        /// <summary>
        /// When the service returns additional information about the request specification, there may be an additional info_messages field
        /// within the response object. This field is only returned for successful requests. It may not always be returned, and its content is subject to change.
        /// </summary>
        [JsonProperty("info_messages")]
        public IEnumerable<string>? InfoMessages { get; set; }

        /// <summary>
        /// Contains a token that can be used to return up to 20 additional results. A next_page_token will not be returned if there are no additional results to display.
        /// The maximum number of results that can be returned is 60. There is a short delay between when a next_page_token is issued, and when it will become valid.
        /// </summary>
        [JsonProperty("next_page_token")]
        public string? NextPageToken { get; set; } 

        #endregion

        #region Constructors

        /// <summary>
        /// Default Constructor
        /// </summary>
        public PlaceSearchNearbySearchResponseModel()
        {
            
        }

        #endregion

    }
}
