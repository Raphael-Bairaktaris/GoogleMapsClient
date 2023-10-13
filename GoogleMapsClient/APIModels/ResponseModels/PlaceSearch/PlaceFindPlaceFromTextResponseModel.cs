using Newtonsoft.Json;
using System.Diagnostics.CodeAnalysis;

namespace GoogleMapsClient
{
    /// <summary>
    /// Represents a places find place from text
    /// </summary>
    public class PlaceFindPlaceFromTextResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="Candidates"/> property
        /// </summary>
        private IEnumerable<PlaceFindPlaceAttributesResponseModel>? mCandidates;

        /// <summary>
        /// The member of the <see cref="ErrorMessage"/> property
        /// </summary>
        private string? mErrorMessage;

        /// <summary>
        /// The member of the <see cref="InfoMessages"/> property
        /// </summary>
        private string? mInfoMessages;

        /// <summary>
        /// The member of the <see cref="Status"/> property
        /// </summary>
        private PlaceFindPlaceSearchStatusResponseModel? mStatus;

        #endregion

        #region Public properties

        /// <summary>
        /// Contains an array of place candidates
        /// </summary>
        /// <remarks>
        /// https://developers.google.com/maps/documentation/places/web-service/search-find-place#AddressComponent
        /// </remarks>
        [AllowNull]
        [JsonProperty("candidates")]
        public IEnumerable<PlaceFindPlaceAttributesResponseModel> Candidates 
        { 
            get => mCandidates ?? Enumerable.Empty<PlaceFindPlaceAttributesResponseModel>();

            set => mCandidates = value;
        }

        /// <summary>
        /// Contains the status of the request, and may contain debugging information to help you track down why the request failed.
        /// </summary>
        /// <remarks>
        /// https://developers.google.com/maps/documentation/places/web-service/search-find-place#PlacesSearchStatus
        /// </remarks>
        [AllowNull]
        [JsonProperty("status")]
        public PlaceFindPlaceSearchStatusResponseModel Status
        {
            get => mStatus ??= new PlaceFindPlaceSearchStatusResponseModel();

            set => mStatus = value;
        }

        /// <summary>
        /// When the service returns a status code other than OK, there may be an additional error_message field within the response
        /// object. This field contains more detailed information about thereasons behind the given status code. 
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
        public PlaceFindPlaceFromTextResponseModel()
        {
        }

        #endregion
    }
}
