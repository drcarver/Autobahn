//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   IncidentPersonViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Invalid.ViewModels
{
     /// <summary>
     /// The IncidentPersonViewModel
     /// </summary>
    public partial class IncidentPersonViewModel : ViewModelBase, Interfaces.IIncidentPerson
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from IncidentPerson";

        #endregion

        #region Properties
        /// <summary>
        /// The title of the IncidentPersonViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IIncidentPerson model)
        {
            IsBusy = true;
            Id = model.Id;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
