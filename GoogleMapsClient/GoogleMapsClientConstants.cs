using System.Collections.Immutable;

namespace Simple.GoogleMaps
{
    /// <summary>
    /// Constants related to the Google maps client
    /// </summary>
    public static class GoogleMapsClientConstants
    {

        /// <summary>
        /// Maps the <see cref="AddressType"/>s to their related <see cref="string"/>s
        /// </summary>
        public static IReadOnlyDictionary<AddressType, string> AddressTypeToStringMapper { get; } = new Dictionary<AddressType, string>()
        {
            { AddressType.AdminstrativeAreaLevel1, "adminstrative_area_level_1" },
            { AddressType.AdminstrativeAreaLevel2, "adminstrative_area_level_2" },
            { AddressType.AdminstrativeAreaLevel3, "adminstrative_area_level_3" },
            { AddressType.AdminstrativeAreaLevel4, "adminstrative_area_level_4" },
            { AddressType.AdminstrativeAreaLevel5, "adminstrative_area_level_5" },
            { AddressType.AdminstrativeAreaLevel6, "adminstrative_area_level_6" },
            { AddressType.AdminstrativeAreaLevel7, "adminstrative_area_level_7" },
            { AddressType.Archipelago, "archipelago" },
            { AddressType.ColloquialArea, "colloquial_area" },
            { AddressType.Continent, "continent" },
            { AddressType.Country, "country" },
            { AddressType.Establishment, "establishment" },
            { AddressType.Finance, "finance" },
            { AddressType.Floor, "floor" },
            { AddressType.Food, "food" },
            { AddressType.GeneralContractor, "general_contructor" },
            { AddressType.Geocode, "geocode" },
            { AddressType.Health, "health" },
            { AddressType.Intersection, "intersection" },
            { AddressType.Landmark, "landmark" },
            { AddressType.Locality, "locality" },
            { AddressType.NaturalFeature, "natural_feature" },
            { AddressType.Neighbourhood, "neighbourhood" },
            { AddressType.PlaceOfWorship, "place_of_worship" },
            { AddressType.PlusCode, "plus_code" },
            { AddressType.PointOfInterset, "point_of_interest" },
            { AddressType.Political, "political" },
            { AddressType.PostBox, "post_box" },
            { AddressType.PostalCode, "postal_code" },
            { AddressType.PostalCodePrefix, "postal_code_prefix" },
            { AddressType.PostalCodeSuffix, "postal_code_suffix" },
            { AddressType.PostalTown, "postal_town" },
            { AddressType.Premise, "premise" },
            { AddressType.Room, "room" },
            { AddressType.Route, "route" },
            { AddressType.StreetAddress, "street_address" },
            { AddressType.StreetNumber, "street_number" },
            { AddressType.Sublocality, "sublocality" },
            { AddressType.SublocalityLevel1, "sublocality_level_1" },
            { AddressType.SublocalityLevel2, "sublocality_level_2" },
            { AddressType.SublocalityLevel3, "sublocality_level_3" },
            { AddressType.SublocalityLevel4, "sublocality_level_4" },
            { AddressType.SublocalityLevel5, "sublocality_level_5" },
            { AddressType.Subpremise, "subpremise" },
            { AddressType.TownSquare, "town_square" }
        }.ToImmutableDictionary();

        /// <summary>
        /// Maps the <see cref="AtmosphereCategoryType"/>s to their related <see cref="string"/>s
        /// </summary>
        public static IReadOnlyDictionary<AtmosphereCategoryType, string> AtmosphereCategoryTypeToStringMapper { get; } = new Dictionary<AtmosphereCategoryType, string>()
        {
            { AtmosphereCategoryType.CurbsidePickup, "curbside_pickup" },
            { AtmosphereCategoryType.Delivery, "delivery" },
            { AtmosphereCategoryType.DineIn, "dine_in" },
            { AtmosphereCategoryType.EditorialSummary, "editorial_summary" },
            { AtmosphereCategoryType.PriceLevel, "price_level" },
            { AtmosphereCategoryType.Rating, "rating" },
            { AtmosphereCategoryType.Reservable, "reservable" },
            { AtmosphereCategoryType.Reviews, "reviews" },
            { AtmosphereCategoryType.ServesBeer, "serves_beer" },
            { AtmosphereCategoryType.ServesBreakfast, "serves_breakfast" },
            { AtmosphereCategoryType.ServesBrunch, "serves_brunch" },
            { AtmosphereCategoryType.ServesDinner, "serves_dinner" },
            { AtmosphereCategoryType.ServesLunch, "serves_lunch" },
            { AtmosphereCategoryType.ServesVegetarianFood, "serves_vegetarian_food" },
            { AtmosphereCategoryType.ServesWine, "serves_wine" },
            { AtmosphereCategoryType.Takeout, "takeout" },
            { AtmosphereCategoryType.UserRatingsTotal, "user_ratings_total" }
        }.ToImmutableDictionary();

