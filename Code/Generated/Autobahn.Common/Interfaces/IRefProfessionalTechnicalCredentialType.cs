//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IRefProfessionalTechnicalCredentialType.cs
//**********************************************************

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IRefProfessionalTechnicalCredentialType
     /// </summary>
    public partial interface IRefProfessionalTechnicalCredentialType
    {
        /// <summary>
        /// Defines the RefProfessionalTechnicalCredentialType.Description non nullable property
        /// </summary>
        System.String Description { get; set; }

        /// <summary>
        /// Defines the RefProfessionalTechnicalCredentialType.Code non nullable property
        /// </summary>
        System.String Code { get; set; }

        /// <summary>
        /// Defines the RefProfessionalTechnicalCredentialType.Definition non nullable property
        /// </summary>
        System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefProfessionalTechnicalCredentialType.SortOrder nullable property
        /// </summary>
        System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefProfessionalTechnicalCredentialType.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefProfessionalTechnicalCredentialType.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

    }
}
