//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   ProgramParticipationTitleIIILepViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;
using CommunityToolkit.Maui;

namespace Autobahn.Authorization.ViewModels
{
     /// <summary>
     /// The ProgramParticipationTitleIIILepViewModel
     /// </summary>
    public partial class ProgramParticipationTitleIIILepViewModel : ViewModelBase, Interfaces.IProgramParticipationTitleIIILep
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from ProgramParticipationTitleIIILep";

        // member variable for the PersonProgramParticipationId property
        private Guid _PersonProgramParticipationId;

        // member variable for the ProgramParticipationTitleIiiLepId property
        private Guid _ProgramParticipationTitleIiiLepId;

        // member variable for the RefTitleIIIAccountabilityId property
        private Guid? _RefTitleIIIAccountabilityId;

        // member variable for the RefTitleIIILanguageInstructionProgramTypeId property
        private Guid? _RefTitleIIILanguageInstructionProgramTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the ProgramParticipationTitleIIILepViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="PersonProgramParticipation"/> model
        /// </summary>
        public Guid PersonProgramParticipationId { get => _PersonProgramParticipationId; set => SetProperty(ref _PersonProgramParticipationId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="ProgramParticipationTitleIiiLep"/> model
        /// </summary>
        public Guid ProgramParticipationTitleIiiLepId { get => _ProgramParticipationTitleIiiLepId; set => SetProperty(ref _ProgramParticipationTitleIiiLepId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTitleIIIAccountability"/> model
        /// </summary>
        public Guid? RefTitleIIIAccountabilityId { get => _RefTitleIIIAccountabilityId; set => SetProperty(ref _RefTitleIIIAccountabilityId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTitleIIILanguageInstructionProgramType"/> model
        /// </summary>
        public Guid? RefTitleIIILanguageInstructionProgramTypeId { get => _RefTitleIIILanguageInstructionProgramTypeId; set => SetProperty(ref _RefTitleIIILanguageInstructionProgramTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IProgramParticipationTitleIIILep model)
        {
            IsBusy = true;
            Id = model.Id;
            PersonProgramParticipationId = model.PersonProgramParticipationId;
            ProgramParticipationTitleIiiLepId = model.ProgramParticipationTitleIiiLepId;
            RefTitleIIIAccountabilityId = model.RefTitleIIIAccountabilityId;
            RefTitleIIILanguageInstructionProgramTypeId = model.RefTitleIIILanguageInstructionProgramTypeId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