        /// <summary>
        /// Maps the <see cref="BasicCategoryType"/>s to their related <see cref="string"/>s
        /// </summary>
        public static IReadOnlyDictionary<BasicCategoryType, string> BasicCategoryTypeToStringMapper { get; } = new Dictionary<BasicCategoryType, string>()
        {
            { BasicCategoryType.AddressComponents, "address_components" },
            { BasicCategoryType.ADRAddress, "adr_address" },
            { BasicCategoryType.BusinessStatus, "business_status" },
            { BasicCategoryType.FormattedAddress, "formatted_address" },
            { BasicCategoryType.Geometry, "geometry" },
            { BasicCategoryType.Icon, "icon" },
            { BasicCategoryType.IconMaskBaseUri, "icon_mask_base_uri" },
            { BasicCategoryType.IconBackgroudColor, "icon_background_color" },
            { BasicCategoryType.Name, "name" },
            { BasicCategoryType.Photo, "photo" },
            { BasicCategoryType.PlaceId, "place_id" },
            { BasicCategoryType.PlusCode, "plus_code" },
            { BasicCategoryType.Type, "type" },
            { BasicCategoryType.Url, "url" },
            { BasicCategoryType.UtcOffset, "utf_offset" },
            { BasicCategoryType.Vicinity, "vicinity" },
            { BasicCategoryType.WheelchairAccessibleEntrance, "wheelchair_accessible_entrance" }
        }.ToImmutableDictionary();

        /// <summary>
        /// Maps the <see cref="CollectionType"/>s to their related <see cref="string"/>s
        /// </summary>
        public static IReadOnlyDictionary<CollectionType, string> CollectionTypeToStringMapper { get; } = new Dictionary<CollectionType, string>()
        {
            { CollectionType.Geocode, "geocode" },
            { CollectionType.Address, "address" },
            { CollectionType.Establishment, "establishment" },
            { CollectionType.Regions, "regions" },
            { CollectionType.Cities, "cities" }
        }.ToImmutableDictionary();

        /// <summary>
        /// Maps the <see cref="ContactCategoryType"/>s to their related <see cref="string"/>s
        /// </summary>
        public static IReadOnlyDictionary<ContactCategoryType, string> ContactCategoryTypeToStringMapper { get; } = new Dictionary<ContactCategoryType, string>()
        {
            { ContactCategoryType.CurrentOpeningHours, "current_opening_hours"},
            { ContactCategoryType.FormattedPhoneNumber, "formatted_phone_number" },
            { ContactCategoryType.InternationalPhoneNumber, "international_phone_number" },
            { ContactCategoryType.OpeningHours, "opening_hours" },
            { ContactCategoryType.SecondaryOpeningHours, "secondary_opening_hours" },
            { ContactCategoryType.Website, "website" }
        }.ToImmutableDictionary();

        /// <summary>
        /// Maps the <see cref="PlaceOpeningHoursType"/>s to their related <see cref="string"/>s
        /// </summary>
        public static IReadOnlyDictionary<PlaceOpeningHoursType, string> PlaceOpeningHoursTypeToStringMapper { get; } = new Dictionary<PlaceOpeningHoursType, string>()
        {
            { PlaceOpeningHoursType.DriveThrough, "drive_through" },
            { PlaceOpeningHoursType.HappyHour, "happy_hour" },
            { PlaceOpeningHoursType.Delivery, "delivery" },
            { PlaceOpeningHoursType.Takeout, "takeout" },
            { PlaceOpeningHoursType.Kitchen, "kitchen" },
            { PlaceOpeningHoursType.Breakfast, "breakfast" },
            { PlaceOpeningHoursType.Lunch, "lunch" },
            { PlaceOpeningHoursType.Dinner, "dinner" },
            { PlaceOpeningHoursType.Brunch, "brunch" },
            { PlaceOpeningHoursType.Pickup, "pickup" },
            { PlaceOpeningHoursType.SeniorHours, "senior_hours" }
        }.ToImmutableDictionary();

