//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   IAssessmentNeedScreenEnhancement.cs
//**********************************************************

namespace Autobahn.Assessment.Interfaces
{
     /// <summary>
     /// The IAssessmentNeedScreenEnhancement
     /// </summary>
    public partial interface IAssessmentNeedScreenEnhancement
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentPersonalNeedsProfileDisplay"/> model
        /// </summary>
        Guid AssessmentPersonalNeedsProfileDisplayId { get; set; }

        /// <summary>
        /// Defines the AssessmentNeedScreenEnhancement.InvertColorChoice nullable property
        /// </summary>
        System.Boolean? InvertColorChoice { get; set; }

        /// <summary>
        /// Defines the AssessmentNeedScreenEnhancement.Magnification nullable property
        /// </summary>
        System.Decimal? Magnification { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="AssessmentPersonalNeedsProfileScreenEnhancement"/> model
        /// </summary>
        Guid? AssessmentPersonalNeedsProfileScreenEnhancementId { get; set; }

        /// <summary>
        /// Defines the AssessmentNeedScreenEnhancement.ForegroundColor non nullable property
        /// </summary>
        System.String ForegroundColor { get; set; }

        /// <summary>
        /// Defines the AssessmentNeedScreenEnhancement.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the AssessmentNeedScreenEnhancement.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatus"/> model
        /// </summary>
        Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        Guid? DataCollectionId { get; set; }

    }
}
