namespace GoogleMapsClient
{
    /// <summary>
    /// A <see cref="BaseQueryArgumentConverter{TValue}"/> that is used for converting a <see cref="Coordinates"/> to a <see cref="string"/>.
    /// </summary>
    public class CoordinatesQueryArgumentConverter : BaseQueryArgumentConverter<Coordinates>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public CoordinatesQueryArgumentConverter() : base()
        {

        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        public override string Convert(Coordinates value) => value.ToAPIString();

        #endregion
    }
}
