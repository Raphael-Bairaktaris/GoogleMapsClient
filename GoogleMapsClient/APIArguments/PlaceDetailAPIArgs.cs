using GoogleMapsClient.DataModels.Enums;

namespace GoogleMapsClient
{
    /// <summary>
    /// Arguements used for receiving a place detail 
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
        [ArgumentName("place_id")]
        public string PlaceId { get; }

        /// <summary>
        /// Use the fields parameter to specify a comma-separated list of place data types to return 
        /// </summary>
        /// <example>
        /// For example: fields=formatted_address,name,geometry. Use a forward slash when specifying compound values. 
        /// For example: opening_hours/open_now.
        /// </example>
        [ArgumentName("fields")]
        public IEnumerable<string>? Fields { get; set; }

        /// <summary>
        /// The Basic category includes the following fields: address_components, adr_address,
        /// business_status, formatted_address, geometry, icon, icon_mask_base_uri, icon_background_color,
        /// name, permanently_closed (deprecated), photo, place_id, plus_code, type, url, utc_offset, 
        /// vicinity, wheelchair_accessible_entrance.
        /// </summary>
        [ArgumentName("basic")]
        public BasicCategoryType? Basic { get; set; }

        /// <summary>
        /// The Contact category includes the following fields: current_opening_hours, formatted_phone_number,
        /// international_phone_number, opening_hours, secondary_opening_hours, website
        /// </summary>
        [ArgumentName("contact")]
        public ContactCategoryType? Contact { get; set; }

        /// <summary>
        /// The Atmosphere category includes the following fields: curbside_pickup, delivery, dine_in, 
        /// editorial_summary, price_level, rating, reservable, reviews, serves_beer, serves_breakfast, serves_brunch,
        /// serves_dinner, serves_lunch, serves_vegetarian_food, serves_wine, takeout, user_ratings_total.
        /// </summary>
        [ArgumentName("atmosphere")]
        public AtmosphereCategoryType? Atmosphere { get; set; }

        /// <summary>
        /// List of supported languages
        /// </summary>
        [ArgumentName("language")]
        public SupportedLanguage? Language { get; set; }

        /// <summary>
        /// The region code, specified as a ccTLD ("top-level domain") two-character value. 
        /// Most ccTLD codes are identical to ISO 3166-1 codes, with some notable exceptions.
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/List_of_Internet_top-level_domains#Country_code_top-level_domains
        /// </remarks>
        [ArgumentName("region")]
        public string? Region { get; set; }

        /// <summary>
        /// Specify reviews_no_translations=true to disable translation of reviews; specify reviews_no_translations=false
        /// to enable translation of reviews. Reviews are returned in their original language.
        /// </summary>
        [ArgumentName("reviews_no_translations")]
        public bool? ReviewsNoTranslations { get; set; }

        /// <summary>
        /// The sorting method to use when returning reviews. Can be set to most_relevant (default) or newest.
        /// </summary>
        [ArgumentName("reviews_sort")]
        public ReviewSortingType? ReviewsSort { get; set; }

        /// <summary>
        /// A random string which identifies an autocomplete session for billing purposes.
        /// </summary>
        [ArgumentName("sessiontoken")]
        public string? SessionToken { get; set; }

        #endregion

        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        public PlaceDetailAPIArgs(string placeid)
        {
            PlaceId = placeid;
        }

        #endregion
    }
}