        /// <summary>
        /// Maps the <see cref="PlaceType"/>s to their related <see cref="string"/>s
        /// </summary>
        public static IReadOnlyDictionary<PlaceType, string> PlaceTypeToStringMapper { get; } = new Dictionary<PlaceType, string>()
        {
            { PlaceType.Accounting, "accounting" },
            { PlaceType.Airport, "airport" },
            { PlaceType.AmusementPark, "amusement_park" },
            { PlaceType.Aquarium, "aquarium" },
            { PlaceType.ArtGallery, "art_gallery" },
            { PlaceType.Atm, "atm" },
            { PlaceType.Bakery, "bakery" },
            { PlaceType.Bank, "bank" },
            { PlaceType.Bar, "bar" },
            { PlaceType.BeautySalon, "beauty_salon" },
            { PlaceType.BicycleStore, "bicycle_store" },
            { PlaceType.BookStore, "book_store" },
            { PlaceType.BowlingAlley, "bowling_alley" },
            { PlaceType.BusStation, "bus_station" },
            { PlaceType.Cafe, "cafe" },
            { PlaceType.CampGround, "campground" },
            { PlaceType.CarDealer, "car_dealer" },
            { PlaceType.CarRental, "car_rental" },
            { PlaceType.CarRepair, "car_repair" },
            { PlaceType.CarWash, "car_wash" },
            { PlaceType.Casino, "casino" },
            { PlaceType.Cemetery, "cemetery" },
            { PlaceType.Church, "church" },
            { PlaceType.CityHall, "city_hall" },
            { PlaceType.ClothingStore, "clothing_store" },
            { PlaceType.ConvenienceStore, "convenience_store" },
            { PlaceType.Courthouse, "courthouse" },
            { PlaceType.Dentist, "dentist" },
            { PlaceType.DepartmentStore, "department_store" },
            { PlaceType.Doctor, "doctor" },
            { PlaceType.DrugStore, "drugstore" },
            { PlaceType.Electrician, "electrician" },
            { PlaceType.ElectronicsStore, "electronics_store" },
            { PlaceType.Embassy, "embassy" },
            { PlaceType.FireStation, "fire_station" },
            { PlaceType.Florist, "florist" },
            { PlaceType.FuneralHome, "funeral_home" },
            { PlaceType.FurnitureStore, "furniture_store" },
            { PlaceType.GasStation, "gas_station" },
            { PlaceType.Gym, "gym" },
            { PlaceType.HairCare, "hair_care" },
            { PlaceType.HardwareStore, "hardware_store" },
            { PlaceType.HinduTemple, "hindu_temple" },
            { PlaceType.HomeGoodsStore, "home_goods_store" },
            { PlaceType.Hospital, "hospital" },
            { PlaceType.InsuranceAgency, "insurance_agency" },
            { PlaceType.JewelryStore, "jewelry_store" },
            { PlaceType.Laundry, "laundry" },
            { PlaceType.Lawyer, "lawyer" },
            { PlaceType.Library, "library" },
            { PlaceType.LightRailStation, "light_rail_station" },
            { PlaceType.LiquorStore, "liquor_store" },
            { PlaceType.LocalGovernmentOffice, "local_government_office" },
            { PlaceType.Locksmith, "locksmith" },
            { PlaceType.Lodging, "lodging" },
            { PlaceType.MealDelivery, "meal_delivery" },
            { PlaceType.MealTakeaway, "meal_takeaway" },
            { PlaceType.Mosque, "mosque" },
            { PlaceType.MovieRental, "movie_rental" },
            { PlaceType.MovieTheater, "movie_theater" },
            { PlaceType.MovingCompany, "moving_company" },
            { PlaceType.Museum, "museum" },
            { PlaceType.NightClub, "night_club" },
            { PlaceType.Painter, "painter" },
            { PlaceType.Park, "park" },
            { PlaceType.Parking, "parking" },
            { PlaceType.PetStore, "pet_store" },
            { PlaceType.Pharmacy, "pharmacy" },
            { PlaceType.Physiotherapist, "physiotherapist" },
            { PlaceType.Plumber, "plumber" },
            { PlaceType.Police, "police" },
            { PlaceType.PostOffice, "post_office" },
            { PlaceType.PrimarySchool, "primary_school" },
            { PlaceType.RealEstateAgency, "real_estate_agency" },
            { PlaceType.Restaurant, "restaurant" },
            { PlaceType.RoofingContractor, "roofing_contractor" },
            { PlaceType.RvPark, "rv_park" },
            { PlaceType.School, "school" },
            { PlaceType.SecondarySchool, "secondary_school" },
            { PlaceType.ShoeStore, "shoe_store" },
            { PlaceType.ShoppingMall, "shopping_mall" },
            { PlaceType.Spa, "spa" },
            { PlaceType.Stadium, "stadium" },
            { PlaceType.Storage, "storage" },
            { PlaceType.Store, "store" },
            { PlaceType.SubwayStation, "subway_station" },
            { PlaceType.Supermarket, "supermarket" },
            { PlaceType.Synagogue, "synagogue" },
            { PlaceType.TaxiStand, "taxi_stand" },
            { PlaceType.TouristAttraction, "tourist_attraction" },
            { PlaceType.TrainStation, "train_station" },
            { PlaceType.TransitStation, "transit_station" },
            { PlaceType.TravelAgency, "travel_agency" },
            { PlaceType.University, "university" },
            { PlaceType.VeterinaryCare, "veterinary_care" },
            { PlaceType.Zoo, "zoo" },
        }.ToImmutableDictionary();

