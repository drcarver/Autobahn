//***************************************************************************
//* DomainName: Invalid or Unreferenced Models Interfaces (used by both models and View Models
//* FileName:   IProgramParticipationTitleIIILep.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Invalid.Interfaces
{
     /// <summary>
     /// The IProgramParticipationTitleIIILep Interface
     /// </summary>
    public partial interface IProgramParticipationTitleIIILep : IAutobahnBase
    {
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
         RefTitleIIIAccountabilityId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        Guid? RefTitleIIILanguageInstructionProgramTypeId { get; set; }

    }
}
