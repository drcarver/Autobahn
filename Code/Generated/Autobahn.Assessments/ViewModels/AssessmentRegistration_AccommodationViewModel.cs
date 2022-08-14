//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentRegistration_AccommodationViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.Assessments.ViewModels
{
     /// <summary>
     /// The AssessmentRegistration_AccommodationViewModel
     /// </summary>
    public partial class AssessmentRegistration_AccommodationViewModel : ViewModelBase, Interfaces.IAssessmentRegistration_Accommodation
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from AssessmentRegistration_Accommodation";

        // member variable for the AssessmentAccommodationId property
        private Guid _AssessmentAccommodationId;

        // member variable for the AssessmentRegistrationId property
        private Guid _AssessmentRegistrationId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the AssessmentRegistration_AccommodationViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="AssessmentAccommodation"/> model
        /// </summary>
        public Guid AssessmentAccommodationId { get => _AssessmentAccommodationId; set => SetProperty(ref _AssessmentAccommodationId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="AssessmentRegistration"/> model
        /// </summary>
        public Guid AssessmentRegistrationId { get => _AssessmentRegistrationId; set => SetProperty(ref _AssessmentRegistrationId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAssessmentRegistration_Accommodation model)
        {
            IsBusy = true;
            Id = model.Id;
            AssessmentAccommodationId = model.AssessmentAccommodationId;
            AssessmentRegistrationId = model.AssessmentRegistrationId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
