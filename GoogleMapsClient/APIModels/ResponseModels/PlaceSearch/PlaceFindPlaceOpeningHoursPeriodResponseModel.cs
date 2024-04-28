using Newtonsoft.Json;
using System.Diagnostics.CodeAnalysis;

namespace GoogleMapsClient
{
    /// <summary>
    /// Represents a place find opening hours response
    /// </summary>
    public class PlaceFindPlaceOpeningHoursPeriodResponseModel
    {
        #region Private Members
        /// <summary>
        /// The member of the <see cref="Open"/> property
        /// </summary>
        private PlaceFindPlaceOpeningHoursPeriodDetailResponseModel? mOpen;

        /// <summary>
        /// The member of the <see cref="Close"/> property
        /// </summary>
        private PlaceFindPlaceOpeningHoursPeriodDetailResponseModel? mClose;

        #endregion

        #region Public Property

        /// <summary>
        /// Contains a pair of day and time objects describing when the place opens.
        /// </summary>
        /// <remarks>
        /// https://developers.google.com/maps/documentation/places/web-service/search-find-place#PlaceOpeningHoursPeriodDetail
        /// </remarks>
        [AllowNull]
        [JsonProperty("open")]
        public PlaceFindPlaceOpeningHoursPeriodDetailResponseModel Open
        {
            get => mOpen ??= new PlaceFindPlaceOpeningHoursPeriodDetailResponseModel();
            set => mOpen = value;
        }

        /// <summary>
        /// May contain a pair of day and time objects describing when the place closes. 
        /// If a place is always open, the close section will be missing from the response. 
        /// Clients can rely on always-open being represented as an open period containing 
        /// day with value 0 and time with value 0000, and no close.
        /// </summary>
        [AllowNull]
        [JsonProperty("close")]
        public PlaceFindPlaceOpeningHoursPeriodDetailResponseModel Close
        {
            get => mClose ??= new PlaceFindPlaceOpeningHoursPeriodDetailResponseModel();
            set => mClose = value;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default Constructor
        /// </summary>
        public PlaceFindPlaceOpeningHoursPeriodResponseModel()
        {

        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        public override string ToString() => $"Open {Open}, Close {Close}";

        #endregion
    }
}
