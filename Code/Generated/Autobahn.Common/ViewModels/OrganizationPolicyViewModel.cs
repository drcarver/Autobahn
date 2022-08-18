//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationPolicyViewModel.cs
//***************************************************************************

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The OrganizationPolicy View Model
     /// </summary>
    public partial class OrganizationPolicyViewModel : ViewModelBase, Interfaces.IOrganizationPolicy
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from OrganizationPolicy";

        // member variable for the OrganizationId property
        private Guid _OrganizationId;

        // PolicyType -- (backing property for Personnel Policy Type)
        private System.String _PolicyType;

        // member variable for the Value property
        private System.String _Value;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganization"/> model
        /// </summary>
        public Guid OrganizationId { get => _OrganizationId; set => SetProperty(ref _OrganizationId, value); }

        /// <summary>
        /// Personnel Policy Type
        /// <para>
        /// Policies related to personnel in the organization.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19842">Personnel Policy Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String PolicyType { get => _PolicyType; set => SetProperty(ref _PolicyType, value); }

        public System.String Value { get => _Value; set => SetProperty(ref _Value, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IOrganizationPolicy model)
        {
            IsBusy = true;
            Id = model.Id;
            OrganizationId = model.OrganizationId; // 
            PolicyType = model.PolicyType; // Personnel Policy Type
            Value = model.Value; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
