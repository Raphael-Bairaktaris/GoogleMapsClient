using Newtonsoft.Json;

namespace GoogleMapsClient
{
    /// <summary>
    /// The <see cref="JsonConverter{T}"/> that converts a <see cref="SupportedLanguage"/> to <see cref="string"/>
    /// </summary>
    public class SupportedLanguageToStringJsonConverter : JsonConverter<SupportedLanguage>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public SupportedLanguageToStringJsonConverter()
        {

        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        public override SupportedLanguage ReadJson(JsonReader reader, Type objectType, SupportedLanguage existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            var readerValue = serializer.Deserialize<string>(reader)!;

            return Enum.Parse<SupportedLanguage>(readerValue);
        }

        /// <inheritdoc/> 
        public override void WriteJson(JsonWriter writer, SupportedLanguage value, JsonSerializer serializer)
        {
            writer.WriteValue(value.ToString());
        }

        #endregion
    }
}