using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DD_Tune_Track.Source
{
    /// <summary>
    /// Tune object specific to winter tuning
    /// </summary>
    class WinterTune : Tune
    {
        #region Attributes

        // Asset number of item being tuned
        private string mAssetNumber;

        // Max length of parts field
        private const int mPartsMaxLenth = 100;

        // String field where techs can enter parts used during tune. Will rarely be used. 
        private string mParts;

        // Type of tune being performed
        private WinterTuneType mTuneType = null; 

        #endregion
    }
}
