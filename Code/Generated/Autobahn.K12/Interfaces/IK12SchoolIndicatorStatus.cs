//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   IK12SchoolIndicatorStatus.cs
//**********************************************************

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The IK12SchoolIndicatorStatus
     /// </summary>
    public partial interface IK12SchoolIndicatorStatus
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="K12School"/> model
        /// </summary>
        Guid K12SchoolId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefIndicatorStatusType"/> model
        /// </summary>
        Guid RefIndicatorStatusTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIndicatorStateDefinedStatus"/> model
        /// </summary>
        Guid? RefIndicatorStateDefinedStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIndicatorStatusSubgroupType"/> model
        /// </summary>
        Guid? RefIndicatorStatusSubgroupTypeId { get; set; }

        /// <summary>
        /// Defines the K12SchoolIndicatorStatus.IndicatorStatusSubgroup non nullable property
        /// </summary>
        System.String IndicatorStatusSubgroup { get; set; }

        /// <summary>
        /// Defines the K12SchoolIndicatorStatus.IndicatorStatus non nullable property
        /// </summary>
        System.String IndicatorStatus { get; set; }

        /// <summary>
        /// Defines the K12SchoolIndicatorStatus.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the K12SchoolIndicatorStatus.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIndicatorStatusCustomType"/> model
        /// </summary>
        Guid? RefIndicatorStatusCustomTypeId { get; set; }

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
