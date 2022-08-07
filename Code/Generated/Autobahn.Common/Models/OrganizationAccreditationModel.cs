//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   OrganizationAccreditationModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The OrganizationAccreditation Model
     /// </summary>
    public partial class OrganizationAccreditationModel : AutobahnBase, Interfaces.IOrganizationAccreditationModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Organization"/> model
        /// </summary>
        public Guid OrganizationId { get; set; }

        /// <summary>
        /// Defines the OrganizationAccreditation.AccreditationStatus nullable property
        /// </summary>
        public System.Boolean? AccreditationStatus { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAccreditationAgency"/> model
        /// </summary>
        public Guid? RefAccreditationAgencyId { get; set; }

        /// <summary>
        /// Defines the OrganizationAccreditation.AccreditationAwardDate nullable property
        /// </summary>
        public System.DateTime? AccreditationAwardDate { get; set; }

        /// <summary>
        /// Defines the OrganizationAccreditation.AccreditationExpirationDate nullable property
        /// </summary>
        public System.DateTime? AccreditationExpirationDate { get; set; }

        /// <summary>
        /// Defines the OrganizationAccreditation.SeekingAccreditationDate nullable property
        /// </summary>
        public System.DateTime? SeekingAccreditationDate { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefHigherEducationInstitutionAccreditationStatus"/> model
        /// </summary>
        public Guid? RefHigherEducationInstitutionAccreditationStatusId { get; set; }

        /// <summary>
        /// Defines the OrganizationAccreditation.AccreditationAgencyName non nullable property
        /// </summary>
        public System.String AccreditationAgencyName { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
