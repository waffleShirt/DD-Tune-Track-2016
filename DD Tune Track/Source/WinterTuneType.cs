using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DD_Tune_Track.Source
{
    /// <summary>
    /// Tune Types associated with Winter seasons. Tune types will
    /// generally carry across many seasons. However a season is 
    /// attached to a tune type in case tune types change a it is
    /// not desireable to have a tune type carry over. 
    /// 
    /// </summary>
    class WinterTuneType
    {
        #region Attributes

        // Tune ID. Automatically generated when inserted into database
        private int mID = -1;

        // Tune name
        private string mName;

        // Tune quantity. Used in tune lists. 
        private int mQuantity;

        // Season to which tune type belongs. 
        private Season mSeason = null; 

        #endregion

    }
}
