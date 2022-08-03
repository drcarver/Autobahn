//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IOrganizationAccreditation.cs
//**********************************************************

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IOrganizationAccreditation
     /// </summary>
    public partial interface IOrganizationAccreditation
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Organization"/> model
        /// </summary>
        Guid OrganizationId { get; set; }

        /// <summary>
        /// Defines the OrganizationAccreditation.AccreditationStatus nullable property
        /// </summary>
        System.Boolean? AccreditationStatus { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAccreditationAgency"/> model
        /// </summary>
        Guid? RefAccreditationAgencyId { get; set; }

        /// <summary>
        /// Defines the OrganizationAccreditation.AccreditationAwardDate nullable property
        /// </summary>
        System.DateTime? AccreditationAwardDate { get; set; }

        /// <summary>
        /// Defines the OrganizationAccreditation.AccreditationExpirationDate nullable property
        /// </summary>
        System.DateTime? AccreditationExpirationDate { get; set; }

        /// <summary>
        /// Defines the OrganizationAccreditation.SeekingAccreditationDate nullable property
        /// </summary>
        System.DateTime? SeekingAccreditationDate { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefHigherEducationInstitutionAccreditationStatus"/> model
        /// </summary>
        Guid? RefHigherEducationInstitutionAccreditationStatusId { get; set; }

        /// <summary>
        /// Defines the OrganizationAccreditation.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the OrganizationAccreditation.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Defines the OrganizationAccreditation.AccreditationAgencyName non nullable property
        /// </summary>
        System.String AccreditationAgencyName { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatus"/> model
        /// </summary>
        Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        Guid? DataCollectionId { get; set; }

    }
}
