//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   RecordStatusHistoryViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;
using CommunityToolkit.Maui;

namespace Autobahn.Authorization.ViewModels
{
     /// <summary>
     /// The RecordStatusHistoryViewModel
     /// </summary>
    public partial class RecordStatusHistoryViewModel : ViewModelBase, Interfaces.IRecordStatusHistory
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from RecordStatusHistory";

        // member variable for the RecordId property
        private Guid _RecordId;

        // member variable for the RecordPKColumn property
        private System.String _RecordPKColumn;

        // member variable for the RecordStatusCreatorOrganizationId property
        private Guid? _RecordStatusCreatorOrganizationId;

        // member variable for the RecordStatusCreatorPersonId property
        private Guid? _RecordStatusCreatorPersonId;

        // member variable for the RecordStatusDate property
        private System.DateTime? _RecordStatusDate;

        // member variable for the RecordTable property
        private System.String _RecordTable;

        // member variable for the RefRecordStatusCreatorEntityId property
        private Guid? _RefRecordStatusCreatorEntityId;

        // member variable for the RefRecordStatusTypeId property
        private Guid _RefRecordStatusTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the RecordStatusHistoryViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="Record"/> model
        /// </summary>
        public Guid RecordId { get => _RecordId; set => SetProperty(ref _RecordId, value); }

        /// <summary>
        /// The type of entity that created or indicated the Record Status Type
        /// </summary>
        public System.String RecordPKColumn { get => _RecordPKColumn; set => SetProperty(ref _RecordPKColumn, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatusCreatorOrganization"/> model
        /// </summary>
        public Guid? RecordStatusCreatorOrganizationId { get => _RecordStatusCreatorOrganizationId; set => SetProperty(ref _RecordStatusCreatorOrganizationId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatusCreatorPerson"/> model
        /// </summary>
        public Guid? RecordStatusCreatorPersonId { get => _RecordStatusCreatorPersonId; set => SetProperty(ref _RecordStatusCreatorPersonId, value); }

        /// <summary>
        /// The type of entity that created or indicated the Record Status Type
        /// </summary>
        public System.DateTime? RecordStatusDate { get => _RecordStatusDate; set => SetProperty(ref _RecordStatusDate, value); }

        /// <summary>
        /// The type of entity that created or indicated the Record Status Type
        /// </summary>
        public System.String RecordTable { get => _RecordTable; set => SetProperty(ref _RecordTable, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefRecordStatusCreatorEntity"/> model
        /// </summary>
        public Guid? RefRecordStatusCreatorEntityId { get => _RefRecordStatusCreatorEntityId; set => SetProperty(ref _RefRecordStatusCreatorEntityId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefRecordStatusType"/> model
        /// </summary>
        public Guid RefRecordStatusTypeId { get => _RefRecordStatusTypeId; set => SetProperty(ref _RefRecordStatusTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IRecordStatusHistory model)
        {
            IsBusy = true;
            Id = model.Id;
            RecordId = model.RecordId;
            RecordPKColumn = model.RecordPKColumn;
            RecordStatusCreatorOrganizationId = model.RecordStatusCreatorOrganizationId;
            RecordStatusCreatorPersonId = model.RecordStatusCreatorPersonId;
            RecordStatusDate = model.RecordStatusDate;
            RecordTable = model.RecordTable;
            RefRecordStatusCreatorEntityId = model.RefRecordStatusCreatorEntityId;
            RefRecordStatusTypeId = model.RefRecordStatusTypeId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
