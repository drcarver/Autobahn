//***************************************************************************
//* DomainName: Invalid or Unreferenced Models Interfaces (used by both models and View Models
//* FileName:   IIndividualizedProgramService.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Invalid.Interfaces
{
     /// <summary>
     /// The IIndividualizedProgramService Interface
     /// </summary>
    public partial interface IIndividualizedProgramService : IAutobahnBase
    {
        /// <summary>
        /// The date the service is planned to begin.
        /// </summary>
        System.DateTime? PlannedServiceStartDate { get; set; }

    }
}
