//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationRelationshipViewModel.cs
//**********************************************************

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The OrganizationRelationshipViewModel
     /// </summary>
    public partial class OrganizationRelationshipViewModel : ViewModelBase, Interfaces.IOrganizationRelationship
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from OrganizationRelationship";

        // member variable for the RefOrganizationRelationshipId property
        private Guid? _RefOrganizationRelationshipId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the OrganizationRelationshipViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefOrganizationRelationship"/> model
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20886">Organization Relationship Type</a>
        /// </para>
        /// </summary>
        [DisplayName("Organization Relationship Type")]
        public Guid? RefOrganizationRelationshipId { get => _RefOrganizationRelationshipId; set => SetProperty(ref _RefOrganizationRelationshipId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IOrganizationRelationship model)
        {
            IsBusy = true;
            Id = model.Id;
            RefOrganizationRelationshipId = model.RefOrganizationRelationshipId; // Organization Relationship Type
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
