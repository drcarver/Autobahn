//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationTelephoneViewModel.cs
//**********************************************************

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The OrganizationTelephoneViewModel
     /// </summary>
    public partial class OrganizationTelephoneViewModel : ViewModelBase, Interfaces.IOrganizationTelephone
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from OrganizationTelephone";

        // member variable for the DoNotPublishIndicator property
        private  _DoNotPublishIndicator;

        // member variable for the PrimaryTelephoneNumberIndicator property
        private  _PrimaryTelephoneNumberIndicator;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefInstitutionTelephoneTypeId property
        private Guid? _RefInstitutionTelephoneTypeId;

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
        public  PrimaryTelephoneNumberIndicator { get => _PrimaryTelephoneNumberIndicator; set => SetProperty(ref _PrimaryTelephoneNumberIndicator, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefInstitutionTelephoneType"/> model
        /// </summary>
        public Guid? RefInstitutionTelephoneTypeId { get => _RefInstitutionTelephoneTypeId; set => SetProperty(ref _RefInstitutionTelephoneTypeId, value); }

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
        public void Load(Interfaces.IOrganizationTelephone model)
        {
            IsBusy = true;
            Id = model.Id;
            DoNotPublishIndicator = model.DoNotPublishIndicator; // 
            PrimaryTelephoneNumberIndicator = model.PrimaryTelephoneNumberIndicator; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefInstitutionTelephoneTypeId = model.RefInstitutionTelephoneTypeId; // 
            RefTelephoneNumberListedStatusId = model.RefTelephoneNumberListedStatusId; // 
            TelephoneNumber = model.TelephoneNumber; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
