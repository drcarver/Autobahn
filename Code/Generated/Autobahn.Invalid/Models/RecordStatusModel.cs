//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   RecordStatusModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Invalid.Models
{
     /// <summary>
     /// The RecordStatus Model
     /// </summary>
    public partial class RecordStatusModel : AutobahnBase, Interfaces.IRecordStatus
    {
        /// <summary>
        /// The type of entity that created or indicated the Record Status Type
        /// </summary>
        public Guid? RefRecordStatusCreatorEntityId { get; set; }

    }
}
