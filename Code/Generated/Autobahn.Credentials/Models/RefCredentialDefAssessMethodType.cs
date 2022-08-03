//**********************************************************
//* DomainName: Autobahn.Credentials
//* FileName:   RefCredentialDefAssessMethodType.cs
//**********************************************************

using Autobahn.Credentials.Interfaces;

namespace Autobahn.Credentials.Models
{
     /// <summary>
     /// The RefCredentialDefAssessMethodType
     /// </summary>
    public partial class RefCredentialDefAssessMethodType : IRefCredentialDefAssessMethodType
    {
        /// <summary>
        /// Defines the RefCredentialDefAssessMethodType.Description non nullable property
        /// </summary>
        public System.String Description { get; set; }

        /// <summary>
        /// Defines the RefCredentialDefAssessMethodType.Code non nullable property
        /// </summary>
        public System.String Code { get; set; }

        /// <summary>
        /// Defines the RefCredentialDefAssessMethodType.Definition non nullable property
        /// </summary>
        public System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        public Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefCredentialDefAssessMethodType.SortOrder nullable property
        /// </summary>
        public System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefCredentialDefAssessMethodType.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefCredentialDefAssessMethodType.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

    }
}
