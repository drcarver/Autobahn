//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   IAssessmentNeedScreenEnhancementModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Assessment.Interfaces
{
     /// <summary>
     /// The IAssessmentNeedScreenEnhancementModel Interface
     /// </summary>
    public partial interface IAssessmentNeedScreenEnhancementModel : IAutobahnBase
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

    }
}
