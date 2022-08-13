//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   ProgramParticipationNeglectedViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;
using CommunityToolkit.Maui;

namespace Autobahn.Authorization.ViewModels
{
     /// <summary>
     /// The ProgramParticipationNeglectedViewModel
     /// </summary>
    public partial class ProgramParticipationNeglectedViewModel : ViewModelBase, Interfaces.IProgramParticipationNeglected
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from ProgramParticipationNeglected";

        // member variable for the AchievementIndicator property
        private System.Boolean? _AchievementIndicator;

        // member variable for the ObtainedEmployment property
        private System.Boolean? _ObtainedEmployment;

        // member variable for the OutcomeIndicator property
        private System.Boolean? _OutcomeIndicator;

        // member variable for the PersonProgramParticipationId property
        private Guid _PersonProgramParticipationId;

        // member variable for the RefNeglectedProgramTypeId property
        private Guid? _RefNeglectedProgramTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the ProgramParticipationNeglectedViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The type of program under ESEA Title I, Part D, Subpart 1 (state programs) or Subpart 2 (LEA).
        /// </summary>
        public System.Boolean? AchievementIndicator { get => _AchievementIndicator; set => SetProperty(ref _AchievementIndicator, value); }

        /// <summary>
        /// The type of program under ESEA Title I, Part D, Subpart 1 (state programs) or Subpart 2 (LEA).
        /// </summary>
        public System.Boolean? ObtainedEmployment { get => _ObtainedEmployment; set => SetProperty(ref _ObtainedEmployment, value); }

        /// <summary>
        /// The type of program under ESEA Title I, Part D, Subpart 1 (state programs) or Subpart 2 (LEA).
        /// </summary>
        public System.Boolean? OutcomeIndicator { get => _OutcomeIndicator; set => SetProperty(ref _OutcomeIndicator, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="PersonProgramParticipation"/> model
        /// </summary>
        public Guid PersonProgramParticipationId { get => _PersonProgramParticipationId; set => SetProperty(ref _PersonProgramParticipationId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefNeglectedProgramType"/> model
        /// </summary>
        public Guid? RefNeglectedProgramTypeId { get => _RefNeglectedProgramTypeId; set => SetProperty(ref _RefNeglectedProgramTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IProgramParticipationNeglected model)
        {
            IsBusy = true;
            Id = model.Id;
            AchievementIndicator = model.AchievementIndicator;
            ObtainedEmployment = model.ObtainedEmployment;
            OutcomeIndicator = model.OutcomeIndicator;
            PersonProgramParticipationId = model.PersonProgramParticipationId;
            RefNeglectedProgramTypeId = model.RefNeglectedProgramTypeId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
