namespace GoogleMapsClient
{
    /// <summary>
    /// A <see cref="BaseQueryArgumentConverter{TValue}"/> that is used for converting a <see cref="ContactCategoryType"/> to a <see cref="string"/>.
    /// </summary>
    public class ContactCategoryTypeQueryArgumentConverter : BaseQueryArgumentConverter<ContactCategoryType>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ContactCategoryTypeQueryArgumentConverter() : base()
        {

        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        public override string Convert(ContactCategoryType value) => GoogleMapsClientConstants.ContactCategoryTypeToStringMapper[value];

        #endregion
    }
}
