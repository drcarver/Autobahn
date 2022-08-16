//**********************************************************
//* DomainName: Adult Education (AE)
//* FileName:   ProgramParticipationAEModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.AdultEducation.Models
{
     /// <summary>
     /// The ProgramParticipationAE Model
     /// </summary>
    public partial class ProgramParticipationAEModel : AutobahnBase, Interfaces.IProgramParticipationAE
    {
        /// <summary>
        /// 
        /// </summary>
        public Guid? DisplacedHomemakerIndicator { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  InstructionalActivityHoursCompleted { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  OutOfWorkforceIndicator { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  PostsecondaryTransitionDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  ProxyContactHours { get; set; }

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
        public  RefAdultEducationProgramExitReasonId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefAeFunctioningLevelAtIntakeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefAeFunctioningLevelAtPosttestId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefAeInstructionalProgramTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefAePostsecondaryTransitionActionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefAeSpecialProgramTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefCorrectionalEducationFacilityTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefGoalsForAttendingAdultEducationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefWorkbasedLearningOpportunityTypeId { get; set; }

    }
}
