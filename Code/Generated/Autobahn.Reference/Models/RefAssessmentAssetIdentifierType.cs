//**********************************************************
//* DomainName: Autobahn.Reference
//* FileName:   RefAssessmentAssetIdentifierType.cs
//**********************************************************

using Autobahn.Reference.Interfaces;

namespace Autobahn.Reference.Models
{
     /// <summary>
     /// The RefAssessmentAssetIdentifierType
     /// </summary>
    public partial class RefAssessmentAssetIdentifierType : IRefAssessmentAssetIdentifierType
    {
        /// <summary>
        /// Defines the RefAssessmentAssetIdentifierType.Description non nullable property
        /// </summary>
        public System.String Description { get; set; }

        /// <summary>
        /// Defines the RefAssessmentAssetIdentifierType.Code non nullable property
        /// </summary>
        public System.String Code { get; set; }

        /// <summary>
        /// Defines the RefAssessmentAssetIdentifierType.Definition non nullable property
        /// </summary>
        public System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        public Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefAssessmentAssetIdentifierType.SortOrder nullable property
        /// </summary>
        public System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefAssessmentAssetIdentifierType.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefAssessmentAssetIdentifierType.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

    }
}
