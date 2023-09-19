using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleMapsClient
{
    /// <summary>
    /// Represents a place detail response
    /// </summary>
    public class PlaceDetailResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="InfoMessages"/> property
        /// </summary>
        private string? mInfoMessages;

        /// <summary>
        /// The member of the <see cref="HtmlAtributions"/> property
        /// </summary>
        private string? mHtmlAttributions;

        /// <summary>
        /// The member of the <see cref="Result"/> property
        /// </summary>
        private PlaceFindPlaceAttributesResponseModel? mResult;

        /// <summary>
        /// The member of the <see cref="Status"/> property
        /// </summary>
        private PlaceFindPlaceAttributesResponseModel? mStatus;

        #endregion

        #region Public Property

        /// <summary>
        /// May contain a set of attributions about this listing which must be 
        /// displayed to the user (some listings may not have attribution).
        /// </summary>
        [AllowNull]
        [JsonProperty("html_attributions")]
        public string HtmlAtributions 
        {
            get => mHtmlAttributions ?? string.Empty;
            set => mHtmlAttributions = value;
        }

        /// <summary>
        /// Contains detailed information about the place requested.
        /// </summary>
        [AllowNull]
        [JsonProperty("result")]
        public PlaceFindPlaceAttributesResponseModel Result
        {
            get => mResult ??= new PlaceFindPlaceAttributesResponseModel();

            set => mResult = value;
        }

        /// <summary>
        /// Contains the status of the request, and may contain debugging 
        /// information to help you track down why the request failed.
        /// </summary>
        [AllowNull]
        [JsonProperty("status")]
        public PlaceFindPlaceAttributesResponseModel Status 
        {
            get => mResult ??= new PlaceFindPlaceAttributesResponseModel();

            set => mResult = value;
        }

        /// <summary>
        /// When the service returns additional information about the request specification,
        /// there may be an additional info_messages field within the response object. This field
        /// is only returned for successful requests. It may not always be returned, and its content 
        /// is subject to change.
        /// </summary>
        [AllowNull]
        [JsonProperty("info_messages")]
        public string InfoMessages 
        {
            get => mInfoMessages ?? string.Empty;
            set => mInfoMessages = value;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default Constructor
        /// </summary>
        public PlaceDetailResponseModel()
        {
            
        }

        #endregion
    }
}
