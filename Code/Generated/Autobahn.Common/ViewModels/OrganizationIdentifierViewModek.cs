//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   OrganizationIdentifierViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Common.Interfaces;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The OrganizationIdentifierViewModel
     /// </summary>
    public partial class OrganizationIdentifierViewModel : BindableBase, IOrganizationIdentifier
    {
#region "Backing Fields"
        // member variable for the Identifier property
        private System.String _Identifier;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

#endregion

#region Properties
        public System.String Identifier  { get => _Identifier; set => SetProperty(ref _Identifier, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefOrganizationIdentificationSystemId"/> model
        /// </summary>
        public Guid? RefOrganizationIdentificationSystemId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationId"/> model
        /// </summary>
        public Guid OrganizationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefOrganizationIdentifierTypeId"/> model
        /// </summary>
        public Guid? RefOrganizationIdentifierTypeId { get; set; }

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
        public void Load(IOrganizationIdentifier model)
        {
            IsBusy = true;
            Id = model.Id;
            Identifier = model.Identifier;
            RefOrganizationIdentificationSystemId = model.RefOrganizationIdentificationSystemId;
            OrganizationId = model.OrganizationId;
            RefOrganizationIdentifierTypeId = model.RefOrganizationIdentifierTypeId;
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
