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
            new ReferenceModelBase { Id=Guid.Parse("fa49965e-b76f-4caf-979c-a52c90cbc17c"), Code="Open", Description="Open", Definition="The operational condition of a local education agency (LEA) at the start of the school year is Open.", SortOrder=Convert.ToDecimal("1") },
            new ReferenceModelBase { Id=Guid.Parse("cb3923b3-9631-4e68-a1e0-3f5507e00fb4"), Code="Closed", Description="Closed", Definition="The operational condition of a local education agency (LEA) at the start of the school year is Closed.", SortOrder=Convert.ToDecimal("1") },
            new ReferenceModelBase { Id=Guid.Parse("44a079a2-941c-48a5-99b2-89b1a5b81b93"), Code="New", Description="New", Definition="The operational condition of a local education agency (LEA) at the start of the school year is New.", SortOrder=Convert.ToDecimal("1") },
            new ReferenceModelBase { Id=Guid.Parse("97f8f43c-38d1-4439-be48-6bead0996728"), Code="Added", Description="Added", Definition="The operational condition of a local education agency (LEA) at the start of the school year is Added.", SortOrder=Convert.ToDecimal("1") },
            new ReferenceModelBase { Id=Guid.Parse("9bd9841a-293e-4979-8762-48935d0e87fb"), Code="ChangedBoundary", Description="Changed boundary", Definition="The operational condition of a local education agency (LEA) at the start of the school year is Changed boundary.", SortOrder=Convert.ToDecimal("1") },
            new ReferenceModelBase { Id=Guid.Parse("fc379120-bae2-471d-8d10-535678efa73e"), Code="Inactive", Description="Inactive", Definition="The operational condition of a local education agency (LEA) at the start of the school year is Inactive.", SortOrder=Convert.ToDecimal("1") },
            new ReferenceModelBase { Id=Guid.Parse("ea0094b3-09d0-4b44-89bb-8a272b604748"), Code="FutureAgency", Description="Future agency", Definition="The operational condition of a local education agency (LEA) at the start of the school year is Future agency.", SortOrder=Convert.ToDecimal("1") },
            new ReferenceModelBase { Id=Guid.Parse("74c8f339-8810-43f3-9aca-f769a6735110"), Code="Reopened", Description="Reopened", Definition="The operational condition of a local education agency (LEA) at the start of the school year is Reopened.", SortOrder=Convert.ToDecimal("1") },
            new ReferenceModelBase { Id=Guid.Parse("ac821d43-2ee2-454e-8607-1ab6591cc655"), Code="Open", Description="Open", Definition="Open is the status of the school operations, exclusive of scheduled breaks, holidays, or other temporary interruptions.", SortOrder=Convert.ToDecimal("2") },
            new ReferenceModelBase { Id=Guid.Parse("06bedcb5-03f1-4189-8359-18edaf953c91"), Code="Closed", Description="Closed", Definition="Closed is the status of the school operations, exclusive of scheduled breaks, holidays, or other temporary interruptions.", SortOrder=Convert.ToDecimal("2") },
            new ReferenceModelBase { Id=Guid.Parse("67c4af8a-6b80-4d0c-978d-df92dab2ff40"), Code="New", Description="New", Definition="New is the status of the school operations, exclusive of scheduled breaks, holidays, or other temporary interruptions.", SortOrder=Convert.ToDecimal("2") },
            new ReferenceModelBase { Id=Guid.Parse("281a5144-01d7-43fb-9b9b-3460d8bd104d"), Code="Added", Description="Added", Definition="Added is the status of the school operations, exclusive of scheduled breaks, holidays, or other temporary interruptions.", SortOrder=Convert.ToDecimal("2") },
            new ReferenceModelBase { Id=Guid.Parse("c2c194da-efa0-4919-ba70-7b363174fce6"), Code="ChangedAgency", Description="Changed Agency", Definition="Changed Agency is the status of the school operations, exclusive of scheduled breaks, holidays, or other temporary interruptions.", SortOrder=Convert.ToDecimal("2") },
            new ReferenceModelBase { Id=Guid.Parse("254ff9a5-d1ed-42ce-8501-23e144aad031"), Code="Inactive", Description="Inactive", Definition="Inactive is the status of the school operations, exclusive of scheduled breaks, holidays, or other temporary interruptions.", SortOrder=Convert.ToDecimal("2") },
            new ReferenceModelBase { Id=Guid.Parse("8dd3cfb9-c443-4133-9308-34099a81aac0"), Code="FutureSchool", Description="Future school", Definition="Future school is the status of the school operations, exclusive of scheduled breaks, holidays, or other temporary interruptions.", SortOrder=Convert.ToDecimal("2") },
            new ReferenceModelBase { Id=Guid.Parse("53b30b32-91bc-4458-a820-b1719b9d3b20"), Code="Reopened", Description="Reopened", Definition="Reopened is the status of the school operations, exclusive of scheduled breaks, holidays, or other temporary interruptions.", SortOrder=Convert.ToDecimal("2") },
            new ReferenceModelBase { Id=Guid.Parse("ebc8d152-b068-4806-aabb-f989fa2126ca"), Code="Active", Description="Active", Definition="The organization is active, except for scheduled breaks, holidays, or other temporary interruptions.", SortOrder=Convert.ToDecimal("3") },
            new ReferenceModelBase { Id=Guid.Parse("23cb4335-7b8c-448c-993a-cdebca7c7f26"), Code="Inactive", Description="Inactive", Definition="The organization is inactive.", SortOrder=Convert.ToDecimal("3") },
        };
        #endregion
    }
}
