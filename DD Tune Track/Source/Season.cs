using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DD_Tune_Track.Source
{
    /// <summary>
    /// Defines a season with a name and start and end date. 
    /// </summary>
    class Season
    {
        #region Attributes

        // !!!! Todo: Make sure season date for winter is always set to 2016, not 2017 once it ticks over to January !!!! 

        /*
        Season date ranges. Note that these are only valid
        for Silver Star Mountain Resort. These numbers would
        need to be added to a configuration file if they were
        to be used elsewhere.
        */
        private const int mWinterStartMonth = 10;   // October
        private const int mWinterEndMonth = 4;      // April
        private const int mSummerStartMonth = 5;    // May
        private const int mSummerEndMonth = 10;     // October


        // Season name. Either S for Summer or W for Winter followed by 4 digit year (eg S2016)
        private string mName;

        // Season start date, set when Begin Season is selected in Maintenance module
        private DateTime mStartDate;

        // Season end date, set when End Season is seleted in Maintenance module
        private DateTime mEndDate;

        #endregion

        #region Properties

        /// <summary>
        /// Season name
        /// </summary>
        public string Name
        {
            get { return mName; }
        }

        /// <summary>
        /// Season start date
        /// </summary>
        public DateTime StartDate
        {
            get { return mStartDate; }
            set { mStartDate = value; }
        }

        /// <summary>
        /// Season end date
        /// </summary>
        public DateTime EndDate
        {
            get { return mEndDate; }
            set { mEndDate = value; }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Default constructor. Season name is automatically set
        /// and the start and end date values are set to the min
        /// value for a DateTime object.
        /// </summary>
        /// <param name="isWinter">Season name starts with a W (winter) if true, otherwise S summer)</param>
        public Season(bool isWinter)
        {
            SetSeasonName(isWinter);
            mStartDate = new DateTime();      // Min value for DateTime object
            mEndDate = new DateTime();        // Min value for DateTime object
        }

        /// <summary>
        /// Constructor allows all values to be specified. 
        /// </summary>
        /// <param name="name">Season name</param>
        /// <param name="startDate">Season start date</param>
        /// <param name="endDate">Season end date</param>
        public Season(string name, DateTime startDate, DateTime endDate)
        {
            mName = name;
            mStartDate = startDate;
            mEndDate = endDate; 
        }

        /// <summary>
        /// Copy constructor
        /// </summary>
        /// <param name="other">Other season to be copied</param>
        public Season(Season other)
        {
            mName = other.Name;
            mStartDate = other.StartDate;
            mEndDate = other.EndDate; 
        }

        /// <summary>
        /// Sets the season name
        /// </summary>
        /// <param name="isWinter">Season name starts with a W (winter) if true, otherwise S summer)</param>
        private void SetSeasonName(bool isWinter)
        {
            if (isWinter)
            {
                mName = "W" + DateTime.Now.Year.ToString();
            }
            else
            {
                mName = "S" + DateTime.Now.Year.ToString();
            }
        }

        #endregion
    }
}
