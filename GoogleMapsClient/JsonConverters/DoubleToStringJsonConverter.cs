﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleMapsClient
{
    /// <summary>
    /// A <see cref="JsonConverter{T}"/> that is used for converting a <see cref="double?"/> to a string <see cref="string"/>
    /// </summary>
    public class DoubleToStringJsonConverter : JsonConverter<double?>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public DoubleToStringJsonConverter()
        {
                
        }

        #endregion

        /// <inheritdoc/>
        public override double? ReadJson(JsonReader reader, Type objectType, double? existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            var readerValue = serializer.Deserialize<string?>(reader);

            if (string.IsNullOrEmpty(readerValue))
                return null;

            readerValue = readerValue.Replace(",", ".");

            return double.Parse(readerValue);
        }

        /// <inheritdoc/>
        public override void WriteJson(JsonWriter writer, double? value, JsonSerializer serializer)
        {
            if (value is null)
                writer.WriteNull();
            else
                writer.WriteValue(value);
        }
    }
}
