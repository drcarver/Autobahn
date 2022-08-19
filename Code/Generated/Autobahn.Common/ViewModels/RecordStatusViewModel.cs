//**********************************************************
//* DomainName: Common Models
//* FileName:   RecordStatusViewModel.cs
//***************************************************************************

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The RecordStatus View Model
     /// </summary>
    public partial class RecordStatusViewModel : ViewModelBase, Interfaces.IRecordStatus
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from RecordStatus";

        // member variable for the RecordStatusCreatorOrganizationId property
        private Guid? _RecordStatusCreatorOrganizationId;

        // member variable for the RecordStatusCreatorPersonId property
        private Guid? _RecordStatusCreatorPersonId;

        // RecordStatusDate -- (backing property for Record Status Date)
        private System.DateTime? _RecordStatusDate;

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
        public void Load(Interfaces.IRecordStatus model)
        {
            IsBusy = true;
            Id = model.Id;
            RecordStatusCreatorOrganizationId = model.RecordStatusCreatorOrganizationId; // 
            RecordStatusCreatorPersonId = model.RecordStatusCreatorPersonId; // 
            RecordStatusDate = model.RecordStatusDate; // Record Status Date
            RefRecordStatusCreatorEntityId = model.RefRecordStatusCreatorEntityId; // Record Status Creator Entity
            RefRecordStatusTypeId = model.RefRecordStatusTypeId; // Record Status Type
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }

        #region RefRecordStatusType List
        /// <summary>
        /// The complete <see cref="RefRecordStatusType"> List
        /// </summary>
        private static List<ReferenceModelBase> RefRecordStatusTypeList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("25def93a-eeb7-4dad-9b9a-020f42958d7b"), Code="Certified", Description="Certified", Definition="A person or organization with authority over this record or this process indicated the record was complete and accurate to the best of their knowledge.", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("14f10580-1e77-451a-867f-9df9dfe6f417"), Code="Decertified", Description="Decertified", Definition="A person or organization with authority over this record or this process indicated they wish to reverse the decision that was previously indicated through the status of Certified.", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("97281b51-7684-44b4-9408-0878e1fd3eba"), Code="Deleted", Description="Deleted", Definition="This record is no longer valid.", SortOrder=Convert.ToDecimal("3.00") },
            new ReferenceModelBase { Id=Guid.Parse("3e5605fc-f5d6-4dd6-8e7a-45c694516404"), Code="InProcess", Description="In Process", Definition="The data in this record are potentially transactional in nature.", SortOrder=Convert.ToDecimal("4.00") },
            new ReferenceModelBase { Id=Guid.Parse("ba5fe3a9-b31e-4682-8c4a-c458af78eb03"), Code="Published", Description="Published", Definition="The data in this record is in use or was used for federal, state, or local reporting or to fulfill research or data request purposes.", SortOrder=Convert.ToDecimal("5.00") },
            new ReferenceModelBase { Id=Guid.Parse("73b1924e-4c98-4130-99e4-3603b7914ebc"), Code="Retired", Description="Retired", Definition="The data in this record was once valid for use and is no longer valid for use per the requirements defined by the organization responsible for the record.", SortOrder=Convert.ToDecimal("6.00") },
            new ReferenceModelBase { Id=Guid.Parse("fcaa4dde-c4e0-4892-96a1-09a945ea36bb"), Code="Submitted", Description="Submitted", Definition="The data in this record are not transactional in nature but are complete and do not require any formal certification process.", SortOrder=Convert.ToDecimal("7.00") },
        };
        #endregion
    }
}
