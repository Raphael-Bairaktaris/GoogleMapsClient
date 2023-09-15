using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleMapsClient
{
    /// <summary>
    /// Provides enumeration of contact category
    /// </summary>
    public enum ContactCategory
    {
        /// <summary>
        /// Current opening hours
        /// </summary>
        CurrentOpeningHours = 0,

        /// <summary>
        /// Formatted phone number
        /// </summary>
        FormattedPhoneNumber = 1,
        
        /// <summary>
        /// Internationa phone number
        /// </summary>
        InternationalPhoneNumber = 2,

        /// <summary>
        /// Opening hours
        /// </summary>
        OpeningHours = 3,

        /// <summary>
        /// Secondary opening hours
        /// </summary>
        SecondaryOpeningHours = 4,

        /// <summary>
        /// Website
        /// </summary>
        Website = 5,
    }
}
