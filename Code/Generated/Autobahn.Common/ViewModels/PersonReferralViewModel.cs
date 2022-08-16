//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonReferralViewModel.cs
//**********************************************************

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The PersonReferralViewModel
     /// </summary>
    public partial class PersonReferralViewModel : ViewModelBase, Interfaces.IPersonReferral
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PersonReferral";

        // member variable for the Reason property
        private  _Reason;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the ReferralDate property
        private Guid? _ReferralDate;

        // member variable for the ReferralTypeReceived property
        private  _ReferralTypeReceived;

        // member variable for the ReferredTo property
        private  _ReferredTo;

        // member variable for the RefReferralOutcomeId property
        private  _RefReferralOutcomeId;

        // member variable for the Source property
        private  _Source;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public  Reason { get => _Reason; set => SetProperty(ref _Reason, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// </summary>
        public Guid? ReferralDate { get => _ReferralDate; set => SetProperty(ref _ReferralDate, value); }

        /// <summary>
        /// </summary>
        public  ReferralTypeReceived { get => _ReferralTypeReceived; set => SetProperty(ref _ReferralTypeReceived, value); }

        /// <summary>
        /// </summary>
        public  ReferredTo { get => _ReferredTo; set => SetProperty(ref _ReferredTo, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefReferralOutcome"/> model
        /// </summary>
        public  RefReferralOutcomeId { get => _RefReferralOutcomeId; set => SetProperty(ref _RefReferralOutcomeId, value); }

        /// <summary>
        /// </summary>
        public  Source { get => _Source; set => SetProperty(ref _Source, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPersonReferral model)
        {
            IsBusy = true;
            Id = model.Id;
            Reason = model.Reason; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            ReferralDate = model.ReferralDate; // 
            ReferralTypeReceived = model.ReferralTypeReceived; // 
            ReferredTo = model.ReferredTo; // 
            RefReferralOutcomeId = model.RefReferralOutcomeId; // 
            Source = model.Source; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
