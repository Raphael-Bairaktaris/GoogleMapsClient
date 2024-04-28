namespace Simple.GoogleMaps
{
    /// <summary>
    /// A <see cref="BaseQueryArgumentConverter{TValue}"/> that is used for converting a <see cref="LocationBiasInfo"/> to a <see cref="string"/>.
    /// </summary>
    public class LocationBiasInfoQueryArgumentConverter : BaseQueryArgumentConverter<LocationBiasInfo>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public LocationBiasInfoQueryArgumentConverter() : base()
        {

        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        public override string Convert(LocationBiasInfo value) => value.ToAPIString();

        #endregion
    }
}
