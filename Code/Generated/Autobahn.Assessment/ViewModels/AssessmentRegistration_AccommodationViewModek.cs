//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentRegistration_AccommodationViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Assessment.Interfaces;

namespace Autobahn.Assessment.ViewModels
{
     /// <summary>
     /// The AssessmentRegistration_AccommodationViewModel
     /// </summary>
    public partial class AssessmentRegistration_AccommodationViewModel : BindableBase, IAssessmentRegistration_Accommodation
    {
#region "Backing Fields"
        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

#endregion

#region Properties
        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentRegistrationId"/> model
        /// </summary>
        public Guid AssessmentRegistrationId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentAccommodationId"/> model
        /// </summary>
        public Guid AssessmentAccommodationId { get; set; }

        public System.DateTime? RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        public System.DateTime? RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatusId"/> model
        /// </summary>
        public Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollectionId"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

#endregion


        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(IAssessmentRegistration_Accommodation model)
        {
            IsBusy = true;
            Id = model.Id;
            AssessmentRegistrationId = model.AssessmentRegistrationId;
            AssessmentAccommodationId = model.AssessmentAccommodationId;
            RecordStartDateTime = model.RecordStartDateTime;
            RecordEndDateTime = model.RecordEndDateTime;
            RecordStatusId = model.RecordStatusId;
            DataCollectionId = model.DataCollectionId;
            IsChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
