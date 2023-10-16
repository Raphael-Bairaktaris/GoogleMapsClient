using System.Diagnostics.CodeAnalysis;

namespace GoogleMapsClient
{
    /// <summary>
    /// Contains information relating to one of multiple types of search set of rules.
    /// </summary>
    public class PlaceTypeInfo
    {
        #region Public Properties

        /// <summary>
        /// The collection type enum.
        /// </summary>
        public CollectionType? CollectionType { get; }

        /// <summary>
        /// A flag indicating whether the collection type should be used.
        /// </summary>
        [MemberNotNullWhen(true, nameof(CollectionType))]
        public bool ShouldUseCollectionType { get; }

        /// <summary>
        /// The place type enum.
        /// </summary>
        public PlaceType? PlaceType { get; }

        /// <summary>
        /// A flag indicating whether the place type should be used.
        /// </summary>
        [MemberNotNullWhen(true, nameof(PlaceType))]
        public bool ShouldUsePlaceType { get; }

        /// <summary>
        /// The address type enum.
        /// </summary>
        public AddressType? AddressType { get; }

        /// <summary>
        /// A flag indicating whether the address type should be used.
        /// </summary>
        [MemberNotNullWhen(true, nameof(AddressType))]
        public bool ShouldUseAddressType { get; }

        #endregion

        #region Constructors

        /// <summary>
        /// Collection type constructor.
        /// </summary>
        /// <param name="collectionType">The collection type enum.</param>
        public PlaceTypeInfo(CollectionType collectionType)
        {
            ShouldUseCollectionType = true;
            CollectionType = collectionType;
        }

        /// <summary>
        /// Place type constructor.
        /// </summary>
        /// <param name="placeType">The place type enum.</param>
        public PlaceTypeInfo(PlaceType placeType)
        {
            ShouldUsePlaceType = true;
            PlaceType = placeType;
        }

        /// <summary>
        /// Address type constructor.
        /// </summary>
        /// <param name="addressType">The address type enum.</param>
        public PlaceTypeInfo(AddressType addressType)
        {
            ShouldUseAddressType = true;
            AddressType = addressType;
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Returns a string that can be used as API arguments and represents the current <see cref="PlaceTypeInfo"/>.
        /// </summary>
        /// <returns></returns>
        public string ToAPIString()
        {
            if (ShouldUseCollectionType)
                return GoogleMapsClientConstants.CollectionTypeToStringMapper[CollectionType.Value];
            else if (ShouldUsePlaceType)
                return GoogleMapsClientConstants.PlaceTypeToStringMapper[PlaceType.Value];
            else if (ShouldUseAddressType)
                return GoogleMapsClientConstants.AddressTypeToStringMapper[AddressType.Value];

            return string.Empty ;
        }

        #endregion
    }
}

