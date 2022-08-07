//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IServiceStaffModel.cs
//**********************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IServiceStaffModel Interface
     /// </summary>
    public partial interface IServiceStaffModel : IAutobahnBase
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
