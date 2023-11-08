namespace GoogleMapsClient
{
    /// <summary>
    /// A <see cref="BaseQueryArgumentConverter{TValue}"/> that is used for converting a <see cref="PlaceTypeInfo"/> to a <see cref="string"/>.
    /// </summary>
    public class PlaceTypeInfoQueryArgumentConverter : BaseQueryArgumentConverter<PlaceTypeInfo>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public PlaceTypeInfoQueryArgumentConverter() : base()
        {

        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        public override string Convert(PlaceTypeInfo value) => value.ToAPIString();

        #endregion
    }
}
