//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   CourseSectionLevelViewModel.cs
//**********************************************************


namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The CourseSectionLevelViewModel
     /// </summary>
    public partial class CourseSectionLevelViewModel : ViewModelBase, Interfaces.ICourseSectionLevel
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from CourseSectionLevel";

        // member variable for the CourseSectionId property
        private Guid _CourseSectionId;

        // member variable for the RefCourseLevelTypeId property
        private Guid _RefCourseLevelTypeId;

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
        /// The title of the CourseSectionLevelViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="CourseSectionId"/> model
        /// </summary>
        public Guid CourseSectionId { get => _CourseSectionId; set => SetProperty(ref _CourseSectionId, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefCourseLevelTypeId"/> model
        /// </summary>
        public Guid RefCourseLevelTypeId { get => _RefCourseLevelTypeId; set => SetProperty(ref _RefCourseLevelTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.ICourseSectionLevel model)
        {
            IsBusy = true;
            Id = model.Id;
            CourseSectionId = model.CourseSectionId;
            RefCourseLevelTypeId = model.RefCourseLevelTypeId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
