//***************************************************************************
//* DomainName: Early Learning (EL) Interfaces (used by both models and View Models
//* FileName:   IELChildTransitionPlan.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.EarlyLearning.Interfaces
{
     /// <summary>
     /// The IELChildTransitionPlan Interface
     /// </summary>
    public partial interface IELChildTransitionPlan : IAutobahnBase
    {
        /// <summary>
        /// The determination of whether a child is potentially eligible for Part B 619 services
        /// </summary>
        System.DateTime? DateOfTransitionPlan { get; set; }

        /// <summary>
        /// The determination of whether a child is potentially eligible for Part B 619 services
        /// </summary>
        System.DateTime? IDEAPartCToPartBNotificationDate { get; set; }

        /// <summary>
        /// The determination of whether a child is potentially eligible for Part B 619 services
        /// </summary>
        System.DateTime? IDEAPartCToPartBNotificationOptOutDate { get; set; }

        /// <summary>
        /// The determination of whether a child is potentially eligible for Part B 619 services
        /// </summary>
        System.Boolean? IDEAPartCToPartBNotificationOptOutIndicator { get; set; }

        /// <summary>
        /// The determination of whether a child is potentially eligible for Part B 619 services
        /// </summary>
        Guid? IndividualizedProgramId { get; set; }

        /// <summary>
        /// The determination of whether a child is potentially eligible for Part B 619 services
        /// </summary>
        System.Boolean? PartB619PotentialEligibilityInd { get; set; }

        /// <summary>
        /// The determination of whether a child is potentially eligible for Part B 619 services
        /// </summary>
        Guid PersonId { get; set; }

        /// <summary>
        /// The determination of whether a child is potentially eligible for Part B 619 services
        /// </summary>
        Guid? RefReasonDelayTransitionConfId { get; set; }

        /// <summary>
        /// The determination of whether a child is potentially eligible for Part B 619 services
        /// </summary>
        System.DateTime? TransitionConferenceDate { get; set; }

        /// <summary>
        /// The determination of whether a child is potentially eligible for Part B 619 services
        /// </summary>
        System.DateTime? TransitionConferenceDeclineDate { get; set; }

    }
}
