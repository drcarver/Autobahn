//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   ELChildDemographicViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.EarlyLearning.ViewModels
{
     /// <summary>
     /// The ELChildDemographicViewModel
     /// </summary>
    public partial class ELChildDemographicViewModel : ViewModelBase, Interfaces.IELChildDemographic
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from ELChildDemographic";

        // member variable for the PersonId property
        private Guid _PersonId;

        // member variable for the FosterCareStartDate property
        private System.DateTime? _FosterCareStartDate;

        // member variable for the FosterCareEndDate property
        private System.DateTime? _FosterCareEndDate;

        // member variable for the OtherRaceIndicator property
        private System.Boolean? _OtherRaceIndicator;

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
        /// The title of the ELChildDemographicViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="PersonId"/> model
        /// </summary>
        public Guid PersonId { get => _PersonId; set => SetProperty(ref _PersonId, value); }

        public System.DateTime? FosterCareStartDate { get => _FosterCareStartDate; set => SetProperty(ref _FosterCareStartDate, value); }

        public System.DateTime? FosterCareEndDate { get => _FosterCareEndDate; set => SetProperty(ref _FosterCareEndDate, value); }

        public System.Boolean? OtherRaceIndicator { get => _OtherRaceIndicator; set => SetProperty(ref _OtherRaceIndicator, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IELChildDemographic model)
        {
            IsBusy = true;
            Id = model.Id;
            PersonId = model.PersonId;
            FosterCareStartDate = model.FosterCareStartDate;
            FosterCareEndDate = model.FosterCareEndDate;
            OtherRaceIndicator = model.OtherRaceIndicator;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
