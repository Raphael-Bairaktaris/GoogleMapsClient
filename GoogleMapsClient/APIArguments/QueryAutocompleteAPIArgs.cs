namespace GoogleMapsClient
{
    /// <summary>
    /// Arguments used for receiving a query autocomplete
    /// </summary>
    public class QueryAutocompleteAPIArgs
    {
        #region Public Properties

        /// <summary>
        /// The text string on which to search. The Place Autocomplete service will return candidate
        /// matches based on this string and order results based on their perceived relevance.
        /// </summary>
        [ArgumentName("input")]
        public string Input { get; }

        /// <summary>
        /// The language in which to return results.
        /// </summary>
        [ArgumentName("language")]
        [QueryArgumentConverter<SupportedLanguageQueryArgumentConverter>]
        public SupportedLanguage? Language { get; set; }

        /// <summary>
        /// The point around which to retrieve place information. This must be specified as latitude,longitude.
        /// </summary>
        [ArgumentName("location")]
        [QueryArgumentConverter<CoordinatesQueryArgumentConverter>]
        public Coordinates? Location { get; set; }

        /// <summary>
        /// The position, in the input term, of the last character that the service uses to match predictions.
        /// </summary>
        /// <example>
        /// For example, if the input is Google and the offset is 3, the service will match on Goo. The string 
        /// determined by the offset is matched against the first word in the input term only.
        /// For example, if the input term is Google abc and the offset is 3, the service will attempt to 
        /// match against Goo abc. If no offset is supplied, the service will use the whole term. The offset 
        /// should generally be set to the position of the text caret.
        /// </example>
        [ArgumentName("offset")]
        public uint? Offset { get; set; }

        /// <summary>
        /// Defines the distance (in meters) within which to return place results. You may bias results to a specified circle by passing
        /// a location and a radius parameter. Doing so instructs the Places service to prefer showing results within that circle; 
        /// results outside of the defined area may still be displayed.
        /// </summary>
        [ArgumentName("radius")]
        public double? Radius { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// DefaultConstructor
        /// </summary>
        public QueryAutocompleteAPIArgs(string input)
        {
            Input = input;
        }

        #endregion
    }
}
