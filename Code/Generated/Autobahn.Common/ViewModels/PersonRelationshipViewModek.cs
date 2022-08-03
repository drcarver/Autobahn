//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   PersonRelationshipViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Common.Interfaces;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The PersonRelationshipViewModel
     /// </summary>
    public partial class PersonRelationshipViewModel : BindableBase, IPersonRelationship
    {
#region "Backing Fields"
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

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

#endregion

#region Properties
        /// <summary>
        /// Reference to a required instance of the <see cref="PersonId"/> model
        /// </summary>
        public Guid PersonId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="RelatedPersonId"/> model
        /// </summary>
        public Guid RelatedPersonId { get; set; }

        public System.Boolean? CustodialRelationshipIndicator { get => _CustodialRelationshipIndicator; set => SetProperty(ref _CustodialRelationshipIndicator, value); }

        public System.Boolean? EmergencyContactInd { get => _EmergencyContactInd; set => SetProperty(ref _EmergencyContactInd, value); }

        public System.Int32? ContactPriorityNumber { get => _ContactPriorityNumber; set => SetProperty(ref _ContactPriorityNumber, value); }

        public System.String ContactRestrictions  { get => _ContactRestrictions; set => SetProperty(ref _ContactRestrictions, value); }

        public System.Boolean? LivesWithIndicator { get => _LivesWithIndicator; set => SetProperty(ref _LivesWithIndicator, value); }

        public System.Boolean? PrimaryContactIndicator { get => _PrimaryContactIndicator; set => SetProperty(ref _PrimaryContactIndicator, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefPersonRelationshipTypeId"/> model
        /// </summary>
        public Guid RefPersonRelationshipTypeId { get; set; }

        public System.DateTime? RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        public System.DateTime? RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatusId"/> model
        /// </summary>
        public Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollectionId"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

#endregion


        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(IPersonRelationship model)
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
            RecordStartDateTime = model.RecordStartDateTime;
            RecordEndDateTime = model.RecordEndDateTime;
            RecordStatusId = model.RecordStatusId;
            DataCollectionId = model.DataCollectionId;
            IsChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
