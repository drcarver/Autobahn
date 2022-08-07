//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   ServiceFrequencyModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The ServiceFrequency Model
     /// </summary>
    public partial class ServiceFrequencyModel : AutobahnBase, Interfaces.IServiceFrequencyModel
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
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
