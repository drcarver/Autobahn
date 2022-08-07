//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   OrganizationServiceModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The OrganizationService Model
     /// </summary>
    public partial class OrganizationServiceModel : AutobahnBase, Interfaces.IOrganizationServiceModel
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
