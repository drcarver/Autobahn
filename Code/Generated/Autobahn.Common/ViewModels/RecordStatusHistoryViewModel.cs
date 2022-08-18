//**********************************************************
//* DomainName: Common Models
//* FileName:   RecordStatusHistoryViewModel.cs
//***************************************************************************

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The RecordStatusHistory View Model
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

        // RecordStatusDate -- (backing property for Record Status Date)
        private System.DateTime? _RecordStatusDate;

        // member variable for the RecordTable property
        private System.String _RecordTable;

        // RefRecordStatusCreatorEntityId -- (backing property for Record Status Creator Entity)
        private Guid? _RefRecordStatusCreatorEntityId;

        // RefRecordStatusTypeId -- (backing property for Record Status Type)
        private Guid _RefRecordStatusTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRecord"/> model
        /// </summary>
        public Guid RecordId { get => _RecordId; set => SetProperty(ref _RecordId, value); }

        public System.String RecordPKColumn { get => _RecordPKColumn; set => SetProperty(ref _RecordPKColumn, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRecordStatusCreatorOrganization"/> model
        /// </summary>
        public Guid? RecordStatusCreatorOrganizationId { get => _RecordStatusCreatorOrganizationId; set => SetProperty(ref _RecordStatusCreatorOrganizationId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRecordStatusCreatorPerson"/> model
        /// </summary>
        public Guid? RecordStatusCreatorPersonId { get => _RecordStatusCreatorPersonId; set => SetProperty(ref _RecordStatusCreatorPersonId, value); }

        /// <summary>
        /// Record Status Date
        /// <para>
        /// The date the record was marked with the Record Status Type.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20957">Record Status Date</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.DateTime? RecordStatusDate { get => _RecordStatusDate; set => SetProperty(ref _RecordStatusDate, value); }

        public System.String RecordTable { get => _RecordTable; set => SetProperty(ref _RecordTable, value); }

        /// <summary>
        /// Record Status Creator Entity
        /// <para>
        /// The type of entity that created or indicated the Record Status Type
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20956">Record Status Creator Entity</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefRecordStatusCreatorEntityId { get => _RefRecordStatusCreatorEntityId; set => SetProperty(ref _RefRecordStatusCreatorEntityId, value); }

        /// <summary>
        /// Record Status Type
        /// <para>
        /// A process indicator of the level of stability, quality, and/or preparedness of the record.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20958">Record Status Type</a>
        /// </para>
        /// </summary>
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
            RecordId = model.RecordId; // 
            RecordPKColumn = model.RecordPKColumn; // 
            RecordStatusCreatorOrganizationId = model.RecordStatusCreatorOrganizationId; // 
            RecordStatusCreatorPersonId = model.RecordStatusCreatorPersonId; // 
            RecordStatusDate = model.RecordStatusDate; // Record Status Date
            RecordTable = model.RecordTable; // 
            RefRecordStatusCreatorEntityId = model.RefRecordStatusCreatorEntityId; // Record Status Creator Entity
            RefRecordStatusTypeId = model.RefRecordStatusTypeId; // Record Status Type
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
