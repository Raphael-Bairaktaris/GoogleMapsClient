using Newtonsoft.Json;
using System.Diagnostics.CodeAnalysis;

namespace GoogleMapsClient
{
    /// <summary>
    /// Attributes describing a place. Not all attributes will be available for all place types.
    /// </summary>
    public class PlaceFindNearbySearchAttributesResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="BusinessStatus"/> property
        /// </summary>
        private string? mBusinessStatus;

        /// <summary>
        /// The member of the <see cref="Geometry"/> property
        /// </summary>
        private PlaceFindGeomertryResponseModel? mGeometry;

        /// <summary>
        /// The member of the <see cref="Icon"/> property
        /// </summary>
        private string? mIcon;

        /// <summary>
        /// The member of the <see cref="IconBackgroundColor"/> property
        /// </summary>
        private string? mIconBackgroundColor;

        /// <summary>
        /// The member of the <see cref="Name"/> property
        /// </summary>
        private string? mName;

        /// <summary>
        /// The member of the <see cref="PlaceId"/> property
        /// </summary>
        private string? mPlaceId;

        /// <summary>
        /// The member of the <see cref="PlusCode"/> property
        /// </summary>
        private PlaceFindPlusCodeResponseModel? mPlusCode;

        /// <summary>
        /// The member of the <see cref="Reviews"/> property
        /// </summary>
        private IEnumerable<PlaceFindReviewResponseModel>? mReviews;

        /// <summary>
        /// The member of the <see cref="Vicinity"/> property
        /// </summary>
        private string? mVicinity;

        /// <summary>
        /// The member of the <see cref="Types"/> property
        /// </summary>
        private IEnumerable<AddressType>? mTypes;

        #endregion

        #region Public Property

        /// <summary>
        /// Indicates the operational status of the place, 
        /// if it is a business. If no data exists, business_status is not returned.
        ///The allowed values include: OPERATIONAL, CLOSED_TEMPORARILY, and CLOSED_PERMANENTLY
        /// </summary>
        [AllowNull]
        [JsonProperty("business_status")]
        public string BusinessStatus
        {
            get => mBusinessStatus ?? string.Empty;
            set => mBusinessStatus = value;
        }

        /// <summary>
        /// Contains the location and viewport for the location
        /// </summary>
        /// <remarks>
        /// https://developers.google.com/maps/documentation/places/web-service/search-find-place#Geometry
        /// </remarks>
        [AllowNull]
        [JsonProperty("geometry")]
        public PlaceFindGeomertryResponseModel Geometry
        {
            get => mGeometry ??= new PlaceFindGeomertryResponseModel();
            set => mGeometry = value;
        }

        /// <summary>
        /// Contains the URL of a suggested icon which may be displayed to the user when
        /// indicating this result on a map.
        /// </summary>
        [AllowNull]
        [JsonProperty("icon")]
        public string Icon
        {
            get => mIcon ?? string.Empty;
            set => mIcon = value;
        }

        /// <summary>
        /// Contains the default HEX color colde for the place's category.
        /// </summary>
        [AllowNull]
        [JsonProperty("icon_background_color")]
        public string IconBackgroundColor
        {
            get => mIconBackgroundColor ?? string.Empty;
            set => mIconBackgroundColor = value;
        }

        /// <summary>
        /// Contains the URL of a recommended icon, minus the .svg or .png file type extension.
        /// </summary>
        [JsonProperty("icon_mask_base_uri")]
        public Uri? IconMaskBaseUri { get; set; }

        /// <summary>
        /// Contains the human-readable name for the returned result. For establishment results,
        /// this is usually the canonicalized business name
        /// </summary>
        [AllowNull]
        [JsonProperty("name")]
        public string Name
        {
            get => mName ?? string.Empty;
            set => mName = value;
        }

        /// <summary>
        /// Indicates if the shop is open now.
        /// </summary>
        [JsonProperty("open_now")]
        public PlaceFindPlaceOpeningHoursResponseModel? OpenNow { get; set; }

