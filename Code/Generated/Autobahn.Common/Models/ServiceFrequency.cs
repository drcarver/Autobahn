//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   ServiceFrequency.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The ServiceFrequency
     /// </summary>
    public partial class ServiceFrequency : IServiceFrequency
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="ServicePlan"/> model
        /// </summary>
        public Guid ServicePlanId { get; set; }

        /// <summary>
        /// Defines the ServiceFrequency.DurationInMinutes nullable property
        /// </summary>
        public System.Int32? DurationInMinutes { get; set; }

        /// <summary>
        /// Defines the ServiceFrequency.FrequencyLength nullable property
        /// </summary>
        public System.Int32? FrequencyLength { get; set; }

        /// <summary>
        /// Defines the ServiceFrequency.InstancesPerCycle nullable property
        /// </summary>
        public System.Int32? InstancesPerCycle { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFrequencyUnit"/> model
        /// </summary>
        public Guid? RefFrequencyUnitId { get; set; }

        /// <summary>
        /// Defines the ServiceFrequency.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the ServiceFrequency.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatus"/> model
        /// </summary>
        public Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
