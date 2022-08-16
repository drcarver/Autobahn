//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonDigitalAccessSpeedViewModel.cs
//**********************************************************

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The PersonDigitalAccessSpeedViewModel
     /// </summary>
    public partial class PersonDigitalAccessSpeedViewModel : ViewModelBase, Interfaces.IPersonDigitalAccessSpeed
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PersonDigitalAccessSpeed";

        // member variable for the InternetDownloadSpeed property
        private  _InternetDownloadSpeed;

        // member variable for the InternetSpeedTestDateTime property
        private  _InternetSpeedTestDateTime;

        // member variable for the InternetUploadSpeed property
        private  _InternetUploadSpeed;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private Guid? _RecordStartDateTime;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public  InternetDownloadSpeed { get => _InternetDownloadSpeed; set => SetProperty(ref _InternetDownloadSpeed, value); }

        /// <summary>
        /// </summary>
        public  InternetSpeedTestDateTime { get => _InternetSpeedTestDateTime; set => SetProperty(ref _InternetSpeedTestDateTime, value); }

        /// <summary>
        /// </summary>
        public  InternetUploadSpeed { get => _InternetUploadSpeed; set => SetProperty(ref _InternetUploadSpeed, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public Guid? RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPersonDigitalAccessSpeed model)
        {
            IsBusy = true;
            Id = model.Id;
            InternetDownloadSpeed = model.InternetDownloadSpeed; // 
            InternetSpeedTestDateTime = model.InternetSpeedTestDateTime; // 
            InternetUploadSpeed = model.InternetUploadSpeed; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
