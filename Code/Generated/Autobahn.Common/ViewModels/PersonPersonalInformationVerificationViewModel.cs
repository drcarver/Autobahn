//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonPersonalInformationVerificationViewModel.cs
//**********************************************************

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The PersonPersonalInformationVerificationViewModel
     /// </summary>
    public partial class PersonPersonalInformationVerificationViewModel : ViewModelBase, Interfaces.IPersonPersonalInformationVerification
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PersonPersonalInformationVerification";

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefPersonalInformationTypeId property
        private  _RefPersonalInformationTypeId;

        // member variable for the RefPersonalInformationVerificationId property
        private Guid? _RefPersonalInformationVerificationId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPersonalInformationType"/> model
        /// </summary>
        public  RefPersonalInformationTypeId { get => _RefPersonalInformationTypeId; set => SetProperty(ref _RefPersonalInformationTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPersonalInformationVerification"/> model
        /// </summary>
        public Guid? RefPersonalInformationVerificationId { get => _RefPersonalInformationVerificationId; set => SetProperty(ref _RefPersonalInformationVerificationId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPersonPersonalInformationVerification model)
        {
            IsBusy = true;
            Id = model.Id;
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefPersonalInformationTypeId = model.RefPersonalInformationTypeId; // 
            RefPersonalInformationVerificationId = model.RefPersonalInformationVerificationId; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
