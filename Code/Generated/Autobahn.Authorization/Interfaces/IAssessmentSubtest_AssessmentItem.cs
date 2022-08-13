//***************************************************************************
//* DomainName: Authentication and Authorization Interfaces (used by both models and View Models
//* FileName:   IAssessmentSubtest_AssessmentItem.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Authorization.Interfaces
{
     /// <summary>
     /// The IAssessmentSubtest_AssessmentItem Interface
     /// </summary>
    public partial interface IAssessmentSubtest_AssessmentItem : IAutobahnBase
    {
        /// <summary>
        /// A weighting factor for how the item score is used to compute a sub-test score when the item is correct or partially correct. Item weight of 1 indicates the full item score is used. A weight of .5 would indicate the item only contributes one half of the item score to the subtest. A weight of 0 indicates the item does not affect the sub test score.
        /// </summary>
        Guid AssessmentItemId { get; set; }

        /// <summary>
        /// A weighting factor for how the item score is used to compute a sub-test score when the item is correct or partially correct. Item weight of 1 indicates the full item score is used. A weight of .5 would indicate the item only contributes one half of the item score to the subtest. A weight of 0 indicates the item does not affect the sub test score.
        /// </summary>
        Guid AssessmentSubtestId { get; set; }

        /// <summary>
        /// A weighting factor for how the item score is used to compute a sub-test score when the item is correct or partially correct. Item weight of 1 indicates the full item score is used. A weight of .5 would indicate the item only contributes one half of the item score to the subtest. A weight of 0 indicates the item does not affect the sub test score.
        /// </summary>
        Guid AssessmentSubtestItemId { get; set; }

        /// <summary>
        /// A weighting factor for how the item score is used to compute a sub-test score when the item is correct or partially correct. Item weight of 1 indicates the full item score is used. A weight of .5 would indicate the item only contributes one half of the item score to the subtest. A weight of 0 indicates the item does not affect the sub test score.
        /// </summary>
        System.Decimal? ItemWeightCorrect { get; set; }

        /// <summary>
        /// A weighting factor for how the item score is used to compute a sub-test score when the item is correct or partially correct. Item weight of 1 indicates the full item score is used. A weight of .5 would indicate the item only contributes one half of the item score to the subtest. A weight of 0 indicates the item does not affect the sub test score.
        /// </summary>
        System.Decimal? ItemWeightIncorrect { get; set; }

        /// <summary>
        /// A weighting factor for how the item score is used to compute a sub-test score when the item is correct or partially correct. Item weight of 1 indicates the full item score is used. A weight of .5 would indicate the item only contributes one half of the item score to the subtest. A weight of 0 indicates the item does not affect the sub test score.
        /// </summary>
        System.Decimal? ItemWeightNotAttempted { get; set; }

    }
}
