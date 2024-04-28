using System.Diagnostics.CodeAnalysis;

namespace GoogleMapsClient
{
    /// <summary>
    /// Contains information relating to one of multiple types of search set of rules.
    /// </summary>
    public class LocationRestrictionInfo : IAPIStringFormattable
    {
        #region Public Properties

        /// <summary>
        /// A flag indicating whether a circular based location search should be used.
        /// </summary>
        [MemberNotNullWhen(true, nameof(CircularRadius), nameof(CircularCenter))]
        public bool ShouldUseCircular { get; }

        /// <summary>
        /// The radius of the circular that is used when a circular based location search is performed.
        /// </summary>
        public double? CircularRadius { get; }

        /// <summary>
        /// The coordinates for the center of the circle when a circular based location search is performed.
        /// </summary>
        public Coordinates? CircularCenter { get; }

        /// <summary>
        /// A flag indicating whether a rectangular based location search should be used.
        /// </summary>
        [MemberNotNullWhen(true, nameof(RectangularSouthwest), nameof(RectangularNortheast))]
        public bool ShouldUseRectangular { get; }

        /// <summary>
        /// The coordinates for the southwest part of the rectangle.
        /// </summary>
        public Coordinates? RectangularSouthwest { get; }

        /// <summary>
        /// The coordinates for the northeast part of the rectangle.
        /// </summary>
        public Coordinates? RectangularNortheast { get; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        protected LocationRestrictionInfo()
        {

        }

        /// <summary>
        /// Circular based constructor
        /// </summary>
        /// <param name="circularRadius">The radius of the circular that is used when a circular based location search is performed.</param>
        /// <param name="circularCenter">The coordinates for the center of the circle when a circular based location search is performed.</param>
        public LocationRestrictionInfo(double circularRadius, Coordinates circularCenter)
        {
            ShouldUseCircular = true;
            CircularRadius = circularRadius;
            CircularCenter = circularCenter;
        }

        /// <summary>
        /// Rectangular based constructor
        /// </summary>
        /// <param name="rectangularSouthwest">The coordinates for the southwest part of the rectangle.</param>
        /// <param name="rectangularNortheast">The coordinates for the northeast part of the rectangle.</param>
        public LocationRestrictionInfo(Coordinates rectangularSouthwest, Coordinates rectangularNortheast)
        {
            ShouldUseRectangular = true;
            RectangularSouthwest = rectangularSouthwest;
            RectangularNortheast = rectangularNortheast;
        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        public virtual string ToAPIString()
        {
            if (ShouldUseCircular)
                return $"circle:{CircularRadius}@{CircularCenter.Value.Latitude},{CircularCenter.Value.Longitude}";
            else if (ShouldUseRectangular)
                return $"rectangle:{RectangularSouthwest.Value.Latitude},{RectangularSouthwest.Value.Longitude}|{RectangularNortheast.Value.Latitude},{RectangularNortheast.Value.Longitude}";

            return string.Empty;
        }

        #endregion
    }
}
