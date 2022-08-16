//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   ServiceStaffModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Invalid.Models
{
     /// <summary>
     /// The ServiceStaff Model
     /// </summary>
    public partial class ServiceStaffModel : AutobahnBase, Interfaces.IServiceStaff
    {
        /// <summary>
        /// 
        /// </summary>
        public  RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordStartDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? RefSpecialEducationStaffCategoryId { get; set; }

    }
}
