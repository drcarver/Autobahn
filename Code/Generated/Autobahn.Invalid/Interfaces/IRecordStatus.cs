//***************************************************************************
//* DomainName: Invalid or Unreferenced Models Interfaces (used by both models and View Models
//* FileName:   IRecordStatus.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Invalid.Interfaces
{
     /// <summary>
     /// The IRecordStatus Interface
     /// </summary>
    public partial interface IRecordStatus : IAutobahnBase
    {
        /// <summary>
        /// The type of entity that created or indicated the Record Status Type
        /// </summary>
        Guid? RefRecordStatusCreatorEntityId { get; set; }

    }
}
