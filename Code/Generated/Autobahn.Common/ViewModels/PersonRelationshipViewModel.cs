//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonRelationshipViewModel.cs
//**********************************************************

using System.ComponentModel;
using System.Windows.Input;

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
        private  _ContactPriorityNumber;

        // member variable for the ContactRestrictions property
        private  _ContactRestrictions;

        // member variable for the CustodialRelationshipIndicator property
        private Guid? _CustodialRelationshipIndicator;

        // member variable for the EmergencyContactInd property
        private  _EmergencyContactInd;

        // member variable for the LivesWithIndicator property
        private  _LivesWithIndicator;

        // member variable for the PrimaryContactIndicator property
        private  _PrimaryContactIndicator;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefPersonRelationshipTypeId property
        private  _RefPersonRelationshipTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public  ContactPriorityNumber { get => _ContactPriorityNumber; set => SetProperty(ref _ContactPriorityNumber, value); }

        /// <summary>
        /// </summary>
        public  ContactRestrictions { get => _ContactRestrictions; set => SetProperty(ref _ContactRestrictions, value); }

        /// <summary>
        /// </summary>
        public Guid? CustodialRelationshipIndicator { get => _CustodialRelationshipIndicator; set => SetProperty(ref _CustodialRelationshipIndicator, value); }

        /// <summary>
        /// </summary>
        public  EmergencyContactInd { get => _EmergencyContactInd; set => SetProperty(ref _EmergencyContactInd, value); }

        /// <summary>
        /// </summary>
        public  LivesWithIndicator { get => _LivesWithIndicator; set => SetProperty(ref _LivesWithIndicator, value); }

        /// <summary>
        /// </summary>
        public  PrimaryContactIndicator { get => _PrimaryContactIndicator; set => SetProperty(ref _PrimaryContactIndicator, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPersonRelationshipType"/> model
        /// </summary>
        public  RefPersonRelationshipTypeId { get => _RefPersonRelationshipTypeId; set => SetProperty(ref _RefPersonRelationshipTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPersonRelationship model)
        {
            IsBusy = true;
            Id = model.Id;
            ContactPriorityNumber = model.ContactPriorityNumber; // 
            ContactRestrictions = model.ContactRestrictions; // 
            CustodialRelationshipIndicator = model.CustodialRelationshipIndicator; // 
            EmergencyContactInd = model.EmergencyContactInd; // 
            LivesWithIndicator = model.LivesWithIndicator; // 
            PrimaryContactIndicator = model.PrimaryContactIndicator; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefPersonRelationshipTypeId = model.RefPersonRelationshipTypeId; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
