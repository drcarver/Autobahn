//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IServiceFrequency.cs
//**********************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IServiceFrequency
     /// </summary>
    public partial interface IServiceFrequency : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="ServicePlan"/> model
        /// </summary>
        Guid ServicePlanId { get; set; }

        /// <summary>
        /// Defines the ServiceFrequency.DurationInMinutes nullable property
        /// </summary>
        System.Int32? DurationInMinutes { get; set; }

        /// <summary>
        /// Defines the ServiceFrequency.FrequencyLength nullable property
        /// </summary>
        System.Int32? FrequencyLength { get; set; }

        /// <summary>
        /// Defines the ServiceFrequency.InstancesPerCycle nullable property
        /// </summary>
        System.Int32? InstancesPerCycle { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFrequencyUnit"/> model
        /// </summary>
        Guid? RefFrequencyUnitId { get; set; }

    }
}
