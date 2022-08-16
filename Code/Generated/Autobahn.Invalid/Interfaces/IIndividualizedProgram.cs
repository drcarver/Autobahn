//***************************************************************************
//* DomainName: Invalid or Unreferenced Models Interfaces (used by both models and View Models
//* FileName:   IIndividualizedProgram.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Invalid.Interfaces
{
     /// <summary>
     /// The IIndividualizedProgram Interface
     /// </summary>
    public partial interface IIndividualizedProgram : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
         InclusionMinutesPerWeek { get; set; }

        /// <summary>
        /// 
        /// </summary>
         InclusiveSettingIndicator { get; set; }

        /// <summary>
        /// 
        /// </summary>
         IndividualizedProgramDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
         NonInclusionMinutesPerWeek { get; set; }

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
         RefIndividualizedProgramDateType { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefIndividualizedProgramLocationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefIndividualizedProgramTransitionTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefIndividualizedProgramTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        Guid? RefStudentSupportServiceTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         ServicePlanDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
         ServicePlanEndDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
         ServicePlanMeetingParticipants { get; set; }

        /// <summary>
        /// 
        /// </summary>
         ServicePlanReevaluationDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
         ServicePlanSignatureDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
         ServicePlanSignedBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
         TransferOfRightsStatement { get; set; }

    }
}
