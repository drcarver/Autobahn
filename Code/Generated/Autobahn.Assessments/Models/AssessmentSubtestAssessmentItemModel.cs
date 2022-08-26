//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentSubtestAssessmentItemModel.cs
//***************************************************************************

using Autobahn.Interfaces.Assessments;
using Autobahn.Interfaces.Common;
using Autobahn.Common.Models;

namespace Autobahn.Assessments.Models
{
     /// <summary>
     /// The AssessmentSubtestAssessmentItem Model
     /// </summary>
    public partial class AssessmentSubtestAssessmentItemModel : AutobahnBase, IAssessmentSubtestAssessmentItem
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IAssessmentItem"/> model
        /// </summary>
        public Guid AssessmentItemId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IAssessmentSubtest"/> model
        /// </summary>
        public Guid AssessmentSubtestId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IAssessmentSubtestItem"/> model
        /// </summary>
        public Guid AssessmentSubtestItemId { get; set; }

        public Decimal? ItemWeightCorrect { get; set; }

        public Decimal? ItemWeightIncorrect { get; set; }

        public Decimal? ItemWeightNotAttempted { get; set; }

    }
}
