//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationPersonRoleRelationshipViewModel.cs
//**********************************************************

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The OrganizationPersonRoleRelationshipViewModel
     /// </summary>
    public partial class OrganizationPersonRoleRelationshipViewModel : ViewModelBase, Interfaces.IOrganizationPersonRoleRelationship
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from OrganizationPersonRoleRelationship";

        #endregion

        #region Properties
        /// <summary>
        /// The title of the OrganizationPersonRoleRelationshipViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IOrganizationPersonRoleRelationship model)
        {
            IsBusy = true;
            Id = model.Id;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
