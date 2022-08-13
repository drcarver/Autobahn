//**********************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ELChildTransitionPlanModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.EarlyLearning.Models
{
     /// <summary>
     /// The ELChildTransitionPlan Model
     /// </summary>
    public partial class ELChildTransitionPlanModel : AutobahnBase, Interfaces.IELChildTransitionPlan
    {
        /// <summary>
        /// The determination of whether a child is potentially eligible for Part B 619 services
        /// </summary>
        public System.DateTime? DateOfTransitionPlan { get; set; }

        /// <summary>
        /// The determination of whether a child is potentially eligible for Part B 619 services
        /// </summary>
        public System.DateTime? IDEAPartCToPartBNotificationDate { get; set; }

        /// <summary>
        /// The determination of whether a child is potentially eligible for Part B 619 services
        /// </summary>
        public System.DateTime? IDEAPartCToPartBNotificationOptOutDate { get; set; }

        /// <summary>
        /// The determination of whether a child is potentially eligible for Part B 619 services
        /// </summary>
        public System.Boolean? IDEAPartCToPartBNotificationOptOutIndicator { get; set; }

        /// <summary>
        /// The determination of whether a child is potentially eligible for Part B 619 services
        /// </summary>
        public Guid? IndividualizedProgramId { get; set; }

        /// <summary>
        /// The determination of whether a child is potentially eligible for Part B 619 services
        /// </summary>
        public System.Boolean? PartB619PotentialEligibilityInd { get; set; }

        /// <summary>
        /// The determination of whether a child is potentially eligible for Part B 619 services
        /// </summary>
        public Guid PersonId { get; set; }

        /// <summary>
        /// The determination of whether a child is potentially eligible for Part B 619 services
        /// </summary>
        public Guid? RefReasonDelayTransitionConfId { get; set; }

        /// <summary>
        /// The determination of whether a child is potentially eligible for Part B 619 services
        /// </summary>
        public System.DateTime? TransitionConferenceDate { get; set; }

        /// <summary>
        /// The determination of whether a child is potentially eligible for Part B 619 services
        /// </summary>
        public System.DateTime? TransitionConferenceDeclineDate { get; set; }

    }
}
