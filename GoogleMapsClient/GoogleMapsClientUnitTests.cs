using Xunit;

namespace GoogleMapsClient
{
    /// <summary>
    /// The tests for the <see cref="GoogleMapsClient"/>
    /// </summary>
    public class GoogleMapsClientUnitTests
    {
        #region Private Members

        /// <summary>
        /// The client
        /// </summary>
        private readonly GoogleMapsClient mClient;

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public GoogleMapsClientUnitTests() : base()
        {
            mClient = new GoogleMapsClient("");
        }

        #endregion

        #region Test Methods

        #region Text Search

        /// <summary>
        /// Checks whether the text search can be retrieved
        /// </summary>
        [Fact]
        public async void TextSearchAsync()
        {
            // Get the response
            var response = await mClient.TextSearchAsync(new TextSearchAPIArgs() { Query = ""});

            // Checks whether the response is successful
            Assert.True(response.IsSuccessful);
        }

        #endregion

        #region Nearby Search

        /// <summary>
        /// Checks whether the nearby search can be retrieved
        /// </summary>
        [Fact]
        public async void NearbySearchAsync()
        {
            // Input data
            var location = new Coordinates(latitude: 40.6212232, longitude: 22.9254278);
            var radius = 1000;
            var args = new NearbySearchAPIArgs(location, radius);

            // Get the response
            var response = await mClient.NearbySearchAsync(args);

            // Checks whether the response is successful
            Assert.True(response.IsSuccessful);
        }

        #endregion

        #region Place Auto Complete Prediction

        /// <summary>
        /// Checks whether the place auto complete prediction can be retrieved
        /// </summary>
        [Fact]
        public async void PlaceAutoCompletePredictionAsync()
        {
            // Get the response
            var response = await mClient.PlaceAutoCompletePredictionAsync(new PlaceAutocompletePredictionAPIArgs("Ζακύνθου 35 Πάτρα"));

            // Checks whether the response is successful
            Assert.True(response.IsSuccessful);
        }

        #endregion

        #region Place Detail

        /// <summary>
        /// Checks whether the place detail can be retrieved
        /// </summary>
        [Fact]
        public async void PlaceDetailAsync()
        {
            // Get the response
            var response = await mClient.PlaceDetailAsync(new PlaceDetailAPIArgs("ChIJN1t_tDeuEmsRUsoyG83frY4"));

            // Checks whether the response is successful
            Assert.True(response.IsSuccessful);
        }

        #endregion

        #region Place Query Autocomplete

        /// <summary>
        /// Checks whether the place query can be retrieved
        /// </summary>
        [Fact]
        public async void PlaceQueryAutocompleteAsync()
        {
            // Get the response
            var response = await mClient.PlaceQueryAutocompleteAsync(new QueryAutocompleteAPIArgs("point_of_interest"));

            // Checks whether the response is successful
            Assert.True(response.IsSuccessful);
        }

        #endregion

        #region Place Find

        /// <summary>
        /// Checks whether the place can be retrieved
        /// </summary>
        [Fact]
        public async void PlaceFindAsync()
        {
            // Get the response
            var response = await mClient.PlaceFindAsync(new PlaceFindAPIArgs("point_of_interest", "establishment"));

            // Checks whether the response is successful
            Assert.True(response.IsSuccessful);
        }

        #endregion

        #endregion

    }
}
