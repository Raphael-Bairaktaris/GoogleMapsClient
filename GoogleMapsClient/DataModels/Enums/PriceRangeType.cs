namespace GoogleMapsClient.DataModels.Enums
{
    /// <summary>
    /// Provides a price range enumeration
    /// </summary>
    public enum PriceRangeType
    {
        /// <summary>
        /// Usually $10 and under
        /// </summary>
        Free = 0,

        /// <summary>
        /// Usually between $10-$25
        /// </summary>
        Inexpensive = 1,

        /// <summary>
        /// Usually between $25-45$
        /// </summary>
        ModeratelyExpensive = 2,

        /// <summary>
        /// Usually $50-$100
        /// </summary>
        Expensive = 3,

        /// <summary>
        /// Above $100
        /// </summary>
        VeryExpensive = 4
    }
}
