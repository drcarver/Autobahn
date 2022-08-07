//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   PersonMilitaryViewModel.cs
//**********************************************************


namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The PersonMilitaryViewModel
     /// </summary>
    public partial class PersonMilitaryViewModel : ViewModelBase, Interfaces.IPersonMilitaryViewModel
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PersonMilitary";

        // member variable for the PersonId property
        private Guid _PersonId;

        // member variable for the RefMilitaryActiveStudentIndicatorId property
        private Guid? _RefMilitaryActiveStudentIndicatorId;

        // member variable for the RefMilitaryConnectedStudentIndicatorId property
        private Guid? _RefMilitaryConnectedStudentIndicatorId;

        // member variable for the RefMilitaryVeteranStudentIndicatorId property
        private Guid? _RefMilitaryVeteranStudentIndicatorId;

        // member variable for the RefMilitaryBranchId property
        private Guid? _RefMilitaryBranchId;

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
        /// The title of the PersonMilitaryViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="PersonId"/> model
        /// </summary>
        public Guid PersonId { get => _PersonId; set => SetProperty(ref _PersonId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefMilitaryActiveStudentIndicatorId"/> model
        /// </summary>
        public Guid? RefMilitaryActiveStudentIndicatorId { get => _RefMilitaryActiveStudentIndicatorId; set => SetProperty(ref _RefMilitaryActiveStudentIndicatorId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefMilitaryConnectedStudentIndicatorId"/> model
        /// </summary>
        public Guid? RefMilitaryConnectedStudentIndicatorId { get => _RefMilitaryConnectedStudentIndicatorId; set => SetProperty(ref _RefMilitaryConnectedStudentIndicatorId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefMilitaryVeteranStudentIndicatorId"/> model
        /// </summary>
        public Guid? RefMilitaryVeteranStudentIndicatorId { get => _RefMilitaryVeteranStudentIndicatorId; set => SetProperty(ref _RefMilitaryVeteranStudentIndicatorId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefMilitaryBranchId"/> model
        /// </summary>
        public Guid? RefMilitaryBranchId { get => _RefMilitaryBranchId; set => SetProperty(ref _RefMilitaryBranchId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPersonMilitary model)
        {
            IsBusy = true;
            Id = model.Id;
            PersonId = model.PersonId;
            RefMilitaryActiveStudentIndicatorId = model.RefMilitaryActiveStudentIndicatorId;
            RefMilitaryConnectedStudentIndicatorId = model.RefMilitaryConnectedStudentIndicatorId;
            RefMilitaryVeteranStudentIndicatorId = model.RefMilitaryVeteranStudentIndicatorId;
            RefMilitaryBranchId = model.RefMilitaryBranchId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
