namespace Simple.GoogleMaps
{
    /// <summary>
    /// A <see cref="BaseQueryArgumentConverter{TValue}"/> that is used for converting a <see cref="PriceRangeType"/> to a <see cref="string"/>.
    /// </summary>
    public class PriceRangeTypeQueryArgumentConverter : BaseQueryArgumentConverter<PriceRangeType>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public PriceRangeTypeQueryArgumentConverter() : base()
        {

        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        public override string Convert(PriceRangeType value) => GoogleMapsClientConstants.PriceRangeTypeToStringMapper[value];

        #endregion
    }
}
