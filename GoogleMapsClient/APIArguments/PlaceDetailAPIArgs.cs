using Newtonsoft.Json;

namespace GoogleMapsClient
{
    /// <summary>
    /// Represents a place detail 
    /// </summary>
    public class PlaceDetailAPIArgs
    {
        #region Public Properties
        
        /// <summary>
        /// A textual identifier that uniquely identifies a place, returned from a Place Search.
        /// </summary>
        /// <remarks>
        /// https://developers.google.com/maps/documentation/places/web-service/place-id
        /// </remarks>
        [JsonProperty("place_id")]
        public string PlaceId { get; set; }

        /// <summary>
        /// The Basic category includes the following fields: address_components, adr_address,
        /// business_status, formatted_address, geometry, icon, icon_mask_base_uri, icon_background_color,
        /// name, permanently_closed (deprecated), photo, place_id, plus_code, type, url, utc_offset, 
        /// vicinity, wheelchair_accessible_entrance.
        /// </summary>
        public BasicCategoryType? Basic { get; set; }

        /// <summary>
        /// The Contact category includes the following fields: current_opening_hours, formatted_phone_number,
        /// international_phone_number, opening_hours, secondary_opening_hours, website
        /// </summary>
        public ContactCategoryType? Contact { get; set; }

        /// <summary>
        /// The Atmosphere category includes the following fields: curbside_pickup, delivery, dine_in, 
        /// editorial_summary, price_level, rating, reservable, reviews, serves_beer, serves_breakfast, serves_brunch,
        /// serves_dinner, serves_lunch, serves_vegetarian_food, serves_wine, takeout, user_ratings_total.
        /// </summary>
        public AtmosphereCategoryType? Atmosphere { get; set; }

        /// <summary>
        /// List of supported languages
        /// </summary>
        public SupportedLanguage? Language { get; set; }

        #endregion

        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        public PlaceDetailAPIArgs()
        {

        }

        #endregion
    }
}
