//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonTelephoneViewModel.cs
//**********************************************************

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The PersonTelephoneViewModel
     /// </summary>
    public partial class PersonTelephoneViewModel : ViewModelBase, Interfaces.IPersonTelephone
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PersonTelephone";

        // member variable for the DoNotPublishIndicator property
        private  _DoNotPublishIndicator;

        // member variable for the PrimaryTelephoneNumberIndicator property
        private Guid? _PrimaryTelephoneNumberIndicator;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefPersonTelephoneNumberTypeId property
        private  _RefPersonTelephoneNumberTypeId;

        // member variable for the RefTelephoneNumberListedStatusId property
        private  _RefTelephoneNumberListedStatusId;

        // member variable for the TelephoneNumber property
        private  _TelephoneNumber;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public  DoNotPublishIndicator { get => _DoNotPublishIndicator; set => SetProperty(ref _DoNotPublishIndicator, value); }

        /// <summary>
        /// </summary>
        public Guid? PrimaryTelephoneNumberIndicator { get => _PrimaryTelephoneNumberIndicator; set => SetProperty(ref _PrimaryTelephoneNumberIndicator, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPersonTelephoneNumberType"/> model
        /// </summary>
        public  RefPersonTelephoneNumberTypeId { get => _RefPersonTelephoneNumberTypeId; set => SetProperty(ref _RefPersonTelephoneNumberTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTelephoneNumberListedStatus"/> model
        /// </summary>
        public  RefTelephoneNumberListedStatusId { get => _RefTelephoneNumberListedStatusId; set => SetProperty(ref _RefTelephoneNumberListedStatusId, value); }

        /// <summary>
        /// </summary>
        public  TelephoneNumber { get => _TelephoneNumber; set => SetProperty(ref _TelephoneNumber, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPersonTelephone model)
        {
            IsBusy = true;
            Id = model.Id;
            DoNotPublishIndicator = model.DoNotPublishIndicator; // 
            PrimaryTelephoneNumberIndicator = model.PrimaryTelephoneNumberIndicator; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefPersonTelephoneNumberTypeId = model.RefPersonTelephoneNumberTypeId; // 
            RefTelephoneNumberListedStatusId = model.RefTelephoneNumberListedStatusId; // 
            TelephoneNumber = model.TelephoneNumber; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
