using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    /// <summary>
    /// Lớp nhân viên
    /// </summary>
    public class Employees : Persons
    {
        #region Field

        private int employeeId;
        private string identityNumber;
        private string positionId;
        private int salary;
        private DateTime joinDate;
        private int workStatus;

        #endregion

        #region Constructor

        public Employees()
        {

        }

        public Employees(int employeeId, string fullName): base(fullName)
        {
            this.employeeId = employeeId;
        }

        public Employees(int employeeId,string identityNumber, string positionId, 
            int salary, DateTime joinDate, int workStatus, string fullName, DateTime dateOfBirth,
            int gender, string address, string email, string phoneNumber)
            : base(fullName, dateOfBirth, gender, address, email, phoneNumber)
        {
            this.employeeId = employeeId;
            this.identityNumber = identityNumber;
            this.positionId = positionId;
            this.salary = salary;
            this.joinDate = joinDate;
            this.workStatus = workStatus;
        }

        #endregion

        #region Property

        /// <summary>
        /// Mã nhân viên
        /// </summary>
        public int EmployeeId
        {
            get { return employeeId; }
            set { employeeId = value; }
        }

        /// <summary>
        /// Số cmnd
        /// </summary>
        public string IdentityNumber
        {
            get { return identityNumber; }
            set { identityNumber = value; }
        }

        /// <summary>
        /// Id vị trí
        /// </summary>
        public string PositionId
        {
            get { return positionId; }
            set { positionId = value; }
        }

        /// <summary>
        /// Lương cơ bản
        /// </summary>
        public int Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        /// <summary>
        /// ngày vào công ty
        /// </summary>
        public DateTime JoinDate
        {
            get { return joinDate; }
            set { joinDate = value; }
        }

        /// <summary>
        /// Tình trạng làm việc
        /// </summary>
        public int WorkStatus
        {
            get { return workStatus; }
            set { workStatus = value; }
        }


        #endregion

        #region Method

        #endregion
    }
}