        /// <summary>
        /// Maps the <see cref="StatusCodeType"/>s to their related <see cref="string"/>s
        /// </summary>
        public static IReadOnlyDictionary<StatusCodeType, string> StatusCodeTypeToStringMapper { get; } = new Dictionary<StatusCodeType, string>()
        {
            { StatusCodeType.OK, "OK" },
            { StatusCodeType.ZeroResults, "ZERO_RESULTS" },
            { StatusCodeType.InvalidRequest, "INVALID_REQUEST" },
            { StatusCodeType.OverQueryLimit, "OVER_QUERY_LIMIT" },
            { StatusCodeType.RequestDenied, "REQUEST_DENIED" },
            { StatusCodeType.UnknownError, "UNKNOWN_ERROR" },
        }.ToImmutableDictionary();

        /// <summary>
        /// Maps the <see cref="ReviewSortingType"/>s to their related <see cref="string"/>s
        /// </summary>
        public static IReadOnlyDictionary<ReviewSortingType, string> ReviewSortingTypeToStringMapper { get; } = new Dictionary<ReviewSortingType, string>()
        {
            { ReviewSortingType.MostRelevant, "Most_Relevant" },
            { ReviewSortingType.Newest, "Newest" },
            { ReviewSortingType.HighestRating, "Highest_Rating" },
            { ReviewSortingType.LowestRating, "Lowest_Rating" }
        }.ToImmutableDictionary();

        /// <summary>
        /// Maps the <see cref="PriceRangeType"/>s to their related <see cref="string"/>s
        /// </summary>
        public static IReadOnlyDictionary<PriceRangeType, string> PriceRangeTypeToStringMapper { get; } = new Dictionary<PriceRangeType, string>()
        {
            { PriceRangeType.Free, "Free" },
            { PriceRangeType.Inexpensive, "Inexpensive" },
            { PriceRangeType.ModeratelyExpensive, "ModeratelyExpensive" },
            { PriceRangeType.Expensive , "Expensive" },
            { PriceRangeType.VeryExpensive , "Very_Expensive" }
        }.ToImmutableDictionary();

        /// <summary>
        /// Maps the <see cref="RankByType"/>s to their related <see cref="string"/>
        /// </summary>
        public static IReadOnlyDictionary<RankByType, string> RankByTypeToStringMapper { get; } = new Dictionary<RankByType, string>()
        {
            { RankByType.Prominence, "prominence" },
            { RankByType.Distance, "distance" }
        }.ToImmutableDictionary();

        /// <summary>
        /// Maps the <see cref="RatingType"/>s to their related <see cref="int"/>s
        /// </summary>
        public static IReadOnlyDictionary<RatingType, int> RatingTypeToIntMapper { get; } = new Dictionary<RatingType, int>()
        {
            { RatingType.Poor, 1 },
            { RatingType.Unsatisfactory, 2 },
            { RatingType.Satisfactory, 3 },
            { RatingType.VerySatisfactory, 4},
            { RatingType.Outstanding, 5 }

        }.ToImmutableDictionary();

