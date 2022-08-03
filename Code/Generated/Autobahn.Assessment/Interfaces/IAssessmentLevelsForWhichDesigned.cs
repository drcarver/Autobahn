//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   IAssessmentLevelsForWhichDesigned.cs
//**********************************************************

namespace Autobahn.Assessment.Interfaces
{
     /// <summary>
     /// The IAssessmentLevelsForWhichDesigned
     /// </summary>
    public partial interface IAssessmentLevelsForWhichDesigned
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Assessment"/> model
        /// </summary>
        Guid AssessmentId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefGradeLevel"/> model
        /// </summary>
        Guid RefGradeLevelId { get; set; }

        /// <summary>
        /// Defines the AssessmentLevelsForWhichDesigned.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the AssessmentLevelsForWhichDesigned.RecordEndDateTime nullable property
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
