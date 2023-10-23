using Newtonsoft.Json;

namespace GoogleMapsClient
{
    /// <summary>
    /// The <see cref="JsonConverter{T}"/> that converts a <see cref="TimeOnly"/> to <see cref="string"/>
    /// </summary>
    public class TimeOnlyToStringJsonConveter : JsonConverter<TimeOnly>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public TimeOnlyToStringJsonConveter()
        {

        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        public override TimeOnly ReadJson(JsonReader reader, Type objectType, TimeOnly existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            var readerValue = serializer.Deserialize<string>(reader)!;

            var hours = readerValue.Substring(0, 2);
            var minutes = readerValue.Substring(2, 2);

            return new TimeOnly(int.Parse(hours), int.Parse(minutes));
        }

        /// <inheritdoc/>
        public override void WriteJson(JsonWriter writer, TimeOnly value, JsonSerializer serializer)
        {
            writer.WriteValue(value.Hour.ToString() + value.Minute.ToString());
        }

        #endregion

    }
}
