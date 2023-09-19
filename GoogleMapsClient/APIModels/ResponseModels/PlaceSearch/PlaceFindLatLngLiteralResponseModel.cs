using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleMapsClient
{
    /// <summary>
    /// Represents a specific location with Latitude and Longitude in decimal degrees.
    /// </summary>
    public class PlaceFindLatLngLiteralResponseModel
    {
        #region Public Property

        /// <summary>
        /// Latitude in decimal degrees
        /// </summary>
        [JsonProperty("lat")]
        public double Lat { get; set; }

        /// <summary>
        /// Longtitude in decimal degrees
        /// </summary>
        [JsonProperty("lng")]
        public double Lng { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default Constructor
        /// </summary>
        public PlaceFindLatLngLiteralResponseModel()
        {
            
        }

        #endregion
    }
}
