//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   ELChildHealthViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.EarlyLearning.ViewModels
{
     /// <summary>
     /// The ELChildHealthViewModel
     /// </summary>
    public partial class ELChildHealthViewModel : ViewModelBase, Interfaces.IELChildHealthViewModel
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from ELChildHealth";

        // member variable for the PersonId property
        private Guid _PersonId;

        // member variable for the WellChildScreeningReceivedDate property
        private System.DateTime? _WellChildScreeningReceivedDate;

        // member variable for the RefScheduledWellChildScreeningId property
        private Guid? _RefScheduledWellChildScreeningId;

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
        /// The title of the ELChildHealthViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="PersonId"/> model
        /// </summary>
        public Guid PersonId { get => _PersonId; set => SetProperty(ref _PersonId, value); }

        public System.DateTime? WellChildScreeningReceivedDate { get => _WellChildScreeningReceivedDate; set => SetProperty(ref _WellChildScreeningReceivedDate, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefScheduledWellChildScreeningId"/> model
        /// </summary>
        public Guid? RefScheduledWellChildScreeningId { get => _RefScheduledWellChildScreeningId; set => SetProperty(ref _RefScheduledWellChildScreeningId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IELChildHealth model)
        {
            IsBusy = true;
            Id = model.Id;
            PersonId = model.PersonId;
            WellChildScreeningReceivedDate = model.WellChildScreeningReceivedDate;
            RefScheduledWellChildScreeningId = model.RefScheduledWellChildScreeningId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
