//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   ClassroomViewModel.cs
//**********************************************************


namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The ClassroomViewModel
     /// </summary>
    public partial class ClassroomViewModel : ViewModelBase, Interfaces.IClassroom
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from Classroom";

        // member variable for the LocationId property
        private Guid _LocationId;

        // member variable for the ClassroomIdentifier property
        private System.String _ClassroomIdentifier;

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
        /// The title of the ClassroomViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="LocationId"/> model
        /// </summary>
        public Guid LocationId { get => _LocationId; set => SetProperty(ref _LocationId, value); }

        public System.String ClassroomIdentifier  { get => _ClassroomIdentifier; set => SetProperty(ref _ClassroomIdentifier, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IClassroom model)
        {
            IsBusy = true;
            Id = model.Id;
            LocationId = model.LocationId;
            ClassroomIdentifier = model.ClassroomIdentifier;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
