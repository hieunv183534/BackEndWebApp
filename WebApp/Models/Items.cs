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
        private int price;

        #endregion

        #region Constructor

        public Items()
        {

        }

        public Items(int itemId, string itemName, int price)
        {
            this.itemId = itemId;
            this.itemName = itemName;
            this.price = price;
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
        public int Price
        {
            get { return price; }
            set { price = value; }
        }

        #endregion

        #region Method

        #endregion
    }
}
