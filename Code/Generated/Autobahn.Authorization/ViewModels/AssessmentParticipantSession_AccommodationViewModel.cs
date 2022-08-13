//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   AssessmentParticipantSession_AccommodationViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;
using CommunityToolkit.Maui;

namespace Autobahn.Authorization.ViewModels
{
     /// <summary>
     /// The AssessmentParticipantSession_AccommodationViewModel
     /// </summary>
    public partial class AssessmentParticipantSession_AccommodationViewModel : ViewModelBase, Interfaces.IAssessmentParticipantSession_Accommodation
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from AssessmentParticipantSession_Accommodation";

        // member variable for the AssessmentAccommodationId property
        private Guid _AssessmentAccommodationId;

        // member variable for the AssessmentParticipantSessionId property
        private Guid _AssessmentParticipantSessionId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the AssessmentParticipantSession_AccommodationViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="AssessmentAccommodation"/> model
        /// </summary>
        public Guid AssessmentAccommodationId { get => _AssessmentAccommodationId; set => SetProperty(ref _AssessmentAccommodationId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="AssessmentParticipantSession"/> model
        /// </summary>
        public Guid AssessmentParticipantSessionId { get => _AssessmentParticipantSessionId; set => SetProperty(ref _AssessmentParticipantSessionId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAssessmentParticipantSession_Accommodation model)
        {
            IsBusy = true;
            Id = model.Id;
            AssessmentAccommodationId = model.AssessmentAccommodationId;
            AssessmentParticipantSessionId = model.AssessmentParticipantSessionId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
