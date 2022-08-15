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
        /// The unit of time by which a cycle is defined.
        /// </summary>
        public Guid? RefFrequencyUnitId { get; set; }

    }
}
