//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   IndividualizedProgramProgressReportViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;
using CommunityToolkit.Maui;

namespace Autobahn.Authorization.ViewModels
{
     /// <summary>
     /// The IndividualizedProgramProgressReportViewModel
     /// </summary>
    public partial class IndividualizedProgramProgressReportViewModel : ViewModelBase, Interfaces.IIndividualizedProgramProgressReport
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from IndividualizedProgramProgressReport";

        // member variable for the IndividualizedProgramId property
        private Guid _IndividualizedProgramId;

        // member variable for the IndividualizedProgramProgressReportPlanId property
        private Guid _IndividualizedProgramProgressReportPlanId;

        // member variable for the ProgressDescription property
        private System.String _ProgressDescription;

        // member variable for the ProgressReportDate property
        private System.DateTime? _ProgressReportDate;

        // member variable for the RefIPSPProgressReportTypeId property
        private Guid? _RefIPSPProgressReportTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the IndividualizedProgramProgressReportViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IndividualizedProgram"/> model
        /// </summary>
        public Guid IndividualizedProgramId { get => _IndividualizedProgramId; set => SetProperty(ref _IndividualizedProgramId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IndividualizedProgramProgressReportPlan"/> model
        /// </summary>
        public Guid IndividualizedProgramProgressReportPlanId { get => _IndividualizedProgramProgressReportPlanId; set => SetProperty(ref _IndividualizedProgramProgressReportPlanId, value); }

        /// <summary>
        /// The date parents are notified of the student's progress on annual goals and if the progress is sufficient to achieve the goals by the end of the individualized program service plan.
        /// </summary>
        public System.String ProgressDescription { get => _ProgressDescription; set => SetProperty(ref _ProgressDescription, value); }

        /// <summary>
        /// The date parents are notified of the student's progress on annual goals and if the progress is sufficient to achieve the goals by the end of the individualized program service plan.
        /// </summary>
        public System.DateTime? ProgressReportDate { get => _ProgressReportDate; set => SetProperty(ref _ProgressReportDate, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIPSPProgressReportType"/> model
        /// </summary>
        public Guid? RefIPSPProgressReportTypeId { get => _RefIPSPProgressReportTypeId; set => SetProperty(ref _RefIPSPProgressReportTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IIndividualizedProgramProgressReport model)
        {
            IsBusy = true;
            Id = model.Id;
            IndividualizedProgramId = model.IndividualizedProgramId;
            IndividualizedProgramProgressReportPlanId = model.IndividualizedProgramProgressReportPlanId;
            ProgressDescription = model.ProgressDescription;
            ProgressReportDate = model.ProgressReportDate;
            RefIPSPProgressReportTypeId = model.RefIPSPProgressReportTypeId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
