//***************************************************************************
//* DomainName: Assessments Interfaces (used by both models and View Models
//* FileName:   IAssessmentSubtestAssessmentItem.cs
//***************************************************************************

using Autobahn.Interfaces.Common;

namespace Autobahn.Interfaces.Assessments
{
     /// <summary>
     /// The IAssessmentSubtestAssessmentItem Interface
     /// </summary>
    public partial interface IAssessmentSubtestAssessmentItem : IAutobahnBase
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IAssessmentItem"/> model
        /// </summary>
        Guid AssessmentItemId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IAssessmentSubtest"/> model
        /// </summary>
        Guid AssessmentSubtestId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IAssessmentSubtestItem"/> model
        /// </summary>
        Guid AssessmentSubtestItemId { get; set; }

        Decimal? ItemWeightCorrect { get; set; }

        Decimal? ItemWeightIncorrect { get; set; }

        Decimal? ItemWeightNotAttempted { get; set; }

    }
}
