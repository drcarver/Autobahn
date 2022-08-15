//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   RecordStatusHistoryModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Invalid.Models
{
     /// <summary>
     /// The RecordStatusHistory Model
     /// </summary>
    public partial class RecordStatusHistoryModel : AutobahnBase, Interfaces.IRecordStatusHistory
    {
        /// <summary>
        /// The type of entity that created or indicated the Record Status Type
        /// </summary>
        public Guid? RefRecordStatusCreatorEntityId { get; set; }

    }
}
