//**********************************************************
//* DomainName: Autobahn.Credentials
//* FileName:   IRefCredentialDefAssessMethodType.cs
//**********************************************************

namespace Autobahn.Credentials.Interfaces
{
     /// <summary>
     /// The IRefCredentialDefAssessMethodType
     /// </summary>
    public partial interface IRefCredentialDefAssessMethodType
    {
        /// <summary>
        /// Defines the RefCredentialDefAssessMethodType.Description non nullable property
        /// </summary>
        System.String Description { get; set; }

        /// <summary>
        /// Defines the RefCredentialDefAssessMethodType.Code non nullable property
        /// </summary>
        System.String Code { get; set; }

        /// <summary>
        /// Defines the RefCredentialDefAssessMethodType.Definition non nullable property
        /// </summary>
        System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefCredentialDefAssessMethodType.SortOrder nullable property
        /// </summary>
        System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefCredentialDefAssessMethodType.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefCredentialDefAssessMethodType.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

    }
}
