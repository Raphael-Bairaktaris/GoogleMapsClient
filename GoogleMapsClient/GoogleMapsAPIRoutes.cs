namespace Simple.GoogleMaps
{
    /// <summary>
    /// The API routes of Google Maps API
    /// </summary>
    public static class GoogleMapsAPIRoutes
    {
        /// <summary>
        /// The base route
        /// </summary>
        public const string BaseRoute = "https://maps.googleapis.com/maps/api/place";

        /// <summary>
        /// The find place route
        /// </summary>
        public const string FindPlaceAPIRoute = $"{BaseRoute}/findplacefromtext/json";

        /// <summary>
        /// The nearby search route
        /// </summary>
        public const string NearbySearchAPIRoute = $"{BaseRoute}/nearbysearch/json";

        /// <summary>
        /// The text search route
        /// </summary>
        public const string TextSearchAPIRoute = $"{BaseRoute}/textsearch/json";

        /// <summary>
        /// The place details route
        /// </summary>
        public const string PlaceDetailsAPIRoute = $"{BaseRoute}/details/json";

        /// <summary>
        /// The place photo route
        /// </summary>
        public const string PlacePhotoAPIRoute = $"{BaseRoute}/photo/json";

        /// <summary>
        /// The place autocomplete route
        /// </summary>
        public const string PlaceAutoCompleteAPIRoute = $"{BaseRoute}/autocomplete/json";

        /// <summary>
        /// The query autocomplete route
        /// </summary>
        public const string QueryAutocompleteAPIRoute = $"{BaseRoute}/queryautocomplete/json";
    }
}
