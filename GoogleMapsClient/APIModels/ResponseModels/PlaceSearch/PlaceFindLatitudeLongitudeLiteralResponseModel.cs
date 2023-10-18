using Newtonsoft.Json;

namespace GoogleMapsClient
{
    /// <summary>
    /// Represents a specific location with Latitude and Longitude in decimal degrees.
    /// </summary>
    public class PlaceFindLatitudeLongitudeLiteralResponseModel
    {
        #region Public Property

        /// <summary>
        /// Latitude in decimal degrees
        /// </summary>
        [JsonProperty("lat")]
        public double Latitude { get; set; }

        /// <summary>
        /// Longitude in decimal degrees
        /// </summary>
        [JsonProperty("lng")]
        public double Longitude { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default Constructor
        /// </summary>
        public PlaceFindLatitudeLongitudeLiteralResponseModel()
        {
            
        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        public override string ToString() => $"Latitude: {Latitude}, Longitude: {Longitude}";

        #endregion
    }
}
