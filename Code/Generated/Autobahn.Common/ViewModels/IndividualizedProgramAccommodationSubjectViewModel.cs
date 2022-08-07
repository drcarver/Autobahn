//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IndividualizedProgramAccommodationSubjectViewModel.cs
//**********************************************************


namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The IndividualizedProgramAccommodationSubjectViewModel
     /// </summary>
    public partial class IndividualizedProgramAccommodationSubjectViewModel : ViewModelBase, Interfaces.IIndividualizedProgramAccommodationSubjectViewModel
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from IndividualizedProgramAccommodationSubject";

        // member variable for the IndividualizedProgramAccommodationId property
        private Guid _IndividualizedProgramAccommodationId;

        // member variable for the RefSCEDCourseSubjectAreaId property
        private Guid _RefSCEDCourseSubjectAreaId;

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
        /// The title of the IndividualizedProgramAccommodationSubjectViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="IndividualizedProgramAccommodationId"/> model
        /// </summary>
        public Guid IndividualizedProgramAccommodationId { get => _IndividualizedProgramAccommodationId; set => SetProperty(ref _IndividualizedProgramAccommodationId, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefSCEDCourseSubjectAreaId"/> model
        /// </summary>
        public Guid RefSCEDCourseSubjectAreaId { get => _RefSCEDCourseSubjectAreaId; set => SetProperty(ref _RefSCEDCourseSubjectAreaId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IIndividualizedProgramAccommodationSubject model)
        {
            IsBusy = true;
            Id = model.Id;
            IndividualizedProgramAccommodationId = model.IndividualizedProgramAccommodationId;
            RefSCEDCourseSubjectAreaId = model.RefSCEDCourseSubjectAreaId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
