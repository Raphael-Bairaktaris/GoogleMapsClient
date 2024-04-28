using Newtonsoft.Json;

namespace GoogleMapsClient
{
    /// <summary>
    /// The <see cref="JsonConverter{T}"/> that converts a <see cref="PriceRangeType"/> to a <see cref="string"/>
    /// </summary>
    public class PriceRangeTypeToStringJsonConverter : BaseEnumJsonConverter<PriceRangeType>
    {
        #region Constructor

        /// <summary>
        /// Default Constructor
        /// </summary>
        public PriceRangeTypeToStringJsonConverter()
        {

        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<PriceRangeType, string> GetMapper() => GoogleMapsClientConstants.PriceRangeTypeToStringMapper;

        #endregion
    }
}
