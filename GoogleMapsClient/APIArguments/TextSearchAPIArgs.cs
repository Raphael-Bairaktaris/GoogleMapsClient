using GoogleMapsClient.DataModels.Enums;

namespace GoogleMapsClient
{
    /// <summary>
    /// Arguements used for receiving a search result from text
    /// </summary>
    public class TextSearchAPIArgs
    {
        #region Public Properties

        /// <summary>
        /// The text string on which to search. This must a place name, address, or category of establishments.
        /// Any other types of input can generate errors and are not guaranteed to return valid results. The Google Places service will
        /// return candidate matches based on this string and order the results based on their perceived relevance.
        /// </summary>
        /// <example>For example: "restaurant" or "123 Main Street".</example>
        [ArgumentName("query")]
        public string? Query { get; set; }

        /// <summary>
        /// Defines the distance (in meters) within which to return place results. You may bias results to a specified circle
        /// by passing a location and a radius parameter. Doing so instructs the Places service to prefer showing results within
        /// that circle; results outside of the defined area may still be displayed.
        /// </summary>
        [ArgumentName("radius")]
        public double? Radius { get; set; }

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
        /// Restricts results to only those places within the specified range. Valid values range between 0 (most affordable)
        /// to 4 (most expensive), inclusive. The exact amount indicated by a specific value will vary from region to region.
        /// </summary>
        [ArgumentName("maxprice")]
        [QueryArgumentConverter<PriceRangeTypeQueryArgumentConverter>]
        public PriceRangeType? MaxPrice { get; set; }

        /// <summary>
        /// Restricts results to only those places within the specified range. Valid values range between 0 (most affordable) 
        /// to 4 (most expensive), inclusive. The exact amount indicated by a specific value will vary from region to region.
        /// </summary>
        [ArgumentName("minprice")]
        [QueryArgumentConverter<PriceRangeTypeQueryArgumentConverter>]
        public PriceRangeType? MinPrice { get; set; }

        /// <summary>
        /// Returns only those places that are open for business at the time the query is sent. Places that do not specify
        /// opening hours in the Google Places database will not be returned if you include this parameter in your query.
        /// </summary>
        [ArgumentName("opennow")]
        public bool? IsOpenNow { get; set; }

        /// <summary>
        /// Returns up to 20 results from a previously run search. Setting a pagetoken parameter will execute a search 
        /// with the same parameters used previously — all parameters other than pagetoken will be ignored.
        /// </summary>
        [ArgumentName("pagetoken")]
        public string? PageToken { get; set; }

        /// <summary>
        /// Restricts the results to places matching the specified type. Only one type may be specified. 
        /// If more than one type is provided, all types following the first entry are ignored.
        /// </summary>
        [ArgumentName("type")]
        [QueryArgumentConverter<PlaceTypeQueryArgumentConverter>]
        public PlaceType? Type { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default contructor
        /// </summary>
        public TextSearchAPIArgs()
        {

        }

        #endregion
    }
}
