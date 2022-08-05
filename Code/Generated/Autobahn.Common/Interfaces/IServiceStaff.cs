//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IServiceStaff.cs
//**********************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IServiceStaff
     /// </summary>
    public partial interface IServiceStaff : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefSpecialEducationStaffCategory"/> model
        /// </summary>
        Guid RefSpecialEducationStaffCategoryId { get; set; }

    }
}
