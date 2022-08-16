//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   ProgramParticipationSpecialEducationViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Invalid.ViewModels
{
     /// <summary>
     /// The ProgramParticipationSpecialEducationViewModel
     /// </summary>
    public partial class ProgramParticipationSpecialEducationViewModel : ViewModelBase, Interfaces.IProgramParticipationSpecialEducation
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from ProgramParticipationSpecialEducation";

        // member variable for the AwaitingInitialIDEAEvaluationStatus property
        private Guid? _AwaitingInitialIDEAEvaluationStatus;

        // member variable for the IDEAPlacementRationale property
        private  _IDEAPlacementRationale;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefIDEAEducationalEnvironmentECId property
        private  _RefIDEAEducationalEnvironmentECId;

        // member variable for the RefIDEAEducationalEnvironmentSchoolAgeId property
        private  _RefIDEAEducationalEnvironmentSchoolAgeId;

        // member variable for the RefSpecialEducationExitReasonId property
        private  _RefSpecialEducationExitReasonId;

        // member variable for the SpecialEducationFTE property
        private  _SpecialEducationFTE;

        // member variable for the SpecialEducationServicesExitDate property
        private  _SpecialEducationServicesExitDate;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public Guid? AwaitingInitialIDEAEvaluationStatus { get => _AwaitingInitialIDEAEvaluationStatus; set => SetProperty(ref _AwaitingInitialIDEAEvaluationStatus, value); }

        /// <summary>
        /// </summary>
        public  IDEAPlacementRationale { get => _IDEAPlacementRationale; set => SetProperty(ref _IDEAPlacementRationale, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIDEAEducationalEnvironmentEC"/> model
        /// </summary>
        public  RefIDEAEducationalEnvironmentECId { get => _RefIDEAEducationalEnvironmentECId; set => SetProperty(ref _RefIDEAEducationalEnvironmentECId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIDEAEducationalEnvironmentSchoolAge"/> model
        /// </summary>
        public  RefIDEAEducationalEnvironmentSchoolAgeId { get => _RefIDEAEducationalEnvironmentSchoolAgeId; set => SetProperty(ref _RefIDEAEducationalEnvironmentSchoolAgeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefSpecialEducationExitReason"/> model
        /// </summary>
        public  RefSpecialEducationExitReasonId { get => _RefSpecialEducationExitReasonId; set => SetProperty(ref _RefSpecialEducationExitReasonId, value); }

        /// <summary>
        /// </summary>
        public  SpecialEducationFTE { get => _SpecialEducationFTE; set => SetProperty(ref _SpecialEducationFTE, value); }

        /// <summary>
        /// </summary>
        public  SpecialEducationServicesExitDate { get => _SpecialEducationServicesExitDate; set => SetProperty(ref _SpecialEducationServicesExitDate, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IProgramParticipationSpecialEducation model)
        {
            IsBusy = true;
            Id = model.Id;
            AwaitingInitialIDEAEvaluationStatus = model.AwaitingInitialIDEAEvaluationStatus; // 
            IDEAPlacementRationale = model.IDEAPlacementRationale; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefIDEAEducationalEnvironmentECId = model.RefIDEAEducationalEnvironmentECId; // 
            RefIDEAEducationalEnvironmentSchoolAgeId = model.RefIDEAEducationalEnvironmentSchoolAgeId; // 
            RefSpecialEducationExitReasonId = model.RefSpecialEducationExitReasonId; // 
            SpecialEducationFTE = model.SpecialEducationFTE; // 
            SpecialEducationServicesExitDate = model.SpecialEducationServicesExitDate; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
