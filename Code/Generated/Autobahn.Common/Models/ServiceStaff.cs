//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   ServiceStaff.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The ServiceStaff
     /// </summary>
    public partial class ServiceStaff : AutobahnBase, Interfaces.IServiceStaff
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefSpecialEducationStaffCategory"/> model
        /// </summary>
        public Guid RefSpecialEducationStaffCategoryId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
