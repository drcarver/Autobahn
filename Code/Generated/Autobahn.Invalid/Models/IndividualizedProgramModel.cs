//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   IndividualizedProgramModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Invalid.Models
{
     /// <summary>
     /// The IndividualizedProgram Model
     /// </summary>
    public partial class IndividualizedProgramModel : AutobahnBase, Interfaces.IIndividualizedProgram
    {
        /// <summary>
        /// 
        /// </summary>
        public  InclusionMinutesPerWeek { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  InclusiveSettingIndicator { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  IndividualizedProgramDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  NonInclusionMinutesPerWeek { get; set; }

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
        public  RefIndividualizedProgramDateType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefIndividualizedProgramLocationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefIndividualizedProgramTransitionTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefIndividualizedProgramTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? RefStudentSupportServiceTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  ServicePlanDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  ServicePlanEndDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  ServicePlanMeetingParticipants { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  ServicePlanReevaluationDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  ServicePlanSignatureDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  ServicePlanSignedBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  TransferOfRightsStatement { get; set; }

    }
}
