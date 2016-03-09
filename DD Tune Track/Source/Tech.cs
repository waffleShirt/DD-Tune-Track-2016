using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DD_Tune_Track.Source
{
    /// <summary>
    /// Technician details
    /// </summary>
    class Tech
    {
        #region Attributes

        // Technician ID. Automatically generated when inserted into database. 
        private int mID = -1;

        // Technician name representaion, usually initials. 
        private string mName;

        // Season to which tech belongs
        private Season mSeason = null;

        #endregion

        #region Properties

        /// <summary>
        /// Tech ID
        /// </summary>
        public int ID
        {
            get { return mID; }
        }

        /// <summary>
        /// Tech name
        /// </summary>
        public string Name
        {
            get { return mName; }
        }

        /// <summary>
        /// Tech season
        /// </summary>
        public Season Season
        {
            get { return mSeason; }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Default constructor.
        /// </summary>
        public Tech()
        {
            mID = -1;
            mName = "";
            mSeason = Program.appObject.CurrentSeason; 
        }

        /// <summary>
        /// Constructor allows tech name to be set. ID not set. Season set to current 
        /// season in Tune Track Application Object.
        /// </summary>
        /// <param name="name">Tech name</param>
        public Tech(string name)
        {
            mID = -1;
            mName = name;
            mSeason = Program.appObject.CurrentSeason;
        }

        /// <summary>
        /// Full tech constructor. 
        /// </summary>
        /// <param name="ID">Tech ID from database</param>
        /// <param name="name">Tech name</param>
        /// <param name="season">Tech season</param>
        public Tech(int ID, string name, Season season)
        {
            mID = ID;
            mName = name;
            mSeason = season; 
        }

        /// <summary>
        /// Copy constructor
        /// </summary>
        /// <param name="originalTech">Tech to clone</param>
        public Tech(Tech originalTech)
        {
            mID = originalTech.ID;
            mName = originalTech.Name;
            mSeason = new Season(originalTech.Season);
        }

        #endregion
    }
}
