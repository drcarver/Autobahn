//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationIdentifierViewModel.cs
//**********************************************************

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The OrganizationIdentifierViewModel
     /// </summary>
    public partial class OrganizationIdentifierViewModel : ViewModelBase, Interfaces.IOrganizationIdentifier
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from OrganizationIdentifier";

        // member variable for the RefOrganizationIdentifierTypeId property
        private Guid? _RefOrganizationIdentifierTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the OrganizationIdentifierViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefOrganizationentifierType"/> model
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19006">Activity Identifier</a>
        /// </para>
        /// </summary>
        [DisplayName("Activity Identifier")]
        public Guid? RefOrganizationIdentifierTypeId { get => _RefOrganizationIdentifierTypeId; set => SetProperty(ref _RefOrganizationIdentifierTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IOrganizationIdentifier model)
        {
            IsBusy = true;
            Id = model.Id;
            RefOrganizationIdentifierTypeId = model.RefOrganizationIdentifierTypeId; // Activity Identifier
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
