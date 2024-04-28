using Newtonsoft.Json;
using System.Diagnostics.CodeAnalysis;

namespace Simple.GoogleMaps
{
    /// <summary>
    /// Represents a place photo
    /// </summary>
    public class PlacePhotoResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="HTMLAttributions"/> property
        /// </summary>
        private IEnumerable<string>? mHTMLAttributions;

        /// <summary>
        /// The member of the <see cref="PhotoReference"/> property
        /// </summary>
        private string? mPhotoReference;

        #endregion

        #region Public Properties

        /// <summary>
        /// Contains an array of html attributions
        /// </summary>
        [AllowNull]
        [JsonProperty("html_attributions")]
        public IEnumerable<string> HTMLAttributions
        {
            get => mHTMLAttributions ?? Enumerable.Empty<string>();

            set => mHTMLAttributions = value;
        }

        /// <summary>
        /// The pixel height of the image
        /// </summary>
        [JsonProperty("height")]
        public double Height { get; set; }

        /// <summary>
        /// The pixel width of the image
        /// </summary>
        [JsonProperty("width")]
        public double Width { get; set; }

        /// <summary>
        ///  A string used to identify the photo when you perform a Photo request.
        /// </summary>
        [AllowNull]
        [JsonProperty("photo_reference")]
        public string PhotoReference
        {
            get => mPhotoReference ?? string.Empty;

            set => mPhotoReference = value;
        }

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
