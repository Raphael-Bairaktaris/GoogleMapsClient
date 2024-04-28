using Newtonsoft.Json;
using System.Diagnostics.CodeAnalysis;

namespace Simple.GoogleMaps
{
    /// <summary>
    /// Represents a place auto complete structured format 
    /// </summary>
    public class PlaceAutocompleteStructuredFormatResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="MainText"/> property
        /// </summary>
        private string? mMainText;

        /// <summary>
        /// The member of the <see cref="MainTextMatchedSubstrings"/> property
        /// </summary>
        private IEnumerable<PlaceAutocompleteMatchedSubstringResponseModel>? mMainTextMatchedSubstrings;

        /// <summary>
        /// The member of the <see cref="SecondaryText"/> property
        /// </summary>
        private string? mSecondaryText;

        /// <summary>
        /// The member of the <see cref="SecondaryTextMatchedSubstrings"/> property
        /// </summary>
        private IEnumerable<PlaceAutocompleteMatchedSubstringResponseModel>? mSecondaryTextMatchedSubstrings;

        #endregion

        #region Public Properties

        /// <summary>
        /// Contains the main text of a prediction, usually the name of the place.
        /// </summary>
        [AllowNull]
        [JsonProperty("main_text")]
        public string MainText
        {
            get => mMainText ?? string.Empty;

            set => mMainText = value;
        }

        /// <summary>
        /// Contains an array with offset value and length. These describe the location of the entered
        /// term in the prediction result text, so that the term can be highlighted if desired.
        /// </summary>
        [AllowNull]
        [JsonProperty("main_text_matched_substrings")]
        public IEnumerable<PlaceAutocompleteMatchedSubstringResponseModel> MainTextMatchedSubstrings
        {
            get => mMainTextMatchedSubstrings ?? Enumerable.Empty<PlaceAutocompleteMatchedSubstringResponseModel>();

            set => mMainTextMatchedSubstrings = value;
        }

        /// <summary>
        /// Contains the secondary text of a prediction, usually the location of the place.
        /// </summary>
        [AllowNull]
        [JsonProperty("secondary_text")]
        public string SecondaryText
        {
            get => mSecondaryText ?? string.Empty;

            set => mSecondaryText = value;
        }

        /// <summary>
        /// Contains an array with offset value and length. These describe the location of 
        /// the entered term in the prediction result text, so that the term can be highlighted 
        /// if desired.
        /// </summary>
        [AllowNull]
        [JsonProperty("secondary_text_matched_substrings")]
        public IEnumerable<PlaceAutocompleteMatchedSubstringResponseModel> SecondaryTextMatchedSubstrings
        {
            get => mSecondaryTextMatchedSubstrings ?? Enumerable.Empty<PlaceAutocompleteMatchedSubstringResponseModel>();

            set => mSecondaryTextMatchedSubstrings = value;

        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public PlaceAutocompleteStructuredFormatResponseModel()
        {

        }

        #endregion
    }
}