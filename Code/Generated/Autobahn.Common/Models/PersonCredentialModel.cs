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
        /// 
        /// </summary>
        public  CredentialName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  CredentialOrLicenseAwardEntity { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? ExpirationDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  IssuanceDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  ProfessionalCertificateOrLicenseNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordStartDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefCredentialTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefIssuingStateId { get; set; }

    }
}
