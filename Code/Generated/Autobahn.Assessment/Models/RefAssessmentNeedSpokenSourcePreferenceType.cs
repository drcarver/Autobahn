//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   RefAssessmentNeedSpokenSourcePreferenceType.cs
//**********************************************************

using Autobahn.Assessment.Interfaces;

namespace Autobahn.Assessment.Models
{
     /// <summary>
     /// The RefAssessmentNeedSpokenSourcePreferenceType
     /// </summary>
    public partial class RefAssessmentNeedSpokenSourcePreferenceType : IRefAssessmentNeedSpokenSourcePreferenceType
    {
        /// <summary>
        /// Defines the RefAssessmentNeedSpokenSourcePreferenceType.Description non nullable property
        /// </summary>
        public System.String Description { get; set; }

        /// <summary>
        /// Defines the RefAssessmentNeedSpokenSourcePreferenceType.Code non nullable property
        /// </summary>
        public System.String Code { get; set; }

        /// <summary>
        /// Defines the RefAssessmentNeedSpokenSourcePreferenceType.Definition non nullable property
        /// </summary>
        public System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        public Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefAssessmentNeedSpokenSourcePreferenceType.SortOrder nullable property
        /// </summary>
        public System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefAssessmentNeedSpokenSourcePreferenceType.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefAssessmentNeedSpokenSourcePreferenceType.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

    }
}
