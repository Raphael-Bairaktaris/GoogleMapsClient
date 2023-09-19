using Newtonsoft.Json;

namespace GoogleMapsClient
{
    /// <summary>
    /// The <see cref="JsonConverter{T}"/> that converts a <see cref="AtmosphereCategoryType"/> to <see cref="string"/>
    /// </summary>
    public class AtmosphereCategoryTypeToStringJsonConverter : BaseEnumJsonConverter<AtmosphereCategoryType>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public AtmosphereCategoryTypeToStringJsonConverter()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<AtmosphereCategoryType, string> GetMapper() => GoogleMapsClientConstants.AtmosphereCategoryTypeToStringMapper;

        #endregion
    }
}