//**********************************************************
//* DomainName: Autobahn.Common
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

        // member variable for the PersonId property
        private Guid _PersonId;

        // member variable for the RelatedPersonId property
        private Guid _RelatedPersonId;

        // member variable for the CustodialRelationshipIndicator property
        private System.Boolean? _CustodialRelationshipIndicator;

        // member variable for the EmergencyContactInd property
        private System.Boolean? _EmergencyContactInd;

        // member variable for the ContactPriorityNumber property
        private System.Int32? _ContactPriorityNumber;

        // member variable for the ContactRestrictions property
        private System.String _ContactRestrictions;

        // member variable for the LivesWithIndicator property
        private System.Boolean? _LivesWithIndicator;

        // member variable for the PrimaryContactIndicator property
        private System.Boolean? _PrimaryContactIndicator;

        // member variable for the RefPersonRelationshipTypeId property
        private Guid _RefPersonRelationshipTypeId;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

        // member variable for the RecordStatusId property
        private Guid? _RecordStatusId;

        // member variable for the DataCollectionId property
        private Guid? _DataCollectionId;

#endregion

        #region Properties
        /// <summary>
        /// The title of the PersonRelationshipViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="PersonId"/> model
        /// </summary>
        public Guid PersonId { get => _PersonId; set => SetProperty(ref _PersonId, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="RelatedPersonId"/> model
        /// </summary>
        public Guid RelatedPersonId { get => _RelatedPersonId; set => SetProperty(ref _RelatedPersonId, value); }

        public System.Boolean? CustodialRelationshipIndicator { get => _CustodialRelationshipIndicator; set => SetProperty(ref _CustodialRelationshipIndicator, value); }

        public System.Boolean? EmergencyContactInd { get => _EmergencyContactInd; set => SetProperty(ref _EmergencyContactInd, value); }

        public System.Int32? ContactPriorityNumber { get => _ContactPriorityNumber; set => SetProperty(ref _ContactPriorityNumber, value); }

        public System.String ContactRestrictions  { get => _ContactRestrictions; set => SetProperty(ref _ContactRestrictions, value); }

        public System.Boolean? LivesWithIndicator { get => _LivesWithIndicator; set => SetProperty(ref _LivesWithIndicator, value); }

        public System.Boolean? PrimaryContactIndicator { get => _PrimaryContactIndicator; set => SetProperty(ref _PrimaryContactIndicator, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefPersonRelationshipTypeId"/> model
        /// </summary>
        public Guid RefPersonRelationshipTypeId { get => _RefPersonRelationshipTypeId; set => SetProperty(ref _RefPersonRelationshipTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPersonRelationship model)
        {
            IsBusy = true;
            Id = model.Id;
            PersonId = model.PersonId;
            RelatedPersonId = model.RelatedPersonId;
            CustodialRelationshipIndicator = model.CustodialRelationshipIndicator;
            EmergencyContactInd = model.EmergencyContactInd;
            ContactPriorityNumber = model.ContactPriorityNumber;
            ContactRestrictions = model.ContactRestrictions;
            LivesWithIndicator = model.LivesWithIndicator;
            PrimaryContactIndicator = model.PrimaryContactIndicator;
            RefPersonRelationshipTypeId = model.RefPersonRelationshipTypeId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
