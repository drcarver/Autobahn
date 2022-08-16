//***************************************************************************
//* DomainName: Invalid or Unreferenced Models Interfaces (used by both models and View Models
//* FileName:   IServiceFrequency.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Invalid.Interfaces
{
     /// <summary>
     /// The IServiceFrequency Interface
     /// </summary>
    public partial interface IServiceFrequency : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
         DurationInMinutes { get; set; }

        /// <summary>
        /// 
        /// </summary>
         FrequencyLength { get; set; }

        /// <summary>
        /// 
        /// </summary>
         InstancesPerCycle { get; set; }

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
        Guid? RefFrequencyUnitId { get; set; }

    }
}
