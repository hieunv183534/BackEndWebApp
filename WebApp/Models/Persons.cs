using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{

    /// <summary>
    /// Lớp người
    /// </summary>
    public class Persons
    {

        #region Field

        private string fullName;
        private DateTime dateOfBirth;
        private int gender;
        private string address;
        private string email;
        private string phoneNumber;

        #endregion

        #region Constructor

        public Persons() { }

        public Persons(string fullName)
        {
            this.fullName = fullName;
        }

        public Persons(string fullName, DateTime dateOfBirth,int gender , string address, string email, string phoneNumber): this(fullName)
        {
            this.dateOfBirth = dateOfBirth;
            this.gender = gender;
            this.address = address;
            this.email = email;
            this.phoneNumber = phoneNumber;
        }

        #endregion

        #region Property

        /// <summary>
        /// Họ và tên
        /// </summary>
        public string FullName
        {
            get { return fullName; }
            set { fullName = value; }
        }

        /// <summary>
        /// Ngày sinh
        /// </summary>
        public DateTime DateOfBirth
        {
            get { return dateOfBirth; }
            set { dateOfBirth = value; }
        }

        /// <summary>
        /// Giới tính
        /// 2: nữ / 1: nam / 0: không xác định
        /// </summary>
        public int Gender
        {
            get { return gender; }
            set { gender = value; }
        }


        /// <summary>
        /// Địa chỉ
        /// </summary>
        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        /// <summary>
        /// Email
        /// </summary>
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        /// <summary>
        /// Số điện thoại
        /// </summary>
        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        #endregion

        #region Method

        #endregion
    }
}
