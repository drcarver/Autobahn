//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   K12SchoolIndicatorStatusModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The K12SchoolIndicatorStatus Model
     /// </summary>
    public partial class K12SchoolIndicatorStatusModel : AutobahnBase, Interfaces.IK12SchoolIndicatorStatusModel
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
        /// Reference to an optional instance of the <see cref="RefIndicatorStatusCustomType"/> model
        /// </summary>
        public Guid? RefIndicatorStatusCustomTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
