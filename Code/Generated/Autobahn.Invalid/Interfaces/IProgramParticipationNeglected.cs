//***************************************************************************
//* DomainName: Invalid or Unreferenced Models Interfaces (used by both models and View Models
//* FileName:   IProgramParticipationNeglected.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Invalid.Interfaces
{
     /// <summary>
     /// The IProgramParticipationNeglected Interface
     /// </summary>
    public partial interface IProgramParticipationNeglected : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
         AchievementIndicator { get; set; }

        /// <summary>
        /// 
        /// </summary>
         ObtainedEmployment { get; set; }

        /// <summary>
        /// 
        /// </summary>
         OutcomeIndicator { get; set; }

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
        Guid? RefNeglectedProgramTypeId { get; set; }

    }
}
