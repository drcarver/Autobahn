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

        // member variable for the Identifier property
        private  _Identifier;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefOrganizationIdentificationSystemId property
        private  _RefOrganizationIdentificationSystemId;

        // member variable for the RefOrganizationIdentifierTypeId property
        private Guid? _RefOrganizationIdentifierTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public  Identifier { get => _Identifier; set => SetProperty(ref _Identifier, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefOrganizationentificationSystem"/> model
        /// </summary>
        public  RefOrganizationIdentificationSystemId { get => _RefOrganizationIdentificationSystemId; set => SetProperty(ref _RefOrganizationIdentificationSystemId, value); }

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
            Identifier = model.Identifier; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefOrganizationIdentificationSystemId = model.RefOrganizationIdentificationSystemId; // 
            RefOrganizationIdentifierTypeId = model.RefOrganizationIdentifierTypeId; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
