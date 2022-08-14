//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonDigitalAccessSpeedViewModel.cs
//**********************************************************

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
        private System.Decimal? _InternetDownloadSpeed;

        // member variable for the InternetSpeedTestDateTime property
        private System.DateTime? _InternetSpeedTestDateTime;

        // member variable for the InternetUploadSpeed property
        private System.Decimal? _InternetUploadSpeed;

        // member variable for the PersonDigitalAccessId property
        private Guid? _PersonDigitalAccessId;

        // member variable for the PersonLearningDeviceId property
        private Guid? _PersonLearningDeviceId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the PersonDigitalAccessSpeedViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public System.Decimal? InternetDownloadSpeed { get => _InternetDownloadSpeed; set => SetProperty(ref _InternetDownloadSpeed, value); }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public System.DateTime? InternetSpeedTestDateTime { get => _InternetSpeedTestDateTime; set => SetProperty(ref _InternetSpeedTestDateTime, value); }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public System.Decimal? InternetUploadSpeed { get => _InternetUploadSpeed; set => SetProperty(ref _InternetUploadSpeed, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="PersonDigitalAccess"/> model
        /// </summary>
        public Guid? PersonDigitalAccessId { get => _PersonDigitalAccessId; set => SetProperty(ref _PersonDigitalAccessId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="PersonLearningDevice"/> model
        /// </summary>
        public Guid? PersonLearningDeviceId { get => _PersonLearningDeviceId; set => SetProperty(ref _PersonLearningDeviceId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPersonDigitalAccessSpeed model)
        {
            IsBusy = true;
            Id = model.Id;
            InternetDownloadSpeed = model.InternetDownloadSpeed;
            InternetSpeedTestDateTime = model.InternetSpeedTestDateTime;
            InternetUploadSpeed = model.InternetUploadSpeed;
            PersonDigitalAccessId = model.PersonDigitalAccessId;
            PersonLearningDeviceId = model.PersonLearningDeviceId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
