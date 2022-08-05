//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RecordStatus.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The RecordStatus
     /// </summary>
    public partial class RecordStatus : AutobahnBase, Interfaces.IRecordStatus
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatusCreatorOrganization"/> model
        /// </summary>
        public Guid? RecordStatusCreatorOrganizationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatusCreatorPerson"/> model
        /// </summary>
        public Guid? RecordStatusCreatorPersonId { get; set; }

        /// <summary>
        /// Defines the RecordStatus.RecordStatusDate nullable property
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
