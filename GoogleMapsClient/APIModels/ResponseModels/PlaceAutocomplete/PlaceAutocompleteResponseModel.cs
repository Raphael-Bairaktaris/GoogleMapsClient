using Newtonsoft.Json;
using System.Diagnostics.CodeAnalysis;

namespace GoogleMapsClient
{
    /// <summary>
    /// Represents an autocomplete response
    /// </summary>
    public class PlaceAutocompleteResponseModel
    {
        #region Private Property

        /// <summary>
        /// The member of the <see cref="Predictions"/> property
        /// </summary>
        /// <remarks>
        /// https://developers.google.com/maps/documentation/places/web-service/autocomplete#PlaceAutocompletePrediction
        /// </remarks>
        private IEnumerable<PlaceAutocompletePredictionResponseModel>? mPredictions;

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
        private string? mStatus;

        #endregion

        #region Public Property

        /// <summary>
        /// Contains an array of predictions
        /// </summary>
        [AllowNull]
        [JsonProperty("predictions")]
        public IEnumerable<PlaceAutocompletePredictionResponseModel> Predictions
        {
            get => mPredictions ?? Enumerable.Empty<PlaceAutocompletePredictionResponseModel>();

            set => mPredictions = value;
        }

        /// <summary>
        /// Contains the status of the request, and may contain debugging information to 
        /// help you track down why the request failed.
        /// </summary>
        /// <remarks>
        /// https://developers.google.com/maps/documentation/places/web-service/autocomplete#PlacesAutocompleteStatus
        /// </remarks>
        [AllowNull]
        [JsonProperty("status")]
        public string Status
        {
            get => mStatus ?? string.Empty;

            set => mStatus = value;
        }

        /// <summary>
        /// When the service returns a status code other than OK, there may be an additional error_message 
        /// field within the response object. This field contains more detailed information about thereasons behind 
        /// the given status code. This field is not always returned, and its content is subject to change.
        /// </summary>
        [AllowNull]
        [JsonProperty("error_message")]
        public string ErrorMessage
        {
            get => mErrorMessage ?? string.Empty;

            set => mErrorMessage = value;
        }

        /// <summary>
        /// When the service returns additional information about the request specification, there may be an 
        /// additional info_messages field within the response object. This field is only returned for successful 
        /// requests. It may not always be returned, and its content is subject to change.
        /// </summary>
        [AllowNull]
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
        public PlaceAutocompleteResponseModel()
        {

        }

        #endregion
    }
}
