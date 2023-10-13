using Newtonsoft.Json;

namespace GoogleMapsClient
{
    /// <summary>
    /// The <see cref="JsonConverter{T}"/> that converts a <see cref="IEnumerable{AddressType}"/> to <see cref="string"/>
    /// </summary>
    public class AddressTypeEnumerableToStringJsonConverter : BaseEnumEnumerableJsonConverter<AddressType>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public AddressTypeEnumerableToStringJsonConverter() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<AddressType, string> GetMapper() => GoogleMapsClientConstants.AddressTypeToStringMapper;

        #endregion
    }
}