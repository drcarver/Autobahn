//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IServiceStaff.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IServiceStaff Interface
     /// </summary>
    public partial interface IServiceStaff : IAutobahnBase
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
        /// </summary>
        Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefSpecialEducationStaffCategory"/> model
        /// </summary>
        Guid RefSpecialEducationStaffCategoryId { get; set; }

    }
}
