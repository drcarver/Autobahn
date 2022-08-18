//**********************************************************
//* DomainName: Credentials
//* FileName:   CredentialDefAgentViewModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Credentials.ViewModels
{
     /// <summary>
     /// The CredentialDefAgent View Model
     /// </summary>
    public partial class CredentialDefAgentViewModel : ViewModelBase, Interfaces.ICredentialDefAgent
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from CredentialDefAgent";

        // member variable for the OrganizationId property
        private Guid? _OrganizationId;

        // member variable for the PersonId property
        private Guid? _PersonId;

        // RefCredentialDefAgentRoleTypeId -- (backing property for Credential Definition Agent Role Type)
        private Guid? _RefCredentialDefAgentRoleTypeId;

        // RefCTDLOrganizationTypeId -- (backing property for CTDL Organization Type)
        private Guid? _RefCTDLOrganizationTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganization"/> model
        /// </summary>
        public Guid? OrganizationId { get => _OrganizationId; set => SetProperty(ref _OrganizationId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IPerson"/> model
        /// </summary>
        public Guid? PersonId { get => _PersonId; set => SetProperty(ref _PersonId, value); }

        /// <summary>
        /// Credential Definition Agent Role Type
        /// <para>
        /// The role that an organization or person has in relation to this Credential Definition based on terms defined by Credential Engine.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20895">Credential Definition Agent Role Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefCredentialDefAgentRoleTypeId { get => _RefCredentialDefAgentRoleTypeId; set => SetProperty(ref _RefCredentialDefAgentRoleTypeId, value); }

        /// <summary>
        /// CTDL Organization Type
        /// <para>
        /// The type of credentialing organization or entity as defined by the Credential Transparency Description Language.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20736">CTDL Organization Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefCTDLOrganizationTypeId { get => _RefCTDLOrganizationTypeId; set => SetProperty(ref _RefCTDLOrganizationTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.ICredentialDefAgent model)
        {
            IsBusy = true;
            Id = model.Id;
            OrganizationId = model.OrganizationId; // 
            PersonId = model.PersonId; // 
            RefCredentialDefAgentRoleTypeId = model.RefCredentialDefAgentRoleTypeId; // Credential Definition Agent Role Type
            RefCTDLOrganizationTypeId = model.RefCTDLOrganizationTypeId; // CTDL Organization Type
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
