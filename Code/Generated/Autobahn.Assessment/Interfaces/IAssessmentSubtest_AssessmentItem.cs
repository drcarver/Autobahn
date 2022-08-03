//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   IAssessmentSubtest_AssessmentItem.cs
//**********************************************************

namespace Autobahn.Assessment.Interfaces
{
     /// <summary>
     /// The IAssessmentSubtest_AssessmentItem
     /// </summary>
    public partial interface IAssessmentSubtest_AssessmentItem
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

        /// <summary>
        /// Defines the AssessmentSubtest_AssessmentItem.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the AssessmentSubtest_AssessmentItem.RecordEndDateTime nullable property
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
