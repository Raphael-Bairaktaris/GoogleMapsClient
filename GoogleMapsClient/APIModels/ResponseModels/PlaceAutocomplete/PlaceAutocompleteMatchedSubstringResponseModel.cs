using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace GoogleMapsClient
{
    /// <summary>
    /// Represents an auto complete matched substring 
    /// </summary>
    public class PlaceAutocompleteMatchedSubstringResponseModel
    {
        #region Public Properties

        /// <summary>
        /// Length of the matched substring in the prediction result text.
        /// </summary>
        [JsonProperty("length")]
        public int Length { get; set; }

        /// <summary>
        /// Start location of the matched substring in the prediction result text.
        /// </summary>
        [JsonProperty("offset")]
        public int Offset { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public PlaceAutocompleteMatchedSubstringResponseModel()
        {
            
        }
        #endregion
    }

}