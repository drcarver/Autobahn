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
        /// 
        /// </summary>
         PlannedServiceDuration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        Guid? PlannedServiceStartDate { get; set; }

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
         RefIndividualizedProgramPlannedServiceTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefMethodOfServiceDeliveryId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefServiceFrequencyId { get; set; }

    }
}
