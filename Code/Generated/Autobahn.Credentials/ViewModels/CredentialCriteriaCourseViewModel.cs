//**********************************************************
//* DomainName: Credentials
//* FileName:   CredentialCriteriaCourseViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Credentials.ViewModels
{
     /// <summary>
     /// The CredentialCriteriaCourseViewModel
     /// </summary>
    public partial class CredentialCriteriaCourseViewModel : ViewModelBase, Interfaces.ICredentialCriteriaCourse
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from CredentialCriteriaCourse";

        #endregion

        #region Properties
        /// <summary>
        /// The title of the CredentialCriteriaCourseViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.ICredentialCriteriaCourse model)
        {
            IsBusy = true;
            Id = model.Id;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
