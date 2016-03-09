using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DD_Tune_Track.Source
{
    /// <summary>
    /// A Charge List is the main parent object using in
    /// tune track. It stores the data about when a tune was
    /// performed and who did it, whether it has been charged
    /// and to what season the charge list belongs to. It 
    /// also holds the list of tunes that belong to the
    /// Charge List. 
    /// </summary>
    class ChargeList
    {
        #region Attributes

        // Charge List ID. Automatically generated when Charge List is added to database. 
        private int mID = -1;

        // Charge list date
        private DateTime mDate;

        // Flag to determine whether list has been charged
        private bool mCharged = false;

        // Tech who charged the list
        private Tech mChargedBy = null;

        // Date and time list was charged (set to DateTime min value if not set)
        private DateTime mChargedAt; 

        // List of tunes performed on the charge list
        private List<Tune> mTuneList = null;

        // Season to which charge list belongs
        private Season mSeason = null; 

        #endregion

    }
}
