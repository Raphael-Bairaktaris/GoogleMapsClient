namespace GoogleMapsClient
{
    /// <summary>
    /// A <see cref="BaseQueryArgumentConverter{TValue}"/> that is used for converting a <see cref="RankByType"/> to a <see cref="string"/>.
    /// </summary>
    public class RankByTypeQueryArgumentConverter : BaseQueryArgumentConverter<RankByType>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public RankByTypeQueryArgumentConverter() : base()
        {

        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        public override string Convert(RankByType value) => GoogleMapsClientConstants.RankByTypeToStringMapper[value];

        #endregion
    }
}
