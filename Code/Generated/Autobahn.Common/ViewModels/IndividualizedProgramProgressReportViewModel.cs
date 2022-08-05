//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IndividualizedProgramProgressReportViewModel.cs
//**********************************************************


namespace Autobahn.Common.ViewModels
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
        /// The title of the IndividualizedProgramProgressReportViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="IndividualizedProgramId"/> model
        /// </summary>
        public Guid IndividualizedProgramId { get => _IndividualizedProgramId; set => SetProperty(ref _IndividualizedProgramId, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="IndividualizedProgramProgressReportPlanId"/> model
        /// </summary>
        public Guid IndividualizedProgramProgressReportPlanId { get => _IndividualizedProgramProgressReportPlanId; set => SetProperty(ref _IndividualizedProgramProgressReportPlanId, value); }

        public System.String ProgressDescription  { get => _ProgressDescription; set => SetProperty(ref _ProgressDescription, value); }

        public System.DateTime? ProgressReportDate { get => _ProgressReportDate; set => SetProperty(ref _ProgressReportDate, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIPSPProgressReportTypeId"/> model
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
