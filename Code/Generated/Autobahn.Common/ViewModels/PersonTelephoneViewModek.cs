//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   PersonTelephoneViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Common.Interfaces;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The PersonTelephoneViewModel
     /// </summary>
    public partial class PersonTelephoneViewModel : BindableBase, IPersonTelephone
    {
#region "Backing Fields"
        // member variable for the TelephoneNumber property
        private System.String _TelephoneNumber;

        // member variable for the PrimaryTelephoneNumberIndicator property
        private System.Boolean _PrimaryTelephoneNumberIndicator;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

        // member variable for the DoNotPublishIndicator property
        private System.Boolean? _DoNotPublishIndicator;

#endregion

#region Properties
        /// <summary>
        /// Reference to a required instance of the <see cref="PersonId"/> model
        /// </summary>
        public Guid PersonId { get; set; }

        public System.String TelephoneNumber  { get => _TelephoneNumber; set => SetProperty(ref _TelephoneNumber, value); }

        public System.Boolean PrimaryTelephoneNumberIndicator  { get => _PrimaryTelephoneNumberIndicator; set => SetProperty(ref _PrimaryTelephoneNumberIndicator, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPersonTelephoneNumberTypeId"/> model
        /// </summary>
        public Guid? RefPersonTelephoneNumberTypeId { get; set; }

        public System.DateTime? RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        public System.DateTime? RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        public System.Boolean? DoNotPublishIndicator { get => _DoNotPublishIndicator; set => SetProperty(ref _DoNotPublishIndicator, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTelephoneNumberListedStatusId"/> model
        /// </summary>
        public Guid? RefTelephoneNumberListedStatusId { get; set; }

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
        public void Load(IPersonTelephone model)
        {
            IsBusy = true;
            Id = model.Id;
            PersonId = model.PersonId;
            TelephoneNumber = model.TelephoneNumber;
            PrimaryTelephoneNumberIndicator = model.PrimaryTelephoneNumberIndicator;
            RefPersonTelephoneNumberTypeId = model.RefPersonTelephoneNumberTypeId;
            RecordStartDateTime = model.RecordStartDateTime;
            RecordEndDateTime = model.RecordEndDateTime;
            DoNotPublishIndicator = model.DoNotPublishIndicator;
            RefTelephoneNumberListedStatusId = model.RefTelephoneNumberListedStatusId;
            RecordStatusId = model.RecordStatusId;
            DataCollectionId = model.DataCollectionId;
            IsChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
