//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentRegistration_AccommodationViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.Assessment.ViewModels
{
     /// <summary>
     /// The AssessmentRegistration_AccommodationViewModel
     /// </summary>
    public partial class AssessmentRegistration_AccommodationViewModel : ViewModelBase, Interfaces.IAssessmentRegistration_Accommodation
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from AssessmentRegistration_Accommodation";

        // member variable for the AssessmentRegistrationId property
        private Guid _AssessmentRegistrationId;

        // member variable for the AssessmentAccommodationId property
        private Guid _AssessmentAccommodationId;

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
        /// The title of the AssessmentRegistration_AccommodationViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentRegistrationId"/> model
        /// </summary>
        public Guid AssessmentRegistrationId { get => _AssessmentRegistrationId; set => SetProperty(ref _AssessmentRegistrationId, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentAccommodationId"/> model
        /// </summary>
        public Guid AssessmentAccommodationId { get => _AssessmentAccommodationId; set => SetProperty(ref _AssessmentAccommodationId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAssessmentRegistration_Accommodation model)
        {
            IsBusy = true;
            Id = model.Id;
            AssessmentRegistrationId = model.AssessmentRegistrationId;
            AssessmentAccommodationId = model.AssessmentAccommodationId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
