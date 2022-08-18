//**********************************************************
//* DomainName: Credentials
//* FileName:   CredentialOfferedViewModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Credentials.ViewModels
{
     /// <summary>
     /// The CredentialOffered View Model
     /// </summary>
    public partial class CredentialOfferedViewModel : ViewModelBase, Interfaces.ICredentialOffered
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from CredentialOffered";

        // member variable for the CredentialDefinitionId property
        private Guid _CredentialDefinitionId;

        // member variable for the CredentialIssuerId property
        private Guid _CredentialIssuerId;

        // CredentialOfferedEndDate -- (backing property for Credential Offered End Date)
        private System.DateTime? _CredentialOfferedEndDate;

        // CredentialOfferedStartDate -- (backing property for Credential Offered Start Date)
        private System.DateTime? _CredentialOfferedStartDate;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="ICredentialDefinition"/> model
        /// </summary>
        public Guid CredentialDefinitionId { get => _CredentialDefinitionId; set => SetProperty(ref _CredentialDefinitionId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="ICredentialIssuer"/> model
        /// </summary>
        public Guid CredentialIssuerId { get => _CredentialIssuerId; set => SetProperty(ref _CredentialIssuerId, value); }

        /// <summary>
        /// Credential Offered End Date
        /// <para>
        /// The last date a credential was offered.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20893">Credential Offered End Date</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.DateTime? CredentialOfferedEndDate { get => _CredentialOfferedEndDate; set => SetProperty(ref _CredentialOfferedEndDate, value); }

        /// <summary>
        /// Credential Offered Start Date
        /// <para>
        /// The first date a credential was offered.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20892">Credential Offered Start Date</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.DateTime? CredentialOfferedStartDate { get => _CredentialOfferedStartDate; set => SetProperty(ref _CredentialOfferedStartDate, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.ICredentialOffered model)
        {
            IsBusy = true;
            Id = model.Id;
            CredentialDefinitionId = model.CredentialDefinitionId; // 
            CredentialIssuerId = model.CredentialIssuerId; // 
            CredentialOfferedEndDate = model.CredentialOfferedEndDate; // Credential Offered End Date
            CredentialOfferedStartDate = model.CredentialOfferedStartDate; // Credential Offered Start Date
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
