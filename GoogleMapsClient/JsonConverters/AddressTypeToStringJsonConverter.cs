using Newtonsoft.Json;

namespace Simple.GoogleMaps
{
    /// <summary>
    /// The <see cref="JsonConverter{T}"/> that converts a <see cref="AddressType"/> to <see cref="string"/>
    /// </summary>
    public class AddressTypeToStringJsonConverter : BaseEnumJsonConverter<AddressType>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public AddressTypeToStringJsonConverter()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<AddressType, string> GetMapper() => GoogleMapsClientConstants.AddressTypeToStringMapper;

        #endregion
    }
}