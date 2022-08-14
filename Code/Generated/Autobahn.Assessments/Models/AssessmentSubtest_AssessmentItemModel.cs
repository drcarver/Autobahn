//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentSubtest_AssessmentItemModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Assessments.Models
{
     /// <summary>
     /// The AssessmentSubtest_AssessmentItem Model
     /// </summary>
    public partial class AssessmentSubtest_AssessmentItemModel : AutobahnBase, Interfaces.IAssessmentSubtest_AssessmentItem
    {
        /// <summary>
        /// A weighting factor for how the item score is used to compute a sub-test score when the item is correct or partially correct. Item weight of 1 indicates the full item score is used. A weight of .5 would indicate the item only contributes one half of the item score to the subtest. A weight of 0 indicates the item does not affect the sub test score.
        /// </summary>
        public Guid AssessmentItemId { get; set; }

        /// <summary>
        /// A weighting factor for how the item score is used to compute a sub-test score when the item is correct or partially correct. Item weight of 1 indicates the full item score is used. A weight of .5 would indicate the item only contributes one half of the item score to the subtest. A weight of 0 indicates the item does not affect the sub test score.
        /// </summary>
        public Guid AssessmentSubtestId { get; set; }

        /// <summary>
        /// A weighting factor for how the item score is used to compute a sub-test score when the item is correct or partially correct. Item weight of 1 indicates the full item score is used. A weight of .5 would indicate the item only contributes one half of the item score to the subtest. A weight of 0 indicates the item does not affect the sub test score.
        /// </summary>
        public Guid AssessmentSubtestItemId { get; set; }

        /// <summary>
        /// A weighting factor for how the item score is used to compute a sub-test score when the item is correct or partially correct. Item weight of 1 indicates the full item score is used. A weight of .5 would indicate the item only contributes one half of the item score to the subtest. A weight of 0 indicates the item does not affect the sub test score.
        /// </summary>
        public System.Decimal? ItemWeightCorrect { get; set; }

        /// <summary>
        /// A weighting factor for how the item score is used to compute a sub-test score when the item is correct or partially correct. Item weight of 1 indicates the full item score is used. A weight of .5 would indicate the item only contributes one half of the item score to the subtest. A weight of 0 indicates the item does not affect the sub test score.
        /// </summary>
        public System.Decimal? ItemWeightIncorrect { get; set; }

        /// <summary>
        /// A weighting factor for how the item score is used to compute a sub-test score when the item is correct or partially correct. Item weight of 1 indicates the full item score is used. A weight of .5 would indicate the item only contributes one half of the item score to the subtest. A weight of 0 indicates the item does not affect the sub test score.
        /// </summary>
        public System.Decimal? ItemWeightNotAttempted { get; set; }

    }
}
