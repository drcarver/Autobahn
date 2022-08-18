//**********************************************************
//* DomainName: Credentials
//* FileName:   CredentialDefCategoryViewModel.cs
//* Name:       Credential Definition Category Type
//* Definition: A category for defining the qualification, achievement, personal or organizational quality, or aspect of an identity.
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Credentials.ViewModels
{
     /// <summary>
     /// A category for defining the qualification, achievement, personal or organizational quality, or aspect of an identity.
     /// </summary>
    public partial class CredentialDefCategoryViewModel : ViewModelBase, Interfaces.ICredentialDefCategory
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from CredentialDefCategory";

        // Category -- (backing property for Credential Definition Category Type)
        private System.String _Category;

        // CategorySystem -- (backing property for Credential Definition Category System)
        private System.String _CategorySystem;

        // member variable for the CredentialDefinitionId property
        private Guid _CredentialDefinitionId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Credential Definition Category Type
        /// <para>
        /// A category for defining the qualification, achievement, personal or organizational quality, or aspect of an identity.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19892">Credential Definition Category Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String Category { get => _Category; set => SetProperty(ref _Category, value); }

        /// <summary>
        /// Credential Definition Category System
        /// <para>
        /// The system that defines the categories of the qualification, achievement, personal or organizational quality, or aspect of an identity used in Credential Category Type.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20211">Credential Definition Category System</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String CategorySystem { get => _CategorySystem; set => SetProperty(ref _CategorySystem, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="ICredentialDefinition"/> model
        /// </summary>
        public Guid CredentialDefinitionId { get => _CredentialDefinitionId; set => SetProperty(ref _CredentialDefinitionId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.ICredentialDefCategory model)
        {
            IsBusy = true;
            Id = model.Id;
            Category = model.Category; // Credential Definition Category Type
            CategorySystem = model.CategorySystem; // Credential Definition Category System
            CredentialDefinitionId = model.CredentialDefinitionId; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
