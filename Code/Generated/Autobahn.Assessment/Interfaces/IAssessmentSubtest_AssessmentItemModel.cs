//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   IAssessmentSubtest_AssessmentItemModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Assessment.Interfaces
{
     /// <summary>
     /// The IAssessmentSubtest_AssessmentItemModel Interface
     /// </summary>
    public partial interface IAssessmentSubtest_AssessmentItemModel : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentSubtestItem"/> model
        /// </summary>
        Guid AssessmentSubtestItemId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentSubtest"/> model
        /// </summary>
        Guid AssessmentSubtestId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentItem"/> model
        /// </summary>
        Guid AssessmentItemId { get; set; }

        /// <summary>
        /// Defines the AssessmentSubtest_AssessmentItem.ItemWeightCorrect nullable property
        /// </summary>
        System.Decimal? ItemWeightCorrect { get; set; }

        /// <summary>
        /// Defines the AssessmentSubtest_AssessmentItem.ItemWeightIncorrect nullable property
        /// </summary>
        System.Decimal? ItemWeightIncorrect { get; set; }

        /// <summary>
        /// Defines the AssessmentSubtest_AssessmentItem.ItemWeightNotAttempted nullable property
        /// </summary>
        System.Decimal? ItemWeightNotAttempted { get; set; }

    }
}
