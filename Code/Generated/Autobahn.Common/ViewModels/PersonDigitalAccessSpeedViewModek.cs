//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   PersonDigitalAccessSpeedViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Common.Interfaces;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The PersonDigitalAccessSpeedViewModel
     /// </summary>
    public partial class PersonDigitalAccessSpeedViewModel : BindableBase, IPersonDigitalAccessSpeed
    {
#region "Backing Fields"
        // member variable for the InternetDownloadSpeed property
        private System.Decimal? _InternetDownloadSpeed;

        // member variable for the InternetSpeedTestDateTime property
        private System.DateTime? _InternetSpeedTestDateTime;

        // member variable for the InternetUploadSpeed property
        private System.Decimal? _InternetUploadSpeed;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

#endregion

#region Properties
        public System.Decimal? InternetDownloadSpeed { get => _InternetDownloadSpeed; set => SetProperty(ref _InternetDownloadSpeed, value); }

        public System.DateTime? InternetSpeedTestDateTime { get => _InternetSpeedTestDateTime; set => SetProperty(ref _InternetSpeedTestDateTime, value); }

        public System.Decimal? InternetUploadSpeed { get => _InternetUploadSpeed; set => SetProperty(ref _InternetUploadSpeed, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="PersonDigitalAccessId"/> model
        /// </summary>
        public Guid? PersonDigitalAccessId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="PersonLearningDeviceId"/> model
        /// </summary>
        public Guid? PersonLearningDeviceId { get; set; }

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
        public void Load(IPersonDigitalAccessSpeed model)
        {
            IsBusy = true;
            Id = model.Id;
            InternetDownloadSpeed = model.InternetDownloadSpeed;
            InternetSpeedTestDateTime = model.InternetSpeedTestDateTime;
            InternetUploadSpeed = model.InternetUploadSpeed;
            PersonDigitalAccessId = model.PersonDigitalAccessId;
            PersonLearningDeviceId = model.PersonLearningDeviceId;
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
