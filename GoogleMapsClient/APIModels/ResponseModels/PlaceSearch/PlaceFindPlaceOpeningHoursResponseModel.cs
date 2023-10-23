using Newtonsoft.Json;
using System.Diagnostics.CodeAnalysis;

namespace GoogleMapsClient
{
    /// <summary>
    /// Represents the opening hours of a place
    /// </summary>
    public class PlaceFindPlaceOpeningHoursResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="Periods"/> property
        /// </summary>
        private IEnumerable<PlaceFindPlaceOpeningHoursPeriodResponseModel>? mPeriods;

        /// <summary>
        /// The members of the <see cref="SpecialDays"/> property
        /// </summary>
        private IEnumerable<PlaceFindSpecialDayResponseModel>? mSpecialDays;

        /// <summary>
        /// The member of the <see cref="Type"/> property
        /// </summary>
        private string? mType;

        /// <summary>
        /// The member of the <see cref="WeekdayText"/> property
        /// </summary>
        private IEnumerable<string>? mWeekdayText;

        #endregion

        #region Public Property
        /// <summary>
        /// A boolean value indicating if the place is open at the current time.
        /// </summary>
        [JsonProperty("open_now")]
        public bool OpenNow { get; set; }

        /// <summary>
        /// An array of opening periods covering seven days, starting from Sunday, in chronological order.
        /// </summary>
        /// <remarks>
        /// https://developers.google.com/maps/documentation/places/web-service/search-find-place#PlaceOpeningHoursPeriod
        /// </remarks>
        [AllowNull]
        [JsonProperty("periods")]
        public IEnumerable<PlaceFindPlaceOpeningHoursPeriodResponseModel> Periods
        {
            get => mPeriods ?? Enumerable.Empty<PlaceFindPlaceOpeningHoursPeriodResponseModel>();
            set => mPeriods = value;
        }

        /// <summary>
        /// An array of up to seven entries sorresponding to the next seven days.
        /// </summary>
        /// <remarks>
        /// https://developers.google.com/maps/documentation/places/web-service/search-find-place#PlaceSpecialDay
        /// </remarks>
        [AllowNull]
        [JsonProperty("special_days")]
        public IEnumerable<PlaceFindSpecialDayResponseModel> SpecialDays
        {
            get => mSpecialDays ?? Enumerable.Empty<PlaceFindSpecialDayResponseModel>();
            set => mSpecialDays = value;
        }

        /// <summary>
        /// A type string used to identify the type of secondary hours.
        /// </summary>
        [AllowNull]
        [JsonProperty("type")]
        public string Type
        {
            get => mType ?? string.Empty;
            set => mType = value;
        }

        /// <summary>
        /// An array of strings describing in human-readable text the hours of the place.
        /// </summary>
        [AllowNull]
        [JsonProperty("weekday_text")]
        public IEnumerable<string> WeekdayText
        {
            get => mWeekdayText ?? Enumerable.Empty<string>();
            set => mWeekdayText = value;
        }

        #endregion

        #region Constructor
        /// <summary>
        /// Default Constructor
        /// </summary>
        public PlaceFindPlaceOpeningHoursResponseModel()
        {

        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        public override string ToString() => WeekdayText.AggregateString();

        #endregion
    }
}
