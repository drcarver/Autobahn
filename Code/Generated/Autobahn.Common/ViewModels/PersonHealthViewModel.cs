//**********************************************************
//* DomainName: Common Models
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

        // member variable for the DentalScreeningDate property
        private System.DateTime _DentalScreeningDate;

        // member variable for the HealthScreeningEquipmentUsed property
        private System.String _HealthScreeningEquipmentUsed;

        // member variable for the HealthScreeningFollowUpRecommendation property
        private System.String _HealthScreeningFollowUpRecommendation;

        // member variable for the HearingScreeningDate property
        private System.DateTime? _HearingScreeningDate;

        // member variable for the PersonId property
        private Guid _PersonId;

        // member variable for the RefDentalInsuranceCoverageTypeId property
        private Guid? _RefDentalInsuranceCoverageTypeId;

        // member variable for the RefDentalScreeningStatusId property
        private Guid? _RefDentalScreeningStatusId;

        // member variable for the RefHealthInsuranceCoverageId property
        private Guid? _RefHealthInsuranceCoverageId;

        // member variable for the RefHearingScreeningStatusId property
        private Guid? _RefHearingScreeningStatusId;

        // member variable for the RefMedicalAlertIndicatorId property
        private Guid? _RefMedicalAlertIndicatorId;

        // member variable for the RefVisionScreeningStatusId property
        private Guid? _RefVisionScreeningStatusId;

        // member variable for the VisionScreeningDate property
        private System.DateTime? _VisionScreeningDate;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the PersonHealthViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Status of an examination used to measure a person's ability to see.
        /// </summary>
        public System.DateTime DentalScreeningDate { get => _DentalScreeningDate; set => SetProperty(ref _DentalScreeningDate, value); }

        /// <summary>
        /// Status of an examination used to measure a person's ability to see.
        /// </summary>
        public System.String HealthScreeningEquipmentUsed { get => _HealthScreeningEquipmentUsed; set => SetProperty(ref _HealthScreeningEquipmentUsed, value); }

        /// <summary>
        /// Status of an examination used to measure a person's ability to see.
        /// </summary>
        public System.String HealthScreeningFollowUpRecommendation { get => _HealthScreeningFollowUpRecommendation; set => SetProperty(ref _HealthScreeningFollowUpRecommendation, value); }

        /// <summary>
        /// Status of an examination used to measure a person's ability to see.
        /// </summary>
        public System.DateTime? HearingScreeningDate { get => _HearingScreeningDate; set => SetProperty(ref _HearingScreeningDate, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="Person"/> model
        /// </summary>
        public Guid PersonId { get => _PersonId; set => SetProperty(ref _PersonId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefDentalInsuranceCoverageType"/> model
        /// </summary>
        public Guid? RefDentalInsuranceCoverageTypeId { get => _RefDentalInsuranceCoverageTypeId; set => SetProperty(ref _RefDentalInsuranceCoverageTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefDentalScreeningStatus"/> model
        /// </summary>
        public Guid? RefDentalScreeningStatusId { get => _RefDentalScreeningStatusId; set => SetProperty(ref _RefDentalScreeningStatusId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefHealthInsuranceCoverage"/> model
        /// </summary>
        public Guid? RefHealthInsuranceCoverageId { get => _RefHealthInsuranceCoverageId; set => SetProperty(ref _RefHealthInsuranceCoverageId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefHearingScreeningStatus"/> model
        /// </summary>
        public Guid? RefHearingScreeningStatusId { get => _RefHearingScreeningStatusId; set => SetProperty(ref _RefHearingScreeningStatusId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefMedicalAlertIndicator"/> model
        /// </summary>
        public Guid? RefMedicalAlertIndicatorId { get => _RefMedicalAlertIndicatorId; set => SetProperty(ref _RefMedicalAlertIndicatorId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefVisionScreeningStatus"/> model
        /// </summary>
        public Guid? RefVisionScreeningStatusId { get => _RefVisionScreeningStatusId; set => SetProperty(ref _RefVisionScreeningStatusId, value); }

        /// <summary>
        /// Status of an examination used to measure a person's ability to see.
        /// </summary>
        public System.DateTime? VisionScreeningDate { get => _VisionScreeningDate; set => SetProperty(ref _VisionScreeningDate, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPersonHealth model)
        {
            IsBusy = true;
            Id = model.Id;
            DentalScreeningDate = model.DentalScreeningDate;
            HealthScreeningEquipmentUsed = model.HealthScreeningEquipmentUsed;
            HealthScreeningFollowUpRecommendation = model.HealthScreeningFollowUpRecommendation;
            HearingScreeningDate = model.HearingScreeningDate;
            PersonId = model.PersonId;
            RefDentalInsuranceCoverageTypeId = model.RefDentalInsuranceCoverageTypeId;
            RefDentalScreeningStatusId = model.RefDentalScreeningStatusId;
            RefHealthInsuranceCoverageId = model.RefHealthInsuranceCoverageId;
            RefHearingScreeningStatusId = model.RefHearingScreeningStatusId;
            RefMedicalAlertIndicatorId = model.RefMedicalAlertIndicatorId;
            RefVisionScreeningStatusId = model.RefVisionScreeningStatusId;
            VisionScreeningDate = model.VisionScreeningDate;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
