//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IPersonStatus.cs
//**********************************************************

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IPersonStatus
     /// </summary>
    public partial interface IPersonStatus
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Person"/> model
        /// </summary>
        Guid PersonId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefPersonStatusType"/> model
        /// </summary>
        Guid RefPersonStatusTypeId { get; set; }

        /// <summary>
        /// Defines the PersonStatus.StatusValue non nullable property
        /// </summary>
        System.Boolean StatusValue { get; set; }

        /// <summary>
        /// Defines the PersonStatus.StatusStartDate nullable property
        /// </summary>
        System.DateTime? StatusStartDate { get; set; }

        /// <summary>
        /// Defines the PersonStatus.StatusEndDate nullable property
        /// </summary>
        System.DateTime? StatusEndDate { get; set; }

        /// <summary>
        /// Defines the PersonStatus.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the PersonStatus.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatus"/> model
        /// </summary>
        Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        Guid? DataCollectionId { get; set; }

    }
}
