//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   PersonReferralViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Common.Interfaces;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The PersonReferralViewModel
     /// </summary>
    public partial class PersonReferralViewModel : BindableBase, IPersonReferral
    {
#region "Backing Fields"
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

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

#endregion

#region Properties
        /// <summary>
        /// Reference to a required instance of the <see cref="PersonId"/> model
        /// </summary>
        public Guid PersonId { get; set; }

        public System.DateTime? ReferralDate { get => _ReferralDate; set => SetProperty(ref _ReferralDate, value); }

        public System.String Reason  { get => _Reason; set => SetProperty(ref _Reason, value); }

        public System.String Source  { get => _Source; set => SetProperty(ref _Source, value); }

        public System.String ReferralTypeReceived  { get => _ReferralTypeReceived; set => SetProperty(ref _ReferralTypeReceived, value); }

        public System.String ReferredTo  { get => _ReferredTo; set => SetProperty(ref _ReferredTo, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefReferralOutcomeId"/> model
        /// </summary>
        public Guid? RefReferralOutcomeId { get; set; }

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
        public void Load(IPersonReferral model)
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
