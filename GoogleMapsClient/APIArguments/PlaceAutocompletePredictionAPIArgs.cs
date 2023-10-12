namespace GoogleMapsClient
{
    /// <summary>
    /// Arguments used for retrieving place auto-complete predictions
    /// </summary>
    public class PlaceAutocompletePredictionAPIArgs
    {
        #region Public Properties

        /// <summary>
        /// The text string on which to search. The Place Autocomplete service will return candidate 
        /// matches based on this string and order results based on their perceived relevance.
        /// </summary>
        public string Input { get; set; }

        /// <summary>
        /// Defines the distance (in meters) within which to return place results. You may bias results
        /// to a specified circle by passing a location and a radius parameter. Doing so instructs the 
        /// Places service to prefer showing results within that circle; results outside of the defined area may still be displayed.
        /// </summary>
        public uint? Radius { get; set; }

        /// <summary>
        /// A grouping of places to which you would like to restrict your results. Currently, you can use
        /// components to filter by up to 5 countries. Countries must be passed as a two character, ISO 3166-1 Alpha-2 
        /// compatible country code. For example: components=country:fr would restrict your results to places within France. 
        /// Multiple countries must be passed as multiple country:XX filters, with the pipe character | as a separator. 
        /// </summary>
        /// <example>
        /// For example: components=country:us|country:pr|country:vi|country:gu|country:mp would restrict your results to 
        /// places within the United States and its unincorporated organized territories.
        /// </example>
        public string? Components { get; set; }

        /// <summary>
        /// The language in which to return results.
        /// </summary>
        /// <remarks>
        /// https://developers.google.com/maps/faq#languagesupport
        /// </remarks>
        public SupportedLanguage? Language { get; set; }

        /// <summary>
        /// The position, in the input term, of the last character that the service uses to match predictions. 
        /// </summary>
        /// <example>
        /// For example, if the input is Google and the offset is 3, the service will match on Goo. The string 
        /// determined by the offset is matched against the first word in the input term only. 
        /// For example, if the input term is Google abc and the offset is 3, the service will attempt to match against Goo abc. 
        /// If no offset is supplied, the service will use the whole term. The offset should generally be set to the position of the text caret.
        /// </example>
        public uint? Offset { get; set; }

        /// <summary>
        /// The origin point from which to calculate straight-line distance to the destination (returned as distance_meters). 
        /// If this value is omitted, straight-line distance will not be returned. Must be specified as latitude,longitude.
        /// </summary>
        public string? Origin { get; set; }

        /// <summary>
        /// The region code, specified as a ccTLD ("top-level domain") two-character value. 
        /// Most ccTLD codes are identical to ISO 3166-1 codes, with some notable exceptions.
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/List_of_Internet_top-level_domains#Country_code_top-level_domains
        /// </remarks>
        public string? Region { get; set; }

        /// <summary>
        /// A random string which identifies an autocomplete session for billing purposes.
        /// </summary>
        /// <remarks>
        /// https://developers.google.com/maps/documentation/places/web-service/details#session_tokens
        /// </remarks>
        public string? SessionToken { get; set; }

        /// <summary>
        /// Returns only those places that are strictly within the region defined by location and radius. 
        /// This is a restriction, rather than a bias, meaning that results outside this region will not be returned 
        /// even if they match the user input.
        /// </summary>
        public bool? StrictBounds { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public PlaceAutocompletePredictionAPIArgs()
        {
                
        }

        #endregion
    }
}
