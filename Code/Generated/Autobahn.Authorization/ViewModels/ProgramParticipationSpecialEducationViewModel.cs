//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   ProgramParticipationSpecialEducationViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;
using CommunityToolkit.Maui;

namespace Autobahn.Authorization.ViewModels
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
        private System.Boolean? _AwaitingInitialIDEAEvaluationStatus;

        // member variable for the IDEAPlacementRationale property
        private System.String _IDEAPlacementRationale;

        // member variable for the PersonProgramParticipationId property
        private Guid _PersonProgramParticipationId;

        // member variable for the RefIDEAEducationalEnvironmentECId property
        private Guid? _RefIDEAEducationalEnvironmentECId;

        // member variable for the RefIDEAEducationalEnvironmentSchoolAgeId property
        private Guid? _RefIDEAEducationalEnvironmentSchoolAgeId;

        // member variable for the RefSpecialEducationExitReasonId property
        private Guid? _RefSpecialEducationExitReasonId;

        // member variable for the SpecialEducationFTE property
        private System.Decimal? _SpecialEducationFTE;

        // member variable for the SpecialEducationServicesExitDate property
        private System.DateTime? _SpecialEducationServicesExitDate;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the ProgramParticipationSpecialEducationViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Awaiting initial evaluation for special education programs and related services under the Individuals with Disabilities Education Act (IDEA). 
        /// </summary>
        public System.Boolean? AwaitingInitialIDEAEvaluationStatus { get => _AwaitingInitialIDEAEvaluationStatus; set => SetProperty(ref _AwaitingInitialIDEAEvaluationStatus, value); }

        /// <summary>
        /// Awaiting initial evaluation for special education programs and related services under the Individuals with Disabilities Education Act (IDEA). 
        /// </summary>
        public System.String IDEAPlacementRationale { get => _IDEAPlacementRationale; set => SetProperty(ref _IDEAPlacementRationale, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="PersonProgramParticipation"/> model
        /// </summary>
        public Guid PersonProgramParticipationId { get => _PersonProgramParticipationId; set => SetProperty(ref _PersonProgramParticipationId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIDEAEducationalEnvironmentEC"/> model
        /// </summary>
        public Guid? RefIDEAEducationalEnvironmentECId { get => _RefIDEAEducationalEnvironmentECId; set => SetProperty(ref _RefIDEAEducationalEnvironmentECId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIDEAEducationalEnvironmentSchoolAge"/> model
        /// </summary>
        public Guid? RefIDEAEducationalEnvironmentSchoolAgeId { get => _RefIDEAEducationalEnvironmentSchoolAgeId; set => SetProperty(ref _RefIDEAEducationalEnvironmentSchoolAgeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefSpecialEducationExitReason"/> model
        /// </summary>
        public Guid? RefSpecialEducationExitReasonId { get => _RefSpecialEducationExitReasonId; set => SetProperty(ref _RefSpecialEducationExitReasonId, value); }

        /// <summary>
        /// Awaiting initial evaluation for special education programs and related services under the Individuals with Disabilities Education Act (IDEA). 
        /// </summary>
        public System.Decimal? SpecialEducationFTE { get => _SpecialEducationFTE; set => SetProperty(ref _SpecialEducationFTE, value); }

        /// <summary>
        /// Awaiting initial evaluation for special education programs and related services under the Individuals with Disabilities Education Act (IDEA). 
        /// </summary>
        public System.DateTime? SpecialEducationServicesExitDate { get => _SpecialEducationServicesExitDate; set => SetProperty(ref _SpecialEducationServicesExitDate, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IProgramParticipationSpecialEducation model)
        {
            IsBusy = true;
            Id = model.Id;
            AwaitingInitialIDEAEvaluationStatus = model.AwaitingInitialIDEAEvaluationStatus;
            IDEAPlacementRationale = model.IDEAPlacementRationale;
            PersonProgramParticipationId = model.PersonProgramParticipationId;
            RefIDEAEducationalEnvironmentECId = model.RefIDEAEducationalEnvironmentECId;
            RefIDEAEducationalEnvironmentSchoolAgeId = model.RefIDEAEducationalEnvironmentSchoolAgeId;
            RefSpecialEducationExitReasonId = model.RefSpecialEducationExitReasonId;
            SpecialEducationFTE = model.SpecialEducationFTE;
            SpecialEducationServicesExitDate = model.SpecialEducationServicesExitDate;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
