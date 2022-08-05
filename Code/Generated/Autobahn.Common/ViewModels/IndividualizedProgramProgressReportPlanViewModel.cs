//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IndividualizedProgramProgressReportPlanViewModel.cs
//**********************************************************


namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The IndividualizedProgramProgressReportPlanViewModel
     /// </summary>
    public partial class IndividualizedProgramProgressReportPlanViewModel : ViewModelBase, Interfaces.IIndividualizedProgramProgressReportPlan
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from IndividualizedProgramProgressReportPlan";

        // member variable for the IndividualizedProgramId property
        private Guid _IndividualizedProgramId;

        // member variable for the RefIPSPProgressReportScheduleId property
        private Guid? _RefIPSPProgressReportScheduleId;

        // member variable for the RefIPSPProgressReportTypeId property
        private Guid? _RefIPSPProgressReportTypeId;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

        // member variable for the RecordStatusId property
        private Guid? _RecordStatusId;

        // member variable for the DataCollectionId property
        private Guid? _DataCollectionId;

#endregion

        #region Properties
        /// <summary>
        /// The title of the IndividualizedProgramProgressReportPlanViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="IndividualizedProgramId"/> model
        /// </summary>
        public Guid IndividualizedProgramId { get => _IndividualizedProgramId; set => SetProperty(ref _IndividualizedProgramId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIPSPProgressReportScheduleId"/> model
        /// </summary>
        public Guid? RefIPSPProgressReportScheduleId { get => _RefIPSPProgressReportScheduleId; set => SetProperty(ref _RefIPSPProgressReportScheduleId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIPSPProgressReportTypeId"/> model
        /// </summary>
        public Guid? RefIPSPProgressReportTypeId { get => _RefIPSPProgressReportTypeId; set => SetProperty(ref _RefIPSPProgressReportTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IIndividualizedProgramProgressReportPlan model)
        {
            IsBusy = true;
            Id = model.Id;
            IndividualizedProgramId = model.IndividualizedProgramId;
            RefIPSPProgressReportScheduleId = model.RefIPSPProgressReportScheduleId;
            RefIPSPProgressReportTypeId = model.RefIPSPProgressReportTypeId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
