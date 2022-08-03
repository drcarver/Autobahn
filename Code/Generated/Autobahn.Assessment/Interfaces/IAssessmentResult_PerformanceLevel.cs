//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   IAssessmentResult_PerformanceLevel.cs
//**********************************************************

namespace Autobahn.Assessment.Interfaces
{
     /// <summary>
     /// The IAssessmentResult_PerformanceLevel
     /// </summary>
    public partial interface IAssessmentResult_PerformanceLevel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentResult"/> model
        /// </summary>
        Guid AssessmentResultId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentPerformanceLevel"/> model
        /// </summary>
        Guid AssessmentPerformanceLevelId { get; set; }

        /// <summary>
        /// Defines the AssessmentResult_PerformanceLevel.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the AssessmentResult_PerformanceLevel.RecordEndDateTime nullable property
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
