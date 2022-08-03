//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RecordStatusHistory.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The RecordStatusHistory
     /// </summary>
    public partial class RecordStatusHistory : IRecordStatusHistory
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RecordStatus"/> model
        /// </summary>
        public Guid RecordStatusId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="Record"/> model
        /// </summary>
        public Guid RecordId { get; set; }

        /// <summary>
        /// Defines the RecordStatusHistory.RecordPKColumn non nullable property
        /// </summary>
        public System.String RecordPKColumn { get; set; }

        /// <summary>
        /// Defines the RecordStatusHistory.RecordTable non nullable property
        /// </summary>
        public System.String RecordTable { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatusCreatorOrganization"/> model
        /// </summary>
        public Guid? RecordStatusCreatorOrganizationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatusCreatorPerson"/> model
        /// </summary>
        public Guid? RecordStatusCreatorPersonId { get; set; }

        /// <summary>
        /// Defines the RecordStatusHistory.RecordStatusDate nullable property
        /// </summary>
        public System.DateTime? RecordStatusDate { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefRecordStatusType"/> model
        /// </summary>
        public Guid RefRecordStatusTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefRecordStatusCreatorEntity"/> model
        /// </summary>
        public Guid? RefRecordStatusCreatorEntityId { get; set; }

    }
}
