//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentSubtestAssessmentItemModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Assessments.Models
{
     /// <summary>
     /// The AssessmentSubtestAssessmentItem Model
     /// </summary>
    public partial class AssessmentSubtestAssessmentItemModel : AutobahnBase, Interfaces.IAssessmentSubtestAssessmentItem
    {
        /// <summary>
        /// A weighting factor for how the item score is used to compute a sub-test score when the item is correct or partially correct. Item weight of 1 indicates the full item score is used. A weight of .5 would indicate the item only contributes one half of the item score to the subtest. A weight of 0 indicates the item does not affect the sub test score.
        /// </summary>
        public System.Decimal? ItemWeightCorrect { get; set; }

    }
}
