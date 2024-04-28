using Newtonsoft.Json;

namespace GoogleMapsClient
{
    /// <summary>
    /// Contains the location and viewport for the location.
    /// </summary>
    public class PlaceFindGeometryResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="Location"/> property
        /// </summary>
        private PlaceFindLatitudeLongitudeLiteralResponseModel? mLocation;

        /// <summary>
        /// The member of the <see cref="Viewport"/> property
        /// </summary>
        private PlaceFindBoundsResponseModel? mViewport;

        #endregion

        #region Public Property

        /// <remarks>
        /// https://developers.google.com/maps/documentation/places/web-service/search-find-place#LatLngLiteral
        /// </remarks>
        [JsonProperty("location")]
        public PlaceFindLatitudeLongitudeLiteralResponseModel? Location
        {
            get => mLocation ??= new PlaceFindLatitudeLongitudeLiteralResponseModel();

            set => mLocation = value;
        }

        /// <remarks>
        /// https://developers.google.com/maps/documentation/places/web-service/search-find-place#Bounds
        /// </remarks>
        [JsonProperty("viewport")]
        public PlaceFindBoundsResponseModel? Viewport
        {
            get => mViewport ??= new PlaceFindBoundsResponseModel();

            set => mViewport = value;
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Default Constructor
        /// </summary>
        public PlaceFindGeometryResponseModel()
        {

        }

        #endregion

        #region Public Methods 

        /// <inheritdoc/>
        public override string ToString() => $"location {Location}, viewport {Viewport}";

        #endregion
    }
}
