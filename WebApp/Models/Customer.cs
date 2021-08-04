using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    /// <summary>
    /// Lớp khách hàng
    /// </summary>
    public class Customer : Persons
    {
        #region Field
        private int customerId;
        private int debit;
        private int cutomerTypeId;
        #endregion

        #region Constructor

        public Customer()
        {

        }

        public Customer(int customerId, string name) : base(name)
        {
            this.customerId = customerId;
        }

        public Customer(int customerId, int debit, int cutomerTypeId, string fullName,
            DateTime dateOfBirth, int gender, string address, string email, string phoneNumber)
            : base(fullName, dateOfBirth, gender, address, email, phoneNumber)
        {
            this.customerId = customerId;
            this.debit = debit;
            this.cutomerTypeId = cutomerTypeId;
        }

        #endregion

        #region Property

        /// <summary>
        /// Mã khách hàng
        /// </summary>
        public int CustomerId
        {
            get { return customerId; }
            set { customerId = value; }
        }

        /// <summary>
        /// Số nợ
        /// </summary>
        public int Debit
        {
            get { return debit; }
            set { debit = value; }
        }

        /// <summary>
        /// Mã loại khách hàng
        /// </summary>
        public int CustomerTypeId
        {
            get { return cutomerTypeId; }
            set { cutomerTypeId = value; }
        }

        #endregion

        #region Method
        #endregion
    }
}
