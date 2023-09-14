using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleMapsClient
{
    public class GoogleMapsClient
    {
        #region Public Properties

        public string APIKey { get; }

        #endregion

        #region Constructors

        public GoogleMapsClient(string apiKey)
        {
            APIKey = apiKey ?? throw new ArgumentNullException(nameof(apiKey));
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public Task<IEnumerable<PlaceAutocompletePredictionResponseModel>> GetPlaceAutocompletePredictionsAsync(PlaceAutocompletePredictionAPIArgs? args = null)
        {
            return null;
        }

        #endregion
    }
}
