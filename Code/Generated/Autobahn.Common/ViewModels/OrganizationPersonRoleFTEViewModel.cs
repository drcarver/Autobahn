//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationPersonRoleFTEViewModel.cs
//**********************************************************

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The OrganizationPersonRoleFTEViewModel
     /// </summary>
    public partial class OrganizationPersonRoleFTEViewModel : ViewModelBase, Interfaces.IOrganizationPersonRoleFTE
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from OrganizationPersonRoleFTE";

        #endregion

        #region Properties
        /// <summary>
        /// The title of the OrganizationPersonRoleFTEViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IOrganizationPersonRoleFTE model)
        {
            IsBusy = true;
            Id = model.Id;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
