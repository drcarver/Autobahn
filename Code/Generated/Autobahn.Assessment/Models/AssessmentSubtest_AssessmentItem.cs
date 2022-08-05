//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentSubtest_AssessmentItem.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Assessment.Models
{
     /// <summary>
     /// The AssessmentSubtest_AssessmentItem
     /// </summary>
    public partial class AssessmentSubtest_AssessmentItem : AutobahnBase, Interfaces.IAssessmentSubtest_AssessmentItem
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentSubtestItem"/> model
        /// </summary>
        public Guid AssessmentSubtestItemId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentSubtest"/> model
        /// </summary>
        public Guid AssessmentSubtestId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentItem"/> model
        /// </summary>
        public Guid AssessmentItemId { get; set; }

        /// <summary>
        /// Defines the AssessmentSubtest_AssessmentItem.ItemWeightCorrect nullable property
        /// </summary>
        public System.Decimal? ItemWeightCorrect { get; set; }

        /// <summary>
        /// Defines the AssessmentSubtest_AssessmentItem.ItemWeightIncorrect nullable property
        /// </summary>
        public System.Decimal? ItemWeightIncorrect { get; set; }

        /// <summary>
        /// Defines the AssessmentSubtest_AssessmentItem.ItemWeightNotAttempted nullable property
        /// </summary>
        public System.Decimal? ItemWeightNotAttempted { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
