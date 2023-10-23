using Newtonsoft.Json;

namespace GoogleMapsClient
{
    /// <summary>
    /// Represents a place find address component respone
    /// </summary>
    public class PlaceFindAddressComponentResponseModel
    {

        #region Private Members

        /// <summary>
        /// The member of the <see cref="LongName"/> property
        /// </summary>
        private string? mLongName;

        /// <summary>
        /// The member of the <see cref="ShortName"/> property
        /// </summary>
        private string? mShortName;

        /// <summary>
        /// The member of the <see cref="Types"/> property
        /// </summary>
        private IEnumerable<AddressType>? mTypes;

        #endregion

        #region Public Property

        /// <summary>
        /// The full text description or name of the address component as returned by the Geocoder.
        /// </summary>
        [JsonProperty("long_name")]
        public string LongName
        {
            get => mLongName ?? string.Empty;

            set => mLongName = value;
        }

        /// <summary>
        /// An abbreviated textual name for the address component, if available.
        /// </summary>
        /// <example>
        /// For example, an address component for the state of Alaska may have a long_name of 
        /// "Alaska" and a short_name of "AK" using the 2-letter postal abbreviation.
        /// </example>
        [JsonProperty("short_name")]
        public string ShortName
        {
            get => mShortName ?? string.Empty;

            set => mShortName = value;
        }

        /// <summary>
        /// An array indicating the type of the address component.
        /// </summary>
        [JsonProperty("types")]
        [JsonConverter(typeof(AddressTypeToStringJsonConverter))]
        public IEnumerable<AddressType> Types
        {
            get => mTypes ?? Enumerable.Empty<AddressType>();

            set => mTypes = value;
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Default Constructor
        /// </summary>
        public PlaceFindAddressComponentResponseModel()
        {

        }

        #endregion
    }
}
