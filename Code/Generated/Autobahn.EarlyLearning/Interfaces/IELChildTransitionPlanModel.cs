//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   IELChildTransitionPlanModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.EarlyLearning.Interfaces
{
     /// <summary>
     /// The IELChildTransitionPlanModel Interface
     /// </summary>
    public partial interface IELChildTransitionPlanModel : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Person"/> model
        /// </summary>
        Guid PersonId { get; set; }

        /// <summary>
        /// Defines the ELChildTransitionPlan.PartB619PotentialEligibilityInd nullable property
        /// </summary>
        System.Boolean? PartB619PotentialEligibilityInd { get; set; }

        /// <summary>
        /// Defines the ELChildTransitionPlan.IDEAPartCToPartBNotificationDate nullable property
        /// </summary>
        System.DateTime? IDEAPartCToPartBNotificationDate { get; set; }

        /// <summary>
        /// Defines the ELChildTransitionPlan.TransitionConferenceDate nullable property
        /// </summary>
        System.DateTime? TransitionConferenceDate { get; set; }

        /// <summary>
        /// Defines the ELChildTransitionPlan.TransitionConferenceDeclineDate nullable property
        /// </summary>
        System.DateTime? TransitionConferenceDeclineDate { get; set; }

        /// <summary>
        /// Defines the ELChildTransitionPlan.DateOfTransitionPlan nullable property
        /// </summary>
        System.DateTime? DateOfTransitionPlan { get; set; }

        /// <summary>
        /// Defines the ELChildTransitionPlan.IDEAPartCToPartBNotificationOptOutDate nullable property
        /// </summary>
        System.DateTime? IDEAPartCToPartBNotificationOptOutDate { get; set; }

        /// <summary>
        /// Defines the ELChildTransitionPlan.IDEAPartCToPartBNotificationOptOutIndicator nullable property
        /// </summary>
        System.Boolean? IDEAPartCToPartBNotificationOptOutIndicator { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IndividualizedProgram"/> model
        /// </summary>
        Guid? IndividualizedProgramId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefReasonDelayTransitionConf"/> model
        /// </summary>
        Guid? RefReasonDelayTransitionConfId { get; set; }

    }
}
