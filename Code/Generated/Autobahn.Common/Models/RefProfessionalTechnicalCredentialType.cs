//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefProfessionalTechnicalCredentialType.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The RefProfessionalTechnicalCredentialType
     /// </summary>
    public partial class RefProfessionalTechnicalCredentialType : IRefProfessionalTechnicalCredentialType
    {
        /// <summary>
        /// Defines the RefProfessionalTechnicalCredentialType.Description non nullable property
        /// </summary>
        public System.String Description { get; set; }

        /// <summary>
        /// Defines the RefProfessionalTechnicalCredentialType.Code non nullable property
        /// </summary>
        public System.String Code { get; set; }

        /// <summary>
        /// Defines the RefProfessionalTechnicalCredentialType.Definition non nullable property
        /// </summary>
        public System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        public Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefProfessionalTechnicalCredentialType.SortOrder nullable property
        /// </summary>
        public System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefProfessionalTechnicalCredentialType.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefProfessionalTechnicalCredentialType.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

    }
}
