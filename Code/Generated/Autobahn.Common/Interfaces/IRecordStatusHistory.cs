//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IRecordStatusHistory.cs
//**********************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IRecordStatusHistory
     /// </summary>
    public partial interface IRecordStatusHistory : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Record"/> model
        /// </summary>
        Guid RecordId { get; set; }

        /// <summary>
        /// Defines the RecordStatusHistory.RecordPKColumn non nullable property
        /// </summary>
        System.String RecordPKColumn { get; set; }

        /// <summary>
        /// Defines the RecordStatusHistory.RecordTable non nullable property
        /// </summary>
        System.String RecordTable { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatusCreatorOrganization"/> model
        /// </summary>
        Guid? RecordStatusCreatorOrganizationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatusCreatorPerson"/> model
        /// </summary>
        Guid? RecordStatusCreatorPersonId { get; set; }

        /// <summary>
        /// Defines the RecordStatusHistory.RecordStatusDate nullable property
        /// </summary>
        System.DateTime? RecordStatusDate { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefRecordStatusType"/> model
        /// </summary>
        Guid RefRecordStatusTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefRecordStatusCreatorEntity"/> model
        /// </summary>
        Guid? RefRecordStatusCreatorEntityId { get; set; }

    }
}
