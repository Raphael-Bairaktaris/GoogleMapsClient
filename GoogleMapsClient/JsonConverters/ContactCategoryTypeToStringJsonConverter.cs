using Newtonsoft.Json;

namespace GoogleMapsClient
{
    /// <summary>
    /// The <see cref="JsonConverter{T}"/> that converts a <see cref="ContactCategoryType"/> to <see cref="string"/>
    /// </summary>
    public class ContactCategoryTypeToStringJsonConverter : BaseEnumJsonConverter<ContactCategoryType>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ContactCategoryTypeToStringJsonConverter()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<ContactCategoryType, string> GetMapper() => GoogleMapsClientConstants.ContactCategoryTypeToStringMapper;

        #endregion
    }
}