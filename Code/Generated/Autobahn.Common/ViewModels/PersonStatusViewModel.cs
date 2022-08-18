//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonStatusViewModel.cs
//***************************************************************************

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The PersonStatus View Model
     /// </summary>
    public partial class PersonStatusViewModel : ViewModelBase, Interfaces.IPersonStatus
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PersonStatus";

        // member variable for the PersonId property
        private Guid _PersonId;

        // RefPersonStatusTypeId -- (backing property for Economic Disadvantage Status)
        private Guid _RefPersonStatusTypeId;

        // StatusEndDate -- (backing property for Status End Date)
        private System.DateTime? _StatusEndDate;

        // StatusStartDate -- (backing property for Status Start Date)
        private System.DateTime? _StatusStartDate;

        // member variable for the StatusValue property
        private System.Boolean _StatusValue;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IPerson"/> model
        /// </summary>
        public Guid PersonId { get => _PersonId; set => SetProperty(ref _PersonId, value); }

        /// <summary>
        /// Economic Disadvantage Status
        /// <para>
        /// An indication that the student met the State criteria for classification as having an economic disadvantage.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19086">Economic Disadvantage Status</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid RefPersonStatusTypeId { get => _RefPersonStatusTypeId; set => SetProperty(ref _RefPersonStatusTypeId, value); }

        /// <summary>
        /// Status End Date
        /// <para>
        /// The last year, month and day when a status applied to an individual.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20193">Status End Date</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.DateTime? StatusEndDate { get => _StatusEndDate; set => SetProperty(ref _StatusEndDate, value); }

        /// <summary>
        /// Status Start Date
        /// <para>
        /// The year, month and day that a status became applicable to an individual.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20192">Status Start Date</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.DateTime? StatusStartDate { get => _StatusStartDate; set => SetProperty(ref _StatusStartDate, value); }

        public System.Boolean StatusValue { get => _StatusValue; set => SetProperty(ref _StatusValue, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPersonStatus model)
        {
            IsBusy = true;
            Id = model.Id;
            PersonId = model.PersonId; // 
            RefPersonStatusTypeId = model.RefPersonStatusTypeId; // Economic Disadvantage Status
            StatusEndDate = model.StatusEndDate; // Status End Date
            StatusStartDate = model.StatusStartDate; // Status Start Date
            StatusValue = model.StatusValue; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }

        #region RefPersonStatusType List
        /// <summary>
        /// The complete <see cref="RefPersonStatusType"> List
        /// </summary>
        private static List<ReferenceModelBase> RefPersonStatusTypeList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("84b42e08-b902-4b4e-8321-56b036486ce4"), Code="EconomicDisadvantage", Description="Economic Disadvantage", Definition="", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("97dcf676-06b7-482a-ba0b-9bcc7af2743e"), Code="HomelessUnaccompaniedYouth", Description="Homeless Unaccompanied Youth", Definition="", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("2c2249db-9f76-4f65-8955-9cfca47fee8a"), Code="IDEA", Description="IDEA", Definition="", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("519f6417-e47a-4d3e-aa60-a7fe2ffe03bd"), Code="LEP ", Description="English Learner", Definition="", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("dd12412a-14f0-463f-b8f5-9f1398260d6e"), Code="Migrant", Description="Migrant", Definition="", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("8cad9f1b-171b-4f7a-9933-1bc56b48e97d"), Code="SchoolChoiceAppliedforTransfer", Description="School Choice Applied for Transfer", Definition="", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("00471146-2323-4901-b0ee-3f40fd961a09"), Code="SchoolChoiceEligibleforTransfer", Description="School Choice Eligible for Transfer", Definition="", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("c73a4926-2c8f-4d92-a11f-bd7f59e77767"), Code="SchoolChoiceTransfer", Description="School Choice Transfer", Definition="", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("1d3aeefd-6005-4456-b399-0cb9ae3e4357"), Code="TitleISchoolSupplementalServicesApplied", Description="Title I School Supplemental Services Applied", Definition="", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("0ed364af-3390-4480-b767-edf3ce8f3650"), Code="TitleISchoolSupplementalServicesEligible", Description="Title I School Supplemental Services Eligible", Definition="", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("a69ba5ba-9126-4a55-847c-0338c1dccf94"), Code="TitleISchoolSupplementalServicesReceived", Description="Title I School Supplemental Services Received", Definition="", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("de6c39de-56c3-443c-b31b-fa3a603599ad"), Code="TitleIIIImmigrant", Description="Title III Immigrant", Definition="", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("3f88283f-edc9-43d3-92f5-86affd250d18"), Code="Truant", Description="Truant", Definition="", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("98e77c8a-4d69-455b-a5d1-7a9c3b1c6018"), Code="SingleParentorSinglePregnantWoman", Description="Single Parent or Single Pregnant Woman", Definition="", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("ccf4fc09-4e1b-444a-b6ae-81c85491f091"), Code="Perkins LEP ", Description="Perkins Limited English Proficiency", Definition="", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("e1fd2bf0-562d-4fc3-8b67-e9265d21ef02"), Code="Low-income", Description="Low-income", Definition="", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("8ba3834f-771b-49ec-b60e-618be70233b6"), Code="DislocatedWorker", Description="Dislocated Worker", Definition="", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("037bcf8a-7631-48f4-92f7-74a58059e7cc"), Code="PublicAssistance", Description="Public Assistance", Definition="", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("ec7fac1c-7687-4c08-b8ce-a7d04f77107f"), Code="RuralResidency", Description="Rural Residency", Definition="", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("4c9ca516-2be1-4d53-a27f-1d5d6b136056"), Code="ProfessionalAssociationMembership", Description="Professional Association Membership", Definition="", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("968a1345-b054-40bc-868b-2bf225f92ba2"), Code="StateApprovedTrainer", Description="State Approved Trainer", Definition="", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("5a04a642-19cb-4c66-892d-ef83eabaa0e6"), Code="StateApprovedTechnicalAssistanceProvider", Description="State Approved Technical Assistance Provider", Definition="", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("c2a914b9-00c6-46a5-821c-884810e914ac"), Code="AwaitingFosterCare", Description="Awaiting Foster Care", Definition="", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("b4731a75-a175-4807-a133-ab70288e977a"), Code="Marital", Description="Marital", Definition="", SortOrder=Convert.ToDecimal("") },
        };
        #endregion
    }
}
