//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IOrganizationAccreditation.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IOrganizationAccreditation Interface
     /// </summary>
    public partial interface IOrganizationAccreditation : IAutobahnBase
    {
        /// <summary>
        /// An indication of the accreditation status of a higher education institution.
        /// </summary>
        System.String AccreditationAgencyName { get; set; }

        /// <summary>
        /// An indication of the accreditation status of a higher education institution.
        /// </summary>
        System.DateTime? AccreditationAwardDate { get; set; }

        /// <summary>
        /// An indication of the accreditation status of a higher education institution.
        /// </summary>
        System.DateTime? AccreditationExpirationDate { get; set; }

        /// <summary>
        /// An indication of the accreditation status of a higher education institution.
        /// </summary>
        System.Boolean? AccreditationStatus { get; set; }

        /// <summary>
        /// An indication of the accreditation status of a higher education institution.
        /// </summary>
        Guid OrganizationId { get; set; }

        /// <summary>
        /// An indication of the accreditation status of a higher education institution.
        /// </summary>
        Guid? RefAccreditationAgencyId { get; set; }

        /// <summary>
        /// An indication of the accreditation status of a higher education institution.
        /// </summary>
        Guid? RefHigherEducationInstitutionAccreditationStatusId { get; set; }

        /// <summary>
        /// An indication of the accreditation status of a higher education institution.
        /// </summary>
        System.DateTime? SeekingAccreditationDate { get; set; }

    }
}
