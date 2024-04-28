using Newtonsoft.Json;

namespace GoogleMapsClient
{
    /// <summary>
    /// The <see cref="JsonConverter{T}"/> that converts a <see cref="SupportedLanguage"/> to <see cref="string"/>
    /// </summary>
    public class SupportedLanguageEnumerableToStringJsonConverter : BaseEnumEnumerableJsonConverter<SupportedLanguage>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public SupportedLanguageEnumerableToStringJsonConverter()
        {

        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<SupportedLanguage, string> GetMapper() => GoogleMapsClientConstants.SupportedLanguageToStringMapper;

        #endregion
    }
}