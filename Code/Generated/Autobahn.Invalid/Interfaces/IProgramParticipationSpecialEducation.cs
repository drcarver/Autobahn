//***************************************************************************
//* DomainName: Invalid or Unreferenced Models Interfaces (used by both models and View Models
//* FileName:   IProgramParticipationSpecialEducation.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Invalid.Interfaces
{
     /// <summary>
     /// The IProgramParticipationSpecialEducation Interface
     /// </summary>
    public partial interface IProgramParticipationSpecialEducation : IAutobahnBase
    {
        /// <summary>
        /// Awaiting initial evaluation for special education programs and related services under the Individuals with Disabilities Education Act (IDEA). 
        /// </summary>
        System.Boolean? AwaitingInitialIDEAEvaluationStatus { get; set; }

    }
}
