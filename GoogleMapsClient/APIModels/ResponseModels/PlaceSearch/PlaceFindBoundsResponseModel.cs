using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleMapsClient
{
    /// <summary>
    /// Represents a rectangle in geographical coordinates from points at the southwest and northeast corners.
    /// </summary>
    public class PlaceFindBoundsResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="Northeast"/> property
        /// </summary>
        private PlaceFindLatitudeLongitudeLiteralResponseModel? mNortheast;

        /// <summary>
        /// The member of the <see cref="Southwest"/> property
        /// </summary>
        private PlaceFindLatitudeLongitudeLiteralResponseModel? mSouthwest;

        #endregion

        #region Public Property

        /// <remarks>
        /// https://developers.google.com/maps/documentation/places/web-service/search-find-place#LatLngLiteral
        /// </remarks>
        [AllowNull]
        public PlaceFindLatitudeLongitudeLiteralResponseModel Northeast
        {
            get => mNortheast ??= new PlaceFindLatitudeLongitudeLiteralResponseModel();

            set => mNortheast = value;
        }

        /// <remarks>
        /// https://developers.google.com/maps/documentation/places/web-service/search-find-place#LatLngLiteral
        /// </remarks>
        [AllowNull]
        public PlaceFindLatitudeLongitudeLiteralResponseModel? Southwest 
        { 
            get => mSouthwest ??= new PlaceFindLatitudeLongitudeLiteralResponseModel();
            
            set => mSouthwest = value;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default Constructor
        /// </summary>
        public PlaceFindBoundsResponseModel()
        {
            
        }

        #endregion
    }
}
