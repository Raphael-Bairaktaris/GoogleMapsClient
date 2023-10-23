using Newtonsoft.Json;

namespace GoogleMapsClient
{
    /// <summary>
    /// Represents a result returned directly from the Google API
    /// </summary>
    /// <typeparam name="T">The type of the results.</typeparam>
    public class GoogleResultResponseModel<T>
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="HTMLAttributions"/> property
        /// </summary>
        private IEnumerable<string>? mHTMLAttributions;

        /// <summary>
        /// The member of the <see cref="Results"/> property
        /// </summary>
        private IEnumerable<T>? mResults;

        /// <summary>
        /// The member of the <see cref="Status"/> property
        /// </summary>
        private string? mStatus;

        #endregion

        #region Public 

        /// <summary>
        /// May contain a set of attributions about this listing which must be 
        /// displayed to the user (some listings may not have attribution).
        /// </summary>
        [JsonProperty("html_attributions")]
        public IEnumerable<string> HTMLAttributions
        {
            get => mHTMLAttributions ?? Enumerable.Empty<string>();

            set => mHTMLAttributions = value;
        }

        /// <summary>
        /// The results
        /// </summary>
        [JsonProperty("results")]
        public IEnumerable<T> Results
        {
            get => mResults ?? Enumerable.Empty<T>();

            set => mResults = value;
        }

        /// <summary>
        /// The status
        /// </summary>
        [JsonProperty("status")]
        public string Status
        {
            get => mStatus ?? string.Empty;

            set => mStatus = value;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public GoogleResultResponseModel()
        {

        }

        #endregion
    }
}
