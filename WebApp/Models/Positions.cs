using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    /// <summary>
    /// Lớp vị trí nhân viên
    /// </summary>
    public class Positions
    {
        #region Field

        private string positionId;
        private string positionName;

        #endregion

        #region Constructor

        public Positions()
        {

        }

        public Positions(string positionId, string positionName)
        {
            this.positionId = positionId;
            this.positionName = positionName;
        }

        #endregion

        #region Property

        /// <summary>
        /// Mã vị trí nhân viên
        /// </summary>
        public string PositionId
        {
            get { return positionId; }
            set { positionId = value; }
        }


        /// <summary>
        /// Tên vị trí nhân viên
        /// </summary>
        public string PositionName
        {
            get { return positionName; }
            set { positionName = value; }
        }

        #endregion

        #region Method

        #endregion
    }
}
