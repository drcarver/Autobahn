//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   IAssessmentSubtestLevelsForWhichDesigned.cs
//**********************************************************

namespace Autobahn.Assessment.Interfaces
{
     /// <summary>
     /// The IAssessmentSubtestLevelsForWhichDesigned
     /// </summary>
    public partial interface IAssessmentSubtestLevelsForWhichDesigned
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentSubTest"/> model
        /// </summary>
        Guid AssessmentSubTestId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefGrade"/> model
        /// </summary>
        Guid RefGradeId { get; set; }

        /// <summary>
        /// Defines the AssessmentSubtestLevelsForWhichDesigned.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the AssessmentSubtestLevelsForWhichDesigned.RecordEndDateTime nullable property
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
