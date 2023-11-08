namespace GoogleMapsClient
{
    /// <summary>
    /// A <see cref="BaseQueryArgumentConverter{TValue}"/> that is used for converting a <see cref="SupportedLanguage"/> to a <see cref="string"/>.
    /// </summary>
    public class SupportedLanguageQueryArgumentConverter : BaseQueryArgumentConverter<SupportedLanguage>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public SupportedLanguageQueryArgumentConverter() : base()
        {

        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        public override string Convert(SupportedLanguage value) => GoogleMapsClientConstants.SupportedLanguageToStringMapper[value];

        #endregion
    }
}
