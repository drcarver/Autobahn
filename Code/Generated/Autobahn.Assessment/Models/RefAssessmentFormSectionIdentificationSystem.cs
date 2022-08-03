//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   RefAssessmentFormSectionIdentificationSystem.cs
//**********************************************************

using Autobahn.Assessment.Interfaces;

namespace Autobahn.Assessment.Models
{
     /// <summary>
     /// The RefAssessmentFormSectionIdentificationSystem
     /// </summary>
    public partial class RefAssessmentFormSectionIdentificationSystem : IRefAssessmentFormSectionIdentificationSystem
    {
        /// <summary>
        /// Defines the RefAssessmentFormSectionIdentificationSystem.Description non nullable property
        /// </summary>
        public System.String Description { get; set; }

        /// <summary>
        /// Defines the RefAssessmentFormSectionIdentificationSystem.Code non nullable property
        /// </summary>
        public System.String Code { get; set; }

        /// <summary>
        /// Defines the RefAssessmentFormSectionIdentificationSystem.Definition non nullable property
        /// </summary>
        public System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        public Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefAssessmentFormSectionIdentificationSystem.SortOrder nullable property
        /// </summary>
        public System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefAssessmentFormSectionIdentificationSystem.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefAssessmentFormSectionIdentificationSystem.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

    }
}
