using Newtonsoft.Json;

namespace Simple.GoogleMaps
{

    /// <summary>
    /// The <see cref="JsonConverter{T}"/> that converts a <see cref="PlaceType"/> to <see cref="string"/>
    /// </summary>
    public class PlaceTypeToStringJsonConverter : BaseEnumJsonConverter<PlaceType>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public PlaceTypeToStringJsonConverter()
        {

        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<PlaceType, string> GetMapper() => GoogleMapsClientConstants.PlaceTypeToStringMapper;

        #endregion
    }
}