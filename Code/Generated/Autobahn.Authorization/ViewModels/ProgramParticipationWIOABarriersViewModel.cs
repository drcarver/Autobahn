//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   ProgramParticipationWIOABarriersViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;
using CommunityToolkit.Maui;

namespace Autobahn.Authorization.ViewModels
{
     /// <summary>
     /// The ProgramParticipationWIOABarriersViewModel
     /// </summary>
    public partial class ProgramParticipationWIOABarriersViewModel : ViewModelBase, Interfaces.IProgramParticipationWIOABarriers
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from ProgramParticipationWIOABarriers";

        #endregion

        #region Properties
        /// <summary>
        /// The title of the ProgramParticipationWIOABarriersViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IProgramParticipationWIOABarriers model)
        {
            IsBusy = true;
            Id = model.Id;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
