//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   PersonReferralViewModel.cs
//**********************************************************


namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The PersonReferralViewModel
     /// </summary>
    public partial class PersonReferralViewModel : ViewModelBase, Interfaces.IPersonReferralViewModel
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PersonReferral";

        // member variable for the PersonId property
        private Guid _PersonId;

        // member variable for the ReferralDate property
        private System.DateTime? _ReferralDate;

        // member variable for the Reason property
        private System.String _Reason;

        // member variable for the Source property
        private System.String _Source;

        // member variable for the ReferralTypeReceived property
        private System.String _ReferralTypeReceived;

        // member variable for the ReferredTo property
        private System.String _ReferredTo;

        // member variable for the RefReferralOutcomeId property
        private Guid? _RefReferralOutcomeId;

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
        /// The title of the PersonReferralViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="PersonId"/> model
        /// </summary>
        public Guid PersonId { get => _PersonId; set => SetProperty(ref _PersonId, value); }

        public System.DateTime? ReferralDate { get => _ReferralDate; set => SetProperty(ref _ReferralDate, value); }

        public System.String Reason  { get => _Reason; set => SetProperty(ref _Reason, value); }

        public System.String Source  { get => _Source; set => SetProperty(ref _Source, value); }

        public System.String ReferralTypeReceived  { get => _ReferralTypeReceived; set => SetProperty(ref _ReferralTypeReceived, value); }

        public System.String ReferredTo  { get => _ReferredTo; set => SetProperty(ref _ReferredTo, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefReferralOutcomeId"/> model
        /// </summary>
        public Guid? RefReferralOutcomeId { get => _RefReferralOutcomeId; set => SetProperty(ref _RefReferralOutcomeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPersonReferral model)
        {
            IsBusy = true;
            Id = model.Id;
            PersonId = model.PersonId;
            ReferralDate = model.ReferralDate;
            Reason = model.Reason;
            Source = model.Source;
            ReferralTypeReceived = model.ReferralTypeReceived;
            ReferredTo = model.ReferredTo;
            RefReferralOutcomeId = model.RefReferralOutcomeId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
