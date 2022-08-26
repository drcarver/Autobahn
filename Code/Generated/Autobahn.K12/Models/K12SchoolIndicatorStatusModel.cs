//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12schoolIndicatorStatusModel.cs
//***************************************************************************

using Autobahn.Interfaces.K12;
using Autobahn.Interfaces.Common;
using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The K12schoolIndicatorStatus Model
     /// </summary>
    public partial class K12schoolIndicatorStatusModel : AutobahnBase, IK12schoolIndicatorStatus
    {
        public System.String IndicatorStatus { get; set; }

        public System.String IndicatorStatusSubgroup { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IK12school"/> model
        /// </summary>
        public Guid K12schoolId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIndicatorStateDefinedStatus"/> model
        /// </summary>
        public Guid? RefIndicatorStateDefinedStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIndicatorStatusCustomType"/> model
        /// </summary>
        public Guid? RefIndicatorStatusCustomTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIndicatorStatusSubgroupType"/> model
        /// </summary>
        public Guid? RefIndicatorStatusSubgroupTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIndicatorStatusType"/> model
        /// </summary>
        public Guid RefIndicatorStatusTypeId { get; set; }

    }
}
