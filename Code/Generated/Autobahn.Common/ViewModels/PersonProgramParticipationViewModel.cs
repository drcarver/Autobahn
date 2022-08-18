//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonProgramParticipationViewModel.cs
//***************************************************************************

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The PersonProgramParticipation View Model
     /// </summary>
    public partial class PersonProgramParticipationViewModel : ViewModelBase, Interfaces.IPersonProgramParticipation
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PersonProgramParticipation";

        // member variable for the OrganizationPersonRoleId property
        private Guid _OrganizationPersonRoleId;

        // ParticipationStatus -- (backing property for Gifted and Talented Indicator)
        private System.String _ParticipationStatus;

        // RefParticipationTypeId -- (backing property for GED Preparation Program Participation Status)
        private Guid? _RefParticipationTypeId;

        // RefProgramEntryReasonId -- (backing property for Program Entry Reason)
        private Guid? _RefProgramEntryReasonId;

        // RefProgramExitReasonId -- (backing property for Exit Reason)
        private Guid? _RefProgramExitReasonId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get => _OrganizationPersonRoleId; set => SetProperty(ref _OrganizationPersonRoleId, value); }

        /// <summary>
        /// Gifted and Talented Indicator
        /// <para>
        /// An indication that the student is participating in and served by a Gifted/Talented program.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19122">Gifted and Talented Indicator</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String ParticipationStatus { get => _ParticipationStatus; set => SetProperty(ref _ParticipationStatus, value); }

        /// <summary>
        /// GED Preparation Program Participation Status
        /// <para>
        /// An indication that a student aged 16-19 participates in a General Educational Development (GED) preparation program.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19120">GED Preparation Program Participation Status</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefParticipationTypeId { get => _RefParticipationTypeId; set => SetProperty(ref _RefParticipationTypeId, value); }

        /// <summary>
        /// Program Entry Reason
        /// <para>
        /// The documented or assumed reason a person is being served by a program.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20909">Program Entry Reason</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefProgramEntryReasonId { get => _RefProgramEntryReasonId; set => SetProperty(ref _RefProgramEntryReasonId, value); }

        /// <summary>
        /// Exit Reason
        /// <para>
        /// The documented or assumed reason a student is no longer being served by a special program.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19222">Exit Reason</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefProgramExitReasonId { get => _RefProgramExitReasonId; set => SetProperty(ref _RefProgramExitReasonId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPersonProgramParticipation model)
        {
            IsBusy = true;
            Id = model.Id;
            OrganizationPersonRoleId = model.OrganizationPersonRoleId; // 
            ParticipationStatus = model.ParticipationStatus; // Gifted and Talented Indicator
            RefParticipationTypeId = model.RefParticipationTypeId; // GED Preparation Program Participation Status
            RefProgramEntryReasonId = model.RefProgramEntryReasonId; // Program Entry Reason
            RefProgramExitReasonId = model.RefProgramExitReasonId; // Exit Reason
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }

        #region RefParticipationType List
        /// <summary>
        /// The complete <see cref="RefParticipationType"> List
        /// </summary>
        private static List<ReferenceModelBase> RefParticipationTypeList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("12065522-f17c-4968-8b02-55cd03a73fdb"), Code="GED Preparation Program Participation", Description="", Definition="GEDPreparationProgramParticipation", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("67cf2e1d-6b41-4a1e-bbdd-1345d6cc50f9"), Code="Gifted and Talented", Description="", Definition="GiftedandTalented", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("6ea4f47a-4ca4-418b-8810-d871cdd34e87"), Code="Homeless Serviced", Description="", Definition="HomelessServiced", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("a1ce10bd-7a42-4743-8c70-fcc828a10e51"), Code="Migrant Education Program Participation", Description="", Definition="MEP Participation ", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("123330d9-6e1e-441b-a949-6cffbcdb567b"), Code="Neglected or Delinquent", Description="", Definition="NeglectedorDelinquent", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("1d9b1aa8-de3d-4ba8-9424-ce65acbe8d4f"), Code="Section 504", Description="", Definition="Section504", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("e49188ed-1576-41bf-9b92-7db872061f37"), Code="Title III Immigrant Participation", Description="", Definition="TitleIIIImmigrantParticipation", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("75401361-20a9-43d1-ae8d-172696a561ca"), Code="Title I Schoolwide Program Participation", Description="", Definition="TitleISchoolwideProgramParticipation", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("5b6b4f46-ef68-423c-a436-329788106e77"), Code="Title I Targeted Assistance Participation", Description="", Definition="TitleITargetedAssistanceParticipation", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("980d2d92-0d5f-44b6-9f4c-1c7f48563b9b"), Code="Title III English Learner Participation", Description="", Definition="Title III LEP Participation ", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("4824eecf-2c07-44cf-b5df-010ab4a65d31"), Code="Kindergarten Program Participation", Description="", Definition="KindergartenProgramParticipation", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("40f5b133-4470-49b3-894f-fc0667959638"), Code="Career Pathways Program Participation", Description="", Definition="CareerPathwaysProgramParticipation", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("b002a3cb-5781-4fac-95a3-bf9aa6244a3c"), Code="Correctional Education Reentry Services Participation", Description="", Definition="CorrectionalEducationReentryServicesParticipation", SortOrder=Convert.ToDecimal("") },
        };
        #endregion

        #region RefProgramEntryReason List
        /// <summary>
        /// The complete <see cref="RefProgramEntryReason"> List
        /// </summary>
        private static List<ReferenceModelBase> RefProgramEntryReasonList = new List<ReferenceModelBase>
        {
        };
        #endregion

        #region RefProgramExitReason List
        /// <summary>
        /// The complete <see cref="RefProgramExitReason"> List
        /// </summary>
        private static List<ReferenceModelBase> RefProgramExitReasonList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("b6a869f9-2e3e-4943-9f2b-1e5501b7e3aa"), Code="06262", Description="Attempts to contact the parent and/or child were unsuccessful", Definition="Attempts to contact the parent and/or child were unsuccessful.", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("238312f0-0afe-4793-923f-263ad79929ac"), Code="02226", Description="Completion of IFSP prior to reaching maximum age for Part C", Definition="Completion of IFSP prior to reaching maximum age for Part C", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("1dd5806b-d369-48b2-b20f-4e6194268ef2"), Code="01923", Description="Died or is permanently incapacitated", Definition="Died or is permanently incapacitated", SortOrder=Convert.ToDecimal("5.00") },
            new ReferenceModelBase { Id=Guid.Parse("3bc7f07f-f28c-43c9-a858-b9b23866eb68"), Code="01927", Description="Discontinued schooling", Definition="Discontinued schooling", SortOrder=Convert.ToDecimal("6.00") },
            new ReferenceModelBase { Id=Guid.Parse("dd3a8ab9-eb4e-438f-bc76-e017835295af"), Code="02222", Description="Discontinued schooling, not special education", Definition="Discontinued schooling, not special education", SortOrder=Convert.ToDecimal("7.00") },
            new ReferenceModelBase { Id=Guid.Parse("7572d24f-a4d9-4cf1-a0a8-329b56596e19"), Code="02221", Description="Discontinued schooling, special education only", Definition="Discontinued schooling, special education only", SortOrder=Convert.ToDecimal("8.00") },
            new ReferenceModelBase { Id=Guid.Parse("2f6edff7-af05-41db-9f6f-b5c84608e9d9"), Code="02227", Description="Eligible for IDEA, Part B", Definition="Eligible for IDEA, Part B", SortOrder=Convert.ToDecimal("9.00") },
            new ReferenceModelBase { Id=Guid.Parse("d992b0ff-bbbc-4320-904e-5ec1bb02844c"), Code="02224", Description="Expulsion", Definition="Expulsion", SortOrder=Convert.ToDecimal("10.00") },
            new ReferenceModelBase { Id=Guid.Parse("2c45b843-942d-40ec-a4ea-30b4c6d496e0"), Code="02212", Description="Graduated with a high school diploma", Definition="Graduated with a high school diploma", SortOrder=Convert.ToDecimal("11.00") },
            new ReferenceModelBase { Id=Guid.Parse("06237549-d186-46be-9ddf-c5e03d352629"), Code="02231", Description="Moved out of state", Definition="Moved out of state", SortOrder=Convert.ToDecimal("12.00") },
            new ReferenceModelBase { Id=Guid.Parse("f9645c9e-5500-4350-a98c-87d9d902a7e7"), Code="02216", Description="No longer receiving special education", Definition="No longer receiving special education", SortOrder=Convert.ToDecimal("13.00") },
            new ReferenceModelBase { Id=Guid.Parse("d825a170-0d3c-419b-a765-214f432ed0a1"), Code="06261", Description="Not eligible for Part B, exit with no referrals", Definition="Not eligible for Part B, exit with no referrals", SortOrder=Convert.ToDecimal("14.00") },
            new ReferenceModelBase { Id=Guid.Parse("355f938a-dadc-41fa-b98d-0893c51fda10"), Code="73075", Description="Moved within the US, not known to be continuing", Definition="Moved within the US, not known to be continuing", SortOrder=Convert.ToDecimal("14.00") },
            new ReferenceModelBase { Id=Guid.Parse("4fd50d16-808b-45e2-915c-d188e630d1b7"), Code="02228", Description="Not eligible for Part B, exit with referrals to other programs", Definition="Not eligible for Part B, exit with referrals to other programs", SortOrder=Convert.ToDecimal("15.00") },
            new ReferenceModelBase { Id=Guid.Parse("3a936510-b55b-44a8-b8df-31a307f12840"), Code="02230", Description="Part B eligibility not determined", Definition="Part B eligibility not determined", SortOrder=Convert.ToDecimal("16.00") },
            new ReferenceModelBase { Id=Guid.Parse("fe47fae7-b971-4ae0-a147-68e27523da4e"), Code="02214", Description="Program completion", Definition="Program completion", SortOrder=Convert.ToDecimal("17.00") },
            new ReferenceModelBase { Id=Guid.Parse("fc54312f-9df8-4b3d-92ac-c45294c0a252"), Code="02225", Description="Program discontinued", Definition="Program discontinued", SortOrder=Convert.ToDecimal("18.00") },
            new ReferenceModelBase { Id=Guid.Parse("1e9528ee-4419-4f9d-830f-8e40851b8670"), Code="02215", Description="Reached maximum age", Definition="Reached maximum age", SortOrder=Convert.ToDecimal("19.00") },
            new ReferenceModelBase { Id=Guid.Parse("46f176cd-5b36-4e9d-ba74-495a74dcb060"), Code="02213", Description="Received certificate of completion, modified diploma, or finished IEP requirements", Definition="Received certificate of completion, modified diploma, or finished IEP requirements", SortOrder=Convert.ToDecimal("20.00") },
            new ReferenceModelBase { Id=Guid.Parse("ee119ae0-a241-495e-90b1-6c8ba1211100"), Code="02217", Description="Refused services", Definition="Refused services", SortOrder=Convert.ToDecimal("21.00") },
            new ReferenceModelBase { Id=Guid.Parse("aabbdcb4-1458-4060-a5b1-4968f1b8eaf9"), Code="73076", Description="Student data claimed in error/never attended", Definition="Student data claimed in error/never attended", SortOrder=Convert.ToDecimal("24.00") },
            new ReferenceModelBase { Id=Guid.Parse("d15cb384-48b8-4ec9-a49b-ef62b27fb8fd"), Code="73078", Description="Student moved to another country, may or may not be continuing", Definition="Student moved to another country, may or may not be continuing", SortOrder=Convert.ToDecimal("25.00") },
            new ReferenceModelBase { Id=Guid.Parse("06d15628-cbf6-4bdb-9d3d-ffc9b19a06ab"), Code="73079", Description="Student with disabilities remaining in school to receive transitional services", Definition="Student with disabilities who met the district graduation requirements for a regular diploma, but is remaining in school to receive transitional services deemed necessary by the IEP team.", SortOrder=Convert.ToDecimal("25.00") },
            new ReferenceModelBase { Id=Guid.Parse("c261d523-a973-4bfd-be5e-badf0dc8e0ff"), Code="02220", Description="Suspended from school", Definition="Suspended from school", SortOrder=Convert.ToDecimal("26.00") },
            new ReferenceModelBase { Id=Guid.Parse("50b90283-9079-42b2-b1e5-220fa88fe98a"), Code="02406", Description="Transferred to another district or school, known not to be continuing in program/service", Definition="Transferred to another district or school, known not to be continuing in program/service", SortOrder=Convert.ToDecimal("30.00") },
            new ReferenceModelBase { Id=Guid.Parse("38ef8661-0d43-44ba-9c04-e8f9bd0aa46c"), Code="02218", Description="Transferred to another district or school, known to be continuing in program/service", Definition="Transferred to another district or school, known to be continuing in program/service", SortOrder=Convert.ToDecimal("31.00") },
            new ReferenceModelBase { Id=Guid.Parse("6cb396c9-31d0-4488-a60f-c8ed145e463c"), Code="02219", Description="Transferred to another district or school, not known to be continuing in program/service", Definition="Transferred to another district or school, not known to be continuing in program/service", SortOrder=Convert.ToDecimal("32.00") },
            new ReferenceModelBase { Id=Guid.Parse("83f96219-a7b1-4540-a29e-e7d365553a92"), Code="73077", Description="Transferred to a juvenile or adult correctional facility where educational services are not provided", Definition="Transferred to a juvenile or adult correctional facility where educational services are not provided", SortOrder=Convert.ToDecimal("36.00") },
            new ReferenceModelBase { Id=Guid.Parse("83fc5255-2820-4f90-b1a9-eafbadb09c10"), Code="02233", Description="Unknown reason", Definition="Unknown reason", SortOrder=Convert.ToDecimal("37.00") },
            new ReferenceModelBase { Id=Guid.Parse("9a94cb41-0c12-48da-b4e2-75432a47c490"), Code="02232", Description="Withdrawal by a parent (or guardian)", Definition="Withdrawal by a parent (or guardian)", SortOrder=Convert.ToDecimal("38.00") },
            new ReferenceModelBase { Id=Guid.Parse("2f620f90-385a-48cb-b102-f03125510b73"), Code="09999", Description="Other", Definition="Other", SortOrder=Convert.ToDecimal("40.00") },
        };
        #endregion
    }
}
