using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleMapsClient
{
    /// <summary>
    /// An object describing the location.
    /// </summary>
    public class PlaceFindGeomertryResponseModel
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
        [AllowNull]
        [JsonProperty("location")]
        public PlaceFindLatitudeLongitudeLiteralResponseModel? Location 
        {
            get => mLocation ??= new PlaceFindLatitudeLongitudeLiteralResponseModel();

            set => mLocation = value;
        }

        /// <remarks>
        /// https://developers.google.com/maps/documentation/places/web-service/search-find-place#Bounds
        /// </remarks>
        [AllowNull]
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
        public PlaceFindGeomertryResponseModel()
        {
            
        }

        #endregion
    }
}
