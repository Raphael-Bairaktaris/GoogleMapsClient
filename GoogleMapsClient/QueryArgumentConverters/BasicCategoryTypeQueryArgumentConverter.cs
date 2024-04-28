namespace Simple.GoogleMaps
{
    /// <summary>
    /// A <see cref="BaseQueryArgumentConverter{TValue}"/> that is used for converting a <see cref="BasicCategoryType"/> to a <see cref="string"/>.
    /// </summary>
    public class BasicCategoryTypeQueryArgumentConverter : BaseQueryArgumentConverter<BasicCategoryType>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public BasicCategoryTypeQueryArgumentConverter() : base()
        {

        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        public override string Convert(BasicCategoryType value) => GoogleMapsClientConstants.BasicCategoryTypeToStringMapper[value];

        #endregion
    }
}
