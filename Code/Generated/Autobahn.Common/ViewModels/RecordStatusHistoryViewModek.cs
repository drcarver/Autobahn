//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RecordStatusHistoryViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Common.Interfaces;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The RecordStatusHistoryViewModel
     /// </summary>
    public partial class RecordStatusHistoryViewModel : BindableBase, IRecordStatusHistory
    {
#region "Backing Fields"
        // member variable for the RecordPKColumn property
        private System.String _RecordPKColumn;

        // member variable for the RecordTable property
        private System.String _RecordTable;

        // member variable for the RecordStatusDate property
        private System.DateTime? _RecordStatusDate;

#endregion

#region Properties
        /// <summary>
        /// Reference to a required instance of the <see cref="RecordStatusId"/> model
        /// </summary>
        public Guid RecordStatusId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="RecordId"/> model
        /// </summary>
        public Guid RecordId { get; set; }

        public System.String RecordPKColumn  { get => _RecordPKColumn; set => SetProperty(ref _RecordPKColumn, value); }

        public System.String RecordTable  { get => _RecordTable; set => SetProperty(ref _RecordTable, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatusCreatorOrganizationId"/> model
        /// </summary>
        public Guid? RecordStatusCreatorOrganizationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatusCreatorPersonId"/> model
        /// </summary>
        public Guid? RecordStatusCreatorPersonId { get; set; }

        public System.DateTime? RecordStatusDate { get => _RecordStatusDate; set => SetProperty(ref _RecordStatusDate, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefRecordStatusTypeId"/> model
        /// </summary>
        public Guid RefRecordStatusTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefRecordStatusCreatorEntityId"/> model
        /// </summary>
        public Guid? RefRecordStatusCreatorEntityId { get; set; }

#endregion


        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(IRecordStatusHistory model)
        {
            IsBusy = true;
            Id = model.Id;
            RecordStatusId = model.RecordStatusId;
            RecordId = model.RecordId;
            RecordPKColumn = model.RecordPKColumn;
            RecordTable = model.RecordTable;
            RecordStatusCreatorOrganizationId = model.RecordStatusCreatorOrganizationId;
            RecordStatusCreatorPersonId = model.RecordStatusCreatorPersonId;
            RecordStatusDate = model.RecordStatusDate;
            RefRecordStatusTypeId = model.RefRecordStatusTypeId;
            RefRecordStatusCreatorEntityId = model.RefRecordStatusCreatorEntityId;
            IsChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
