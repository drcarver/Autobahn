//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   K12SchoolIndicatorStatus.cs
//**********************************************************

using Autobahn.K12.Interfaces;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The K12SchoolIndicatorStatus
     /// </summary>
    public partial class K12SchoolIndicatorStatus : IK12SchoolIndicatorStatus
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="K12School"/> model
        /// </summary>
        public Guid K12SchoolId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefIndicatorStatusType"/> model
        /// </summary>
        public Guid RefIndicatorStatusTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIndicatorStateDefinedStatus"/> model
        /// </summary>
        public Guid? RefIndicatorStateDefinedStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIndicatorStatusSubgroupType"/> model
        /// </summary>
        public Guid? RefIndicatorStatusSubgroupTypeId { get; set; }

        /// <summary>
        /// Defines the K12SchoolIndicatorStatus.IndicatorStatusSubgroup non nullable property
        /// </summary>
        public System.String IndicatorStatusSubgroup { get; set; }

        /// <summary>
        /// Defines the K12SchoolIndicatorStatus.IndicatorStatus non nullable property
        /// </summary>
        public System.String IndicatorStatus { get; set; }

        /// <summary>
        /// Defines the K12SchoolIndicatorStatus.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the K12SchoolIndicatorStatus.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIndicatorStatusCustomType"/> model
        /// </summary>
        public Guid? RefIndicatorStatusCustomTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatus"/> model
        /// </summary>
        public Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}