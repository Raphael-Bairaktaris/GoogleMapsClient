namespace GoogleMapsClient.DataModels.Enums
{
    /// <summary>
    /// Provides enumeration for review sort
    /// </summary>
    public enum ReviewSortingType
    {
        /// <summary>
        /// For most_relevant (default), reviews are sorted by relevance; the service will bias the 
        /// results to return reviews originally written in the preferred language.
        /// </summary>
        MostRelevant = 0,

        /// <summary>
        /// For newest, reviews are sorted in chronological order; the preferred
        /// language does not affect the sort order.
        /// </summary>
        Newest = 1,

        /// <summary>
        /// The highest rating reviews.
        /// </summary>
        HighestRating = 2,

        /// <summary>
        /// The lowest rating reviews.
        /// </summary>
        LowestRating = 3
    }
}
