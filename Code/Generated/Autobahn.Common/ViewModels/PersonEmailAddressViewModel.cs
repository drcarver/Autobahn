//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonEmailAddressViewModel.cs
//**********************************************************

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The PersonEmailAddressViewModel
     /// </summary>
    public partial class PersonEmailAddressViewModel : ViewModelBase, Interfaces.IPersonEmailAddress
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PersonEmailAddress";

        // member variable for the DoNotPublishIndicator property
        private  _DoNotPublishIndicator;

        // member variable for the EmailAddress property
        private Guid? _EmailAddress;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefEmailTypeId property
        private  _RefEmailTypeId;

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
        public Guid? EmailAddress { get => _EmailAddress; set => SetProperty(ref _EmailAddress, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEmailType"/> model
        /// </summary>
        public  RefEmailTypeId { get => _RefEmailTypeId; set => SetProperty(ref _RefEmailTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPersonEmailAddress model)
        {
            IsBusy = true;
            Id = model.Id;
            DoNotPublishIndicator = model.DoNotPublishIndicator; // 
            EmailAddress = model.EmailAddress; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefEmailTypeId = model.RefEmailTypeId; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
