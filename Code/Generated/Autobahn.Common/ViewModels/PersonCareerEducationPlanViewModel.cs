//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   PersonCareerEducationPlanViewModel.cs
//**********************************************************


namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The PersonCareerEducationPlanViewModel
     /// </summary>
    public partial class PersonCareerEducationPlanViewModel : ViewModelBase, Interfaces.IPersonCareerEducationPlanViewModel
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PersonCareerEducationPlan";

        // member variable for the PersonId property
        private Guid _PersonId;

        // member variable for the LastUpdated property
        private System.DateTime? _LastUpdated;

        // member variable for the RefCareerEducationPlanTypeId property
        private Guid? _RefCareerEducationPlanTypeId;

        // member variable for the ProfessionalDevelopmentPlanApprovedBySupervisor property
        private System.Boolean? _ProfessionalDevelopmentPlanApprovedBySupervisor;

        // member variable for the ProfessionalDevelopmentPlanCompletion property
        private System.DateTime? _ProfessionalDevelopmentPlanCompletion;

        // member variable for the TuitionFunded property
        private System.Boolean? _TuitionFunded;

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
        /// The title of the PersonCareerEducationPlanViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="PersonId"/> model
        /// </summary>
        public Guid PersonId { get => _PersonId; set => SetProperty(ref _PersonId, value); }

        public System.DateTime? LastUpdated { get => _LastUpdated; set => SetProperty(ref _LastUpdated, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCareerEducationPlanTypeId"/> model
        /// </summary>
        public Guid? RefCareerEducationPlanTypeId { get => _RefCareerEducationPlanTypeId; set => SetProperty(ref _RefCareerEducationPlanTypeId, value); }

        public System.Boolean? ProfessionalDevelopmentPlanApprovedBySupervisor { get => _ProfessionalDevelopmentPlanApprovedBySupervisor; set => SetProperty(ref _ProfessionalDevelopmentPlanApprovedBySupervisor, value); }

        public System.DateTime? ProfessionalDevelopmentPlanCompletion { get => _ProfessionalDevelopmentPlanCompletion; set => SetProperty(ref _ProfessionalDevelopmentPlanCompletion, value); }

        public System.Boolean? TuitionFunded { get => _TuitionFunded; set => SetProperty(ref _TuitionFunded, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPersonCareerEducationPlan model)
        {
            IsBusy = true;
            Id = model.Id;
            PersonId = model.PersonId;
            LastUpdated = model.LastUpdated;
            RefCareerEducationPlanTypeId = model.RefCareerEducationPlanTypeId;
            ProfessionalDevelopmentPlanApprovedBySupervisor = model.ProfessionalDevelopmentPlanApprovedBySupervisor;
            ProfessionalDevelopmentPlanCompletion = model.ProfessionalDevelopmentPlanCompletion;
            TuitionFunded = model.TuitionFunded;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
