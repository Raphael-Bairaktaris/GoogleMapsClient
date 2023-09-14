using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleMapsClient
{
    /// <summary>
    /// Provides enumeration over the address types
    /// </summary>
    public enum AddressType
    {
        /// <summary>
        /// Adminstrative area level 1 indicates a first-order civil entity
        /// below the country level.
        /// </summary>
        /// <example>
        /// Within the United States, these administrative levels are states.
        /// Not all nations exhibit these administrative levels. 
        /// </example>
        AdminstrativeAreaLevel1 = 0,

        /// <summary>
        /// Adminstrative area level 2 indicates a second-order civil entity 
        /// below the country level. Within the United States, these administrative 
        /// levels are counties. Not all nations exhibit these administrative levels.
        /// </summary>
        AdminstrativeAreaLevel2 = 1,

        /// <summary>
        /// Administrative area level 3 indicates a third-order civil entity below the 
        /// country level. This type indicates a minor civil division. Not all nations 
        /// exhibit these administrative levels.
        /// </summary>
        AdminstrativeAreaLevel3 = 2,

        /// <summary>
        /// Administrative area level 4 indicates a fourth-order civil entity below the 
        /// country level. This type indicates a minor civil division. Not all nations 
        /// exhibit these administrative levels.
        /// </summary>
        AdminstrativeAreaLevel4 = 3,

        /// <summary>
        /// Adminstrative area level 5 indicates a fifth-order civil entity below the country level. 
        /// This type indicates a minor civil division. Not all nations exhibit these administrative levels.
        /// </summary>
        AdminstrativeAreaLevel5 = 4,

        /// <summary>
        /// Administrative area level 6 indicates a sixth-order civil entity below the country level.
        /// This type indicates a minor civil division. Not all nations exhibit these administrative levels.
        /// </summary>
        AdminstrativeAreaLevel6 = 5,

        /// <summary>
        /// administrative_area_level_7 indicates a seventh-order civil entity below the country level. 
        /// This type indicates a minor civil division. Not all nations exhibit these administrative levels.
        /// </summary>
        AdminstrativeAreaLevel7 = 6,

        /// <summary>
        /// Archipelago
        /// </summary>
        Archipelago = 7,

        /// <summary>
        /// Colloquial area indicates a commonly-used alternative name for the entity.
        /// </summary>
        ColloquialArea = 8,

        /// <summary>
        /// Continent
        /// </summary>
        Continent = 9,

        /// <summary>
        /// Country indicates a political entity. Usually, this type indicates a polygon of some civil administration.
        /// </summary>
        Country = 10,

        /// <summary>
        /// Establishment typically indicates a place that has not yet been categorized.
        /// </summary>
        Establishment = 11,

        /// <summary>
        /// Finance
        /// </summary>
        Finance = 12,

        /// <summary>
        /// Floor
        /// </summary>
        Floor = 13,

        /// <summary>
        /// Food
        /// </summary>
        Food = 14,

        /// <summary>
        /// General contractor
        /// </summary>
        GeneralContractor = 15,

        /// <summary>
        /// Geocode
        /// </summary>
        Geocode = 16,

        /// <summary>
        /// Health
        /// </summary>
        Health = 17,

        /// <summary>
        /// Intersection indicates a major intersection, usually of two major roads.
        /// </summary>
        Intersection = 18,

        /// <summary>
        /// Landmark indicates a nearby place that is used as a reference, to aid navigation.
        /// </summary>
        Landmark = 19,

        /// <summary>
        /// Locality indicates an incorporated city or town political entity.
        /// </summary>
        Locality = 20,

        /// <summary>
        /// Natural feature indicates a prominent natural feature.
        /// </summary>
        NaturalFeature = 21,

        /// <summary>
        /// Neighbourhood indicates a named neighborhood.
        /// </summary>
        Neighbourhood = 22,

        /// <summary>
        /// Place of worship
        /// </summary>
        PlaceOfWorship = 23,

        /// <summary>
        /// Plus code indicates an encoded location reference, derived from latitude and longitude.
        /// Plus codes can be used as a replacement for street addresses in places where they do not exist.
        /// </summary>
        /// <remarks>See https://maps.google.com/pluscodes/</remarks>
        PlusCode = 24,

        /// <summary>
        /// Point of interest indicates a named point of interest.
        /// </summary>
        PointOfInterset = 25,

        /// <summary>
        /// Political indicates a political entity. Usually, this type indicates a polygon of some civil administration.
        /// </summary>
        Political = 26,

        /// <summary>
        /// Post box indicates a specific postal box.
        /// </summary>
        PostBox = 27,

        /// <summary>
        /// Postal code indicates a postal code as used to address postal mail within the country.
        /// </summary>
        PostalCode = 28,

        /// <summary>
        /// Postal code prefix
        /// </summary>
        PostalCodePrefix = 29,

        /// <summary>
        /// Postal code suffix
        /// </summary>
        PostalCodeSuffix = 30,

        /// <summary>
        /// Postal town indicates a grouping of geographic areas.
        /// </summary>
        /// <example>
        /// Such as locality and sublocality, used for mailing addresses in some countries.
        /// </example>
        PostalTown = 31,

        /// <summary>
        /// Premise indicates a named location, usually a building or collection of buildings with a common name.
        /// </summary>
        Premise = 32,

        /// <summary>
        /// Room
        /// </summary>
        Room = 33,

        /// <summary>
        /// Route indicates a named route.
        /// </summary>
        /// <example>
        /// Such as "US 101"
        /// </example>
        Route = 34,

        /// <summary>
        /// Street address indicates a precise street address.
        /// </summary>
        StreetAddress = 35,

        /// <summary>
        /// Street number indicates the precise street number.
        /// </summary>
        StreetNumber = 36,

        /// <summary>
        /// Sublocality
        /// </summary>
        Sublocality = 37,

        /// <summary>
        /// Sublocality level 1 indicates a first-order civil entity below a locality.
        /// Larger numbers indicate a smaller geographic area.
        /// </summary>
        SublocalityLevel1 = 38,

        /// <summary>
        /// Sublocality level 2
        /// </summary>
        SublocalityLevel2 = 39,

        /// <summary>
        /// Sublocality level 3
        /// </summary>
        SublocalityLevel3 = 40,

        /// <summary>
        /// Sublocality level 4
        /// </summary>
        SublocalityLevel4 = 41,

        /// <summary>
        /// Sublocality level 5
        /// </summary>
        SublocalityLevel5 = 42,

        /// <summary>
        /// Subpremise indicates a first-order entity below a named location, 
        /// usually a singular building within a collection of buildings with a common name.
        /// </summary>
        Subpremise = 43,

        /// <summary>
        /// Town square
        /// </summary>
        TownSquare = 44
    }
}
