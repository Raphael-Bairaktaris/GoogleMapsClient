using Newtonsoft.Json;
using System.Diagnostics.CodeAnalysis;

namespace GoogleMapsClient
{
    /// <summary>
    /// Contains a summary of the place. A summary is comprised of a textual overview, and also 
    /// includes the language code for these if applicable. Summary text must be presented 
    /// as-is and can not be modified or altered.
    /// </summary>
    public class PlaceFindEditorialSummaryResponseModel
    {
        #region Private Member
        /// <summary>
        /// The member of the <see cref="Language"/> property
        /// </summary>
        private string? mLanguage;

        /// <summary>
        /// The member of the <see cref="Overview"/> property
        /// </summary>
        private string? mOverview;

        #endregion

        #region Public Property

        /// <summary>
        /// The language of the previous fields. May not always be present.
        /// </summary>
        [AllowNull]
        [JsonProperty("language")]
        public string Language
        {
            get => mLanguage ?? string.Empty;

            set => mLanguage = value;
        }

        /// <summary>
        /// A medium-length textual summary of the place.
        /// </summary>
        [AllowNull]
        [JsonProperty("overview")]
        public string Overview
        {
            get => mOverview ?? string.Empty;

            set => mOverview = value;
        }

        #endregion

        #region Constructors
        /// <summary>
        /// Default Constructor
        /// </summary>
        public PlaceFindEditorialSummaryResponseModel()
        {

        }

        #endregion
    }
}
