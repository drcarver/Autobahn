//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   ProgramParticipationTitleIViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;
using CommunityToolkit.Maui;

namespace Autobahn.Authorization.ViewModels
{
     /// <summary>
     /// The ProgramParticipationTitleIViewModel
     /// </summary>
    public partial class ProgramParticipationTitleIViewModel : ViewModelBase, Interfaces.IProgramParticipationTitleI
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from ProgramParticipationTitleI";

        // member variable for the PersonProgramParticipationId property
        private Guid _PersonProgramParticipationId;

        // member variable for the RefTitleIIndicatorId property
        private Guid? _RefTitleIIndicatorId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the ProgramParticipationTitleIViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="PersonProgramParticipation"/> model
        /// </summary>
        public Guid PersonProgramParticipationId { get => _PersonProgramParticipationId; set => SetProperty(ref _PersonProgramParticipationId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTitleIIndicator"/> model
        /// </summary>
        public Guid? RefTitleIIndicatorId { get => _RefTitleIIndicatorId; set => SetProperty(ref _RefTitleIIndicatorId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IProgramParticipationTitleI model)
        {
            IsBusy = true;
            Id = model.Id;
            PersonProgramParticipationId = model.PersonProgramParticipationId;
            RefTitleIIndicatorId = model.RefTitleIIndicatorId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
