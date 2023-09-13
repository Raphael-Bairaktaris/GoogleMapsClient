using Newtonsoft.Json;
using System.Diagnostics.CodeAnalysis;

namespace GoogleMapsClient
{
    /// <summary>
    /// Represents a place autocomple prediction response
    /// </summary>
    public class PlaceAutocompletePredictionResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="Description"/> property
        /// </summary>
        private string? mDescription;

        /// <summary>
        /// The member of the <see cref="Terms"/> property
        /// </summary>
        private IEnumerable<PlaceAutocompleteTermReponseModel>? mTerms;

        #endregion

        #region Public Properties

        /// <summary>
        /// Contains the human-readable name for the returned result. For establishment results, this is usually 
        /// the business name. This content is meant to be read as-is. Do not programmatically parse the formatted 
        /// address.
        /// </summary>
        [AllowNull]
        [JsonProperty("description")]
        public string Description
        {
            get => mDescription ?? string.Empty;

            set => mDescription = value;    
        }

        /// <summary>
        /// Contains an array of terms identifying each section of the returned description (a section of the description is 
        /// generally terminated with a comma). Each entry in the array has a value field, containing the text of the term, 
        /// and an offset field, defining the start position of this term in the description, measured in Unicode characters.
        /// </summary>
        [AllowNull]
        [JsonProperty("terms")]
        public IEnumerable<PlaceAutocompleteTermReponseModel> Terms
        {
            get => mTerms ?? Enumerable.Empty<PlaceAutocompleteTermReponseModel>();

            set => mTerms = value;
        }

        /// <summary>
        /// The straight-line distance in meters from the origin. This field is only returned for requests made with an origin.
        /// </summary>
        [JsonProperty("distance_meters")]
        public int? DistanceMeters { get; set; }

        /// <summary>
        /// A textual identifier that uniquely identifies a place. To retrieve information about the place, pass this identifier 
        /// in the placeId field of a Places API request.
        /// </summary>
        /// <remarks>
        /// See https://developers.google.com/maps/documentation/places/web-service/place-id.
        /// </remarks>
        [JsonProperty("place_id")]
        public string? PlaceId { get; set; }
        /*
       /// <summary>
       /// Contains an array of types that apply to this place.
       /// </summary>
       /// <remarks>
       /// See https://developers.google.com/maps/documentation/places/web-service/supported_types
       /// </remarks>
       [AllowNull]
       [JsonProperty("types")]
       public string Types 
       {
           get; 

           set; 
       }
        */
        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public PlaceAutocompletePredictionResponseModel()
        {
        }

        #endregion

        #region Public Methods

        #endregion
    }
}