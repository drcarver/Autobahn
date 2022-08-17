//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonCredentialModel.cs
//* Name:       Name of Professional Credential or License
//* Definition: The name of the license/credential awarded by a given profession.
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The name of the license/credential awarded by a given profession.
     /// </summary>
    public partial class PersonCredentialModel : AutobahnBase, Interfaces.IPersonCredential
    {
        /// <summary>
        /// Name of Professional Credential or License
        /// <para>
        /// The name of the license/credential awarded by a given profession.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20064">Name of Professional Credential or License</a>
        /// </para>
        /// </summary>
        public System.String CredentialName { get; set; }

        /// <summary>
        /// Credential or License Award Entity
        /// <para>
        /// The name of the organization awarding the individual's credential or license.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20566">Credential or License Award Entity</a>
        /// </para>
        /// </summary>
        public System.String CredentialOrLicenseAwardEntity { get; set; }

        /// <summary>
        /// Credential Expiration Date
        /// <para>
        /// The year, month and day on which an active credential held by a person will expire.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19069">Credential Expiration Date</a>
        /// </para>
        /// </summary>
        public System.DateTime? ExpirationDate { get; set; }

        /// <summary>
        /// Credential Issuance Date
        /// <para>
        /// The year, month and day on which an active credential was issued to a person.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19070">Credential Issuance Date</a>
        /// </para>
        /// </summary>
        public System.DateTime? IssuanceDate { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IPerson"/> model
        /// </summary>
        public Guid PersonId { get; set; }

        /// <summary>
        /// Professional Certificate or License Number
        /// <para>
        /// The number issued by the credentialing/licensing agency.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20398">Professional Certificate or License Number</a>
        /// </para>
        /// </summary>
        public System.String ProfessionalCertificateOrLicenseNumber { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefCredentialType"/> model
        /// </summary>
        public Guid? RefCredentialTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefIssuingState"/> model
        /// </summary>
        public Guid? RefIssuingStateId { get; set; }

    }
}
