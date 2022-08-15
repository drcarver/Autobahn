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
        /// The unit of time by which a cycle is defined.
        /// </summary>
        Guid? RefFrequencyUnitId { get; set; }

    }
}
