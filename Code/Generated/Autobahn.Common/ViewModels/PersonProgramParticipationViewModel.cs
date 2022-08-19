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
            new ReferenceModelBase { Id=Guid.Parse("ea562470-cfdf-41ee-b0c3-8cb6b5569af9"), Code="GED Preparation Program Participation", Description="", Definition="GEDPreparationProgramParticipation", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("51fe2b71-1fde-4752-b232-a2469dc985e8"), Code="Gifted and Talented", Description="", Definition="GiftedandTalented", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("36407ab3-b82c-4e98-8fed-b759473f7788"), Code="Homeless Serviced", Description="", Definition="HomelessServiced", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("72037481-1691-4e88-a1d5-f7abbbde91e1"), Code="Migrant Education Program Participation", Description="", Definition="MEP Participation ", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("edd37753-4a41-4782-b387-d894949e5080"), Code="Neglected or Delinquent", Description="", Definition="NeglectedorDelinquent", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("32269903-d34d-41d9-a3fe-53914f74ef56"), Code="Section 504", Description="", Definition="Section504", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("cbfaf799-7d11-4b00-9c9d-dd8d7513bc4d"), Code="Title III Immigrant Participation", Description="", Definition="TitleIIIImmigrantParticipation", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("344155a8-c727-43b9-a335-482f507c5b6c"), Code="Title I Schoolwide Program Participation", Description="", Definition="TitleISchoolwideProgramParticipation", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("4ecf89e4-5210-4f47-ae4d-07f912fd5231"), Code="Title I Targeted Assistance Participation", Description="", Definition="TitleITargetedAssistanceParticipation", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("42f9ff96-b588-437d-810e-2d190966fc4a"), Code="Title III English Learner Participation", Description="", Definition="Title III LEP Participation ", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("4e6396b0-a4c5-48ad-b3c8-1b6dc3f3f82e"), Code="Kindergarten Program Participation", Description="", Definition="KindergartenProgramParticipation", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("2d3b2832-a0e7-40a7-a638-6a954d113227"), Code="Career Pathways Program Participation", Description="", Definition="CareerPathwaysProgramParticipation", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("bf5f4273-960b-4d61-bf4d-15ccebd66058"), Code="Correctional Education Reentry Services Participation", Description="", Definition="CorrectionalEducationReentryServicesParticipation", SortOrder=Convert.ToDecimal("") },
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
            new ReferenceModelBase { Id=Guid.Parse("a45a7292-78b6-4f4f-8702-b89a62c23688"), Code="06262", Description="Attempts to contact the parent and/or child were unsuccessful", Definition="Attempts to contact the parent and/or child were unsuccessful.", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("bfe5caa0-3781-4332-bfa0-84f3fdd3bf24"), Code="02226", Description="Completion of IFSP prior to reaching maximum age for Part C", Definition="Completion of IFSP prior to reaching maximum age for Part C", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("336a0f65-99c8-4a14-b975-db95ae24dbaf"), Code="01923", Description="Died or is permanently incapacitated", Definition="Died or is permanently incapacitated", SortOrder=Convert.ToDecimal("5.00") },
            new ReferenceModelBase { Id=Guid.Parse("44798d54-b928-47fc-87e7-bfdd91cb82c8"), Code="01927", Description="Discontinued schooling", Definition="Discontinued schooling", SortOrder=Convert.ToDecimal("6.00") },
            new ReferenceModelBase { Id=Guid.Parse("7d6f8895-9781-44ff-8990-51fb770d2df5"), Code="02222", Description="Discontinued schooling, not special education", Definition="Discontinued schooling, not special education", SortOrder=Convert.ToDecimal("7.00") },
            new ReferenceModelBase { Id=Guid.Parse("35d75c0c-7458-4246-8546-d5fa17a13660"), Code="02221", Description="Discontinued schooling, special education only", Definition="Discontinued schooling, special education only", SortOrder=Convert.ToDecimal("8.00") },
            new ReferenceModelBase { Id=Guid.Parse("c9ee5800-28f4-459a-a963-658fa84acf81"), Code="02227", Description="Eligible for IDEA, Part B", Definition="Eligible for IDEA, Part B", SortOrder=Convert.ToDecimal("9.00") },
            new ReferenceModelBase { Id=Guid.Parse("b86c6e7a-c258-4aad-b48a-f7b7276b2986"), Code="02224", Description="Expulsion", Definition="Expulsion", SortOrder=Convert.ToDecimal("10.00") },
            new ReferenceModelBase { Id=Guid.Parse("59800e90-369b-4296-837d-6a1b9d5d240d"), Code="02212", Description="Graduated with a high school diploma", Definition="Graduated with a high school diploma", SortOrder=Convert.ToDecimal("11.00") },
            new ReferenceModelBase { Id=Guid.Parse("10dd0a0a-d7ad-41a9-84b9-02902836d6fd"), Code="02231", Description="Moved out of state", Definition="Moved out of state", SortOrder=Convert.ToDecimal("12.00") },
            new ReferenceModelBase { Id=Guid.Parse("29f9db91-338a-4bf9-9f22-8ed0a879e81c"), Code="02216", Description="No longer receiving special education", Definition="No longer receiving special education", SortOrder=Convert.ToDecimal("13.00") },
            new ReferenceModelBase { Id=Guid.Parse("c08c0e58-306e-4b60-8f26-7afd37193f3b"), Code="06261", Description="Not eligible for Part B, exit with no referrals", Definition="Not eligible for Part B, exit with no referrals", SortOrder=Convert.ToDecimal("14.00") },
            new ReferenceModelBase { Id=Guid.Parse("c48f4f25-1a03-4b85-99ad-1f3600817667"), Code="73075", Description="Moved within the US, not known to be continuing", Definition="Moved within the US, not known to be continuing", SortOrder=Convert.ToDecimal("14.00") },
            new ReferenceModelBase { Id=Guid.Parse("20a7f76d-bce4-43f6-a8c3-dc9de67258fe"), Code="02228", Description="Not eligible for Part B, exit with referrals to other programs", Definition="Not eligible for Part B, exit with referrals to other programs", SortOrder=Convert.ToDecimal("15.00") },
            new ReferenceModelBase { Id=Guid.Parse("71acb83e-692e-41df-96a7-fce7cd14d684"), Code="02230", Description="Part B eligibility not determined", Definition="Part B eligibility not determined", SortOrder=Convert.ToDecimal("16.00") },
            new ReferenceModelBase { Id=Guid.Parse("ae10541a-4c8e-4a27-99cb-d8e0bba5539a"), Code="02214", Description="Program completion", Definition="Program completion", SortOrder=Convert.ToDecimal("17.00") },
            new ReferenceModelBase { Id=Guid.Parse("48df9558-ec07-4891-9cff-500a4ca9438e"), Code="02225", Description="Program discontinued", Definition="Program discontinued", SortOrder=Convert.ToDecimal("18.00") },
            new ReferenceModelBase { Id=Guid.Parse("2b207f8c-7201-44b9-88b6-459d653b058c"), Code="02215", Description="Reached maximum age", Definition="Reached maximum age", SortOrder=Convert.ToDecimal("19.00") },
            new ReferenceModelBase { Id=Guid.Parse("066f8887-c74c-4c62-953d-fc946488d0a6"), Code="02213", Description="Received certificate of completion, modified diploma, or finished IEP requirements", Definition="Received certificate of completion, modified diploma, or finished IEP requirements", SortOrder=Convert.ToDecimal("20.00") },
            new ReferenceModelBase { Id=Guid.Parse("511db5d0-52da-4c2d-9273-81379a2640d5"), Code="02217", Description="Refused services", Definition="Refused services", SortOrder=Convert.ToDecimal("21.00") },
            new ReferenceModelBase { Id=Guid.Parse("f561ee15-7712-4eea-a936-9ca8c6389582"), Code="73076", Description="Student data claimed in error/never attended", Definition="Student data claimed in error/never attended", SortOrder=Convert.ToDecimal("24.00") },
            new ReferenceModelBase { Id=Guid.Parse("a8ecc28e-486d-4717-9bb0-d76ac7fe9d4f"), Code="73078", Description="Student moved to another country, may or may not be continuing", Definition="Student moved to another country, may or may not be continuing", SortOrder=Convert.ToDecimal("25.00") },
            new ReferenceModelBase { Id=Guid.Parse("6ab9cecc-34c1-4695-9f4c-60653520e0af"), Code="73079", Description="Student with disabilities remaining in school to receive transitional services", Definition="Student with disabilities who met the district graduation requirements for a regular diploma, but is remaining in school to receive transitional services deemed necessary by the IEP team.", SortOrder=Convert.ToDecimal("25.00") },
            new ReferenceModelBase { Id=Guid.Parse("d4848bab-364e-4f9f-9fc5-5a0a46e2390e"), Code="02220", Description="Suspended from school", Definition="Suspended from school", SortOrder=Convert.ToDecimal("26.00") },
            new ReferenceModelBase { Id=Guid.Parse("2bcdffa7-4dbe-4c53-9ff4-145a117667d7"), Code="02406", Description="Transferred to another district or school, known not to be continuing in program/service", Definition="Transferred to another district or school, known not to be continuing in program/service", SortOrder=Convert.ToDecimal("30.00") },
            new ReferenceModelBase { Id=Guid.Parse("cba43012-f840-44a1-97f4-c3d7a8f6ef7f"), Code="02218", Description="Transferred to another district or school, known to be continuing in program/service", Definition="Transferred to another district or school, known to be continuing in program/service", SortOrder=Convert.ToDecimal("31.00") },
            new ReferenceModelBase { Id=Guid.Parse("901a6cc5-eb7f-4aed-afd4-e86fa5cf812a"), Code="02219", Description="Transferred to another district or school, not known to be continuing in program/service", Definition="Transferred to another district or school, not known to be continuing in program/service", SortOrder=Convert.ToDecimal("32.00") },
            new ReferenceModelBase { Id=Guid.Parse("7c03cfc5-1e1c-4086-a50b-c72735bc4d3a"), Code="73077", Description="Transferred to a juvenile or adult correctional facility where educational services are not provided", Definition="Transferred to a juvenile or adult correctional facility where educational services are not provided", SortOrder=Convert.ToDecimal("36.00") },
            new ReferenceModelBase { Id=Guid.Parse("f5e0712b-8945-43f9-b808-15994d119411"), Code="02233", Description="Unknown reason", Definition="Unknown reason", SortOrder=Convert.ToDecimal("37.00") },
            new ReferenceModelBase { Id=Guid.Parse("ecd9f22e-7317-4921-b99b-e58ff515ece3"), Code="02232", Description="Withdrawal by a parent (or guardian)", Definition="Withdrawal by a parent (or guardian)", SortOrder=Convert.ToDecimal("38.00") },
            new ReferenceModelBase { Id=Guid.Parse("a512b5ba-9229-4b1a-a858-9afebc8000dc"), Code="09999", Description="Other", Definition="Other", SortOrder=Convert.ToDecimal("40.00") },
        };
        #endregion
    }
}
