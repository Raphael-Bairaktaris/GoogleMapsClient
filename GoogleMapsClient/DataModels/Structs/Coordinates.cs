namespace Simple.GoogleMaps
{
    /// <summary>
    /// A set of coordinates.
    /// </summary>
    public readonly record struct Coordinates : IAPIStringFormattable
    {
        #region Public Properties

        /// <summary>
        /// Latitude in decimal degrees
        /// </summary>
        public double Latitude { get; }

        /// <summary>
        /// Longitude in decimal degrees
        /// </summary>
        public double Longitude { get; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="latitude">Latitude in decimal degrees</param>
        /// <param name="longitude">Longitude in decimal degrees</param>
        public Coordinates(double latitude, double longitude)
        {
            Latitude = latitude;
            Longitude = longitude;
        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        public override string ToString() => $"Latitude: {Latitude}, Longitude: {Longitude}";

        /// <inheritdoc/>
        public string ToAPIString() => $"{Latitude.ToString().Replace(",", ".")},{Longitude.ToString().Replace(",", ".")}";

        #endregion
    }
}
