//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   PersonCareerEducationPlanViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Common.Interfaces;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The PersonCareerEducationPlanViewModel
     /// </summary>
    public partial class PersonCareerEducationPlanViewModel : BindableBase, IPersonCareerEducationPlan
    {
#region "Backing Fields"
        // member variable for the LastUpdated property
        private System.DateTime? _LastUpdated;

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

#endregion

#region Properties
        /// <summary>
        /// Reference to a required instance of the <see cref="PersonId"/> model
        /// </summary>
        public Guid PersonId { get; set; }

        public System.DateTime? LastUpdated { get => _LastUpdated; set => SetProperty(ref _LastUpdated, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCareerEducationPlanTypeId"/> model
        /// </summary>
        public Guid? RefCareerEducationPlanTypeId { get; set; }

        public System.Boolean? ProfessionalDevelopmentPlanApprovedBySupervisor { get => _ProfessionalDevelopmentPlanApprovedBySupervisor; set => SetProperty(ref _ProfessionalDevelopmentPlanApprovedBySupervisor, value); }

        public System.DateTime? ProfessionalDevelopmentPlanCompletion { get => _ProfessionalDevelopmentPlanCompletion; set => SetProperty(ref _ProfessionalDevelopmentPlanCompletion, value); }

        public System.Boolean? TuitionFunded { get => _TuitionFunded; set => SetProperty(ref _TuitionFunded, value); }

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
        public void Load(IPersonCareerEducationPlan model)
        {
            IsBusy = true;
            Id = model.Id;
            PersonId = model.PersonId;
            LastUpdated = model.LastUpdated;
            RefCareerEducationPlanTypeId = model.RefCareerEducationPlanTypeId;
            ProfessionalDevelopmentPlanApprovedBySupervisor = model.ProfessionalDevelopmentPlanApprovedBySupervisor;
            ProfessionalDevelopmentPlanCompletion = model.ProfessionalDevelopmentPlanCompletion;
            TuitionFunded = model.TuitionFunded;
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
