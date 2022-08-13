//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IPersonCredential.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IPersonCredential Interface
     /// </summary>
    public partial interface IPersonCredential : IAutobahnBase
    {
        /// <summary>
        /// The year, month and day on which an active credential held by a person will expire.
        /// </summary>
        System.String CredentialName { get; set; }

        /// <summary>
        /// The year, month and day on which an active credential held by a person will expire.
        /// </summary>
        System.String CredentialOrLicenseAwardEntity { get; set; }

        /// <summary>
        /// The year, month and day on which an active credential held by a person will expire.
        /// </summary>
        System.DateTime? ExpirationDate { get; set; }

        /// <summary>
        /// The year, month and day on which an active credential held by a person will expire.
        /// </summary>
        System.DateTime? IssuanceDate { get; set; }

        /// <summary>
        /// The year, month and day on which an active credential held by a person will expire.
        /// </summary>
        Guid PersonId { get; set; }

        /// <summary>
        /// The year, month and day on which an active credential held by a person will expire.
        /// </summary>
        System.String ProfessionalCertificateOrLicenseNumber { get; set; }

        /// <summary>
        /// The year, month and day on which an active credential held by a person will expire.
        /// </summary>
        Guid? RefCredentialTypeId { get; set; }

        /// <summary>
        /// The year, month and day on which an active credential held by a person will expire.
        /// </summary>
        Guid? RefIssuingStateId { get; set; }

    }
}
