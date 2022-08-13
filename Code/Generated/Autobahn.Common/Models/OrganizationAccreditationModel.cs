//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationAccreditationModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The OrganizationAccreditation Model
     /// </summary>
    public partial class OrganizationAccreditationModel : AutobahnBase, Interfaces.IOrganizationAccreditation
    {
        /// <summary>
        /// An indication of the accreditation status of a higher education institution.
        /// </summary>
        public System.String AccreditationAgencyName { get; set; }

        /// <summary>
        /// An indication of the accreditation status of a higher education institution.
        /// </summary>
        public System.DateTime? AccreditationAwardDate { get; set; }

        /// <summary>
        /// An indication of the accreditation status of a higher education institution.
        /// </summary>
        public System.DateTime? AccreditationExpirationDate { get; set; }

        /// <summary>
        /// An indication of the accreditation status of a higher education institution.
        /// </summary>
        public System.Boolean? AccreditationStatus { get; set; }

        /// <summary>
        /// An indication of the accreditation status of a higher education institution.
        /// </summary>
        public Guid OrganizationId { get; set; }

        /// <summary>
        /// An indication of the accreditation status of a higher education institution.
        /// </summary>
        public Guid? RefAccreditationAgencyId { get; set; }

        /// <summary>
        /// An indication of the accreditation status of a higher education institution.
        /// </summary>
        public Guid? RefHigherEducationInstitutionAccreditationStatusId { get; set; }

        /// <summary>
        /// An indication of the accreditation status of a higher education institution.
        /// </summary>
        public System.DateTime? SeekingAccreditationDate { get; set; }

    }
}
