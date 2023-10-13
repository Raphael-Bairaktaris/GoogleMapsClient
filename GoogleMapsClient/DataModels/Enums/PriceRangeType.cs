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
        MostAffordable = 0,

        /// <summary>
        /// Usually between $10-$25
        /// </summary>
        ModeratelyExpensive = 1,

        /// <summary>
        /// Usually between $25-45$
        /// </summary>
        Expensive = 2,

        /// <summary>
        /// Usually $50-$100
        /// </summary>
        MostExpensive = 3,

        /// <summary>
        /// Above $100
        /// </summary>
        Luxurious = 4
    }
}
