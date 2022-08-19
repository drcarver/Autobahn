//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationOperationalStatusViewModel.cs
//***************************************************************************

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The OrganizationOperationalStatus View Model
     /// </summary>
    public partial class OrganizationOperationalStatusViewModel : ViewModelBase, Interfaces.IOrganizationOperationalStatus
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from OrganizationOperationalStatus";

        // OperationalStatusEffectiveDate -- (backing property for Operation Date)
        private System.DateTime? _OperationalStatusEffectiveDate;

        // member variable for the OrganizationId property
        private Guid _OrganizationId;

        // RefOperationalStatusId -- (backing property for Local Education Agency Operational Status)
        private Guid _RefOperationalStatusId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Operation Date
        /// <para>
        /// The year, month and day on which a program or center began operation.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19350">Operation Date</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.DateTime? OperationalStatusEffectiveDate { get => _OperationalStatusEffectiveDate; set => SetProperty(ref _OperationalStatusEffectiveDate, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganization"/> model
        /// </summary>
        public Guid OrganizationId { get => _OrganizationId; set => SetProperty(ref _OrganizationId, value); }

        /// <summary>
        /// Local Education Agency Operational Status
        /// <para>
        /// The classification of the operational condition of a local education agency (LEA) at the start of the school year.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19174">Local Education Agency Operational Status</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid RefOperationalStatusId { get => _RefOperationalStatusId; set => SetProperty(ref _RefOperationalStatusId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IOrganizationOperationalStatus model)
        {
            IsBusy = true;
            Id = model.Id;
            OperationalStatusEffectiveDate = model.OperationalStatusEffectiveDate; // Operation Date
            OrganizationId = model.OrganizationId; // 
            RefOperationalStatusId = model.RefOperationalStatusId; // Local Education Agency Operational Status
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }

        #region RefOperationalStatus List
        /// <summary>
        /// The complete <see cref="RefOperationalStatus"> List
        /// </summary>
        private static List<ReferenceModelBase> RefOperationalStatusList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("a9ec3084-3dfa-4ded-a4ca-ca6d607cfca6"), Code="Open", Description="Open", Definition="The operational condition of a local education agency (LEA) at the start of the school year is Open.", SortOrder=Convert.ToDecimal("1") },
            new ReferenceModelBase { Id=Guid.Parse("42b85000-3eae-4fb2-a76f-cbb86c18ee0f"), Code="Closed", Description="Closed", Definition="The operational condition of a local education agency (LEA) at the start of the school year is Closed.", SortOrder=Convert.ToDecimal("1") },
            new ReferenceModelBase { Id=Guid.Parse("1763bfee-5c4f-41f5-9e99-a0c780c7d19a"), Code="New", Description="New", Definition="The operational condition of a local education agency (LEA) at the start of the school year is New.", SortOrder=Convert.ToDecimal("1") },
            new ReferenceModelBase { Id=Guid.Parse("60450a7d-8496-4d90-95cf-15148a7ef6df"), Code="Added", Description="Added", Definition="The operational condition of a local education agency (LEA) at the start of the school year is Added.", SortOrder=Convert.ToDecimal("1") },
            new ReferenceModelBase { Id=Guid.Parse("f6982ba8-2da8-4e33-ac91-b93b9cbb0eb1"), Code="ChangedBoundary", Description="Changed boundary", Definition="The operational condition of a local education agency (LEA) at the start of the school year is Changed boundary.", SortOrder=Convert.ToDecimal("1") },
            new ReferenceModelBase { Id=Guid.Parse("1f3626ab-bff6-40af-b2ef-a5937ba1208f"), Code="Inactive", Description="Inactive", Definition="The operational condition of a local education agency (LEA) at the start of the school year is Inactive.", SortOrder=Convert.ToDecimal("1") },
            new ReferenceModelBase { Id=Guid.Parse("cf7aa98a-dcbe-465a-b8fb-56dc9df2e9e6"), Code="FutureAgency", Description="Future agency", Definition="The operational condition of a local education agency (LEA) at the start of the school year is Future agency.", SortOrder=Convert.ToDecimal("1") },
            new ReferenceModelBase { Id=Guid.Parse("cb179af3-64eb-4807-a595-c939315400d1"), Code="Reopened", Description="Reopened", Definition="The operational condition of a local education agency (LEA) at the start of the school year is Reopened.", SortOrder=Convert.ToDecimal("1") },
            new ReferenceModelBase { Id=Guid.Parse("2243ddf3-736d-4a34-84b7-d41b97d02faa"), Code="Open", Description="Open", Definition="Open is the status of the school operations, exclusive of scheduled breaks, holidays, or other temporary interruptions.", SortOrder=Convert.ToDecimal("2") },
            new ReferenceModelBase { Id=Guid.Parse("68250c1f-39ee-4cf4-be5f-e28ab250c862"), Code="Closed", Description="Closed", Definition="Closed is the status of the school operations, exclusive of scheduled breaks, holidays, or other temporary interruptions.", SortOrder=Convert.ToDecimal("2") },
            new ReferenceModelBase { Id=Guid.Parse("60856bfb-c9e7-4315-b525-264793021715"), Code="New", Description="New", Definition="New is the status of the school operations, exclusive of scheduled breaks, holidays, or other temporary interruptions.", SortOrder=Convert.ToDecimal("2") },
            new ReferenceModelBase { Id=Guid.Parse("639c2b7c-1c06-4732-a1b1-449ef5d95397"), Code="Added", Description="Added", Definition="Added is the status of the school operations, exclusive of scheduled breaks, holidays, or other temporary interruptions.", SortOrder=Convert.ToDecimal("2") },
            new ReferenceModelBase { Id=Guid.Parse("10516605-ca98-4b13-98b1-1d7e013b7fc2"), Code="ChangedAgency", Description="Changed Agency", Definition="Changed Agency is the status of the school operations, exclusive of scheduled breaks, holidays, or other temporary interruptions.", SortOrder=Convert.ToDecimal("2") },
            new ReferenceModelBase { Id=Guid.Parse("70aed035-0b67-488d-ad07-f219fb5a3385"), Code="Inactive", Description="Inactive", Definition="Inactive is the status of the school operations, exclusive of scheduled breaks, holidays, or other temporary interruptions.", SortOrder=Convert.ToDecimal("2") },
            new ReferenceModelBase { Id=Guid.Parse("07b99678-b284-498b-bcc0-b8217aedc3d4"), Code="FutureSchool", Description="Future school", Definition="Future school is the status of the school operations, exclusive of scheduled breaks, holidays, or other temporary interruptions.", SortOrder=Convert.ToDecimal("2") },
            new ReferenceModelBase { Id=Guid.Parse("ed664151-37cb-49ae-aa64-a7a511999d05"), Code="Reopened", Description="Reopened", Definition="Reopened is the status of the school operations, exclusive of scheduled breaks, holidays, or other temporary interruptions.", SortOrder=Convert.ToDecimal("2") },
            new ReferenceModelBase { Id=Guid.Parse("febf2b9c-70c4-4460-9aa4-cc7b09d7dc5c"), Code="Active", Description="Active", Definition="The organization is active, except for scheduled breaks, holidays, or other temporary interruptions.", SortOrder=Convert.ToDecimal("3") },
            new ReferenceModelBase { Id=Guid.Parse("9f819bbc-e10b-4b06-b939-84612861ce26"), Code="Inactive", Description="Inactive", Definition="The organization is inactive.", SortOrder=Convert.ToDecimal("3") },
        };
        #endregion
    }
}
