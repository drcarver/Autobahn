//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonHealthViewModel.cs
//**********************************************************

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The PersonHealthViewModel
     /// </summary>
    public partial class PersonHealthViewModel : ViewModelBase, Interfaces.IPersonHealth
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PersonHealth";

        // member variable for the DentalScreeningDate property
        private  _DentalScreeningDate;

        // member variable for the HealthScreeningEquipmentUsed property
        private  _HealthScreeningEquipmentUsed;

        // member variable for the HealthScreeningFollowUpRecommendation property
        private  _HealthScreeningFollowUpRecommendation;

        // member variable for the HearingScreeningDate property
        private  _HearingScreeningDate;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefDentalInsuranceCoverageTypeId property
        private  _RefDentalInsuranceCoverageTypeId;

        // member variable for the RefDentalScreeningStatusId property
        private  _RefDentalScreeningStatusId;

        // member variable for the RefHealthInsuranceCoverageId property
        private  _RefHealthInsuranceCoverageId;

        // member variable for the RefHearingScreeningStatusId property
        private  _RefHearingScreeningStatusId;

        // member variable for the RefMedicalAlertIndicatorId property
        private  _RefMedicalAlertIndicatorId;

        // member variable for the RefVisionScreeningStatusId property
        private Guid? _RefVisionScreeningStatusId;

        // member variable for the VisionScreeningDate property
        private  _VisionScreeningDate;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public  DentalScreeningDate { get => _DentalScreeningDate; set => SetProperty(ref _DentalScreeningDate, value); }

        /// <summary>
        /// </summary>
        public  HealthScreeningEquipmentUsed { get => _HealthScreeningEquipmentUsed; set => SetProperty(ref _HealthScreeningEquipmentUsed, value); }

        /// <summary>
        /// </summary>
        public  HealthScreeningFollowUpRecommendation { get => _HealthScreeningFollowUpRecommendation; set => SetProperty(ref _HealthScreeningFollowUpRecommendation, value); }

        /// <summary>
        /// </summary>
        public  HearingScreeningDate { get => _HearingScreeningDate; set => SetProperty(ref _HearingScreeningDate, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefDentalInsuranceCoverageType"/> model
        /// </summary>
        public  RefDentalInsuranceCoverageTypeId { get => _RefDentalInsuranceCoverageTypeId; set => SetProperty(ref _RefDentalInsuranceCoverageTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefDentalScreeningStatus"/> model
        /// </summary>
        public  RefDentalScreeningStatusId { get => _RefDentalScreeningStatusId; set => SetProperty(ref _RefDentalScreeningStatusId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefHealthInsuranceCoverage"/> model
        /// </summary>
        public  RefHealthInsuranceCoverageId { get => _RefHealthInsuranceCoverageId; set => SetProperty(ref _RefHealthInsuranceCoverageId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefHearingScreeningStatus"/> model
        /// </summary>
        public  RefHearingScreeningStatusId { get => _RefHearingScreeningStatusId; set => SetProperty(ref _RefHearingScreeningStatusId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefMedicalAlertIndicator"/> model
        /// </summary>
        public  RefMedicalAlertIndicatorId { get => _RefMedicalAlertIndicatorId; set => SetProperty(ref _RefMedicalAlertIndicatorId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefVisionScreeningStatus"/> model
        /// </summary>
        public Guid? RefVisionScreeningStatusId { get => _RefVisionScreeningStatusId; set => SetProperty(ref _RefVisionScreeningStatusId, value); }

        /// <summary>
        /// </summary>
        public  VisionScreeningDate { get => _VisionScreeningDate; set => SetProperty(ref _VisionScreeningDate, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPersonHealth model)
        {
            IsBusy = true;
            Id = model.Id;
            DentalScreeningDate = model.DentalScreeningDate; // 
            HealthScreeningEquipmentUsed = model.HealthScreeningEquipmentUsed; // 
            HealthScreeningFollowUpRecommendation = model.HealthScreeningFollowUpRecommendation; // 
            HearingScreeningDate = model.HearingScreeningDate; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefDentalInsuranceCoverageTypeId = model.RefDentalInsuranceCoverageTypeId; // 
            RefDentalScreeningStatusId = model.RefDentalScreeningStatusId; // 
            RefHealthInsuranceCoverageId = model.RefHealthInsuranceCoverageId; // 
            RefHearingScreeningStatusId = model.RefHearingScreeningStatusId; // 
            RefMedicalAlertIndicatorId = model.RefMedicalAlertIndicatorId; // 
            RefVisionScreeningStatusId = model.RefVisionScreeningStatusId; // 
            VisionScreeningDate = model.VisionScreeningDate; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
