//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentParticipantSession_AccommodationViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.Assessment.ViewModels
{
     /// <summary>
     /// The AssessmentParticipantSession_AccommodationViewModel
     /// </summary>
    public partial class AssessmentParticipantSession_AccommodationViewModel : ViewModelBase, Interfaces.IAssessmentParticipantSession_AccommodationViewModel
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from AssessmentParticipantSession_Accommodation";

        // member variable for the AssessmentParticipantSessionId property
        private Guid _AssessmentParticipantSessionId;

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
        /// The title of the AssessmentParticipantSession_AccommodationViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentParticipantSessionId"/> model
        /// </summary>
        public Guid AssessmentParticipantSessionId { get => _AssessmentParticipantSessionId; set => SetProperty(ref _AssessmentParticipantSessionId, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentAccommodationId"/> model
        /// </summary>
        public Guid AssessmentAccommodationId { get => _AssessmentAccommodationId; set => SetProperty(ref _AssessmentAccommodationId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAssessmentParticipantSession_Accommodation model)
        {
            IsBusy = true;
            Id = model.Id;
            AssessmentParticipantSessionId = model.AssessmentParticipantSessionId;
            AssessmentAccommodationId = model.AssessmentAccommodationId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
