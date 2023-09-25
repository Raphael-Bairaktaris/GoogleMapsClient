using Newtonsoft.Json;

namespace GoogleMapsClient
{
    /// <summary>
    /// The <see cref="JsonConverter{T}"/> that converts a <see cref="StatusCodeType"/> to <see cref="string"/>
    /// </summary>
    public class StatusCodeTypeToStringJsonConverter : BaseEnumJsonConverter<StatusCodeType>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public StatusCodeTypeToStringJsonConverter()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<StatusCodeType, string> GetMapper() => GoogleMapsClientConstants.StatusCodeTypeToStringMapper;
        
        #endregion
    }
}