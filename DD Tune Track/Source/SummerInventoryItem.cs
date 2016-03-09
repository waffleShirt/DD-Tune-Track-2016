using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DD_Tune_Track.Source
{
    /// <summary>
    /// As there are numerous parts used when tuning in summer
    /// this inventory item class is required to store the data
    /// and operations that represent an inventory item. 
    /// </summary>
    class SummerInventoryItem
    {
        #region Attributes 

        // Inventory item ID. Automatically generated when item is added to the database. 
        private int mID = -1;

        // Maximum character length for barcodes
        private const int mBarcodeNumberMaxLength = 4;

        /* 
        Barcode number as used in Siriusware. Note that not all items in the inventory
        will have a barcode number, such as labour codes that do not have a barcode 
        number that can be typed into Siriusware.  
        */
        private string mBarcodeNumber;

        // Maximum length for item description
        private const int mDescriptonMaxLength = 20; 

        // Item description
        private string mDescription;

        // Item quantity. Field not used when class is used to populate parts selector list. 
        private int mQuantity; 

        #endregion
    }
}
