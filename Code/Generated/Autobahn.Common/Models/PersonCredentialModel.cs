//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonCredentialModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The PersonCredential Model
     /// </summary>
    public partial class PersonCredentialModel : AutobahnBase, Interfaces.IPersonCredential
    {
        /// <summary>
        /// The year, month and day on which an active credential held by a person will expire.
        /// </summary>
        public System.String CredentialName { get; set; }

        /// <summary>
        /// The year, month and day on which an active credential held by a person will expire.
        /// </summary>
        public System.String CredentialOrLicenseAwardEntity { get; set; }

        /// <summary>
        /// The year, month and day on which an active credential held by a person will expire.
        /// </summary>
        public System.DateTime? ExpirationDate { get; set; }

        /// <summary>
        /// The year, month and day on which an active credential held by a person will expire.
        /// </summary>
        public System.DateTime? IssuanceDate { get; set; }

        /// <summary>
        /// The year, month and day on which an active credential held by a person will expire.
        /// </summary>
        public Guid PersonId { get; set; }

        /// <summary>
        /// The year, month and day on which an active credential held by a person will expire.
        /// </summary>
        public System.String ProfessionalCertificateOrLicenseNumber { get; set; }

        /// <summary>
        /// The year, month and day on which an active credential held by a person will expire.
        /// </summary>
        public Guid? RefCredentialTypeId { get; set; }

        /// <summary>
        /// The year, month and day on which an active credential held by a person will expire.
        /// </summary>
        public Guid? RefIssuingStateId { get; set; }

    }
}
