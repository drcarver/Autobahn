//**********************************************************
//* DomainName: Common Models
//* FileName:   ServiceStaffModel.cs
//***************************************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The ServiceStaff Model
     /// </summary>
    public partial class ServiceStaffModel : AutobahnBase, Interfaces.IServiceStaff
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefSpecialEducationStaffCategory"/> model
        /// </summary>
        public Guid RefSpecialEducationStaffCategoryId { get; set; }

    }
}
