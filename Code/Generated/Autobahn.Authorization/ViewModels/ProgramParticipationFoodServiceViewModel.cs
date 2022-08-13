//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   ProgramParticipationFoodServiceViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;
using CommunityToolkit.Maui;

namespace Autobahn.Authorization.ViewModels
{
     /// <summary>
     /// The ProgramParticipationFoodServiceViewModel
     /// </summary>
    public partial class ProgramParticipationFoodServiceViewModel : ViewModelBase, Interfaces.IProgramParticipationFoodService
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from ProgramParticipationFoodService";

        // member variable for the PersonProgramParticipationId property
        private Guid _PersonProgramParticipationId;

        // member variable for the RefSchoolFoodServiceProgramId property
        private Guid _RefSchoolFoodServiceProgramId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the ProgramParticipationFoodServiceViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="PersonProgramParticipation"/> model
        /// </summary>
        public Guid PersonProgramParticipationId { get => _PersonProgramParticipationId; set => SetProperty(ref _PersonProgramParticipationId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefSchoolFoodServiceProgram"/> model
        /// </summary>
        public Guid RefSchoolFoodServiceProgramId { get => _RefSchoolFoodServiceProgramId; set => SetProperty(ref _RefSchoolFoodServiceProgramId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IProgramParticipationFoodService model)
        {
            IsBusy = true;
            Id = model.Id;
            PersonProgramParticipationId = model.PersonProgramParticipationId;
            RefSchoolFoodServiceProgramId = model.RefSchoolFoodServiceProgramId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
