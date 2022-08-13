//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12SchoolIndicatorStatusModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The K12SchoolIndicatorStatus Model
     /// </summary>
    public partial class K12SchoolIndicatorStatusModel : AutobahnBase, Interfaces.IK12SchoolIndicatorStatus
    {
        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public System.String IndicatorStatus { get; set; }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public System.String IndicatorStatusSubgroup { get; set; }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public Guid K12SchoolId { get; set; }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public Guid? RefIndicatorStateDefinedStatusId { get; set; }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public Guid? RefIndicatorStatusCustomTypeId { get; set; }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public Guid? RefIndicatorStatusSubgroupTypeId { get; set; }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public Guid RefIndicatorStatusTypeId { get; set; }

    }
}
