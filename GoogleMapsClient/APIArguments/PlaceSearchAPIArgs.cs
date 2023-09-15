using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleMapsClient
{
    /// <summary>
    /// Represent a place search 
    /// </summary>
    public class PlaceSearchAPIArgs
    {
        #region Public Properties
        /// <summary>
        /// The text string on which to search. This must be a place name, address, or 
        /// category of establishments. Any other type of input can generate errors.
        /// </summary>
        /// <example>
        /// Example "restaurant" or "123 Main Street".
        /// </example>
        [AllowNull]
        public string? Input 
        { get;
            
          set; 
        }

        /// <summary>
        /// The type of input. This can be one of either textquery or phonenumber. 
        /// Phone numbers must be in international format
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/E.164
        /// </remarks>
        [AllowNull]
        public string? Inputtype 
        { 
          get; 
          set; 
        }

        //Na rwthsw sxetika me to FIELD

        /// <summary>
        /// The Basic category includes the following fields: address_components, adr_address,
        /// business_status, formatted_address, geometry, icon, icon_mask_base_uri, icon_background_color,
        /// name, permanently_closed (deprecated), photo, place_id, plus_code, type, url, utc_offset, 
        /// vicinity, wheelchair_accessible_entrance.
        /// </summary>
        [AllowNull]
        public BasicCategory? Basic
        {
            get;
            set;
        }

        /// <summary>
        /// The Contact category includes the following fields: current_opening_hours, formatted_phone_number,
        /// international_phone_number, opening_hours, secondary_opening_hours, website
        /// </summary>
        public ContactCategory? Contact 
        { 
            get; 
            set; 
        }

        /// <summary>
        /// The Atmosphere category includes the following fields: curbside_pickup, delivery, dine_in, 
        /// editorial_summary, price_level, rating, reservable, reviews, serves_beer, serves_breakfast, serves_brunch,
        /// serves_dinner, serves_lunch, serves_vegetarian_food, serves_wine, takeout, user_ratings_total.
        /// </summary>
        public AtmosphereCategory? Atmosphere 
        { 
            get; 
            set; 
        }

        /// <summary>
        /// List of supported languages
        /// </summary>
        public SupportedLanguage? Language 
        { 
            get; 
            set; 
        }



        #endregion

        #region Constructor
        /// <summary>
        /// Default constructor
        /// </summary>
        public PlaceSearchAPIArgs()
        {
            
        }
        #endregion
    }
}
