//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IPersonProgramParticipation.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IPersonProgramParticipation Interface
     /// </summary>
    public partial interface IPersonProgramParticipation : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
         ParticipationStatus { get; set; }

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
        Guid? RefParticipationTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefProgramEntryReasonId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefProgramExitReasonId { get; set; }

    }
}
