namespace GoogleMapsClient
{
    public static class GoogleMapsAPIRoutes
    {
        public const string BaseRoute = "https://maps.googleapis.com/maps/api/place";

        public const string FindPlaceAPIRoute = $"{BaseRoute}/findplacefromtext/json";

        public const string NearbySearchAPIRoute = $"{BaseRoute}/nearbysearch/json";

        public const string TextSearchAPIRoute = $"{BaseRoute}/textsearch/json";

        public const string PlaceDetailsAPIRoute = $"{BaseRoute}/details/json";

        public const string PlacePhotoAPIRoute = $"{BaseRoute}/photo/json";

        public const string PlaceAutoCompleteAPIRoute = $"{BaseRoute}/autocomplete/json";

        public const string QueryAutocompleteAPIRoute = $"{BaseRoute}/queryautocomplete/json";
    }
}
