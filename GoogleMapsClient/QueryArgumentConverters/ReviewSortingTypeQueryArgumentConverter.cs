namespace GoogleMapsClient
{
    /// <summary>
    /// A <see cref="BaseQueryArgumentConverter{TValue}"/> that is used for converting a <see cref="ReviewSortingType"/> to a <see cref="string"/>.
    /// </summary>
    public class ReviewSortingTypeQueryArgumentConverter : BaseQueryArgumentConverter<ReviewSortingType>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ReviewSortingTypeQueryArgumentConverter() : base()
        {

        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        public override string Convert(ReviewSortingType value) => GoogleMapsClientConstants.ReviewSortingTypeToStringMapper[value];

        #endregion
    }
}
