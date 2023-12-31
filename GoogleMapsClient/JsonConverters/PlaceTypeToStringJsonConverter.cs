﻿using Newtonsoft.Json;

namespace GoogleMapsClient
{

    /// <summary>
    /// The <see cref="JsonConverter{T}"/> that converts a <see cref="PlaceType"/> to <see cref="string"/>
    /// </summary>
    public class PlaceTypeToStringJsonConverter : BaseEnumJsonConverter<PlaceType>
    {
        #region Constructors

        /// <summary>
        /// Defualt constructor
        /// </summary>
        public PlaceTypeToStringJsonConverter()
        {

        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<PlaceType, string> GetMapper() => GoogleMapsClientConstants.PlaceTypeToStringMapper;

        #endregion
    }
}