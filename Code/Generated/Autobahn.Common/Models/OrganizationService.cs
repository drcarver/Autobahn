//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   OrganizationService.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The OrganizationService
     /// </summary>
    public partial class OrganizationService : AutobahnBase, Interfaces.IOrganizationService
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Organization"/> model
        /// </summary>
        public Guid OrganizationId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefStudentSupportServiceType"/> model
        /// </summary>
        public Guid RefStudentSupportServiceTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
