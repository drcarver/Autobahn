//**********************************************************
//* DomainName: Autobahn.Credentials
//* FileName:   RefCredentialDefIntendedPurposeType.cs
//**********************************************************

using Autobahn.Credentials.Interfaces;

namespace Autobahn.Credentials.Models
{
     /// <summary>
     /// The RefCredentialDefIntendedPurposeType
     /// </summary>
    public partial class RefCredentialDefIntendedPurposeType : IRefCredentialDefIntendedPurposeType
    {
        /// <summary>
        /// Defines the RefCredentialDefIntendedPurposeType.Description non nullable property
        /// </summary>
        public System.String Description { get; set; }

        /// <summary>
        /// Defines the RefCredentialDefIntendedPurposeType.Code non nullable property
        /// </summary>
        public System.String Code { get; set; }

        /// <summary>
        /// Defines the RefCredentialDefIntendedPurposeType.Definition non nullable property
        /// </summary>
        public System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        public Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefCredentialDefIntendedPurposeType.SortOrder nullable property
        /// </summary>
        public System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefCredentialDefIntendedPurposeType.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefCredentialDefIntendedPurposeType.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

    }
}
