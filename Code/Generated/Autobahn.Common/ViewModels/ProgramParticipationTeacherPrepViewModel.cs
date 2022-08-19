//**********************************************************
//* DomainName: Common Models
//* FileName:   ProgramParticipationTeacherPrepViewModel.cs
//* Name:       Supervised Clinical Experience Clock Hours
//* Definition: An indication of  the number of clock hours (minimum) a student is required to complete associated with a supervised clinical experience.
//***************************************************************************

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// An indication of  the number of clock hours (minimum) a student is required to complete associated with a supervised clinical experience.
     /// </summary>
    public partial class ProgramParticipationTeacherPrepViewModel : ViewModelBase, Interfaces.IProgramParticipationTeacherPrep
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from ProgramParticipationTeacherPrep";

        // ClinicalExperienceClockHours -- (backing property for Supervised Clinical Experience Clock Hours)
        private System.Int32? _ClinicalExperienceClockHours;

        // member variable for the PersonProgramParticipationId property
        private Guid _PersonProgramParticipationId;

        // RefAltRouteToCertificationOrLicensureId -- (backing property for Alternative Route to Certification or Licensure)
        private Guid? _RefAltRouteToCertificationOrLicensureId;

        // RefCriticalTeacherShortageCandidateId -- (backing property for Critical Teacher Shortage Area Candidate)
        private Guid? _RefCriticalTeacherShortageCandidateId;

        // RefSupervisedClinicalExperienceId -- (backing property for Supervised Clinical Experience)
        private Guid? _RefSupervisedClinicalExperienceId;

        // RefTeacherPrepCompleterStatusId -- (backing property for Teacher Preparation Program Completer Status)
        private Guid? _RefTeacherPrepCompleterStatusId;

        // RefTeacherPrepEnrollmentStatusId -- (backing property for Teacher Preparation Program Enrollment Status)
        private Guid? _RefTeacherPrepEnrollmentStatusId;

        // RefTeachingCredentialBasisId -- (backing property for Teaching Credential Basis)
        private Guid? _RefTeachingCredentialBasisId;

        // RefTeachingCredentialTypeId -- (backing property for Teaching Credential Type)
        private Guid? _RefTeachingCredentialTypeId;

        // SchoolAgeEducationPSCredits -- (backing property for Number of School-age Education Postsecondary Credit Hours)
        private System.Decimal? _SchoolAgeEducationPSCredits;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Supervised Clinical Experience Clock Hours
        /// <para>
        /// An indication of  the number of clock hours (minimum) a student is required to complete associated with a supervised clinical experience.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19755">Supervised Clinical Experience Clock Hours</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Int32? ClinicalExperienceClockHours { get => _ClinicalExperienceClockHours; set => SetProperty(ref _ClinicalExperienceClockHours, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IPersonProgramParticipation"/> model
        /// </summary>
        public Guid PersonProgramParticipationId { get => _PersonProgramParticipationId; set => SetProperty(ref _PersonProgramParticipationId, value); }

        /// <summary>
        /// Alternative Route to Certification or Licensure
        /// <para>
        /// An indication of whether a person is enrolled in an alternative teacher preparation program as defined by Title II.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19751">Alternative Route to Certification or Licensure</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefAltRouteToCertificationOrLicensureId { get => _RefAltRouteToCertificationOrLicensureId; set => SetProperty(ref _RefAltRouteToCertificationOrLicensureId, value); }

        /// <summary>
        /// Critical Teacher Shortage Area Candidate
        /// <para>
        /// An indication of whether a person is pursuing licensure/certification in a field designated as a shortage area as defined by Title II.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19753">Critical Teacher Shortage Area Candidate</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefCriticalTeacherShortageCandidateId { get => _RefCriticalTeacherShortageCandidateId; set => SetProperty(ref _RefCriticalTeacherShortageCandidateId, value); }

        /// <summary>
        /// Supervised Clinical Experience
        /// <para>
        /// An indication of whether a person is enrolled in a supervised clinical experience (including student teaching) as part of a teacher preparation program.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19754">Supervised Clinical Experience</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefSupervisedClinicalExperienceId { get => _RefSupervisedClinicalExperienceId; set => SetProperty(ref _RefSupervisedClinicalExperienceId, value); }

        /// <summary>
        /// Teacher Preparation Program Completer Status
        /// <para>
        /// An indication of whether a person completed a state-approved teacher preparation program.  The fact that a person has or has not been recommended to the state for initial certification or licensure may not be used as a criterion for determining who is a program completer.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19750">Teacher Preparation Program Completer Status</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefTeacherPrepCompleterStatusId { get => _RefTeacherPrepCompleterStatusId; set => SetProperty(ref _RefTeacherPrepCompleterStatusId, value); }

        /// <summary>
        /// Teacher Preparation Program Enrollment Status
        /// <para>
        /// An indication of whether a person is pursuing certification as a teacher.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19749">Teacher Preparation Program Enrollment Status</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefTeacherPrepEnrollmentStatusId { get => _RefTeacherPrepEnrollmentStatusId; set => SetProperty(ref _RefTeacherPrepEnrollmentStatusId, value); }

        /// <summary>
        /// Teaching Credential Basis
        /// <para>
        /// An indication of the pre-determined criteria for granting the teaching credential that a person holds.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19277">Teaching Credential Basis</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefTeachingCredentialBasisId { get => _RefTeachingCredentialBasisId; set => SetProperty(ref _RefTeachingCredentialBasisId, value); }

        /// <summary>
        /// Teaching Credential Type
        /// <para>
        /// An indication of the category of a legal document giving authorization to perform teaching assignment services.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19278">Teaching Credential Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefTeachingCredentialTypeId { get => _RefTeachingCredentialTypeId; set => SetProperty(ref _RefTeachingCredentialTypeId, value); }

        /// <summary>
        /// Number of School-age Education Postsecondary Credit Hours
        /// <para>
        /// The number of college course credit hours an individual has successfully completed that are related to K-12 education, parks and recreation, and juvenile justice.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19815">Number of School-age Education Postsecondary Credit Hours</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Decimal? SchoolAgeEducationPSCredits { get => _SchoolAgeEducationPSCredits; set => SetProperty(ref _SchoolAgeEducationPSCredits, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IProgramParticipationTeacherPrep model)
        {
            IsBusy = true;
            Id = model.Id;
            ClinicalExperienceClockHours = model.ClinicalExperienceClockHours; // Supervised Clinical Experience Clock Hours
            PersonProgramParticipationId = model.PersonProgramParticipationId; // 
            RefAltRouteToCertificationOrLicensureId = model.RefAltRouteToCertificationOrLicensureId; // Alternative Route to Certification or Licensure
            RefCriticalTeacherShortageCandidateId = model.RefCriticalTeacherShortageCandidateId; // Critical Teacher Shortage Area Candidate
            RefSupervisedClinicalExperienceId = model.RefSupervisedClinicalExperienceId; // Supervised Clinical Experience
            RefTeacherPrepCompleterStatusId = model.RefTeacherPrepCompleterStatusId; // Teacher Preparation Program Completer Status
            RefTeacherPrepEnrollmentStatusId = model.RefTeacherPrepEnrollmentStatusId; // Teacher Preparation Program Enrollment Status
            RefTeachingCredentialBasisId = model.RefTeachingCredentialBasisId; // Teaching Credential Basis
            RefTeachingCredentialTypeId = model.RefTeachingCredentialTypeId; // Teaching Credential Type
            SchoolAgeEducationPSCredits = model.SchoolAgeEducationPSCredits; // Number of School-age Education Postsecondary Credit Hours
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }

        #region RefSupervisedClinicalExperience List
        /// <summary>
        /// The complete Supervised Clinical Experience Clock Hours List
        /// </summary>
        private static List<ReferenceModelBase> RefSupervisedClinicalExperienceList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("69150327-07c4-4634-9709-2c01f4c10d05"), Code="Yes", Description="Yes", Definition="", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("34991b0e-684b-4414-a9e3-01b4b9969bcf"), Code="No", Description="No", Definition="", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("dc1b825e-0c6e-4d88-9d5c-1331aeae8da8"), Code="NA", Description="Not applicable", Definition="", SortOrder=Convert.ToDecimal("3.00") },
        };
        #endregion

        #region RefTeacherPrepCompleterStatus List
        /// <summary>
        /// The complete Supervised Clinical Experience Clock Hours List
        /// </summary>
        private static List<ReferenceModelBase> RefTeacherPrepCompleterStatusList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("b3b984b9-e352-4e90-a7dd-6c18dca578d8"), Code="Yes", Description="Yes", Definition="", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("c9b12abd-1d52-47d7-ae4b-cc2b2441fddb"), Code="No", Description="No", Definition="", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("89decc4f-d836-4683-9f82-b10f9888c5fc"), Code="NA", Description="Not applicable", Definition="", SortOrder=Convert.ToDecimal("3.00") },
        };
        #endregion

        #region RefTeacherPrepEnrollmentStatus List
        /// <summary>
        /// The complete Supervised Clinical Experience Clock Hours List
        /// </summary>
        private static List<ReferenceModelBase> RefTeacherPrepEnrollmentStatusList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("03b91906-b8ef-41b7-8f6d-b11a201902e0"), Code="No", Description="No", Definition="The person is NOT pursuing certification as a teacher.", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("fe6d0261-4f41-41bc-abfb-e334a3016b40"), Code="SeekingCandidacy", Description="Seeking Candidacy", Definition="The person is seeking candidacy and pursuing certification as a teacher.", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("3c5308af-0622-44ae-b231-c5fe78fce859"), Code="Enrolled", Description="Enrolled", Definition="The person is enrolled in a program and pursuing certification as a teacher.", SortOrder=Convert.ToDecimal("3.00") },
        };
        #endregion

        #region RefTeachingCredentialBasis List
        /// <summary>
        /// The complete Supervised Clinical Experience Clock Hours List
        /// </summary>
        private static List<ReferenceModelBase> RefTeachingCredentialBasisList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("326259f9-fb59-4212-ba93-e2e07985beb5"), Code="01050", Description="Associate's degree (two years or more) ", Definition="Associate's degree (two years or more) is the  pre-determined criteria for granting the teaching credential that a person holds.", SortOrder=Convert.ToDecimal("0.00") },
            new ReferenceModelBase { Id=Guid.Parse("a89d20eb-608f-4051-b6a9-630ea2473804"), Code="01235", Description="4-year bachelor's degree", Definition="4-year bachelor's degree is the  pre-determined criteria for granting the teaching credential that a person holds.", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("34dc7c9b-ad21-4518-9feb-7adb39173da2"), Code="01236", Description="5-year bachelor's degree", Definition="5-year bachelor's degree is the  pre-determined criteria for granting the teaching credential that a person holds.", SortOrder=Convert.ToDecimal("4.00") },
            new ReferenceModelBase { Id=Guid.Parse("4cb2c5a7-35c0-4f3f-bde8-6f23b1072a0d"), Code="73205", Description="Post-baccalaureate certificate", Definition="Post-baccalaureate certificate is the  pre-determined criteria for granting the teaching credential that a person holds.", SortOrder=Convert.ToDecimal("5.00") },
            new ReferenceModelBase { Id=Guid.Parse("4e0afb97-f999-4668-8173-16467ed830ef"), Code="01237", Description="Master's degree", Definition="Master's degree is the  pre-determined criteria for granting the teaching credential that a person holds.", SortOrder=Convert.ToDecimal("6.00") },
            new ReferenceModelBase { Id=Guid.Parse("d2f0b4fa-67b7-4293-bd2a-41ee3d4c3381"), Code="73081", Description="Post-master's certificate", Definition="Post-master's certificate is the  pre-determined criteria for granting the teaching credential that a person holds.", SortOrder=Convert.ToDecimal("7.00") },
            new ReferenceModelBase { Id=Guid.Parse("d8c25a90-214e-4e1c-ba4d-7c01c57fba21"), Code="01238", Description="Doctoral degree", Definition="Doctoral degree is the  pre-determined criteria for granting the teaching credential that a person holds.", SortOrder=Convert.ToDecimal("8.00") },
            new ReferenceModelBase { Id=Guid.Parse("3010a2ba-e48e-42fd-9c7a-460d1b12243e"), Code="73206", Description="Post-doctoral certificate", Definition="Post-doctoral certificate is the  pre-determined criteria for granting the teaching credential that a person holds.", SortOrder=Convert.ToDecimal("9.00") },
            new ReferenceModelBase { Id=Guid.Parse("fc81fb47-fb35-4930-b61e-6b4cc05d7409"), Code="01239", Description="Met state testing requirement", Definition="Met state testing requirement is the  pre-determined criteria for granting the teaching credential that a person holds.", SortOrder=Convert.ToDecimal("10.00") },
            new ReferenceModelBase { Id=Guid.Parse("979367a5-56d0-4369-a526-129f0880b24a"), Code="01240", Description="Special/alternative program completion", Definition="Special/alternative program completion is the  pre-determined criteria for granting the teaching credential that a person holds.", SortOrder=Convert.ToDecimal("12.00") },
            new ReferenceModelBase { Id=Guid.Parse("72b7bf58-543b-49fe-884b-3d16c3c9f409"), Code="01241", Description="Relevant experience", Definition="Relevant experience is the  pre-determined criteria for granting the teaching credential that a person holds.", SortOrder=Convert.ToDecimal("14.00") },
            new ReferenceModelBase { Id=Guid.Parse("449bb3c6-48b4-4138-b61e-ee562b0b2ce3"), Code="01242", Description="Credentials based on reciprocation with another state", Definition="Credentials based on reciprocation with another state is the  pre-determined criteria for granting the teaching credential that a person holds.", SortOrder=Convert.ToDecimal("16.00") },
        };
        #endregion

        #region RefTeachingCredentialType List
        /// <summary>
        /// The complete Supervised Clinical Experience Clock Hours List
        /// </summary>
        private static List<ReferenceModelBase> RefTeachingCredentialTypeList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("2e9097a2-8a04-471c-ab87-68defd5c6f0e"), Code="Emergency", Description="Emergency", Definition="Emergency is the category of legal document giving authorization for the person to perform teaching assignment services.", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("a6500084-255d-4965-ae9a-c21f9c35d0c1"), Code="Intern", Description="Intern", Definition="Intern is the category of legal document giving authorization for the person to perform teaching assignment services.", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("04ca28bc-2281-416c-972b-87dcdde4615a"), Code="Master", Description="Master", Definition="Master is the category of legal document giving authorization for the person to perform teaching assignment services.", SortOrder=Convert.ToDecimal("3.00") },
            new ReferenceModelBase { Id=Guid.Parse("511d7b24-c327-4f84-8e04-cc21f23cd111"), Code="Nonrenewable", Description="Nonrenewable", Definition="Nonrenewable is the category of legal document giving authorization for the person to perform teaching assignment services.", SortOrder=Convert.ToDecimal("4.00") },
            new ReferenceModelBase { Id=Guid.Parse("02a9040a-8dc0-4d30-90b6-ac4f230de141"), Code="Probationary", Description="Probationary/initial", Definition="Probationary/initial  is the category of legal document giving authorization for the person to perform teaching assignment services.", SortOrder=Convert.ToDecimal("5.00") },
            new ReferenceModelBase { Id=Guid.Parse("a26c381a-3106-4550-9f02-e1caf2869fc7"), Code="Professional", Description="Professional", Definition="Professional  is the category of legal document giving authorization for the person to perform teaching assignment services.", SortOrder=Convert.ToDecimal("6.00") },
            new ReferenceModelBase { Id=Guid.Parse("f1a0e7ce-089a-437a-9836-56609a0264b5"), Code="Provisional", Description="Provisional", Definition="Provisional  is the category of legal document giving authorization for the person to perform teaching assignment services.", SortOrder=Convert.ToDecimal("7.00") },
            new ReferenceModelBase { Id=Guid.Parse("9dbfaf2c-8044-4e64-8064-81ec536ee34c"), Code="Regular", Description="Regular/standard", Definition="Regular/standard  is the category of legal document giving authorization for the person to perform teaching assignment services.", SortOrder=Convert.ToDecimal("8.00") },
            new ReferenceModelBase { Id=Guid.Parse("75050e94-3f0c-431e-82fd-4790bab0d933"), Code="Retired", Description="Retired", Definition="Retired is the category of legal document giving authorization for the person to perform teaching assignment services.", SortOrder=Convert.ToDecimal("9.00") },
            new ReferenceModelBase { Id=Guid.Parse("a859954f-41aa-4076-bf6a-31ec951d0435"), Code="Specialist", Description="Specialist", Definition="Specialist is the category of legal document giving authorization for the person to perform teaching assignment services.", SortOrder=Convert.ToDecimal("10.00") },
            new ReferenceModelBase { Id=Guid.Parse("2490da20-c50b-4747-9d50-fbdeb070b8b4"), Code="Substitute", Description="Substitute", Definition="Substitute is the category of legal document giving authorization for the person to perform teaching assignment services.", SortOrder=Convert.ToDecimal("11.00") },
            new ReferenceModelBase { Id=Guid.Parse("3b9b4cbf-c109-4ab9-8330-dccc3a72dd45"), Code="TeacherAssistant", Description="Teacher assistant", Definition="Teacher assistant is the category of legal document giving authorization for the person to perform teaching assignment services.", SortOrder=Convert.ToDecimal("12.00") },
            new ReferenceModelBase { Id=Guid.Parse("36a83c3b-48c8-4763-bb65-fcb2905a58d7"), Code="Temporary", Description="Temporary", Definition="Temporary is the category of legal document giving authorization for the person to perform teaching assignment services.", SortOrder=Convert.ToDecimal("13.00") },
            new ReferenceModelBase { Id=Guid.Parse("e0dac816-82fb-4ce8-806c-5d879fc43474"), Code="09999", Description="Other", Definition="Other is the category of legal document giving authorization for the person to perform teaching assignment services.", SortOrder=Convert.ToDecimal("14.00") },
        };
        #endregion
    }
}
