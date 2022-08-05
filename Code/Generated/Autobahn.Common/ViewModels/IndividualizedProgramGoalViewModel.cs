//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IndividualizedProgramGoalViewModel.cs
//**********************************************************


namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The IndividualizedProgramGoalViewModel
     /// </summary>
    public partial class IndividualizedProgramGoalViewModel : ViewModelBase, Interfaces.IIndividualizedProgramGoal
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from IndividualizedProgramGoal";

        // member variable for the GoalId property
        private Guid _GoalId;

        // member variable for the IndividualizedProgramId property
        private Guid _IndividualizedProgramId;

        // member variable for the RefIEPGoalTypeId property
        private Guid? _RefIEPGoalTypeId;

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
        /// The title of the IndividualizedProgramGoalViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="GoalId"/> model
        /// </summary>
        public Guid GoalId { get => _GoalId; set => SetProperty(ref _GoalId, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="IndividualizedProgramId"/> model
        /// </summary>
        public Guid IndividualizedProgramId { get => _IndividualizedProgramId; set => SetProperty(ref _IndividualizedProgramId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIEPGoalTypeId"/> model
        /// </summary>
        public Guid? RefIEPGoalTypeId { get => _RefIEPGoalTypeId; set => SetProperty(ref _RefIEPGoalTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IIndividualizedProgramGoal model)
        {
            IsBusy = true;
            Id = model.Id;
            GoalId = model.GoalId;
            IndividualizedProgramId = model.IndividualizedProgramId;
            RefIEPGoalTypeId = model.RefIEPGoalTypeId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
