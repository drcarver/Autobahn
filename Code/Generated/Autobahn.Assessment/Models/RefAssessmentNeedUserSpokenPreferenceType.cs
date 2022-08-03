//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   RefAssessmentNeedUserSpokenPreferenceType.cs
//**********************************************************

using Autobahn.Assessment.Interfaces;

namespace Autobahn.Assessment.Models
{
     /// <summary>
     /// The RefAssessmentNeedUserSpokenPreferenceType
     /// </summary>
    public partial class RefAssessmentNeedUserSpokenPreferenceType : IRefAssessmentNeedUserSpokenPreferenceType
    {
        /// <summary>
        /// Defines the RefAssessmentNeedUserSpokenPreferenceType.Description non nullable property
        /// </summary>
        public System.String Description { get; set; }

        /// <summary>
        /// Defines the RefAssessmentNeedUserSpokenPreferenceType.Code non nullable property
        /// </summary>
        public System.String Code { get; set; }

        /// <summary>
        /// Defines the RefAssessmentNeedUserSpokenPreferenceType.Definition non nullable property
        /// </summary>
        public System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        public Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefAssessmentNeedUserSpokenPreferenceType.SortOrder nullable property
        /// </summary>
        public System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefAssessmentNeedUserSpokenPreferenceType.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefAssessmentNeedUserSpokenPreferenceType.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

    }
}
