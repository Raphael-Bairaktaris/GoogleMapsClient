using Newtonsoft.Json;

namespace Simple.GoogleMaps
{
    /// <summary>
    /// Represents a places find place from text
    /// </summary>
    public class PlaceFindFromTextResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="Candidates"/> property
        /// </summary>
        private IEnumerable<PlaceFindAttributesResponseModel>? mCandidates;

        /// <summary>
        /// The member of the <see cref="ErrorMessage"/> property
        /// </summary>
        private string? mErrorMessage;

        /// <summary>
        /// The member of the <see cref="InfoMessages"/> property
        /// </summary>
        private string? mInfoMessages;

        #endregion

        #region Public properties

        /// <summary>
        /// Contains an array of place candidates
        /// </summary>
        /// <remarks>
        /// https://developers.google.com/maps/documentation/places/web-service/search-find-place#AddressComponent
        /// </remarks>
        [JsonProperty("candidates")]
        public IEnumerable<PlaceFindAttributesResponseModel> Candidates
        {
            get => mCandidates ?? Enumerable.Empty<PlaceFindAttributesResponseModel>();

            set => mCandidates = value;
        }

        /// <summary>
        /// When the service returns a status code other than OK, there may be an additional error_message field within the response
        /// object. This field contains more detailed information about the reasons behind the given status code. 
        /// This field is not always returned, and its content is subject to change.
        /// </summary>
        [JsonProperty("error_message")]
        public string ErrorMessage
        {
            get => mErrorMessage ?? string.Empty;

            set => mErrorMessage = value;
        }

        /// <summary>
        /// When the service returns additional information about the request specification, there may be an additional info_messages
        /// field within the response object. This field is only returned for successful requests. It may not always be returned, 
        /// and its content is subject to change.
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
        /// Default constructor
        /// </summary>
        public PlaceFindFromTextResponseModel()
        {
        }

        #endregion
    }
}
