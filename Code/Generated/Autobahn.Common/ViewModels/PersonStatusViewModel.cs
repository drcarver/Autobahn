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
            new ReferenceModelBase { Id=Guid.Parse("c881ab9d-11b4-4702-abf6-7398045490bd"), Code="EconomicDisadvantage", Description="Economic Disadvantage", Definition="", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("5ca59c5f-6251-4ef7-b637-fd70be909511"), Code="HomelessUnaccompaniedYouth", Description="Homeless Unaccompanied Youth", Definition="", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("aa07b03d-c63e-4ed9-8eda-d21de6d0b56f"), Code="IDEA", Description="IDEA", Definition="", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("022aa207-7ccd-4264-8471-d0d1436c22c4"), Code="LEP ", Description="English Learner", Definition="", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("19ddf3e5-dadd-4ca6-9305-e9d72a27566f"), Code="Migrant", Description="Migrant", Definition="", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("4074804e-96d3-41e8-89e7-cd178986a17b"), Code="SchoolChoiceAppliedforTransfer", Description="School Choice Applied for Transfer", Definition="", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("8bc02c6c-da0b-4e10-9502-f245026ca1ee"), Code="SchoolChoiceEligibleforTransfer", Description="School Choice Eligible for Transfer", Definition="", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("c3fa01f9-108a-4bc3-84af-a0cca9c35046"), Code="SchoolChoiceTransfer", Description="School Choice Transfer", Definition="", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("e54103d7-b718-4a48-b2bd-ea2ffcf90f32"), Code="TitleISchoolSupplementalServicesApplied", Description="Title I School Supplemental Services Applied", Definition="", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("575f4a21-581d-4f0a-88f0-c4bdecaad5f3"), Code="TitleISchoolSupplementalServicesEligible", Description="Title I School Supplemental Services Eligible", Definition="", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("76bfb3ef-1dbf-4d4f-959b-fa055f769206"), Code="TitleISchoolSupplementalServicesReceived", Description="Title I School Supplemental Services Received", Definition="", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("7c78565e-69ee-447b-abba-93a606fde525"), Code="TitleIIIImmigrant", Description="Title III Immigrant", Definition="", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("5295d0c2-e72f-41e5-97f7-0b3362f660c2"), Code="Truant", Description="Truant", Definition="", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("3e636a20-153d-4252-a5aa-ad001ad432ec"), Code="SingleParentorSinglePregnantWoman", Description="Single Parent or Single Pregnant Woman", Definition="", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("32db3f74-4ef3-423b-850c-49431acef85a"), Code="Perkins LEP ", Description="Perkins Limited English Proficiency", Definition="", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("d426ab50-4a6c-4a0d-a8a0-0c04d5a994cd"), Code="Low-income", Description="Low-income", Definition="", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("ee3ec83f-b822-4e1f-ae2d-cbe32cb4e356"), Code="DislocatedWorker", Description="Dislocated Worker", Definition="", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("69455c60-05fa-4d52-98eb-027aac4d6706"), Code="PublicAssistance", Description="Public Assistance", Definition="", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("fbd642a2-c4a8-4131-a1be-a2e33a3eab19"), Code="RuralResidency", Description="Rural Residency", Definition="", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("167f0818-efec-4db9-92b9-6292fb3f1302"), Code="ProfessionalAssociationMembership", Description="Professional Association Membership", Definition="", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("6585e7e8-20b2-4542-81fc-514066b91b32"), Code="StateApprovedTrainer", Description="State Approved Trainer", Definition="", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("90e61d15-3c2c-4e86-96df-65e2a6c62585"), Code="StateApprovedTechnicalAssistanceProvider", Description="State Approved Technical Assistance Provider", Definition="", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("287474e6-e3f6-4239-bb11-af7cabc0752b"), Code="AwaitingFosterCare", Description="Awaiting Foster Care", Definition="", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("97e1ee5d-a155-4698-a910-f9bd9195cfe6"), Code="Marital", Description="Marital", Definition="", SortOrder=Convert.ToDecimal("") },
        };
        #endregion
    }
}
