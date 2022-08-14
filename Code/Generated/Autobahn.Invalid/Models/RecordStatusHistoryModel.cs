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
        public Guid RecordId { get; set; }

        /// <summary>
        /// The type of entity that created or indicated the Record Status Type
        /// </summary>
        public System.String RecordPKColumn { get; set; }

        /// <summary>
        /// The type of entity that created or indicated the Record Status Type
        /// </summary>
        public Guid? RecordStatusCreatorOrganizationId { get; set; }

        /// <summary>
        /// The type of entity that created or indicated the Record Status Type
        /// </summary>
        public Guid? RecordStatusCreatorPersonId { get; set; }

        /// <summary>
        /// The type of entity that created or indicated the Record Status Type
        /// </summary>
        public System.DateTime? RecordStatusDate { get; set; }

        /// <summary>
        /// The type of entity that created or indicated the Record Status Type
        /// </summary>
        public System.String RecordTable { get; set; }

        /// <summary>
        /// The type of entity that created or indicated the Record Status Type
        /// </summary>
        public Guid? RefRecordStatusCreatorEntityId { get; set; }

        /// <summary>
        /// The type of entity that created or indicated the Record Status Type
        /// </summary>
        public Guid RefRecordStatusTypeId { get; set; }

    }
}
