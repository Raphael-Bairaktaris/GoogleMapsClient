using Newtonsoft.Json;

namespace GoogleMapsClient
{
    /// <summary>
    /// Represents a place photo response
    /// </summary>
    public class PlacePhotoResponseModel
    {
        #region Public Properties

        /// <summary>
        /// Contains an array of html attributions
        /// </summary>
        [JsonProperty("html_attributions")]
        public IEnumerable<string>? HTMLAttributions { get; set; }

        /// <summary>
        /// The pixel height of the image
        /// </summary>
        [JsonProperty("height")]
        public double? Height { get; set; }

        /// <summary>
        /// The pixel width of the image
        /// </summary>
        [JsonProperty("width")]
        public double? Width { get; set; }

        /// <summary>
        ///  A string used to identify the photo when you perform a Photo request.
        /// </summary>
        [JsonProperty("photo_reference")]
        public string? PhotoReference { get; set; }
        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public PlacePhotoResponseModel()
        {
            
        }

        #endregion
    }
}
