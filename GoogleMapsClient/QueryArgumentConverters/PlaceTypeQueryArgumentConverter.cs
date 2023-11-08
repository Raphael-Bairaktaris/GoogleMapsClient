namespace GoogleMapsClient
{
    /// <summary>
    /// A <see cref="BaseQueryArgumentConverter{TValue}"/> that is used for converting a <see cref="PlaceType"/> to a <see cref="string"/>.
    /// </summary>
    public class PlaceTypeQueryArgumentConverter : BaseQueryArgumentConverter<PlaceType>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public PlaceTypeQueryArgumentConverter() : base()
        {

        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        public override string Convert(PlaceType value) => GoogleMapsClientConstants.PlaceTypeToStringMapper[value];

        #endregion
    }
}
