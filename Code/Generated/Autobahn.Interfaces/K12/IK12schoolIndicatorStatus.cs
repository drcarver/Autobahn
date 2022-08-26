//***************************************************************************
//* DomainName: Elementary and Secondary (K12) Interfaces (used by both models and View Models
//* FileName:   IK12schoolIndicatorStatus.cs
//***************************************************************************

using Autobahn.Interfaces.Common;

namespace Autobahn.Interfaces.K12
{
     /// <summary>
     /// The IK12schoolIndicatorStatus Interface
     /// </summary>
    public partial interface IK12schoolIndicatorStatus : IAutobahnBase
    {
        System.String IndicatorStatus { get; set; }

        System.String IndicatorStatusSubgroup { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IK12school"/> model
        /// </summary>
        Guid K12schoolId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIndicatorStateDefinedStatus"/> model
        /// </summary>
        Guid? RefIndicatorStateDefinedStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIndicatorStatusCustomType"/> model
        /// </summary>
        Guid? RefIndicatorStatusCustomTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIndicatorStatusSubgroupType"/> model
        /// </summary>
        Guid? RefIndicatorStatusSubgroupTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIndicatorStatusType"/> model
        /// </summary>
        Guid RefIndicatorStatusTypeId { get; set; }

    }
}
