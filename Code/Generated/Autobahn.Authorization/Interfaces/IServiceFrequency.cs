//***************************************************************************
//* DomainName: Authentication and Authorization Interfaces (used by both models and View Models
//* FileName:   IServiceFrequency.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Authorization.Interfaces
{
     /// <summary>
     /// The IServiceFrequency Interface
     /// </summary>
    public partial interface IServiceFrequency : IAutobahnBase
    {
        /// <summary>
        /// The unit of time by which a cycle is defined.
        /// </summary>
        System.Int32? DurationInMinutes { get; set; }

        /// <summary>
        /// The unit of time by which a cycle is defined.
        /// </summary>
        System.Int32? FrequencyLength { get; set; }

        /// <summary>
        /// The unit of time by which a cycle is defined.
        /// </summary>
        System.Int32? InstancesPerCycle { get; set; }

        /// <summary>
        /// The unit of time by which a cycle is defined.
        /// </summary>
        Guid? RefFrequencyUnitId { get; set; }

        /// <summary>
        /// The unit of time by which a cycle is defined.
        /// </summary>
        Guid ServicePlanId { get; set; }

    }
}
