//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   ProgramParticipationWIOAViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;
using CommunityToolkit.Maui;

namespace Autobahn.Authorization.ViewModels
{
     /// <summary>
     /// The ProgramParticipationWIOAViewModel
     /// </summary>
    public partial class ProgramParticipationWIOAViewModel : ViewModelBase, Interfaces.IProgramParticipationWIOA
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from ProgramParticipationWIOA";

        // member variable for the PersonProgramParticipationId property
        private Guid _PersonProgramParticipationId;

        // member variable for the WIOACareerServices property
        private System.Boolean? _WIOACareerServices;

        // member variable for the WIOATrainingServices property
        private System.Boolean? _WIOATrainingServices;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the ProgramParticipationWIOAViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="PersonProgramParticipation"/> model
        /// </summary>
        public Guid PersonProgramParticipationId { get => _PersonProgramParticipationId; set => SetProperty(ref _PersonProgramParticipationId, value); }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public System.Boolean? WIOACareerServices { get => _WIOACareerServices; set => SetProperty(ref _WIOACareerServices, value); }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public System.Boolean? WIOATrainingServices { get => _WIOATrainingServices; set => SetProperty(ref _WIOATrainingServices, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IProgramParticipationWIOA model)
        {
            IsBusy = true;
            Id = model.Id;
            PersonProgramParticipationId = model.PersonProgramParticipationId;
            WIOACareerServices = model.WIOACareerServices;
            WIOATrainingServices = model.WIOATrainingServices;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
