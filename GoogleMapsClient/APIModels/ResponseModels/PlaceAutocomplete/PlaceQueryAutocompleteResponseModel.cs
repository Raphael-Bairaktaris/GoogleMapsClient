using Newtonsoft.Json;
using System.Diagnostics.CodeAnalysis;

namespace Simple.GoogleMaps
{
    /// <summary>
    /// Represents a pace query autocomplete
    /// </summary>
    public class PlaceQueryAutocompleteResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="Status"/> property
        /// </summary>
        private string? mStatus;

        #endregion

        #region Public Property

        /// <summary>
        /// Contains an array of predictions.
        /// </summary>
        [AllowNull]
        [JsonProperty("predictions")]
        public IEnumerable<PlaceAutocompletePredictionResponseModel> Predictions { get; set; }

        /// <summary>
        /// Contains the status of the request, and may contain debugging information to help you track down why the request failed.
        /// </summary>
        [JsonProperty("status")]
        public string Status
        {
            get => mStatus ?? string.Empty;

            set => mStatus = value;
        }

        /// <summary>
        /// When the service returns a status code other than OK, there may be an additional error_message field within the response object. 
        /// This field contains more detailed information about the reasons behind the given status code. This field is not always returned, 
        /// and its content is subject to change.
        /// </summary>
        [JsonProperty("error_message")]
        public string? ErrorMessage { get; set; }

        /// <summary>
        /// When the service returns additional information about the request specification, there may be an additional info_messages field within 
        /// the response object. This field is only returned for successful requests. It may not always be returned, and its content is subject to change.
        /// </summary>
        [JsonProperty("info_messages")]
        public IEnumerable<string>? InfoMessages { get; set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor.
        /// </summary>
        public PlaceQueryAutocompleteResponseModel()
        {

        }

        #endregion
    }
}
