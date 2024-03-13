using Newtonsoft.Json;

namespace GoogleMapsClient
{
    /// <summary>
    /// Represents a place detail response
    /// </summary>
    public class PlaceDetailResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="HtmlAttributions"/> property
        /// </summary>
        private IEnumerable<string>? mHtmlAttributions;

        /// <summary>
        /// The member of the <see cref="Result"/> property
        /// </summary>
        private PlaceFindAttributesResponseModel? mResult;

        /// <summary>
        /// The member of the <see cref="InfoMessages"/> property
        /// </summary>
        private string? mInfoMessages;

        #endregion

        #region Public Property

        /// <summary>
        /// May contain a set of attributions about this listing which must be 
        /// displayed to the user (some listings may not have attribution).
        /// </summary>
        [JsonProperty("html_attributions")]
        public IEnumerable<string> HtmlAttributions
        {
            get => mHtmlAttributions ?? Enumerable.Empty<string>();

            set => mHtmlAttributions = value;
        }

        /// <summary>
        /// Contains detailed information about the place requested.
        /// </summary>
        [JsonProperty("result")]
        public PlaceFindAttributesResponseModel Result
        {
            get => mResult ??= new PlaceFindAttributesResponseModel();

            set => mResult = value;
        }

        /// <summary>
        /// Contains the status of the request, and may contain debugging 
        /// information to help you track down why the request failed.
        /// </summary>
        [JsonProperty("status")]
        [JsonConverter(typeof(StatusCodeTypeToStringJsonConverter))]
        public StatusCodeType Status { get; set; }

        /// <summary>
        /// When the service returns additional information about the request specification,
        /// there may be an additional info_messages field within the response object. This field
        /// is only returned for successful requests. It may not always be returned, and its content 
        /// is subject to change.
        /// </summary>
        [JsonProperty("info_messages")]
        public string InfoMessages
        {
            get => mInfoMessages ?? string.Empty;

            set => mInfoMessages = value;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default Constructor
        /// </summary>
        public PlaceDetailResponseModel()
        {

        }

        #endregion
    }
}
