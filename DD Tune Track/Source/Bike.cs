using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DD_Tune_Track.Source
{
    /// <summary>
    /// Holds all of the required attributes and methods
    /// needed to implement a bike. 
    /// </summary>
    class Bike
    {
        #region Attributes

        // Bike ID, automatically generated when bike is added to database
        private int mID;

        // Bike asset number. Taken straight from the barcode used in the rental shop
        private string mAssetNumber;

        // Bike brand, eg Norco, Specialized etc
        private string mBrand; 

        // Bike model, eg Aurum 7.2, Phoenix etc
        private string mModel;

        // Serial number taken from frame
        private string mSerial;

        // Season to which bike belongs
        private Season mSeason;

        #endregion

        #region Properties

        /// <summary>
        /// ID number from database
        /// </summary>
        public int ID
        {
            get { return mID; }
        }

        /// <summary>
        /// Asset number
        /// </summary>
        public string AssetNumber
        {
            get { return mAssetNumber; }
            set { mAssetNumber = value; }
        }

        /// <summary>
        /// Brand
        /// </summary>
        public string Brand
        {
            get { return mBrand; }
            set { mBrand = value; }
        }

        /// <summary>
        /// Model
        /// </summary>
        public string Model
        {
            get { return mModel; }
            set { mModel = value; }
        }

        /// <summary>
        /// Serial number
        /// </summary>
        public string Serial
        {
            get { return mSerial; }
            set { mSerial = value; }
        }

        /// <summary>
        /// Season
        /// </summary>
        public Season Season
        {
            get { return mSeason; }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Bike constructor. All fields are set except the ID. The bike season is set automatically. 
        /// </summary>
        /// <param name="assetNumber">Asset number</param>
        /// <param name="brand">Brand</param>
        /// <param name="model">Model</param>
        /// <param name="serial">Serial Number</param>
        public Bike(string assetNumber, string brand, string model, string serial)
        {
            mID = -1;           // New bike. ID will not be set until bike is entered into database. 
            mAssetNumber = assetNumber;
            mBrand = brand;
            mModel = model;
            mSerial = serial;
            mSeason = Program.appObject.CurrentSeason; 
        }

        /// <summary>
        /// Constructor allows for all fields to be set
        /// </summary>
        /// <param name="ID">ID number from database</param>
        /// <param name="assetNumber">Asset number<param>
        /// <param name="brand">Brand</param>
        /// <param name="model">Model</param>
        /// <param name="serial">Serial</param>
        /// <param name="season">Season</param>
        public Bike(int ID, string assetNumber, string brand, string model, string serial, Season season)
        {
            mID = ID;
            mAssetNumber = assetNumber;
            mBrand = brand;
            mModel = model;
            mSerial = serial;
            mSeason = season; 
        }

        /// <summary>
        /// Copy constructor
        /// </summary>
        /// <param name="other">Bike to copy</param>
        public Bike(Bike other)
        {
            mID = other.ID;
            mAssetNumber = other.AssetNumber;
            mBrand = other.Brand;
            mModel = other.Model;
            mSerial = other.Serial;
            mSeason = new Season(other.mSeason); 
        }

        #endregion

    }
}
