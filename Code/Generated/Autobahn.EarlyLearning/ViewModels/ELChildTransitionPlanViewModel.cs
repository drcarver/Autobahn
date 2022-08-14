//**********************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ELChildTransitionPlanViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.EarlyLearning.ViewModels
{
     /// <summary>
     /// The ELChildTransitionPlanViewModel
     /// </summary>
    public partial class ELChildTransitionPlanViewModel : ViewModelBase, Interfaces.IELChildTransitionPlan
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from ELChildTransitionPlan";

        // member variable for the DateOfTransitionPlan property
        private System.DateTime? _DateOfTransitionPlan;

        // member variable for the IDEAPartCToPartBNotificationDate property
        private System.DateTime? _IDEAPartCToPartBNotificationDate;

        // member variable for the IDEAPartCToPartBNotificationOptOutDate property
        private System.DateTime? _IDEAPartCToPartBNotificationOptOutDate;

        // member variable for the IDEAPartCToPartBNotificationOptOutIndicator property
        private System.Boolean? _IDEAPartCToPartBNotificationOptOutIndicator;

        // member variable for the IndividualizedProgramId property
        private Guid? _IndividualizedProgramId;

        // member variable for the PartB619PotentialEligibilityInd property
        private System.Boolean? _PartB619PotentialEligibilityInd;

        // member variable for the PersonId property
        private Guid _PersonId;

        // member variable for the RefReasonDelayTransitionConfId property
        private Guid? _RefReasonDelayTransitionConfId;

        // member variable for the TransitionConferenceDate property
        private System.DateTime? _TransitionConferenceDate;

        // member variable for the TransitionConferenceDeclineDate property
        private System.DateTime? _TransitionConferenceDeclineDate;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the ELChildTransitionPlanViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The determination of whether a child is potentially eligible for Part B 619 services
        /// </summary>
        public System.DateTime? DateOfTransitionPlan { get => _DateOfTransitionPlan; set => SetProperty(ref _DateOfTransitionPlan, value); }

        /// <summary>
        /// The determination of whether a child is potentially eligible for Part B 619 services
        /// </summary>
        public System.DateTime? IDEAPartCToPartBNotificationDate { get => _IDEAPartCToPartBNotificationDate; set => SetProperty(ref _IDEAPartCToPartBNotificationDate, value); }

        /// <summary>
        /// The determination of whether a child is potentially eligible for Part B 619 services
        /// </summary>
        public System.DateTime? IDEAPartCToPartBNotificationOptOutDate { get => _IDEAPartCToPartBNotificationOptOutDate; set => SetProperty(ref _IDEAPartCToPartBNotificationOptOutDate, value); }

        /// <summary>
        /// The determination of whether a child is potentially eligible for Part B 619 services
        /// </summary>
        public System.Boolean? IDEAPartCToPartBNotificationOptOutIndicator { get => _IDEAPartCToPartBNotificationOptOutIndicator; set => SetProperty(ref _IDEAPartCToPartBNotificationOptOutIndicator, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IndividualizedProgram"/> model
        /// </summary>
        public Guid? IndividualizedProgramId { get => _IndividualizedProgramId; set => SetProperty(ref _IndividualizedProgramId, value); }

        /// <summary>
        /// The determination of whether a child is potentially eligible for Part B 619 services
        /// </summary>
        public System.Boolean? PartB619PotentialEligibilityInd { get => _PartB619PotentialEligibilityInd; set => SetProperty(ref _PartB619PotentialEligibilityInd, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="Person"/> model
        /// </summary>
        public Guid PersonId { get => _PersonId; set => SetProperty(ref _PersonId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefReasonDelayTransitionConf"/> model
        /// </summary>
        public Guid? RefReasonDelayTransitionConfId { get => _RefReasonDelayTransitionConfId; set => SetProperty(ref _RefReasonDelayTransitionConfId, value); }

        /// <summary>
        /// The determination of whether a child is potentially eligible for Part B 619 services
        /// </summary>
        public System.DateTime? TransitionConferenceDate { get => _TransitionConferenceDate; set => SetProperty(ref _TransitionConferenceDate, value); }

        /// <summary>
        /// The determination of whether a child is potentially eligible for Part B 619 services
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
            DateOfTransitionPlan = model.DateOfTransitionPlan;
            IDEAPartCToPartBNotificationDate = model.IDEAPartCToPartBNotificationDate;
            IDEAPartCToPartBNotificationOptOutDate = model.IDEAPartCToPartBNotificationOptOutDate;
            IDEAPartCToPartBNotificationOptOutIndicator = model.IDEAPartCToPartBNotificationOptOutIndicator;
            IndividualizedProgramId = model.IndividualizedProgramId;
            PartB619PotentialEligibilityInd = model.PartB619PotentialEligibilityInd;
            PersonId = model.PersonId;
            RefReasonDelayTransitionConfId = model.RefReasonDelayTransitionConfId;
            TransitionConferenceDate = model.TransitionConferenceDate;
            TransitionConferenceDeclineDate = model.TransitionConferenceDeclineDate;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