        /// <summary>
        /// Maps the <see cref="SupportedLanguage"/>s to their related <see cref="string"/>s
        /// </summary>
        public static IReadOnlyDictionary<SupportedLanguage, string> SupportedLanguageToStringMapper { get; } = new Dictionary<SupportedLanguage, string>()
        {
            { SupportedLanguage.AF, "afrikaans" },
            { SupportedLanguage.SQ, "albanian" },
            { SupportedLanguage.AM, "amharic" },
            { SupportedLanguage.AR, "arabic" },
            { SupportedLanguage.HY, "armenian" },
            { SupportedLanguage.AZ, "azerbaijani" },
            { SupportedLanguage.EU, "basque" },
            { SupportedLanguage.BE, "belarusian" },
            { SupportedLanguage.BN, "bengali" },
            { SupportedLanguage.BS, "bosnian" },
            { SupportedLanguage.BG, "bulgarian" },
            { SupportedLanguage.MY, "burmese" },
            { SupportedLanguage.CA, "catalan" },
            { SupportedLanguage.ZH, "chinese" },
            { SupportedLanguage.ZHCN, "chinese_simplified" },
            { SupportedLanguage.ZHHK, "chinese_hong_kong" },
            { SupportedLanguage.ZHTW, "chinese_traditional" },
            { SupportedLanguage.HR, "croatian" },
            { SupportedLanguage.CS, "czech" },
            { SupportedLanguage.DA, "danish" },
            { SupportedLanguage.NL, "dutch" },
            { SupportedLanguage.EN, "en-us" },
            { SupportedLanguage.ENAU, "en-au" },
            { SupportedLanguage.ENGB, "en-gb" },
            { SupportedLanguage.ET, "estonian" },
            { SupportedLanguage.FA, "farsi" },
            { SupportedLanguage.FI, "finnish" },
            { SupportedLanguage.FIL, "filipino" },
            { SupportedLanguage.FR, "french" },
            { SupportedLanguage.FRCA, "french_canada" },
            { SupportedLanguage.GL, "galician" },
            { SupportedLanguage.KA, "georgian" },
            { SupportedLanguage.DE, "germany" },
            { SupportedLanguage.EL, "greek" },
            { SupportedLanguage.GU, "gujarati" },
            { SupportedLanguage.IW, "hebrew" },
            { SupportedLanguage.HI, "hindi" },
            { SupportedLanguage.HU, "hungarian" },
            { SupportedLanguage.IS, "icelandic" },
            { SupportedLanguage.ID, "indonesian" },
            { SupportedLanguage.IT, "italian" },
            { SupportedLanguage.JA, "japanese" },
            { SupportedLanguage.KN, "kannada" },
            { SupportedLanguage.KK, "kazakh" },
            { SupportedLanguage.KM, "khmer" },
            { SupportedLanguage.KO, "korean" },
            { SupportedLanguage.KY, "kyrgyz" },
            { SupportedLanguage.LO, "lao" },
            { SupportedLanguage.LV, "latvian" },
            { SupportedLanguage.LT, "lithuanian" },
            { SupportedLanguage.MK, "macedonian" },
            { SupportedLanguage.MS, "malay" },
            { SupportedLanguage.MR, "marathi" },
            { SupportedLanguage.MN, "mongolian" },
            { SupportedLanguage.NE, "nepali" },
            { SupportedLanguage.NO, "norwegian" },
            { SupportedLanguage.PL, "polish" },
            { SupportedLanguage.PT, "porguguese" },
            { SupportedLanguage.PTBR, "portuguese_brazil" },
            { SupportedLanguage.PA, "punjabi" },
            { SupportedLanguage.RO, "romanian" },
            { SupportedLanguage.RU, "russian" },
            { SupportedLanguage.SR, "serbian" },
            { SupportedLanguage.SI, "sinhalese" },
            { SupportedLanguage.SK, "slovak" },
            { SupportedLanguage.SL, "slovenian" },
            { SupportedLanguage.ES, "spanish" },
            { SupportedLanguage.ES419, "spanish_latin_america" },
            { SupportedLanguage.SW, "swahili" },
            { SupportedLanguage.SV, "sweedish" },
            { SupportedLanguage.TA, "tamil" },
            { SupportedLanguage.TE, "telugu" },
            { SupportedLanguage.TH, "thai" },
            { SupportedLanguage.TR, "turkish" },
            { SupportedLanguage.UK, "ukranian" },
            { SupportedLanguage.UR, "urdu" },
            { SupportedLanguage.UZ, "uzbek" },
            { SupportedLanguage.VI, "vietnamese" },
            { SupportedLanguage.ZU, "zulu" },

        }.ToImmutableDictionary();
    }
}
