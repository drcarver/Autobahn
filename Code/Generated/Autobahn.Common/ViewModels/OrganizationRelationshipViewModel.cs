//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationRelationshipViewModel.cs
//***************************************************************************

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The OrganizationRelationship View Model
     /// </summary>
    public partial class OrganizationRelationshipViewModel : ViewModelBase, Interfaces.IOrganizationRelationship
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from OrganizationRelationship";

        // member variable for the OrganizationId property
        private Guid _OrganizationId;

        // member variable for the Parent_OrganizationId property
        private Guid _Parent_OrganizationId;

        // RefOrganizationRelationshipId -- (backing property for Organization Relationship Type)
        private Guid? _RefOrganizationRelationshipId;

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
        /// Reference to an optional instance of the <see cref="IParent_Organization"/> model
        /// </summary>
        public Guid Parent_OrganizationId { get => _Parent_OrganizationId; set => SetProperty(ref _Parent_OrganizationId, value); }

        /// <summary>
        /// Organization Relationship Type
        /// <para>
        /// The nature of one organization's relationship to another.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20886">Organization Relationship Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefOrganizationRelationshipId { get => _RefOrganizationRelationshipId; set => SetProperty(ref _RefOrganizationRelationshipId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IOrganizationRelationship model)
        {
            IsBusy = true;
            Id = model.Id;
            OrganizationId = model.OrganizationId; // 
            Parent_OrganizationId = model.Parent_OrganizationId; // 
            RefOrganizationRelationshipId = model.RefOrganizationRelationshipId; // Organization Relationship Type
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }

        #region RefOrganizationRelationship List
        /// <summary>
        /// The complete <see cref="RefOrganizationRelationship"> List
        /// </summary>
        private static List<ReferenceModelBase> RefOrganizationRelationshipList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("94d8c42a-e8b6-4b30-97e8-c53fa7b9100a"), Code="AuthorizingBody", Description="Authorizing Body", Definition="The primary entity with legal authority to create or close the organization.", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("ead806f6-2567-48d9-86a3-b2554285efd1"), Code="OperatingBody", Description="Operating Body", Definition="The entity responsible for operating the organization.", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("30b9ff1b-4157-44c8-8c53-01fa467d5d6f"), Code="SecondaryAuthorizingBody", Description="Secondary Authorizing Body", Definition="The secondary entity with legal authority to create or close the organization.", SortOrder=Convert.ToDecimal("3.00") },
        };
        #endregion
    }
}
