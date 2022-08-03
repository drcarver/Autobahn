//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   RefAssessmentNeedLinkIndicationType.cs
//**********************************************************

using Autobahn.Assessment.Interfaces;

namespace Autobahn.Assessment.Models
{
     /// <summary>
     /// The RefAssessmentNeedLinkIndicationType
     /// </summary>
    public partial class RefAssessmentNeedLinkIndicationType : IRefAssessmentNeedLinkIndicationType
    {
        /// <summary>
        /// Defines the RefAssessmentNeedLinkIndicationType.Description non nullable property
        /// </summary>
        public System.String Description { get; set; }

        /// <summary>
        /// Defines the RefAssessmentNeedLinkIndicationType.Code non nullable property
        /// </summary>
        public System.String Code { get; set; }

        /// <summary>
        /// Defines the RefAssessmentNeedLinkIndicationType.Definition non nullable property
        /// </summary>
        public System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        public Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefAssessmentNeedLinkIndicationType.SortOrder nullable property
        /// </summary>
        public System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefAssessmentNeedLinkIndicationType.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefAssessmentNeedLinkIndicationType.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

    }
}
