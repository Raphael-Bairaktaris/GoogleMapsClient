namespace GoogleMapsClient
{
    /// <summary>
    /// Arguments used for receiving a place photo
    /// </summary>
    public class PlacePhotoAPIArgs
    {
        #region Public Properties

        /// <summary>
        /// A string identifier that uniquely identifies a photo. Photo references are returned from either a Place Search or Place Details request.
        /// </summary>
        [ArgumentName("photo_reference")]
        public string PhotoReference { get; }

        /// <summary>
        /// MaxHeight specifies the maximum desired height, in pixels, of the image. If the image is smaller than the values specified, 
        /// the original image will be returned. If the image is larger in either dimension, it will be scaled to match the smaller of the 
        /// two dimensions, restricted to its original aspect ratio.
        /// </summary>
        /// <remarks>
        /// You must specify either maxheight, or maxwidth, or both.
        /// </remarks>
        [ArgumentName("maxheight")]
        public double? MaxHeight { get; }

        /// <summary>
        /// MaxWidth specifies the maximum desired width, in pixels, of the image. If the image is smaller than the values specified, 
        /// the original image will be returned. If the image is larger in either dimension, it will be scaled to match the smaller of the 
        /// two dimensions, restricted to its original aspect ratio.
        /// </summary>
        /// <remarks>
        /// You must specify either maxheight, or maxwidth, or both.
        /// </remarks>
        [ArgumentName("maxwidth")]
        public double? MaxWidth { get; }

        #endregion

        #region Constructor

        /// <summary>
        /// Single max size based constructor
        /// </summary>
        /// <param name="photoReference">A string identifier that uniquely identifies a photo. Photo references are returned from either a Place Search or Place Details request.</param>
        /// <param name="isWidth">A flag indicating whether the <see cref="MaxWidth"/> or the <see cref="MaxHeight"/> should be set.</param>
        /// <param name="maxSize">The maximum size that's wither the <see cref="MaxWidth"/> or the <see cref="MaxHeight"/></param>
        public PlacePhotoAPIArgs(string photoReference, bool isWidth, double maxSize)
        {
            if (string.IsNullOrEmpty(photoReference))
            {
                throw new ArgumentException($"'{nameof(photoReference)}' cannot be null or empty.", nameof(photoReference));
            }

            PhotoReference = photoReference;
            if (isWidth)
                MaxWidth = maxSize;
            else
                MaxHeight = maxSize;
        }

        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="photoReference">A string identifier that uniquely identifies a photo. Photo references are returned from either a Place Search or Place Details request.</param>
        /// <param name="maxHeight">
        /// MaxHeight specifies the maximum desired height, in pixels, of the image. If the image is smaller than the values specified, 
        /// the original image will be returned. If the image is larger in either dimension, it will be scaled to match the smaller of the 
        /// two dimensions, restricted to its original aspect ratio.
        /// </param>
        /// <param name="maxWidth">
        /// MaxWidth specifies the maximum desired width, in pixels, of the image. If the image is smaller than the values specified, 
        /// the original image will be returned. If the image is larger in either dimension, it will be scaled to match the smaller of the 
        /// two dimensions, restricted to its original aspect ratio.
        /// </param>
        public PlacePhotoAPIArgs(string photoReference, double maxHeight, double maxWidth)
        {
            if (string.IsNullOrEmpty(photoReference))
            {
                throw new ArgumentException($"'{nameof(photoReference)}' cannot be null or empty.", nameof(photoReference));
            }

            PhotoReference = photoReference;
            MaxHeight = maxHeight;
            MaxWidth = maxWidth;
        }

        #endregion
    }
}
