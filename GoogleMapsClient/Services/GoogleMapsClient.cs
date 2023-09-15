using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleMapsClient
{
    /// <summary>
    /// 
    /// </summary>
    public class GoogleMapsClient
    {
        #region Public Properties

        /// <summary>
        /// 
        /// </summary>
        public string APIKey { get; }

        #endregion

        #region Constructors

        /// <summary>
        /// 
        /// </summary>
        /// <param name="apiKey"></param>
        /// <exception cref="ArgumentNullException"></exception>
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
