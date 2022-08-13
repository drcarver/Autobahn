//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   RecordStatusModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Authorization.Models
{
     /// <summary>
     /// The RecordStatus Model
     /// </summary>
    public partial class RecordStatusModel : AutobahnBase, Interfaces.IRecordStatus
    {
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
        public Guid? RefRecordStatusCreatorEntityId { get; set; }

        /// <summary>
        /// The type of entity that created or indicated the Record Status Type
        /// </summary>
        public Guid RefRecordStatusTypeId { get; set; }

    }
}
