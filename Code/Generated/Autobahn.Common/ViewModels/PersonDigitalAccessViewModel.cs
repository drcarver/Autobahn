//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonDigitalAccessViewModel.cs
//**********************************************************

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The PersonDigitalAccessViewModel
     /// </summary>
    public partial class PersonDigitalAccessViewModel : ViewModelBase, Interfaces.IPersonDigitalAccess
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PersonDigitalAccess";

        // member variable for the InternetAccessInResidence property
        private  _InternetAccessInResidence;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private Guid? _RecordStartDateTime;

        // member variable for the RefBarrierToInternetAccessInResidenceId property
        private  _RefBarrierToInternetAccessInResidenceId;

        // member variable for the RefInternetAccessTypeInResidenceId property
        private  _RefInternetAccessTypeInResidenceId;

        // member variable for the RefInternetPerformanceInResidenceId property
        private  _RefInternetPerformanceInResidenceId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public  InternetAccessInResidence { get => _InternetAccessInResidence; set => SetProperty(ref _InternetAccessInResidence, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public Guid? RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBarrierToInternetAccessInResidence"/> model
        /// </summary>
        public  RefBarrierToInternetAccessInResidenceId { get => _RefBarrierToInternetAccessInResidenceId; set => SetProperty(ref _RefBarrierToInternetAccessInResidenceId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefInternetAccessTypeInResidence"/> model
        /// </summary>
        public  RefInternetAccessTypeInResidenceId { get => _RefInternetAccessTypeInResidenceId; set => SetProperty(ref _RefInternetAccessTypeInResidenceId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefInternetPerformanceInResidence"/> model
        /// </summary>
        public  RefInternetPerformanceInResidenceId { get => _RefInternetPerformanceInResidenceId; set => SetProperty(ref _RefInternetPerformanceInResidenceId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPersonDigitalAccess model)
        {
            IsBusy = true;
            Id = model.Id;
            InternetAccessInResidence = model.InternetAccessInResidence; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefBarrierToInternetAccessInResidenceId = model.RefBarrierToInternetAccessInResidenceId; // 
            RefInternetAccessTypeInResidenceId = model.RefInternetAccessTypeInResidenceId; // 
            RefInternetPerformanceInResidenceId = model.RefInternetPerformanceInResidenceId; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
