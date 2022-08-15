//**********************************************************
//* DomainName: Adult Education (AE)
//* FileName:   ProgramParticipationAEViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.AdultEducation.ViewModels
{
     /// <summary>
     /// The ProgramParticipationAEViewModel
     /// </summary>
    public partial class ProgramParticipationAEViewModel : ViewModelBase, Interfaces.IProgramParticipationAE
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from ProgramParticipationAE";

        #endregion

        #region Properties
        /// <summary>
        /// The title of the ProgramParticipationAEViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IProgramParticipationAE model)
        {
            IsBusy = true;
            Id = model.Id;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
