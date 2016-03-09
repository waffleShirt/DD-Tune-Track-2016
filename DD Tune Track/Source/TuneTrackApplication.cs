using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DD_Tune_Track.Source
{
    /// <summary>
    /// High level Application object. Central store for the
    /// majority of the data being used in Tune Track. 
    /// </summary>
    class TuneTrackApplication
    {
        #region Attributes

        // List of bikes (Summer only)
        private List<Bike> mBikes = null;

        // List of loaded charge lists
        private List<ChargeList> mChargeLists = null;

        // Current season
        private Season mCurrentSeason = null;

        // Inventory (Summer only)
        private List<SummerInventoryItem> mInventory = null;

        // List of active techs
        private List<Tech> mTechs = null;

        // List of winter tune types (Winter only)
        private List<WinterTuneType> mWinterTuneTypes = null;

        /*
        Current working date. Generally set to todays date, but once the current days charge list 
        is charged it ticks over to the next days date so that we don't try to add more tunes to a
        locked charge list. 
        */
        private DateTime mWorkingDate;

        #endregion

        #region Properties

        /// <summary>
        /// Technician name list
        /// </summary>
        public List<Tech> Techs
        {
            // Return as redonly
            get { return mTechs.ToList();  }
            set { mTechs = value;  }
        }

        /// <summary>
        /// Current operating season
        /// </summary>
        public Season CurrentSeason
        {
            get { return mCurrentSeason; }
        }

        /// <summary>
        /// Bike List
        /// </summary>
        public List<Bike> BikeList
        {
            // Return as readonly list
            get { return mBikes; }
            set { mBikes = value; }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Default constructor
        /// </summary>
        public TuneTrackApplication()
        {
            // Initialise season date
            mCurrentSeason = new Season(false); 
        }

        public void Initialise()
        {
            // Initialise tech list
            mTechs = new List<Tech>();

            // Add some dummy techs
            mTechs.Add(new Tech("TB"));
            mTechs.Add(new Tech("RG"));

            // Initialise bike list
            mBikes = new List<Bike>();

            // Add some dummy bikes
            mBikes.Add(new Bike("AUR15L1", "Norco", "Aurum", "12345"));
            mBikes.Add(new Bike("PHX15M1", "Pivot", "Phoenix", "2345678")); 
        }

        #endregion
    }
}
