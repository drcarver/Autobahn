//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationTelephoneModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The OrganizationTelephone Model
     /// </summary>
    public partial class OrganizationTelephoneModel : AutobahnBase, Interfaces.IOrganizationTelephone
    {
        /// <summary>
        /// The type of communication number listed for an organization.
        /// </summary>
        public System.Boolean? DoNotPublishIndicator { get; set; }

        /// <summary>
        /// The type of communication number listed for an organization.
        /// </summary>
        public Guid OrganizationId { get; set; }

        /// <summary>
        /// The type of communication number listed for an organization.
        /// </summary>
        public System.Boolean PrimaryTelephoneNumberIndicator { get; set; }

        /// <summary>
        /// The type of communication number listed for an organization.
        /// </summary>
        public Guid? RefInstitutionTelephoneTypeId { get; set; }

        /// <summary>
        /// The type of communication number listed for an organization.
        /// </summary>
        public Guid? RefTelephoneNumberListedStatusId { get; set; }

        /// <summary>
        /// The type of communication number listed for an organization.
        /// </summary>
        public System.String TelephoneNumber { get; set; }

    }
}
