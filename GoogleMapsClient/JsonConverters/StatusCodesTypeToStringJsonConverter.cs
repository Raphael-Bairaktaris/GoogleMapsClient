using Newtonsoft.Json;

namespace GoogleMapsClient
{
    /// <summary>
    /// The <see cref="JsonConverter{T}"/> that converts a <see cref="StatusCodesType"/> to <see cref="string"/>
    /// </summary>
    public class StatusCodesTypeToStringJsonConverter : BaseEnumJsonConverter<StatusCodesType>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public StatusCodesTypeToStringJsonConverter()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<StatusCodesType, string> GetMapper() => GoogleMapsClientConstants.StatusCodesTypeToStringMapper;
        
        #endregion
    }
}