//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IndividualizedProgramAssessmentAccommodationViewModel.cs
//**********************************************************


namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The IndividualizedProgramAssessmentAccommodationViewModel
     /// </summary>
    public partial class IndividualizedProgramAssessmentAccommodationViewModel : ViewModelBase, Interfaces.IIndividualizedProgramAssessmentAccommodationViewModel
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from IndividualizedProgramAssessmentAccommodation";

        // member variable for the AssessmentAccommodationId property
        private Guid _AssessmentAccommodationId;

        // member variable for the IndividualizedProgramAssessmentId property
        private Guid _IndividualizedProgramAssessmentId;

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
        /// The title of the IndividualizedProgramAssessmentAccommodationViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentAccommodationId"/> model
        /// </summary>
        public Guid AssessmentAccommodationId { get => _AssessmentAccommodationId; set => SetProperty(ref _AssessmentAccommodationId, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="IndividualizedProgramAssessmentId"/> model
        /// </summary>
        public Guid IndividualizedProgramAssessmentId { get => _IndividualizedProgramAssessmentId; set => SetProperty(ref _IndividualizedProgramAssessmentId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IIndividualizedProgramAssessmentAccommodation model)
        {
            IsBusy = true;
            Id = model.Id;
            AssessmentAccommodationId = model.AssessmentAccommodationId;
            IndividualizedProgramAssessmentId = model.IndividualizedProgramAssessmentId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
