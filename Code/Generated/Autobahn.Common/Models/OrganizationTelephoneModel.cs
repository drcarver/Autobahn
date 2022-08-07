//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   OrganizationTelephoneModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The OrganizationTelephone Model
     /// </summary>
    public partial class OrganizationTelephoneModel : AutobahnBase, Interfaces.IOrganizationTelephoneModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Organization"/> model
        /// </summary>
        public Guid OrganizationId { get; set; }

        /// <summary>
        /// Defines the OrganizationTelephone.TelephoneNumber non nullable property
        /// </summary>
        public System.String TelephoneNumber { get; set; }

        /// <summary>
        /// Defines the OrganizationTelephone.PrimaryTelephoneNumberIndicator non nullable property
        /// </summary>
        public System.Boolean PrimaryTelephoneNumberIndicator { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefInstitutionTelephoneType"/> model
        /// </summary>
        public Guid? RefInstitutionTelephoneTypeId { get; set; }

        /// <summary>
        /// Defines the OrganizationTelephone.DoNotPublishIndicator nullable property
        /// </summary>
        public System.Boolean? DoNotPublishIndicator { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTelephoneNumberListedStatus"/> model
        /// </summary>
        public Guid? RefTelephoneNumberListedStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
