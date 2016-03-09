using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DD_Tune_Track.Source
{
    /// <summary>
    /// Tune object specific to summer tuning. 
    /// </summary>
    class SummerTune : Tune
    {
        #region Attributes

        // Bike asset
        private Bike mAsset = null;

        // Date tune was performed
        private DateTime mTuneDate;

        // Tech who performed tune
        private Tech mTech = null;

        // List of parts used during tune
        private List<SummerInventoryItem> mParts = null; 

        #endregion

    }
}
