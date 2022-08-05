//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   ELChildTransitionPlan.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.EarlyLearning.Models
{
     /// <summary>
     /// The ELChildTransitionPlan
     /// </summary>
    public partial class ELChildTransitionPlan : AutobahnBase, Interfaces.IELChildTransitionPlan
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Person"/> model
        /// </summary>
        public Guid PersonId { get; set; }

        /// <summary>
        /// Defines the ELChildTransitionPlan.PartB619PotentialEligibilityInd nullable property
        /// </summary>
        public System.Boolean? PartB619PotentialEligibilityInd { get; set; }

        /// <summary>
        /// Defines the ELChildTransitionPlan.IDEAPartCToPartBNotificationDate nullable property
        /// </summary>
        public System.DateTime? IDEAPartCToPartBNotificationDate { get; set; }

        /// <summary>
        /// Defines the ELChildTransitionPlan.TransitionConferenceDate nullable property
        /// </summary>
        public System.DateTime? TransitionConferenceDate { get; set; }

        /// <summary>
        /// Defines the ELChildTransitionPlan.TransitionConferenceDeclineDate nullable property
        /// </summary>
        public System.DateTime? TransitionConferenceDeclineDate { get; set; }

        /// <summary>
        /// Defines the ELChildTransitionPlan.DateOfTransitionPlan nullable property
        /// </summary>
        public System.DateTime? DateOfTransitionPlan { get; set; }

        /// <summary>
        /// Defines the ELChildTransitionPlan.IDEAPartCToPartBNotificationOptOutDate nullable property
        /// </summary>
        public System.DateTime? IDEAPartCToPartBNotificationOptOutDate { get; set; }

        /// <summary>
        /// Defines the ELChildTransitionPlan.IDEAPartCToPartBNotificationOptOutIndicator nullable property
        /// </summary>
        public System.Boolean? IDEAPartCToPartBNotificationOptOutIndicator { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IndividualizedProgram"/> model
        /// </summary>
        public Guid? IndividualizedProgramId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefReasonDelayTransitionConf"/> model
        /// </summary>
        public Guid? RefReasonDelayTransitionConfId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
