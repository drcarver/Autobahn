//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IPersonCredential.cs
//**********************************************************

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IPersonCredential
     /// </summary>
    public partial interface IPersonCredential
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Person"/> model
        /// </summary>
        Guid PersonId { get; set; }

        /// <summary>
        /// Defines the PersonCredential.CredentialName non nullable property
        /// </summary>
        System.String CredentialName { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCredentialType"/> model
        /// </summary>
        Guid? RefCredentialTypeId { get; set; }

        /// <summary>
        /// Defines the PersonCredential.IssuanceDate nullable property
        /// </summary>
        System.DateTime? IssuanceDate { get; set; }

        /// <summary>
        /// Defines the PersonCredential.ExpirationDate nullable property
        /// </summary>
        System.DateTime? ExpirationDate { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIssuingState"/> model
        /// </summary>
        Guid? RefIssuingStateId { get; set; }

        /// <summary>
        /// Defines the PersonCredential.ProfessionalCertificateOrLicenseNumber non nullable property
        /// </summary>
        System.String ProfessionalCertificateOrLicenseNumber { get; set; }

        /// <summary>
        /// Defines the PersonCredential.CredentialOrLicenseAwardEntity non nullable property
        /// </summary>
        System.String CredentialOrLicenseAwardEntity { get; set; }

        /// <summary>
        /// Defines the PersonCredential.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the PersonCredential.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

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
