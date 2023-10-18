using Newtonsoft.Json;
using System.Diagnostics.CodeAnalysis;

namespace GoogleMapsClient
{
    /// <summary>
    /// An encoded location reference, derived from latitude and longitude coordinates, that represents an area, 
    /// 1/8000th of a degree by 1/8000th of a degree (about 14m x 14m at the equator) or smaller. Plus codes 
    /// can be used as a replacement for street addresses in places where they do not exist (where buildings 
    /// are not numbered or streets are not named).
    /// </summary>
    public class PlaceFindPlusCodeResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="GlobalCode"/> property
        /// </summary>
        private string? mGlobalCode;

        /// <summary>
        /// The member of the <see cref="CompoundCode"/> property
        /// </summary>
        private string? mCompoundCode;

        #endregion

        #region Public Property

        /// <summary>
        /// The global_code is a 4 character area code and 6 character or longer local code (849VCWC8+R9).
        /// </summary>
        [AllowNull]
        [JsonProperty("global_code")]
        public string GlobalCode
        {
            get => mGlobalCode ?? string.Empty;

            set => mGlobalCode = value;
        }


        /// <summary>
        /// The compound_code is a 6 character or longer local code with an explicit location 
        /// (CWC8+R9, Mountain View, CA, USA). Some APIs may return an empty string if the compound_code
        /// is not available.
        /// </summary>
        [JsonProperty("compounde_code")]
        public string CompoundCode 
        { 
            get => mCompoundCode ?? string.Empty;

            set => mCompoundCode = value;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default Constructor
        /// </summary>
        public PlaceFindPlusCodeResponseModel()
        {
            
        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        public override string ToString() => $"GlobalCode {GlobalCode}, CompoundCode {CompoundCode}";

        #endregion
    }
}
