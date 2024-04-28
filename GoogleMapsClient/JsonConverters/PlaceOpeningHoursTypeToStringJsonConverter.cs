using Newtonsoft.Json;

namespace Simple.GoogleMaps
{
    /// <summary>
    /// The <see cref="JsonConverter{T}"/> that converts a <see cref="PlaceOpeningHoursType"/> to <see cref="string"/>
    /// </summary>
    public class PlaceOpeningHoursTypeToStringJsonConverter : BaseEnumJsonConverter<PlaceOpeningHoursType>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public PlaceOpeningHoursTypeToStringJsonConverter()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<PlaceOpeningHoursType, string> GetMapper() => GoogleMapsClientConstants.PlaceOpeningHoursTypeToStringMapper;

        #endregion
    }
}