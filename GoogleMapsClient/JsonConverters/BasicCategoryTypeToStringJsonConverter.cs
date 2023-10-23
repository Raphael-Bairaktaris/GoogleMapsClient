using Newtonsoft.Json;

namespace GoogleMapsClient
{
    /// <summary>
    /// The <see cref="JsonConverter{T}"/> that converts a <see cref="BasicCategoryType"/> to <see cref="string"/>
    /// </summary>
    public class BasicCategoryTypeToStringJsonConverter : BaseEnumJsonConverter<BasicCategoryType>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public BasicCategoryTypeToStringJsonConverter()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<BasicCategoryType, string> GetMapper() => GoogleMapsClientConstants.BasicCategoryTypeToStringMapper;

        #endregion
    }
}