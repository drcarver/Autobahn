//**********************************************************
//* DomainName: Workforce
//* FileName:   WorkforceProgramParticipantCohortViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Workforce.ViewModels
{
     /// <summary>
     /// The WorkforceProgramParticipantCohortViewModel
     /// </summary>
    public partial class WorkforceProgramParticipantCohortViewModel : ViewModelBase, Interfaces.IWorkforceProgramParticipantCohort
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from WorkforceProgramParticipantCohort";

        #endregion

        #region Properties
        /// <summary>
        /// The title of the WorkforceProgramParticipantCohortViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IWorkforceProgramParticipantCohort model)
        {
            IsBusy = true;
            Id = model.Id;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
