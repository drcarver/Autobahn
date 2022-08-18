//**********************************************************
//* DomainName: Common Models
//* FileName:   School_OrganizationViewModel.cs
//***************************************************************************

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The School_Organization View Model
     /// </summary>
    public partial class School_OrganizationViewModel : ViewModelBase, Interfaces.ISchool_Organization
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from School_Organization";

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.ISchool_Organization model)
        {
            IsBusy = true;
            Id = model.Id;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
