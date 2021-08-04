using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    /// <summary>
    /// Lớp loại khách hàng: bình thường, thân thiết. vip ...
    /// </summary>
    public class CustomerTypes
    {
        #region Field

        private int customerTypeId;
        private string customerTypeName;
        private float offerCoefficient;

        #endregion

        #region Constructor

        public CustomerTypes()
        {

        }

        public CustomerTypes(int customerTypeId, string customerTypeName, float offerCoefficient)
        {
            this.customerTypeId = customerTypeId;
            this.customerTypeName = customerTypeName;
            this.offerCoefficient = offerCoefficient;
        }

        #endregion

        #region Property

        /// <summary>
        /// Mã loại khách hàng
        /// </summary>
        public int CustomerTypeId
        {
            get { return customerTypeId; }
            set { customerTypeId = value; }
        }

        /// <summary>
        /// Tên loại khách hàng
        /// </summary>
        public string CustomerTypeName
        {
            get { return customerTypeName; }
            set { customerTypeName = value; }
        }

        /// <summary>
        /// Hệ số ưu đãi
        /// </summary>
        public float OfferCoefficient
        {
            get { return offerCoefficient; }
            set { offerCoefficient = value; }
        }


        #endregion

        #region Method

        #endregion
    }
}
