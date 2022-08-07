//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   PersonCredentialModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The PersonCredential Model
     /// </summary>
    public partial class PersonCredentialModel : AutobahnBase, Interfaces.IPersonCredentialModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Person"/> model
        /// </summary>
        public Guid PersonId { get; set; }

        /// <summary>
        /// Defines the PersonCredential.CredentialName non nullable property
        /// </summary>
        public System.String CredentialName { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCredentialType"/> model
        /// </summary>
        public Guid? RefCredentialTypeId { get; set; }

        /// <summary>
        /// Defines the PersonCredential.IssuanceDate nullable property
        /// </summary>
        public System.DateTime? IssuanceDate { get; set; }

        /// <summary>
        /// Defines the PersonCredential.ExpirationDate nullable property
        /// </summary>
        public System.DateTime? ExpirationDate { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIssuingState"/> model
        /// </summary>
        public Guid? RefIssuingStateId { get; set; }

        /// <summary>
        /// Defines the PersonCredential.ProfessionalCertificateOrLicenseNumber non nullable property
        /// </summary>
        public System.String ProfessionalCertificateOrLicenseNumber { get; set; }

        /// <summary>
        /// Defines the PersonCredential.CredentialOrLicenseAwardEntity non nullable property
        /// </summary>
        public System.String CredentialOrLicenseAwardEntity { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
