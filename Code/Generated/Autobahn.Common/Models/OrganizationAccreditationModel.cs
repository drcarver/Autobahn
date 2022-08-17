//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationAccreditationModel.cs
//* Name:       Accreditation Agency Name
//* Definition: The full name of an agency that accredited a school.
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The full name of an agency that accredited a school.
     /// </summary>
    public partial class OrganizationAccreditationModel : AutobahnBase, Interfaces.IOrganizationAccreditation
    {
        /// <summary>
        /// Accreditation Agency Name
        /// <para>
        /// The full name of an agency that accredited a school.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20500">Accreditation Agency Name</a>
        /// </para>
        /// </summary>
        public System.String AccreditationAgencyName { get; set; }

        /// <summary>
        /// Accreditation Award Date
        /// <para>
        /// The year, month and day when an accreditation was awarded.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19840">Accreditation Award Date</a>
        /// </para>
        /// </summary>
        public System.DateTime? AccreditationAwardDate { get; set; }

        /// <summary>
        /// Accreditation Expiration Date
        /// <para>
        /// The year, month and day when an accreditation expires.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19841">Accreditation Expiration Date</a>
        /// </para>
        /// </summary>
        public System.DateTime? AccreditationExpirationDate { get; set; }

        public System.Boolean? AccreditationStatus { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganization"/> model
        /// </summary>
        public Guid OrganizationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefAccreditationAgency"/> model
        /// </summary>
        public Guid? RefAccreditationAgencyId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefHigherEducationInstitutionAccreditationStatus"/> model
        /// </summary>
        public Guid? RefHigherEducationInstitutionAccreditationStatusId { get; set; }

        /// <summary>
        /// Organization Seeking Accreditation Date
        /// <para>
        /// The date in which accreditation process was started (but not officially approved or denied)
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20388">Organization Seeking Accreditation Date</a>
        /// </para>
        /// </summary>
        public System.DateTime? SeekingAccreditationDate { get; set; }

    }
}
