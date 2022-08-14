//***************************************************************************
//* DomainName: Invalid or Unreferenced Models Interfaces (used by both models and View Models
//* FileName:   IServiceStaff.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Invalid.Interfaces
{
     /// <summary>
     /// The IServiceStaff Interface
     /// </summary>
    public partial interface IServiceStaff : IAutobahnBase
    {
        /// <summary>
        /// Titles of personnel employed and contracted to provide special education and related services for children with disabilities.
        /// </summary>
        Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Titles of personnel employed and contracted to provide special education and related services for children with disabilities.
        /// </summary>
        Guid RefSpecialEducationStaffCategoryId { get; set; }

    }
}
