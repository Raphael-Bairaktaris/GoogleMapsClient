using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GoogleMapsClient
{
    /// <summary>
    /// Attributes describing a place. Not all attributes will be available for all place types.
    /// </summary>
    public class PlaceFindPlaceAttributesResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="AddressComponent"/> property
        /// </summary>
        private IEnumerable<PlaceFindAddressComponentResponseModel>? mAddressComponent;

        /// <summary>
        /// The member of the <see cref="ADRAddress"/> property
        /// </summary>
        private string? mADRAddress;

        /// <summary>
        /// The member of the <see cref="BusinessStatus"/> property
        /// </summary>
        private string? mBusinessStatus;

        /// <summary>
        /// The member of the <see cref="CurrentOpeningHours"/> property
        /// </summary>
        private PlaceFindPlaceOpeningHoursResponseModel? mCurrentOpeningHours;

        /// <summary>
        /// The member of the <see cref="EditorialSummary"/> property
        /// </summary>
        private PlaceFindEditorialSummaryResponseModel? mEditorialSummary;

        /// <summary>
        /// The member of the <see cref="FormattedAddress"/> property
        /// </summary>
        private string? mFormattedAddress;

        /// <summary>
        /// The member of the <see cref="FormattedPhoneNumber"/> property
        /// </summary>
        private string? mFormattedPhoneNumber;

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
        /// The member of the <see cref="InternationalPhoneNumber"/> property
        /// </summary>
        private string? mInternationalPhoneNumber;

        /// <summary>
        /// The member of the <see cref="Name"/> property
        /// </summary>
        private string? mName;

        /// <summary>
        /// The member of the <see cref="OpeningHours"/> property
        /// </summary>
        private PlaceFindPlaceOpeningHoursResponseModel? mOpeningHours;

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
        private IEnumerable<PlaceFindPlaceReviewResponseModel>? mReviews;

        /// <summary>
        /// The member of the <see cref="SecondaryOpeningHours"/> property
        /// </summary>
        private IEnumerable<PlaceFindPlaceOpeningHoursResponseModel>? mSecondaryOpeningHours;

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
        /// An array containing the separate components applicable to this address.
        /// </summary>
        /// <remarks>
        /// https://developers.google.com/maps/documentation/places/web-service/search-find-place#AddressComponent
        /// </remarks>
        [AllowNull]
        [JsonProperty("address_component")]
        public IEnumerable<PlaceFindAddressComponentResponseModel> AddressComponent
        {
            get => mAddressComponent ?? Enumerable.Empty<PlaceFindAddressComponentResponseModel>();
            set => mAddressComponent = value;
        }

        /// <summary>
        /// Represents place address in the adr microformat
        /// </summary>
        /// <remarks>
        /// http://microformats.org/wiki/adr
        /// </remarks>
        [AllowNull]
        [JsonProperty("adr_address")]
        public string ADRAddress
        {
            get => mADRAddress ?? string.Empty;
            set => mADRAddress = value;
        }

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
        /// Specifies if the business supports curbside pickup.
        /// </summary>
        [JsonProperty("curbside_pickup")]
        public bool CurbsidePickup { get; set; }

        /// <summary>
        /// Contains the hours of operation for the next seven days (including today). 
        /// The time period starts at midnight on the date of the request and ends at 
        /// 11:59 pm six days later. This field includes the special_days subfield of 
        /// all hours, set for dates that have exceptional hours.
        /// </summary>
        /// <remarks>
        /// https://developers.google.com/maps/documentation/places/web-service/search-find-place#PlaceOpeningHours
        /// </remarks>
        [JsonProperty("current_opening_hours")]
        public PlaceFindPlaceOpeningHoursResponseModel CurrentOpeningHours 
        { 
            get => mCurrentOpeningHours ??= new PlaceFindPlaceOpeningHoursResponseModel();
            set => mCurrentOpeningHours = value;
        }

        /// <summary>
        /// Specifies if the business supports delivery.
        /// </summary>
        [JsonProperty("delivery")]
        public bool Delivery { get; set; }

        /// <summary>
        /// Specifies if the business supports indoor or outdoor seaing options.
        /// </summary>
        [JsonProperty("dine_in")]
        public bool DineIn { get; set; }

        /// <summary>
        /// Contains a summary of the place. A summary is comprised of a textual overview, 
        /// and also includes the language code for these if applicable. Summary text must 
        /// be presented as-is and can not be modified or altered.
        /// </summary>
        /// <remarks>
        /// https://developers.google.com/maps/documentation/places/web-service/search-find-place#PlaceEditorialSummary
        /// </remarks>
        [AllowNull]
        [JsonProperty("editorial_summary")]
        public PlaceFindEditorialSummaryResponseModel EditorialSummary 
        { 
            get => mEditorialSummary ??= new PlaceFindEditorialSummaryResponseModel();
            set => mEditorialSummary = value;
        }

        /// <summary>
        /// A string containing the human-readable address of this place. 
        /// Often this address is equilevant of the postal address.
        /// </summary>
        [AllowNull]
        [JsonProperty("formatted_address")]
        public string FormattedAddress
        {
            get => mFormattedAddress ?? string.Empty;
            set => mFormattedAddress = value;
        }

        /// <summary>
        /// Contains the place's phone number in it's local format.
        /// </summary>
        ///<remarks>
        /// https://en.wikipedia.org/wiki/National_conventions_for_writing_telephone_numbers
        ///</remarks>
        [AllowNull]
        [JsonProperty("formatted_phone_number")]
        public string FormattedPhoneNumber
        {
            get => mFormattedPhoneNumber ?? string.Empty;
            set => mFormattedPhoneNumber = value;
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
        ///Contains the URL of a suggested icon which may be displayed to the user when
        ///indicating this result on a map.
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
        ///Contains the place's phone number in international format. International format includes
        ///the country code, and is prefixed with the plus, +, sign.
        /// </summary>
        /// <example>
        /// For example, the international_phone_number for Google's Sydney, 
        /// Australia office is +61 2 9374 4000.
        /// </example>
        [AllowNull]
        [JsonProperty("international_phone_number")]
        public string InternationalPhoneNumber
        {
            get => mInternationalPhoneNumber ?? string.Empty;
            set => mInternationalPhoneNumber = value;
        }

        /// <summary>
        /// Contains the human-readable name for the returned result. For establishment results,
        ///this is usually the canonicalized business name
        /// </summary>
        [AllowNull]
        [JsonProperty("name")]
        public string Name
        {
            get => mName ?? string.Empty;
            set => mName = value;
        }

        /// <summary>
        /// Contains the regular hours of operation
        /// </summary>
        /// <remarks>
        /// https://developers.google.com/maps/documentation/places/web-service/search-find-place#PlaceOpeningHours
        /// </remarks>
        [AllowNull]
        [JsonProperty("opening_hours")]
        public PlaceFindPlaceOpeningHoursResponseModel OpeningHours 
        { 
            get => mOpeningHours ??= new PlaceFindPlaceOpeningHoursResponseModel();
            set => mOpeningHours = value;
        }

        /// <summary>
        /// An array of photo objects, each containing a reference to an image. 
        /// A request may return up to ten photos.
        /// </summary>
        /// <remarks>
        /// https://developers.google.com/maps/documentation/places/web-service/search-find-place#PlacePhoto
        /// </remarks>
        [JsonProperty("photo")]
        public object? Photo { get; set; }

        /// <summary>
        /// A textual identifier that uniquely identifies a place. To retrieve information
        /// about the place, pass this identifier in the place_id field of a Places API request.
        /// </summary>
        /// <remarks>
        /// https://developers.google.com/maps/documentation/places/web-service/place-id
        /// </remarks>
        [AllowNull]
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
        [AllowNull]
        [JsonProperty("plus_code")]
        public PlaceFindPlusCodeResponseModel PlusCode 
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
        public uint PriceLevel { get; set; }

        /// <summary>
        /// Contains the place's rating from 1.0 to 5.0 based on user reviews.
        /// </summary>
        [JsonProperty("rating")]
        public uint Rating { get; set; }

        /// <summary>
        /// Specifies if the place supports reservations.
        /// </summary>
        [JsonProperty("reservable")]
        public bool Reservable { get; set; }

        /// <summary>
        /// An array of up to five reviews. By default the reviews are sorted in order of relevance.
        /// </summary>
        ///<remarks>
        /// https://developers.google.com/maps/documentation/places/web-service/search-find-place#PlaceReview
        ///</remarks>
        [AllowNull]
        [JsonProperty("reviews")]
        public IEnumerable<PlaceFindPlaceReviewResponseModel> Reviews 
        {
            get => mReviews ?? Enumerable.Empty<PlaceFindPlaceReviewResponseModel>();
            set => mReviews = value;
        }

        /// <summary>
        /// Contains an array of entries for the next seven days including information
        /// about secondary hours of business. Secondary hours are different from a
        /// business's main hours.
        /// </summary>
        /// <example>
        /// For example, a restaurant can specify drive through hours or delivery hours as its secondary hours. 
        /// </example>
        /// <remarks>
        /// https://developers.google.com/maps/documentation/places/web-service/search-find-place#PlaceOpeningHours
        /// </remarks>
        [JsonProperty("secondary_opening_hours")]
        public IEnumerable<PlaceFindPlaceOpeningHoursResponseModel> SecondaryOpeningHours 
        {
            get => mSecondaryOpeningHours ?? Enumerable.Empty<PlaceFindPlaceOpeningHoursResponseModel>();
            set => mSecondaryOpeningHours = value;
        }

        /// <summary>
        /// Specifies if the place serves beer.
        /// </summary>
        [JsonProperty("serves_beer")]
        public bool ServesBeer { get; set; }

        /// <summary>
        /// Specifies if the place serves breakfast.
        /// </summary>
        [JsonProperty("serves_breakfast")]
        public bool ServesBreakfast { get; set; }

        /// <summary>
        /// Specifies if the place serves brunch.
        /// </summary>
        public bool ServesBrunch { get; set; }

        /// <summary>
        /// Specifies if the place serves dinner.
        /// </summary>
        [JsonProperty("serves_dinner")]
        public bool ServesDinner { get; set; }

        /// <summary>
        ///Specifies if the place serves lunch. 
        /// </summary>
        [JsonProperty("serves_lunch")]
        public bool ServesLunch { get; set; }

        /// <summary>
        /// Specifies if the place serves vegetarian food.
        /// </summary>
        [JsonProperty("serves_vegetarian_food")]
        public bool ServesVegetarianFood { get; set; }

        /// <summary>
        /// Specifies if the place serves wine.
        /// </summary>
        [JsonProperty("serves_wine")]
        public bool ServesWine { get; set; }

        /// <summary>
        /// Specifies if the business supports takeout.
        /// </summary>
        [JsonProperty("takeout")]
        public bool Takeout { get; set; }

        /// <summary>
        /// Contains an array of feature types describing the given result.
        /// </summary>
        /// <remarks>
        /// https://developers.google.com/maps/documentation/places/web-service/supported_types#table2
        /// </remarks>
        [AllowNull]
        [JsonProperty("types")]
        [JsonConverter(typeof(AddressTypeEnumerableToStringJsonConverter))]
        public IEnumerable<AddressType> Types
        {
            get => mTypes ?? Enumerable.Empty<AddressType>();
            set => mTypes = value;
        }

        /// <summary>
        /// Contains the URL of the official Google page for this place. This will be the Google-owned page
        /// that contains the best available information about the place. Applications must link to or embed 
        /// this page on any screen that shows detailed results about the place to the user.
        /// </summary>
        [JsonProperty("url")]
        public Uri? Url { get; set; }

        /// <summary>
        /// The total numver  of reviews, with or without text, for this place.
        /// </summary>
        [JsonProperty("user_rating_total")]
        public uint UserRatingTotal { get; set; }

        /// <summary>
        /// Contains the number of minutes this place’s current timezone is offset from UTC.
        /// </summary>
        /// <example>
        /// For example, for places in Sydney, Australia during daylight saving time this would 
        /// be 660 (+11 hours from UTC), and for places in California outside of daylight saving 
        /// time this would be -480 (-8 hours from UTC).
        /// </example>
        [JsonProperty("utc_offset")]
        public int UTCOffset { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [AllowNull]
        [JsonProperty("vicinity")]
        public string Vicinity
        {
            get => mVicinity ?? string.Empty;
            set => mVicinity = value;
        }

        /// <summary>
        /// The authoriative website for this [;ace, such ass a business's homepage.
        /// </summary>
        [JsonProperty("website")]
        public Uri? Website { get; set; }

        /// <summary>
        /// Specifies if the place has an entrance that is wheelchair accessible
        /// </summary>
        [JsonProperty("wheelchair_accessible_entrance")]
        public bool WheelchairAccessibleEntrance { get; set; }
        
        #endregion

        #region Constructors

        /// <summary>
        /// Default Constructor
        /// </summary>
        public PlaceFindPlaceAttributesResponseModel()
        {
            
        }

        #endregion
    }
}
