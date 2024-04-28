namespace Simple.GoogleMaps
{
    /// <summary>
    /// A <see cref="BaseQueryArgumentConverter{TValue}"/> that is used for converting a <see cref="AtmosphereCategoryType"/> to a <see cref="string"/>.
    /// </summary>
    public class AtmosphereCategoryTypeQueryArgumentConverter : BaseQueryArgumentConverter<AtmosphereCategoryType>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public AtmosphereCategoryTypeQueryArgumentConverter() : base()
        {

        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        public override string Convert(AtmosphereCategoryType value) => GoogleMapsClientConstants.AtmosphereCategoryTypeToStringMapper[value];

        #endregion
    }
}
