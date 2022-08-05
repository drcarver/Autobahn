//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IRecordStatus.cs
//**********************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IRecordStatus
     /// </summary>
    public partial interface IRecordStatus : IAutobahnBase
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatusCreatorOrganization"/> model
        /// </summary>
        Guid? RecordStatusCreatorOrganizationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatusCreatorPerson"/> model
        /// </summary>
        Guid? RecordStatusCreatorPersonId { get; set; }

        /// <summary>
        /// Defines the RecordStatus.RecordStatusDate nullable property
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
