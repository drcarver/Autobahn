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
        /// 
        /// </summary>
         CredentialName { get; set; }

        /// <summary>
        /// 
        /// </summary>
         CredentialOrLicenseAwardEntity { get; set; }

        /// <summary>
        /// 
        /// </summary>
        Guid? ExpirationDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
         IssuanceDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
         ProfessionalCertificateOrLicenseNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordStartDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefCredentialTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefIssuingStateId { get; set; }

    }
}
