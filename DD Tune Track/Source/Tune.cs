using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DD_Tune_Track.Source
{
    /// <summary>
    /// Abstract Tune base class. Contains the common attributes and 
    /// methods for Summer and Winter tunes. 
    /// </summary>
    abstract class Tune
    {
        #region Attributes

        // Tune ID. Automatically generated when tune is entered into database. 
        private int mID = -1;

        // Maximum length for notes
        private const int mNotesMaxLength = 100; 

        // Notes field that techs can use to enter addtional info about a tune.
        private string mNotes;

        // Flag for tune being saved to charge list
        private bool mInChargeList = false; 

        #endregion
    }
}
