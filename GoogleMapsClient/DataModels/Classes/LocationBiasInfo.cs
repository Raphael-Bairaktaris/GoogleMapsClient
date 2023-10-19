namespace GoogleMapsClient
{
    /// <summary>
    /// Contains information relating to one of multiple types of search set of rules.
    /// </summary>
    public class LocationBiasInfo : LocationRestrictionInfo
    {
        #region Public Properties

        /// <summary>
        /// A flag indicating whether an IP based location search should be used.
        /// </summary>
        public bool ShouldUseIPBias { get; }

        #endregion

        #region Constructors

        /// <summary>
        /// IP bias constructor
        /// </summary>
        public LocationBiasInfo() : base()
        {
            ShouldUseIPBias = true;
        }

        /// <summary>
        /// Circular based constructor
        /// </summary>
        /// <param name="circularRadius">The radius of the circular that is used when a circular based location search is performed.</param>
        /// <param name="circularCenter">The coordinates for the center of the circle when a circular based location search is performed.</param>
        public LocationBiasInfo(double circularRadius, Coordinates circularCenter) : base(circularRadius, circularCenter) 
        {

        }

        /// <summary>
        /// Rectangular based constructor
        /// </summary>
        /// <param name="rectangularSouthwest">The coordinates for the southwest part of the rectangle.</param>
        /// <param name="rectangularNortheast">The coordinates for the northseast part of the rectangle.</param>
        public LocationBiasInfo(Coordinates rectangularSouthwest, Coordinates rectangularNortheast) : base(rectangularSouthwest, rectangularNortheast)
        {
        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        public override string ToAPIString()
        {
            if (ShouldUseIPBias)
                return "ipbias";

            return base.ToAPIString();
        }

        #endregion
    }
}
