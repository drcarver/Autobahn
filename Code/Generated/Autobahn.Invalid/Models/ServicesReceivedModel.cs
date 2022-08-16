//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   ServicesReceivedModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Invalid.Models
{
     /// <summary>
     /// The ServicesReceived Model
     /// </summary>
    public partial class ServicesReceivedModel : AutobahnBase, Interfaces.IServicesReceived
    {
        /// <summary>
        /// 
        /// </summary>
        public Guid? FullTimeEquivalency { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordStartDateTime { get; set; }

    }
}
