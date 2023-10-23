using Newtonsoft.Json;
using System.Diagnostics.CodeAnalysis;

namespace GoogleMapsClient
{
    /// <summary>
    /// Represents a place autocomplete term
    /// </summary>
    public class PlaceAutocompleteTermReponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="Value"/> property
        /// </summary>
        private string? mValue;

        #endregion

        #region Public Properties

        /// <summary>
        /// Defines the start position of this term in the description, measured in Unicode characters.
        /// </summary>
        [JsonProperty("offset")]
        public int Offset { get; set; }

        /// <summary>
        /// The text of the term.
        /// </summary>
        [AllowNull]
        [JsonProperty("value")]
        public string Value
        {
            get => mValue ?? string.Empty;

            set => mValue = value;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public PlaceAutocompleteTermReponseModel()
        {

        }

        #endregion
    }
}

