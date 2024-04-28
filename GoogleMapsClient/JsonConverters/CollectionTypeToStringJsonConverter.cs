using Newtonsoft.Json;

namespace Simple.GoogleMaps
{
    /// <summary>
    /// The <see cref="JsonConverter{T}"/> that converts a <see cref="CollectionType"/> to <see cref="string"/>
    /// </summary>
    public class CollectionTypeToStringJsonConverter : BaseEnumJsonConverter<CollectionType>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public CollectionTypeToStringJsonConverter()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<CollectionType, string> GetMapper() => GoogleMapsClientConstants.CollectionTypeToStringMapper;

        #endregion
    }
}