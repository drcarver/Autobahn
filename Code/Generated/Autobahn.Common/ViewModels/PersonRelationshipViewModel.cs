//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonRelationshipViewModel.cs
//**********************************************************

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The PersonRelationshipViewModel
     /// </summary>
    public partial class PersonRelationshipViewModel : ViewModelBase, Interfaces.IPersonRelationship
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PersonRelationship";

        // member variable for the ContactPriorityNumber property
        private System.Int32? _ContactPriorityNumber;

        // member variable for the ContactRestrictions property
        private System.String _ContactRestrictions;

        // member variable for the CustodialRelationshipIndicator property
        private System.Boolean? _CustodialRelationshipIndicator;

        // member variable for the EmergencyContactInd property
        private System.Boolean? _EmergencyContactInd;

        // member variable for the LivesWithIndicator property
        private System.Boolean? _LivesWithIndicator;

        // member variable for the PersonId property
        private Guid _PersonId;

        // member variable for the PrimaryContactIndicator property
        private System.Boolean? _PrimaryContactIndicator;

        // member variable for the RefPersonRelationshipTypeId property
        private Guid _RefPersonRelationshipTypeId;

        // member variable for the RelatedPersonId property
        private Guid _RelatedPersonId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the PersonRelationshipViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// An indication that a person has legal custody of a child.
        /// </summary>
        public System.Int32? ContactPriorityNumber { get => _ContactPriorityNumber; set => SetProperty(ref _ContactPriorityNumber, value); }

        /// <summary>
        /// An indication that a person has legal custody of a child.
        /// </summary>
        public System.String ContactRestrictions { get => _ContactRestrictions; set => SetProperty(ref _ContactRestrictions, value); }

        /// <summary>
        /// An indication that a person has legal custody of a child.
        /// </summary>
        public System.Boolean? CustodialRelationshipIndicator { get => _CustodialRelationshipIndicator; set => SetProperty(ref _CustodialRelationshipIndicator, value); }

        /// <summary>
        /// An indication that a person has legal custody of a child.
        /// </summary>
        public System.Boolean? EmergencyContactInd { get => _EmergencyContactInd; set => SetProperty(ref _EmergencyContactInd, value); }

        /// <summary>
        /// An indication that a person has legal custody of a child.
        /// </summary>
        public System.Boolean? LivesWithIndicator { get => _LivesWithIndicator; set => SetProperty(ref _LivesWithIndicator, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="Person"/> model
        /// </summary>
        public Guid PersonId { get => _PersonId; set => SetProperty(ref _PersonId, value); }

        /// <summary>
        /// An indication that a person has legal custody of a child.
        /// </summary>
        public System.Boolean? PrimaryContactIndicator { get => _PrimaryContactIndicator; set => SetProperty(ref _PrimaryContactIndicator, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPersonRelationshipType"/> model
        /// </summary>
        public Guid RefPersonRelationshipTypeId { get => _RefPersonRelationshipTypeId; set => SetProperty(ref _RefPersonRelationshipTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RelatedPerson"/> model
        /// </summary>
        public Guid RelatedPersonId { get => _RelatedPersonId; set => SetProperty(ref _RelatedPersonId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPersonRelationship model)
        {
            IsBusy = true;
            Id = model.Id;
            ContactPriorityNumber = model.ContactPriorityNumber;
            ContactRestrictions = model.ContactRestrictions;
            CustodialRelationshipIndicator = model.CustodialRelationshipIndicator;
            EmergencyContactInd = model.EmergencyContactInd;
            LivesWithIndicator = model.LivesWithIndicator;
            PersonId = model.PersonId;
            PrimaryContactIndicator = model.PrimaryContactIndicator;
            RefPersonRelationshipTypeId = model.RefPersonRelationshipTypeId;
            RelatedPersonId = model.RelatedPersonId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