        /// <summary>
        /// An array of photo objects, each containing a reference to an image. 
        /// A request may return up to ten photos.
        /// </summary>
        /// <remarks>
        /// https://developers.google.com/maps/documentation/places/web-service/search-find-place#PlacePhoto
        /// </remarks>
        [JsonProperty("photo")]
        public PlacePhotoResponseModel? Photo { get; set; }

        /// <summary>
        /// A textual identifier that uniquely identifies a place. To retrieve information
        /// about the place, pass this identifier in the place_id field of a Places API request.
        /// </summary>
        /// <remarks>
        /// https://developers.google.com/maps/documentation/places/web-service/place-id
        /// </remarks>
        [JsonProperty("place_id")]
        public string PlaceId
        {
            get => mPlaceId ?? string.Empty;
            set => mPlaceId = value;
        }

        /// <summary>
        /// An encoded location reference, derived from latitude and longitude coordinates, 
        /// that represents an area: 1/8000th of a degree by 1/8000th of a degree 
        /// (about 14m x 14m at the equator) or smaller. Plus codes can be used as a replacement 
        /// for street addresses in places where they do not exist (where buildings are not numbered 
        /// or streets are not named)
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/Open_Location_Code
        /// https://developers.google.com/maps/documentation/places/web-service/search-find-place#PlusCode
        /// </remarks>
        [JsonProperty("plus_code")]
        public PlaceFindPlusCodeResponseModel? PlusCode
        {
            get => mPlusCode ??= new PlaceFindPlusCodeResponseModel();
            set => mPlusCode = value;
        }

        /// <summary>
        /// The price level of the place, on a scale of 0 to 4. The exact amount indicated by a specific value 
        /// will vary from region to region. Price levels are interpreted as follows:
        /// <list type="bullet|number|table">
        /// <item>
        ///     <descriptionm>Free</descriptionm>    
        /// </item>
        /// <item>
        ///     <description>Inexpensive</description>
        /// </item>
        /// <item>
        ///     <description>Expensive</description>
        /// </item>
        /// <item>
        ///     <description>Very expensive</description>
        /// </item>
        /// </list>
        /// </summary>
        [JsonProperty("price_level")]
        public PriceRangeType? PriceLevel { get; set; }

        /// <summary>
        /// Contains the place's rating from 1.0 to 5.0 based on user reviews.
        /// </summary>
        [JsonProperty("rating")]
        public double? Rating { get; set; }

        /// <summary>
        /// Specifies if the place supports reservations.
        /// </summary>
        [JsonProperty("reservable")]
        public bool? Reservable { get; set; }

        /// <summary>
        /// An array of up to five reviews. By default the reviews are sorted in order of relevance.
        /// </summary>
        ///<remarks>
        /// https://developers.google.com/maps/documentation/places/web-service/search-find-place#PlaceReview
        ///</remarks>
        [AllowNull]
        [JsonProperty("reviews")]
        public IEnumerable<PlaceFindReviewResponseModel> Reviews
        {
            get => mReviews ?? Enumerable.Empty<PlaceFindReviewResponseModel>();
            set => mReviews = value;
        }

        /// <summary>
        /// Contains an array of feature types describing the given result.
        /// </summary>
        /// <remarks>
        /// https://developers.google.com/maps/documentation/places/web-service/supported_types#table2
        /// </remarks>
        [JsonProperty("types")]
        [JsonConverter(typeof(AddressTypeEnumerableToStringJsonConverter))]
        public IEnumerable<AddressType>? Types
        {
            get => mTypes ?? Enumerable.Empty<AddressType>();
            set => mTypes = value;
        }

        /// <summary>
        /// For establishment (types:["establishment", ...]) results only, the vicinity field contains a 
        /// simplified address for the place, including the street name, street number, and locality, 
        /// but not the province/state, postal code, or country
        /// </summary>
        [JsonProperty("vicinity")]
        public string? Vicinity
        {
            get => mVicinity ?? string.Empty;
            set => mVicinity = value;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default Constructor
        /// </summary>
        public PlaceFindNearbySearchAttributesResponseModel()
        {

        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        //public override string ToString() =>;

        #endregion
    }
}
