//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationPolicyViewModel.cs
//**********************************************************

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The OrganizationPolicyViewModel
     /// </summary>
    public partial class OrganizationPolicyViewModel : ViewModelBase, Interfaces.IOrganizationPolicy
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from OrganizationPolicy";

        // member variable for the PolicyType property
        private System.String _PolicyType;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the OrganizationPolicyViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Policies related to personnel in the organization.
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19842">Personnel Policy Type</a>
        /// </para>
        /// </summary>
        [DisplayName("Personnel Policy Type")]
        public System.String PolicyType { get => _PolicyType; set => SetProperty(ref _PolicyType, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IOrganizationPolicy model)
        {
            IsBusy = true;
            Id = model.Id;
            PolicyType = model.PolicyType; // Personnel Policy Type
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
