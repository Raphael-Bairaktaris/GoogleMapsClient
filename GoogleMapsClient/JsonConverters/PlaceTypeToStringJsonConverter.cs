using Newtonsoft.Json;
using System.Collections.Immutable;

namespace GoogleMapsClient
{
    /// <summary>
    /// The <see cref="JsonConverter{T}"/> that converts a <see cref="PlaceType"/> to <see cref="string"/>
    /// </summary>
    public class PlaceTypeToStringJsonConverter : JsonConverter<PlaceType>
    {
        #region Public Properties

      

        #endregion

        #region Constructors

        /// <summary>
        /// Defualt constructor
        /// </summary>
        public PlaceTypeToStringJsonConverter()
        {
            JsonConvert.DefaultSettings = () =>
            {
                var settings = new JsonSerializerSettings();

                settings.Converters.Add(new PlaceTypeToStringJsonConverter());

                return settings;
            };
        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        public override PlaceType ReadJson(JsonReader reader, Type objectType, PlaceType existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            // Get the reader value
            var readerValue = serializer.Deserialize<string>(reader)!;
            
            return GoogleMapsClientConstants.PlaceTypeToStringMapper.First(x => x.Value == readerValue).Key;
        }

        /// <inheritdoc/>
        public override void WriteJson(JsonWriter writer, PlaceType value, JsonSerializer serializer)
        {
            writer.WriteValue(GoogleMapsClientConstants.PlaceTypeToStringMapper[value]);
        }

        #endregion
    }
}