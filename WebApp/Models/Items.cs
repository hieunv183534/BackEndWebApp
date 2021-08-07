using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    /// <summary>
    /// Lớp mặt hàng mà công ty cung cấp
    /// </summary>
    public class Items
    {
        #region Field

        private int itemId;
        private string itemName;
        private int itemPrice;
        private string itemInfo;

        #endregion

        #region Constructor

        public Items()
        {

        }

        public Items(int itemId, string itemName, int itemPrice, string itemInfo)
        {
            this.itemId = itemId;
            this.itemName = itemName;
            this.itemPrice = itemPrice;
            this.itemInfo = itemInfo;
        }

        #endregion

        #region Property

        /// <summary>
        /// Mã mặt hàng
        /// </summary>
        public int ItemId
        {
            get { return itemId; }
            set { itemId = value; }
        }

        /// <summary>
        /// Tên mặt hàng
        /// </summary>
        public string ItemName
        {
            get { return itemName; }
            set { itemName = value; }
        }

        /// <summary>
        /// Giá mặt hàng
        /// </summary>
        public int ItemPrice
        {
            get { return itemPrice; }
            set { itemPrice = value; }
        }

        public string ItemInfo
        {
            get { return itemInfo; }
            set { itemInfo = value; }
        }

        #endregion

        #region Method

        #endregion
    }
}
