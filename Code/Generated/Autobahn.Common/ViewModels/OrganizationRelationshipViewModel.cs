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

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefOrganizationRelationshipId property
        private Guid? _RefOrganizationRelationshipId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefOrganizationRelationship"/> model
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
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefOrganizationRelationshipId = model.RefOrganizationRelationshipId; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
