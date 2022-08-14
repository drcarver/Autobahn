//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationIdentifierViewModel.cs
//**********************************************************

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

        // member variable for the Identifier property
        private System.String _Identifier;

        // member variable for the OrganizationId property
        private Guid _OrganizationId;

        // member variable for the RefOrganizationIdentificationSystemId property
        private Guid? _RefOrganizationIdentificationSystemId;

        // member variable for the RefOrganizationIdentifierTypeId property
        private Guid? _RefOrganizationIdentifierTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the OrganizationIdentifierViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// A unique number or alphanumeric code used in the local system to identify an activity, such as a co-curricular or extra-curricular activity that is offered at an education institution.
        /// </summary>
        public System.String Identifier { get => _Identifier; set => SetProperty(ref _Identifier, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="Organization"/> model
        /// </summary>
        public Guid OrganizationId { get => _OrganizationId; set => SetProperty(ref _OrganizationId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefOrganizationentificationSystem"/> model
        /// </summary>
        public Guid? RefOrganizationIdentificationSystemId { get => _RefOrganizationIdentificationSystemId; set => SetProperty(ref _RefOrganizationIdentificationSystemId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefOrganizationentifierType"/> model
        /// </summary>
        public Guid? RefOrganizationIdentifierTypeId { get => _RefOrganizationIdentifierTypeId; set => SetProperty(ref _RefOrganizationIdentifierTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IOrganizationIdentifier model)
        {
            IsBusy = true;
            Id = model.Id;
            Identifier = model.Identifier;
            OrganizationId = model.OrganizationId;
            RefOrganizationIdentificationSystemId = model.RefOrganizationIdentificationSystemId;
            RefOrganizationIdentifierTypeId = model.RefOrganizationIdentifierTypeId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
