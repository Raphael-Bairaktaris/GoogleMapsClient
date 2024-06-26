﻿using Newtonsoft.Json;

namespace Simple.GoogleMaps
{
    /// <summary>
    /// Represents a place opening hours period detail
    /// </summary>
    public class PlaceFindPlaceOpeningHoursPeriodDetailResponseModel
    {
        #region Public Property

        /// <summary>
        /// A number from 0–6, corresponding to the days of the week, 
        /// starting on Sunday. For example, 2 means Tuesday.
        /// </summary>
        [JsonProperty("day")]
        public DayOfWeek Day { get; set; }

        /// <summary>
        /// May contain a time of day in 24-hour hhmm format. Values are 
        /// in the range 0000–2359. The time will be reported in the place’s time zone.
        /// </summary>
        [JsonProperty("time")]
        [JsonConverter(typeof(TimeOnlyToStringJsonConverter))]
        public TimeOnly Time { get; set; }

        /// <summary>
        /// A date expressed in RFC3339 format in the local timezone for the place, for example 2010-12-31.
        /// </summary>
        [JsonProperty("date")]
        [JsonConverter(typeof(DateOnlyToStringJsonConverter))]
        public DateOnly? Date { get; set; }

        /// <summary>
        /// True if a given period was truncated due to a seven-day cutoff, where the period starts
        /// before midnight on the date of the request and/or ends at or after midnight on the last day. 
        /// This property indicates that the period for open or close can extend past this seven-day cutoff.
        /// </summary>
        [JsonProperty("truncated")]
        public bool? IsTruncated { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default Constructor
        /// </summary>
        public PlaceFindPlaceOpeningHoursPeriodDetailResponseModel()
        {

        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        public override string ToString() => $"Day {Day}, Time {Time}";

        #endregion
    }
}
