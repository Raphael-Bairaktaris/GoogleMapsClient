namespace GoogleMapsClient
{
    /// <summary>
    /// A <see cref="BaseQueryArgumentConverter{TValue}"/> that is used for converting a <see cref="LocationRestrictionInfo"/> to a <see cref="string"/>.
    /// </summary>
    public class LocationRestrictionInfoQueryArgumentConverter : BaseQueryArgumentConverter<LocationRestrictionInfo>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public LocationRestrictionInfoQueryArgumentConverter() : base()
        {

        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        public override string Convert(LocationRestrictionInfo value) => value.ToAPIString();

        #endregion
    }
}
