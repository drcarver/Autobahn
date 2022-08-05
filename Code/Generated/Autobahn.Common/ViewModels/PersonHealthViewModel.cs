//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   PersonHealthViewModel.cs
//**********************************************************


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

        // member variable for the PersonId property
        private Guid _PersonId;

        // member variable for the VisionScreeningDate property
        private System.DateTime? _VisionScreeningDate;

        // member variable for the RefVisionScreeningStatusId property
        private Guid? _RefVisionScreeningStatusId;

        // member variable for the HearingScreeningDate property
        private System.DateTime? _HearingScreeningDate;

        // member variable for the RefHearingScreeningStatusId property
        private Guid? _RefHearingScreeningStatusId;

        // member variable for the DentalScreeningDate property
        private System.DateTime _DentalScreeningDate;

        // member variable for the RefDentalScreeningStatusId property
        private Guid? _RefDentalScreeningStatusId;

        // member variable for the RefHealthInsuranceCoverageId property
        private Guid? _RefHealthInsuranceCoverageId;

        // member variable for the RefDentalInsuranceCoverageTypeId property
        private Guid? _RefDentalInsuranceCoverageTypeId;

        // member variable for the RefMedicalAlertIndicatorId property
        private Guid? _RefMedicalAlertIndicatorId;

        // member variable for the HealthScreeningEquipmentUsed property
        private System.String _HealthScreeningEquipmentUsed;

        // member variable for the HealthScreeningFollowUpRecommendation property
        private System.String _HealthScreeningFollowUpRecommendation;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

        // member variable for the RecordStatusId property
        private Guid? _RecordStatusId;

        // member variable for the DataCollectionId property
        private Guid? _DataCollectionId;

#endregion

        #region Properties
        /// <summary>
        /// The title of the PersonHealthViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="PersonId"/> model
        /// </summary>
        public Guid PersonId { get => _PersonId; set => SetProperty(ref _PersonId, value); }

        public System.DateTime? VisionScreeningDate { get => _VisionScreeningDate; set => SetProperty(ref _VisionScreeningDate, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefVisionScreeningStatusId"/> model
        /// </summary>
        public Guid? RefVisionScreeningStatusId { get => _RefVisionScreeningStatusId; set => SetProperty(ref _RefVisionScreeningStatusId, value); }

        public System.DateTime? HearingScreeningDate { get => _HearingScreeningDate; set => SetProperty(ref _HearingScreeningDate, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefHearingScreeningStatusId"/> model
        /// </summary>
        public Guid? RefHearingScreeningStatusId { get => _RefHearingScreeningStatusId; set => SetProperty(ref _RefHearingScreeningStatusId, value); }

        public System.DateTime DentalScreeningDate  { get => _DentalScreeningDate; set => SetProperty(ref _DentalScreeningDate, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefDentalScreeningStatusId"/> model
        /// </summary>
        public Guid? RefDentalScreeningStatusId { get => _RefDentalScreeningStatusId; set => SetProperty(ref _RefDentalScreeningStatusId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefHealthInsuranceCoverageId"/> model
        /// </summary>
        public Guid? RefHealthInsuranceCoverageId { get => _RefHealthInsuranceCoverageId; set => SetProperty(ref _RefHealthInsuranceCoverageId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefDentalInsuranceCoverageTypeId"/> model
        /// </summary>
        public Guid? RefDentalInsuranceCoverageTypeId { get => _RefDentalInsuranceCoverageTypeId; set => SetProperty(ref _RefDentalInsuranceCoverageTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefMedicalAlertIndicatorId"/> model
        /// </summary>
        public Guid? RefMedicalAlertIndicatorId { get => _RefMedicalAlertIndicatorId; set => SetProperty(ref _RefMedicalAlertIndicatorId, value); }

        public System.String HealthScreeningEquipmentUsed  { get => _HealthScreeningEquipmentUsed; set => SetProperty(ref _HealthScreeningEquipmentUsed, value); }

        public System.String HealthScreeningFollowUpRecommendation  { get => _HealthScreeningFollowUpRecommendation; set => SetProperty(ref _HealthScreeningFollowUpRecommendation, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPersonHealth model)
        {
            IsBusy = true;
            Id = model.Id;
            PersonId = model.PersonId;
            VisionScreeningDate = model.VisionScreeningDate;
            RefVisionScreeningStatusId = model.RefVisionScreeningStatusId;
            HearingScreeningDate = model.HearingScreeningDate;
            RefHearingScreeningStatusId = model.RefHearingScreeningStatusId;
            DentalScreeningDate = model.DentalScreeningDate;
            RefDentalScreeningStatusId = model.RefDentalScreeningStatusId;
            RefHealthInsuranceCoverageId = model.RefHealthInsuranceCoverageId;
            RefDentalInsuranceCoverageTypeId = model.RefDentalInsuranceCoverageTypeId;
            RefMedicalAlertIndicatorId = model.RefMedicalAlertIndicatorId;
            HealthScreeningEquipmentUsed = model.HealthScreeningEquipmentUsed;
            HealthScreeningFollowUpRecommendation = model.HealthScreeningFollowUpRecommendation;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
