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
        /// Date of Transition Plan
        /// <para>
        /// The date transition steps and services were added to the individualized service plan.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20335">Date of Transition Plan</a>
        /// </para>
        /// </summary>
        System.DateTime? DateOfTransitionPlan { get; set; }

        /// <summary>
        /// IDEA Part C to Part B Notification Date
        /// <para>
        /// The date that notification is provided to the State Education Agency (SEA) and local education agency (LEA) of residence for a child potentially eligible for Part B (619) preschool services.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20472">IDEA Part C to Part B Notification Date</a>
        /// </para>
        /// </summary>
        System.DateTime? IDEAPartCToPartBNotificationDate { get; set; }

        /// <summary>
        /// IDEA Part C to Part B Notification Opt Out Date
        /// <para>
        /// The date that parents of a child potentially eligible for Part B preschool services opt out of the impending notification to the local education agency.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20331">IDEA Part C to Part B Notification Opt Out Date</a>
        /// </para>
        /// </summary>
        System.DateTime? IDEAPartCToPartBNotificationOptOutDate { get; set; }

        /// <summary>
        /// IDEA Part C to Part B Notification Opt Out Indicator
        /// <para>
        /// Indicates whether parents of a child potentially eligible for Part B preschool services have opted out of the impending notification to the local education agency.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20330">IDEA Part C to Part B Notification Opt Out Indicator</a>
        /// </para>
        /// </summary>
        System.Boolean? IDEAPartCToPartBNotificationOptOutIndicator { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IIndividualizedProgram"/> model
        /// </summary>
        Guid? IndividualizedProgramId { get; set; }

        /// <summary>
        /// IDEA Part B 619 Potential Eligibility Indicator
        /// <para>
        /// The determination of whether a child is potentially eligible for Part B 619 services
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20327">IDEA Part B 619 Potential Eligibility Indicator</a>
        /// </para>
        /// </summary>
        System.Boolean? PartB619PotentialEligibilityInd { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IPerson"/> model
        /// </summary>
        Guid PersonId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefReasonDelayTransitionConf"/> model
        /// </summary>
        Guid? RefReasonDelayTransitionConfId { get; set; }

        /// <summary>
        /// Transition Conference Date
        /// <para>
        /// The date of the transition conference from IDEA Part C to Part B 619 or another early learning program or service.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20333">Transition Conference Date</a>
        /// </para>
        /// </summary>
        System.DateTime? TransitionConferenceDate { get; set; }

        /// <summary>
        /// Transition Conference Decline Date
        /// <para>
        /// The date the parents declined approval for the transition conference from IDEA Part C to Part B 619 or another early learning program or service.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20334">Transition Conference Decline Date</a>
        /// </para>
        /// </summary>
        System.DateTime? TransitionConferenceDeclineDate { get; set; }

    }
}
