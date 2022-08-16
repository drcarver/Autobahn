//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   ServiceProvidedModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Invalid.Models
{
     /// <summary>
     /// The ServiceProvided Model
     /// </summary>
    public partial class ServiceProvidedModel : AutobahnBase, Interfaces.IServiceProvided
    {
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
        public  RefServicesId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? RefStudentSupportServiceTypeId { get; set; }

    }
}
