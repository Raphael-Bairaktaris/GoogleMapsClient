namespace Simple.GoogleMaps
{
    /// <summary>
    /// Arguments used for receiving a place search 
    /// </summary>
    public class PlaceFindAPIArgs
    {
        #region Public Properties

        /// <summary>
        /// The text string on which to search. This must be a place name, address, or 
        /// category of establishments. Any other type of input can generate errors.
        /// </summary>
        /// <example>
        /// Example "restaurant" or "123 Main Street".
        /// </example>
        [ArgumentName("input")]
        public string Input { get; }

        /// <summary>
        /// The type of input. This can be one of either textquery or phonenumber. 
        /// Phone numbers must be in international format
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/E.164
        /// </remarks>
        [ArgumentName("inputtype")]
        public string InputType { get; }

        /// <summary>
        /// Use the fields parameter to specify a comma-separated list of place data types to return.
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
        [QueryArgumentConverter<BasicCategoryTypeQueryArgumentConverter>]
        public BasicCategoryType? Basic { get; set; }

        /// <summary>
        /// The Contact category includes the following fields: current_opening_hours, formatted_phone_number,
        /// international_phone_number, opening_hours, secondary_opening_hours, website
        /// </summary>
        [ArgumentName("contact")]
        [QueryArgumentConverter<ContactCategoryTypeQueryArgumentConverter>]
        public ContactCategoryType? Contact { get; set; }

        /// <summary>
        /// The Atmosphere category includes the following fields: curbside_pickup, delivery, dine_in, 
        /// editorial_summary, price_level, rating, reservable, reviews, serves_beer, serves_breakfast, serves_brunch,
        /// serves_dinner, serves_lunch, serves_vegetarian_food, serves_wine, takeout, user_ratings_total.
        /// </summary>
        [ArgumentName("atmosphere")]
        [QueryArgumentConverter<AtmosphereCategoryTypeQueryArgumentConverter>]
        public AtmosphereCategoryType? Atmosphere { get; set; }

        /// <summary>
        /// List of supported languages
        /// </summary>
        [ArgumentName("language")]
        [QueryArgumentConverter<SupportedLanguageQueryArgumentConverter>]
        public SupportedLanguage? Language { get; set; }

        /// <summary>
        /// Prefer results in a specified area, by specifying either a radius plus lat/lng, or two lat/lng pairs
        /// representing the points of a rectangle. If this parameter is not specified, the API uses IP address biasing by default.
        /// </summary>
        [ArgumentName("locationbias")]
        public LocationBiasInfo? LocationBias { get; set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="input">
        /// The text string on which to search. This must be a place name, address, or 
        /// category of establishments. Any other type of input can generate errors.
        /// </param>
        /// <param name="inputtype">
        /// The type of input. This can be one of either textquery or phonenumber. 
        /// Phone numbers must be in international format.
        /// </param>
        public PlaceFindAPIArgs(string input, string inputtype)
        {
            if (string.IsNullOrEmpty(input))
            {
                throw new ArgumentException($"'{nameof(input)}' cannot be null or empty.", nameof(input));
            }

            if (string.IsNullOrEmpty(inputtype))
            {
                throw new ArgumentException($"'{nameof(inputtype)}' cannot be null or empty.", nameof(inputtype));
            }

            Input = input;
            InputType = inputtype;
        }

        /// <summary>
        /// Input based constructor
        /// </summary>
        /// <param name="input">
        /// The text string on which to search. This must be a place name, address, or 
        /// category of establishments. Any other type of input can generate errors.
        /// </param>
        public PlaceFindAPIArgs(string input) : this(input, "textquery")
        {

        }

        #endregion
    }
}
