using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleMapsClient
{
    /// <summary>
    /// Represents a place special day response
    /// </summary>
    public class PlaceFindPlaceSpecialDayResponseModel
    {
        #region Public Property

        /// <summary>
        /// A date expressed in RFC3339 format in the local 
        /// timezone for the place, for example 2010-12-31.
        /// </summary>
        [JsonProperty("date")]
        [JsonConverter(typeof(DateOnlyToStringJsonConverter))]
        public DateOnly Date { get; set; }

        /// <summary>
        /// True if there are exceptional hours for this day. If true, 
        /// this means that there is at least one exception for this day. 
        /// Exceptions cause different values to occur in the subfields of current_opening_hours
        /// and secondary_opening_hours such as periods, weekday_text, open_now. 
        /// The exceptions apply to the hours, and the hours are used to generate the other fields.
        /// </summary>
        [JsonProperty("exceptional_hours")]
        public bool ExceptionalHours { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default Constructor
        /// </summary>
        public PlaceFindPlaceSpecialDayResponseModel()
        {
            
        }

        #endregion
    }
}
