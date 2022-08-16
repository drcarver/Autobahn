//***************************************************************************
//* DomainName: Adult Education (AE) Interfaces (used by both models and View Models
//* FileName:   IProgramParticipationAE.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.AdultEducation.Interfaces
{
     /// <summary>
     /// The IProgramParticipationAE Interface
     /// </summary>
    public partial interface IProgramParticipationAE : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
        Guid? DisplacedHomemakerIndicator { get; set; }

        /// <summary>
        /// 
        /// </summary>
         InstructionalActivityHoursCompleted { get; set; }

        /// <summary>
        /// 
        /// </summary>
         OutOfWorkforceIndicator { get; set; }

        /// <summary>
        /// 
        /// </summary>
         PostsecondaryTransitionDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
         ProxyContactHours { get; set; }

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
         RefAdultEducationProgramExitReasonId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefAeFunctioningLevelAtIntakeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefAeFunctioningLevelAtPosttestId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefAeInstructionalProgramTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefAePostsecondaryTransitionActionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefAeSpecialProgramTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefCorrectionalEducationFacilityTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefGoalsForAttendingAdultEducationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefWorkbasedLearningOpportunityTypeId { get; set; }

    }
}
