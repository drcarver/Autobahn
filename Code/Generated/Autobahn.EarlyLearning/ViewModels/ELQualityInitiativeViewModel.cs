//**********************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ELQualityInitiativeViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.EarlyLearning.ViewModels
{
     /// <summary>
     /// The ELQualityInitiativeViewModel
     /// </summary>
    public partial class ELQualityInitiativeViewModel : ViewModelBase, Interfaces.IELQualityInitiative
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from ELQualityInitiative";

        // member variable for the MaximumScore property
        private System.String _MaximumScore;

        // member variable for the MinimumScore property
        private System.String _MinimumScore;

        // member variable for the OrganizationId property
        private Guid _OrganizationId;

        // member variable for the ParticipationEndDate property
        private System.DateTime? _ParticipationEndDate;

        // member variable for the ParticipationIndicator property
        private System.Boolean? _ParticipationIndicator;

        // member variable for the ParticipationStartDate property
        private System.DateTime? _ParticipationStartDate;

        // member variable for the ProgramHeathSafetyChecklistUseStatus property
        private System.Boolean? _ProgramHeathSafetyChecklistUseStatus;

        // member variable for the ScoreLevel property
        private System.String _ScoreLevel;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the ELQualityInitiativeViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// An indication of whether a program uses a health or safety checklist or documentation.
        /// </summary>
        public System.String MaximumScore { get => _MaximumScore; set => SetProperty(ref _MaximumScore, value); }

        /// <summary>
        /// An indication of whether a program uses a health or safety checklist or documentation.
        /// </summary>
        public System.String MinimumScore { get => _MinimumScore; set => SetProperty(ref _MinimumScore, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="Organization"/> model
        /// </summary>
        public Guid OrganizationId { get => _OrganizationId; set => SetProperty(ref _OrganizationId, value); }

        /// <summary>
        /// An indication of whether a program uses a health or safety checklist or documentation.
        /// </summary>
        public System.DateTime? ParticipationEndDate { get => _ParticipationEndDate; set => SetProperty(ref _ParticipationEndDate, value); }

        /// <summary>
        /// An indication of whether a program uses a health or safety checklist or documentation.
        /// </summary>
        public System.Boolean? ParticipationIndicator { get => _ParticipationIndicator; set => SetProperty(ref _ParticipationIndicator, value); }

        /// <summary>
        /// An indication of whether a program uses a health or safety checklist or documentation.
        /// </summary>
        public System.DateTime? ParticipationStartDate { get => _ParticipationStartDate; set => SetProperty(ref _ParticipationStartDate, value); }

        /// <summary>
        /// An indication of whether a program uses a health or safety checklist or documentation.
        /// </summary>
        public System.Boolean? ProgramHeathSafetyChecklistUseStatus { get => _ProgramHeathSafetyChecklistUseStatus; set => SetProperty(ref _ProgramHeathSafetyChecklistUseStatus, value); }

        /// <summary>
        /// An indication of whether a program uses a health or safety checklist or documentation.
        /// </summary>
        public System.String ScoreLevel { get => _ScoreLevel; set => SetProperty(ref _ScoreLevel, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IELQualityInitiative model)
        {
            IsBusy = true;
            Id = model.Id;
            MaximumScore = model.MaximumScore;
            MinimumScore = model.MinimumScore;
            OrganizationId = model.OrganizationId;
            ParticipationEndDate = model.ParticipationEndDate;
            ParticipationIndicator = model.ParticipationIndicator;
            ParticipationStartDate = model.ParticipationStartDate;
            ProgramHeathSafetyChecklistUseStatus = model.ProgramHeathSafetyChecklistUseStatus;
            ScoreLevel = model.ScoreLevel;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
