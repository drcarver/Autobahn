//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   ServiceFrequencyModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Invalid.Models
{
     /// <summary>
     /// The ServiceFrequency Model
     /// </summary>
    public partial class ServiceFrequencyModel : AutobahnBase, Interfaces.IServiceFrequency
    {
        /// <summary>
        /// 
        /// </summary>
        public  DurationInMinutes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  FrequencyLength { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  InstancesPerCycle { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordStartDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? RefFrequencyUnitId { get; set; }

    }
}
