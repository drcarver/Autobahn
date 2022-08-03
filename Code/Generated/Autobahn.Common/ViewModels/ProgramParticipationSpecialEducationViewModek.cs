//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   ProgramParticipationSpecialEducationViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Common.Interfaces;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The ProgramParticipationSpecialEducationViewModel
     /// </summary>
    public partial class ProgramParticipationSpecialEducationViewModel : BindableBase, IProgramParticipationSpecialEducation
    {
#region "Backing Fields"
        // member variable for the AwaitingInitialIDEAEvaluationStatus property
        private System.Boolean? _AwaitingInitialIDEAEvaluationStatus;

        // member variable for the SpecialEducationFTE property
        private System.Decimal? _SpecialEducationFTE;

        // member variable for the SpecialEducationServicesExitDate property
        private System.DateTime? _SpecialEducationServicesExitDate;

        // member variable for the IDEAPlacementRationale property
        private System.String _IDEAPlacementRationale;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

#endregion

#region Properties
        /// <summary>
        /// Reference to a required instance of the <see cref="PersonProgramParticipationId"/> model
        /// </summary>
        public Guid PersonProgramParticipationId { get; set; }

        public System.Boolean? AwaitingInitialIDEAEvaluationStatus { get => _AwaitingInitialIDEAEvaluationStatus; set => SetProperty(ref _AwaitingInitialIDEAEvaluationStatus, value); }

        public System.Decimal? SpecialEducationFTE { get => _SpecialEducationFTE; set => SetProperty(ref _SpecialEducationFTE, value); }

        public System.DateTime? SpecialEducationServicesExitDate { get => _SpecialEducationServicesExitDate; set => SetProperty(ref _SpecialEducationServicesExitDate, value); }

        public System.String IDEAPlacementRationale  { get => _IDEAPlacementRationale; set => SetProperty(ref _IDEAPlacementRationale, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIDEAEducationalEnvironmentECId"/> model
        /// </summary>
        public Guid? RefIDEAEducationalEnvironmentECId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIDEAEducationalEnvironmentSchoolAgeId"/> model
        /// </summary>
        public Guid? RefIDEAEducationalEnvironmentSchoolAgeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefSpecialEducationExitReasonId"/> model
        /// </summary>
        public Guid? RefSpecialEducationExitReasonId { get; set; }

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
        public void Load(IProgramParticipationSpecialEducation model)
        {
            IsBusy = true;
            Id = model.Id;
            PersonProgramParticipationId = model.PersonProgramParticipationId;
            AwaitingInitialIDEAEvaluationStatus = model.AwaitingInitialIDEAEvaluationStatus;
            SpecialEducationFTE = model.SpecialEducationFTE;
            SpecialEducationServicesExitDate = model.SpecialEducationServicesExitDate;
            IDEAPlacementRationale = model.IDEAPlacementRationale;
            RefIDEAEducationalEnvironmentECId = model.RefIDEAEducationalEnvironmentECId;
            RefIDEAEducationalEnvironmentSchoolAgeId = model.RefIDEAEducationalEnvironmentSchoolAgeId;
            RefSpecialEducationExitReasonId = model.RefSpecialEducationExitReasonId;
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
