//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonCareerEducationPlanViewModel.cs
//**********************************************************

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The PersonCareerEducationPlanViewModel
     /// </summary>
    public partial class PersonCareerEducationPlanViewModel : ViewModelBase, Interfaces.IPersonCareerEducationPlan
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PersonCareerEducationPlan";

        // member variable for the LastUpdated property
        private Guid? _LastUpdated;

        // member variable for the ProfessionalDevelopmentPlanApprovedBySupervisor property
        private  _ProfessionalDevelopmentPlanApprovedBySupervisor;

        // member variable for the ProfessionalDevelopmentPlanCompletion property
        private  _ProfessionalDevelopmentPlanCompletion;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefCareerEducationPlanTypeId property
        private  _RefCareerEducationPlanTypeId;

        // member variable for the TuitionFunded property
        private  _TuitionFunded;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public Guid? LastUpdated { get => _LastUpdated; set => SetProperty(ref _LastUpdated, value); }

        /// <summary>
        /// </summary>
        public  ProfessionalDevelopmentPlanApprovedBySupervisor { get => _ProfessionalDevelopmentPlanApprovedBySupervisor; set => SetProperty(ref _ProfessionalDevelopmentPlanApprovedBySupervisor, value); }

        /// <summary>
        /// </summary>
        public  ProfessionalDevelopmentPlanCompletion { get => _ProfessionalDevelopmentPlanCompletion; set => SetProperty(ref _ProfessionalDevelopmentPlanCompletion, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCareerEducationPlanType"/> model
        /// </summary>
        public  RefCareerEducationPlanTypeId { get => _RefCareerEducationPlanTypeId; set => SetProperty(ref _RefCareerEducationPlanTypeId, value); }

        /// <summary>
        /// </summary>
        public  TuitionFunded { get => _TuitionFunded; set => SetProperty(ref _TuitionFunded, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPersonCareerEducationPlan model)
        {
            IsBusy = true;
            Id = model.Id;
            LastUpdated = model.LastUpdated; // 
            ProfessionalDevelopmentPlanApprovedBySupervisor = model.ProfessionalDevelopmentPlanApprovedBySupervisor; // 
            ProfessionalDevelopmentPlanCompletion = model.ProfessionalDevelopmentPlanCompletion; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefCareerEducationPlanTypeId = model.RefCareerEducationPlanTypeId; // 
            TuitionFunded = model.TuitionFunded; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
