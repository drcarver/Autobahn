//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   PersonHealthViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Common.Interfaces;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The PersonHealthViewModel
     /// </summary>
    public partial class PersonHealthViewModel : BindableBase, IPersonHealth
    {
#region "Backing Fields"
        // member variable for the VisionScreeningDate property
        private System.DateTime? _VisionScreeningDate;

        // member variable for the HearingScreeningDate property
        private System.DateTime? _HearingScreeningDate;

        // member variable for the DentalScreeningDate property
        private System.DateTime _DentalScreeningDate;

        // member variable for the HealthScreeningEquipmentUsed property
        private System.String _HealthScreeningEquipmentUsed;

        // member variable for the HealthScreeningFollowUpRecommendation property
        private System.String _HealthScreeningFollowUpRecommendation;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

#endregion

#region Properties
        /// <summary>
        /// Reference to a required instance of the <see cref="PersonId"/> model
        /// </summary>
        public Guid PersonId { get; set; }

        public System.DateTime? VisionScreeningDate { get => _VisionScreeningDate; set => SetProperty(ref _VisionScreeningDate, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefVisionScreeningStatusId"/> model
        /// </summary>
        public Guid? RefVisionScreeningStatusId { get; set; }

        public System.DateTime? HearingScreeningDate { get => _HearingScreeningDate; set => SetProperty(ref _HearingScreeningDate, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefHearingScreeningStatusId"/> model
        /// </summary>
        public Guid? RefHearingScreeningStatusId { get; set; }

        public System.DateTime DentalScreeningDate  { get => _DentalScreeningDate; set => SetProperty(ref _DentalScreeningDate, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefDentalScreeningStatusId"/> model
        /// </summary>
        public Guid? RefDentalScreeningStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefHealthInsuranceCoverageId"/> model
        /// </summary>
        public Guid? RefHealthInsuranceCoverageId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefDentalInsuranceCoverageTypeId"/> model
        /// </summary>
        public Guid? RefDentalInsuranceCoverageTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefMedicalAlertIndicatorId"/> model
        /// </summary>
        public Guid? RefMedicalAlertIndicatorId { get; set; }

        public System.String HealthScreeningEquipmentUsed  { get => _HealthScreeningEquipmentUsed; set => SetProperty(ref _HealthScreeningEquipmentUsed, value); }

        public System.String HealthScreeningFollowUpRecommendation  { get => _HealthScreeningFollowUpRecommendation; set => SetProperty(ref _HealthScreeningFollowUpRecommendation, value); }

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
        public void Load(IPersonHealth model)
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
