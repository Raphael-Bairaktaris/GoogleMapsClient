using Newtonsoft.Json;

namespace GoogleMapsClient
{
    /// <summary>
    /// Represents a place review response
    /// </summary>
    public class PlaceFindReviewResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="AuthorName"/> property
        /// </summary>
        private string? mAuthorName;

        /// <summary>
        /// The member of the <see cref="RelativeTimeDescpription"/> property
        /// </summary>
        private string? mRelativeTimeDescription;

        /// <summary>
        /// The member of the <see cref="Text"/> property
        /// </summary>
        private string? mText;

        #endregion

        #region Public Property

        /// <summary>
        /// The name of the user who submitted the review. 
        /// Anonymous reviews are attributed to "A Google user".
        /// </summary>
        [JsonProperty("author_name")]
        public string? AuthorName
        {
            get => mAuthorName ?? string.Empty;

            set => mAuthorName = value;
        }

        /// <summary>
        /// The user's overall rating for this place. This is a whole number ranging from 1 to 5.
        /// </summary>
        [JsonProperty("rating")]
        public RatingType? Rating { get; set; }

        /// <summary>
        /// The time that the review was submitted in text, relative to the current time.
        /// </summary>
        [JsonProperty("relative_time_description")]
        public string? RelativeTimeDescpription
        {
            get => mRelativeTimeDescription ?? string.Empty;

            set => mRelativeTimeDescription = value;
        }

        /// <summary>
        /// The time that the review was submitted, measured in the number of seconds 
        /// since since midnight, January 1, 1970 UTC.
        /// </summary>
        [JsonProperty("time")]
        [JsonConverter(typeof(DateTimeOffsetToUnixTimeStampJsonConverter))]
        public DateTimeOffset Time { get; set; }

        /// <summary>
        /// The URL to the user's Google Maps Local Guides profile, if available.
        /// </summary>
        [JsonProperty("author_url")]
        public Uri? AuthorUrl { get; set; }

        /// <summary>
        /// An IETF language code indicating the language of the returned review.This field 
        /// contains the main language tag only, and not the secondary tag indicating country or region.
        /// </summary>
        /// <example>
        /// For example, all the English reviews are tagged as 'en', and not 'en-AU' or 'en-UK' 
        /// and so on.This field is empty if there is only a rating with no review text.
        /// </example>
        [JsonProperty("language")]
        public string? Language { get; set; }

        /// <summary>
        /// An IETF language code indicating the original language of the review. If the review 
        /// has been translated, then original_language != language.This field contains the main 
        /// language tag only, and not the secondary tag indicating country or region.
        /// </summary>
        /// <example>
        /// For example, all the English reviews are tagged as 'en', and not 'en-AU' or 'en-UK' 
        /// and so on.This field is empty if there is only a rating with no review text.
        /// </example>
        [JsonProperty("original_language")]
        public string? OriginalLanguage { get; set; }

        /// <summary>
        /// The URL to the user's photo, if available
        /// </summary>
        [JsonProperty("profile_photo_url")]
        public Uri? ProfilePhotoUrl { get; set; }

        /// <summary>
        /// The user's review. When reviewing a location with Google Places, text reviews are considered
        /// optional. Therefore, this field may be empty. Note that this field may include simple HTML markup.
        /// </summary>
        /// <example>
        /// For example, the entity reference &amp; may represent an ampersand character.
        /// </example>
        [JsonProperty("text")]
        public string? Text
        {
            get => mText ?? string.Empty;

            set => mText = value;
        }

        /// <summary>
        /// A boolean value indicating if the review was translated from the original language it was written in. 
        /// If a review has been translated, corresponding to a value of true, Google recommends that you indicate 
        /// this to your users.
        /// </summary>
        /// <example>
        /// For example, you can add the following string, “IsTranslated by Google”, to the review.
        /// </example>
        [JsonProperty("translated")]
        public bool? IsTranslated { get; set; }

        #endregion

        #region Constructors
        /// <summary>
        /// Default Constructor
        /// </summary>
        public PlaceFindReviewResponseModel()
        {

        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        public override string ToString() => AuthorName + " - " + Rating;

        #endregion
    }
}
