//**********************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ELChildTransitionPlanViewModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.EarlyLearning.ViewModels
{
     /// <summary>
     /// The ELChildTransitionPlan View Model
     /// </summary>
    public partial class ELChildTransitionPlanViewModel : ViewModelBase, Interfaces.IELChildTransitionPlan
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from ELChildTransitionPlan";

        // DateOfTransitionPlan -- (backing property for Date of Transition Plan)
        private System.DateTime? _DateOfTransitionPlan;

        // IDEAPartCToPartBNotificationDate -- (backing property for IDEA Part C to Part B Notification Date)
        private System.DateTime? _IDEAPartCToPartBNotificationDate;

        // IDEAPartCToPartBNotificationOptOutDate -- (backing property for IDEA Part C to Part B Notification Opt Out Date)
        private System.DateTime? _IDEAPartCToPartBNotificationOptOutDate;

        // IDEAPartCToPartBNotificationOptOutIndicator -- (backing property for IDEA Part C to Part B Notification Opt Out Indicator)
        private System.Boolean? _IDEAPartCToPartBNotificationOptOutIndicator;

        // member variable for the IndividualizedProgramId property
        private Guid? _IndividualizedProgramId;

        // PartB619PotentialEligibilityInd -- (backing property for IDEA Part B 619 Potential Eligibility Indicator)
        private System.Boolean? _PartB619PotentialEligibilityInd;

        // member variable for the PersonId property
        private Guid _PersonId;

        // RefReasonDelayTransitionConfId -- (backing property for Reason for Delay of Transition Conference)
        private Guid? _RefReasonDelayTransitionConfId;

        // TransitionConferenceDate -- (backing property for Transition Conference Date)
        private System.DateTime? _TransitionConferenceDate;

        // TransitionConferenceDeclineDate -- (backing property for Transition Conference Decline Date)
        private System.DateTime? _TransitionConferenceDeclineDate;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Date of Transition Plan
        /// <para>
        /// The date transition steps and services were added to the individualized service plan.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20335">Date of Transition Plan</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.DateTime? DateOfTransitionPlan { get => _DateOfTransitionPlan; set => SetProperty(ref _DateOfTransitionPlan, value); }

        /// <summary>
        /// IDEA Part C to Part B Notification Date
        /// <para>
        /// The date that notification is provided to the State Education Agency (SEA) and local education agency (LEA) of residence for a child potentially eligible for Part B (619) preschool services.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20472">IDEA Part C to Part B Notification Date</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.DateTime? IDEAPartCToPartBNotificationDate { get => _IDEAPartCToPartBNotificationDate; set => SetProperty(ref _IDEAPartCToPartBNotificationDate, value); }

        /// <summary>
        /// IDEA Part C to Part B Notification Opt Out Date
        /// <para>
        /// The date that parents of a child potentially eligible for Part B preschool services opt out of the impending notification to the local education agency.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20331">IDEA Part C to Part B Notification Opt Out Date</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.DateTime? IDEAPartCToPartBNotificationOptOutDate { get => _IDEAPartCToPartBNotificationOptOutDate; set => SetProperty(ref _IDEAPartCToPartBNotificationOptOutDate, value); }

        /// <summary>
        /// IDEA Part C to Part B Notification Opt Out Indicator
        /// <para>
        /// Indicates whether parents of a child potentially eligible for Part B preschool services have opted out of the impending notification to the local education agency.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20330">IDEA Part C to Part B Notification Opt Out Indicator</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Boolean? IDEAPartCToPartBNotificationOptOutIndicator { get => _IDEAPartCToPartBNotificationOptOutIndicator; set => SetProperty(ref _IDEAPartCToPartBNotificationOptOutIndicator, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IIndividualizedProgram"/> model
        /// </summary>
        public Guid? IndividualizedProgramId { get => _IndividualizedProgramId; set => SetProperty(ref _IndividualizedProgramId, value); }

        /// <summary>
        /// IDEA Part B 619 Potential Eligibility Indicator
        /// <para>
        /// The determination of whether a child is potentially eligible for Part B 619 services
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20327">IDEA Part B 619 Potential Eligibility Indicator</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Boolean? PartB619PotentialEligibilityInd { get => _PartB619PotentialEligibilityInd; set => SetProperty(ref _PartB619PotentialEligibilityInd, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IPerson"/> model
        /// </summary>
        public Guid PersonId { get => _PersonId; set => SetProperty(ref _PersonId, value); }

        /// <summary>
        /// Reason for Delay of Transition Conference
        /// <para>
        /// The reasons for the delay of a transition conference.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20494">Reason for Delay of Transition Conference</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefReasonDelayTransitionConfId { get => _RefReasonDelayTransitionConfId; set => SetProperty(ref _RefReasonDelayTransitionConfId, value); }

        /// <summary>
        /// Transition Conference Date
        /// <para>
        /// The date of the transition conference from IDEA Part C to Part B 619 or another early learning program or service.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20333">Transition Conference Date</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.DateTime? TransitionConferenceDate { get => _TransitionConferenceDate; set => SetProperty(ref _TransitionConferenceDate, value); }

        /// <summary>
        /// Transition Conference Decline Date
        /// <para>
        /// The date the parents declined approval for the transition conference from IDEA Part C to Part B 619 or another early learning program or service.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20334">Transition Conference Decline Date</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.DateTime? TransitionConferenceDeclineDate { get => _TransitionConferenceDeclineDate; set => SetProperty(ref _TransitionConferenceDeclineDate, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IELChildTransitionPlan model)
        {
            IsBusy = true;
            Id = model.Id;
            DateOfTransitionPlan = model.DateOfTransitionPlan; // Date of Transition Plan
            IDEAPartCToPartBNotificationDate = model.IDEAPartCToPartBNotificationDate; // IDEA Part C to Part B Notification Date
            IDEAPartCToPartBNotificationOptOutDate = model.IDEAPartCToPartBNotificationOptOutDate; // IDEA Part C to Part B Notification Opt Out Date
            IDEAPartCToPartBNotificationOptOutIndicator = model.IDEAPartCToPartBNotificationOptOutIndicator; // IDEA Part C to Part B Notification Opt Out Indicator
            IndividualizedProgramId = model.IndividualizedProgramId; // 
            PartB619PotentialEligibilityInd = model.PartB619PotentialEligibilityInd; // IDEA Part B 619 Potential Eligibility Indicator
            PersonId = model.PersonId; // 
            RefReasonDelayTransitionConfId = model.RefReasonDelayTransitionConfId; // Reason for Delay of Transition Conference
            TransitionConferenceDate = model.TransitionConferenceDate; // Transition Conference Date
            TransitionConferenceDeclineDate = model.TransitionConferenceDeclineDate; // Transition Conference Decline Date
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }

        #region RefReasonDelayTransitionConf List
        /// <summary>
        /// The complete <see cref="RefReasonDelayTransitionConf"> List
        /// </summary>
        private static List<ReferenceModelBase> RefReasonDelayTransitionConfList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("1bc7ffde-9d96-475d-b1ec-c8c3e15f02de"), Code="Family", Description="Family", Definition="The reasons for the delay of a transition conference is attributed to the family.", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("86e047d0-2843-421e-bcf0-db0a4458478c"), Code="Program", Description="Program", Definition="The reasons for the delay of a transition conference is attributed to the program.", SortOrder=Convert.ToDecimal("4.00") },
            new ReferenceModelBase { Id=Guid.Parse("f4813234-5711-4a19-832b-4f116a06b369"), Code="BeyondProgramControl", Description="Other beyond the control of the program", Definition="The reasons for the delay of a transition conference is other, beyond the control of the program.", SortOrder=Convert.ToDecimal("6.00") },
            new ReferenceModelBase { Id=Guid.Parse("6438b779-2c6b-4cdd-8233-11ffeaee9e50"), Code="Promotion", Description="Promotion or advancement", Definition="The reasons for the delay of a transition conference is attributed to promotion or advancement.", SortOrder=Convert.ToDecimal("99.00") },
        };
        #endregion
    }
}
