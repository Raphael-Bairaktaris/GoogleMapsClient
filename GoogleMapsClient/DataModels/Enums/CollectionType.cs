namespace Simple.GoogleMaps
{
    /// <summary>
    /// Provides enumeration over the collection types
    /// </summary>
    public enum CollectionType
    {
        /// <summary>
        /// Geocode instructs the Place Autocomplete service to return only geocoding results,
        /// rather than business results. Generally, you use this request to disambiguate results
        /// where the location specified may be indeterminate.
        /// </summary>
        Geocode = 0,

        /// <summary>
        /// Address instructs the Place Autocomplete service to return only geocoding results with a precise address.
        /// Generally, you use this request when you know the user will be looking for a fully specified address.
        /// </summary>
        Address = 1,

        /// <summary>
        /// Establishment instructs the Place Autocomplete service to return only geocoding results with a precise address.
        /// Generally, you use this request when you know the user will be looking for a fully specified address.
        /// </summary>
        Establishment = 2,

        /// <summary>
        /// The (regions) type collection instructs the Places service to return any result matching the following types:
        /// <list type="bullet|number|table">
        /// <item>
        ///     <description>Locality</description>
        /// </item>
        /// 
        /// <item>
        ///     <description>Sublocality</description>
        /// </item>
        /// <item>
        ///     <description>Postal Code</description>
        /// </item>
        /// <item>
        ///     <description>Country</description>
        /// </item>
        /// <item>
        ///     <description>Adminstrative area level 1</description>
        /// </item>
        /// <item>
        ///     <description>Adminstrative area level 2</description>
        /// </item>
        /// </list>
        /// </summary>
        /// 
        Regions = 3,

        /// <summary>
        /// The (cities) type collection instructs the Places service to return results that match locality or administrative_area_level_3
        /// <list type="bullet|number|table">
        /// <item>
        ///     <description>Locality</description>
        /// </item>
        /// <item>
        ///     Adminstrative area level 3
        /// </item>
        /// </list>
        /// </summary>
        Cities = 4
    }
}
