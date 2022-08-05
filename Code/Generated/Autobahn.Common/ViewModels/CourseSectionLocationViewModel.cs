//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   CourseSectionLocationViewModel.cs
//**********************************************************


namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The CourseSectionLocationViewModel
     /// </summary>
    public partial class CourseSectionLocationViewModel : ViewModelBase, Interfaces.ICourseSectionLocation
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from CourseSectionLocation";

        // member variable for the ClassroomId property
        private Guid _ClassroomId;

        // member variable for the CourseSectionId property
        private Guid _CourseSectionId;

        // member variable for the RefInstructionLocationTypeId property
        private Guid? _RefInstructionLocationTypeId;

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
        /// The title of the CourseSectionLocationViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="ClassroomId"/> model
        /// </summary>
        public Guid ClassroomId { get => _ClassroomId; set => SetProperty(ref _ClassroomId, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="CourseSectionId"/> model
        /// </summary>
        public Guid CourseSectionId { get => _CourseSectionId; set => SetProperty(ref _CourseSectionId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefInstructionLocationTypeId"/> model
        /// </summary>
        public Guid? RefInstructionLocationTypeId { get => _RefInstructionLocationTypeId; set => SetProperty(ref _RefInstructionLocationTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.ICourseSectionLocation model)
        {
            IsBusy = true;
            Id = model.Id;
            ClassroomId = model.ClassroomId;
            CourseSectionId = model.CourseSectionId;
            RefInstructionLocationTypeId = model.RefInstructionLocationTypeId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
