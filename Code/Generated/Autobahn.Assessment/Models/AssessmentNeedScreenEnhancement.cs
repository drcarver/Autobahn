//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentNeedScreenEnhancement.cs
//**********************************************************

using Autobahn.Assessment.Interfaces;

namespace Autobahn.Assessment.Models
{
     /// <summary>
     /// The AssessmentNeedScreenEnhancement
     /// </summary>
    public partial class AssessmentNeedScreenEnhancement : IAssessmentNeedScreenEnhancement
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentPersonalNeedsProfileDisplay"/> model
        /// </summary>
        public Guid AssessmentPersonalNeedsProfileDisplayId { get; set; }

        /// <summary>
        /// Defines the AssessmentNeedScreenEnhancement.InvertColorChoice nullable property
        /// </summary>
        public System.Boolean? InvertColorChoice { get; set; }

        /// <summary>
        /// Defines the AssessmentNeedScreenEnhancement.Magnification nullable property
        /// </summary>
        public System.Decimal? Magnification { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="AssessmentPersonalNeedsProfileScreenEnhancement"/> model
        /// </summary>
        public Guid? AssessmentPersonalNeedsProfileScreenEnhancementId { get; set; }

        /// <summary>
        /// Defines the AssessmentNeedScreenEnhancement.ForegroundColor non nullable property
        /// </summary>
        public System.String ForegroundColor { get; set; }

        /// <summary>
        /// Defines the AssessmentNeedScreenEnhancement.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the AssessmentNeedScreenEnhancement.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatus"/> model
        /// </summary>
        public Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
