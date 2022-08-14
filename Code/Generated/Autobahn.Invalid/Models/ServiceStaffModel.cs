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
        /// Titles of personnel employed and contracted to provide special education and related services for children with disabilities.
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Titles of personnel employed and contracted to provide special education and related services for children with disabilities.
        /// </summary>
        public Guid RefSpecialEducationStaffCategoryId { get; set; }

    }
}
