//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentRegistrationModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Assessments.Models
{
     /// <summary>
     /// The AssessmentRegistration Model
     /// </summary>
    public partial class AssessmentRegistrationModel : AutobahnBase, Interfaces.IAssessmentRegistration
    {
        /// <summary>
        /// 
        /// </summary>
        public  AssessmentRegistrationCompletionStatusDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  AssignedByPersonId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  CreationDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  DaysOfInstructionPriorToAssessment { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  LEAFullAcademicYear { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordStartDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? RefAssessmentParticipationIndicatorId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefAssessmentPurposeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefAssessmentReasonNotCompletingId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefAssessmentReasonNotTestedId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefAssessmentRegistrationCompletionStatusId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefGradeLevelToBeAssessedId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefGradeLevelWhenAssessedId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RetestIndicator { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  SchoolFullAcademicYear { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  ScorePublishDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  StateFullAcademicYear { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  TestAttemptIdentifier { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  TestingIndicator { get; set; }

    }
}
