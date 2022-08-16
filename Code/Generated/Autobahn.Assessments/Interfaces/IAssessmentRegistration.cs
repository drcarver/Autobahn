//***************************************************************************
//* DomainName: Assessments Interfaces (used by both models and View Models
//* FileName:   IAssessmentRegistration.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Assessments.Interfaces
{
     /// <summary>
     /// The IAssessmentRegistration Interface
     /// </summary>
    public partial interface IAssessmentRegistration : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
         AssessmentRegistrationCompletionStatusDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
         AssignedByPersonId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         CreationDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
         DaysOfInstructionPriorToAssessment { get; set; }

        /// <summary>
        /// 
        /// </summary>
         LEAFullAcademicYear { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordStartDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        Guid? RefAssessmentParticipationIndicatorId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefAssessmentPurposeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefAssessmentReasonNotCompletingId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefAssessmentReasonNotTestedId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefAssessmentRegistrationCompletionStatusId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefGradeLevelToBeAssessedId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefGradeLevelWhenAssessedId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RetestIndicator { get; set; }

        /// <summary>
        /// 
        /// </summary>
         SchoolFullAcademicYear { get; set; }

        /// <summary>
        /// 
        /// </summary>
         ScorePublishDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
         StateFullAcademicYear { get; set; }

        /// <summary>
        /// 
        /// </summary>
         TestAttemptIdentifier { get; set; }

        /// <summary>
        /// 
        /// </summary>
         TestingIndicator { get; set; }

    }
}
