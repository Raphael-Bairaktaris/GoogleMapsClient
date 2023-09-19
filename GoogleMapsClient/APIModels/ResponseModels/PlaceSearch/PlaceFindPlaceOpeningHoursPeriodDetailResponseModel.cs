using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GoogleMapsClient
{
    /// <summary>
    /// Represents a place opening hourse period detail response
    /// </summary>
    public class PlaceFindPlaceOpeningHoursPeriodDetailResponseModel
    {
        #region Public Property

        /// <summary>
        /// A number from 0–6, corresponding to the days of the week, 
        /// starting on Sunday. For example, 2 means Tuesday.
        /// </summary>
        [JsonProperty("day")]
        public DayOfWeek Day { get; set;}

        /// <summary>
        /// May contain a time of day in 24-hour hhmm format. Values are 
        /// in the range 0000–2359. The time will be reported in the place’s time zone.
        /// </summary>
        [JsonProperty("time")]
        public TimeOnly Time { get; set; }

        /// <summary>
        /// A date expressed in RFC3339 format in the local timezone for the place, for example 2010-12-31.
        /// </summary>
        [JsonProperty("date")]
        public DateOnly Date { get; set; }
        
        /// <summary>
        /// True if a given period was truncated due to a seven-day cutoff, where the period starts
        /// before midnight on the date of the request and/or ends at or after midnight on the last day. 
        /// This property indicates that the period for open or close can extend past this seven-day cutoff.
        /// </summary>
        [JsonProperty("truncated")]
        public bool Truncated { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default Constructor
        /// </summary>
        public PlaceFindPlaceOpeningHoursPeriodDetailResponseModel()
        {
            
        }

        #endregion
    }
}
