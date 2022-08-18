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
            new ReferenceModelBase { Id=Guid.Parse("5a65cda4-65d7-49c9-9aca-0566535b64aa"), Code="Yes", Description="Yes", Definition="", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("bf596cae-c939-4c46-ab9b-b612be0b58ff"), Code="No", Description="No", Definition="", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("4cbadded-d92d-40eb-9c52-a05e7b6218b6"), Code="NA", Description="Not applicable", Definition="", SortOrder=Convert.ToDecimal("3.00") },
        };
        #endregion

        #region RefTeacherPrepCompleterStatus List
        /// <summary>
        /// The complete Supervised Clinical Experience Clock Hours List
        /// </summary>
        private static List<ReferenceModelBase> RefTeacherPrepCompleterStatusList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("463acd34-0b07-4fa8-8dab-b1eaa0df2836"), Code="Yes", Description="Yes", Definition="", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("72bcd9ed-3212-4d4a-a7de-7472e22eb2fc"), Code="No", Description="No", Definition="", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("681939e9-a3a1-4f33-89c8-f00db3e392e0"), Code="NA", Description="Not applicable", Definition="", SortOrder=Convert.ToDecimal("3.00") },
        };
        #endregion

        #region RefTeacherPrepEnrollmentStatus List
        /// <summary>
        /// The complete Supervised Clinical Experience Clock Hours List
        /// </summary>
        private static List<ReferenceModelBase> RefTeacherPrepEnrollmentStatusList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("8fe08aed-ba60-420d-bc60-7e20d92646fc"), Code="No", Description="No", Definition="The person is NOT pursuing certification as a teacher.", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("5bcde713-18dc-4277-89b4-26485729f693"), Code="SeekingCandidacy", Description="Seeking Candidacy", Definition="The person is seeking candidacy and pursuing certification as a teacher.", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("e92cac85-13ab-4bc4-8386-bf78d5efc444"), Code="Enrolled", Description="Enrolled", Definition="The person is enrolled in a program and pursuing certification as a teacher.", SortOrder=Convert.ToDecimal("3.00") },
        };
        #endregion

        #region RefTeachingCredentialBasis List
        /// <summary>
        /// The complete Supervised Clinical Experience Clock Hours List
        /// </summary>
        private static List<ReferenceModelBase> RefTeachingCredentialBasisList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("8fc903b3-9b6e-404a-a6b1-58a7a441a6bf"), Code="01050", Description="Associate's degree (two years or more) ", Definition="Associate's degree (two years or more) is the  pre-determined criteria for granting the teaching credential that a person holds.", SortOrder=Convert.ToDecimal("0.00") },
            new ReferenceModelBase { Id=Guid.Parse("e4c8e592-4b65-4145-946a-5a1abc325348"), Code="01235", Description="4-year bachelor's degree", Definition="4-year bachelor's degree is the  pre-determined criteria for granting the teaching credential that a person holds.", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("20581312-cb2c-4ee2-893c-b47bab64d12f"), Code="01236", Description="5-year bachelor's degree", Definition="5-year bachelor's degree is the  pre-determined criteria for granting the teaching credential that a person holds.", SortOrder=Convert.ToDecimal("4.00") },
            new ReferenceModelBase { Id=Guid.Parse("942b8345-9d88-4ad0-86fe-fa8866517e5b"), Code="73205", Description="Post-baccalaureate certificate", Definition="Post-baccalaureate certificate is the  pre-determined criteria for granting the teaching credential that a person holds.", SortOrder=Convert.ToDecimal("5.00") },
            new ReferenceModelBase { Id=Guid.Parse("cdb15cb5-0644-4749-9c5f-143d184b2926"), Code="01237", Description="Master's degree", Definition="Master's degree is the  pre-determined criteria for granting the teaching credential that a person holds.", SortOrder=Convert.ToDecimal("6.00") },
            new ReferenceModelBase { Id=Guid.Parse("594e31c2-0f6b-49db-a5f1-7b6059f00b9d"), Code="73081", Description="Post-master's certificate", Definition="Post-master's certificate is the  pre-determined criteria for granting the teaching credential that a person holds.", SortOrder=Convert.ToDecimal("7.00") },
            new ReferenceModelBase { Id=Guid.Parse("3470ae0e-127c-4500-bfb0-4ceb873e97a9"), Code="01238", Description="Doctoral degree", Definition="Doctoral degree is the  pre-determined criteria for granting the teaching credential that a person holds.", SortOrder=Convert.ToDecimal("8.00") },
            new ReferenceModelBase { Id=Guid.Parse("30e569c1-b202-45ad-b214-ed8f6f5afe36"), Code="73206", Description="Post-doctoral certificate", Definition="Post-doctoral certificate is the  pre-determined criteria for granting the teaching credential that a person holds.", SortOrder=Convert.ToDecimal("9.00") },
            new ReferenceModelBase { Id=Guid.Parse("fbcf85eb-0db4-4d64-85a4-2b709447131b"), Code="01239", Description="Met state testing requirement", Definition="Met state testing requirement is the  pre-determined criteria for granting the teaching credential that a person holds.", SortOrder=Convert.ToDecimal("10.00") },
            new ReferenceModelBase { Id=Guid.Parse("83608d9f-b03f-4361-99d8-7af1bf0a5cb0"), Code="01240", Description="Special/alternative program completion", Definition="Special/alternative program completion is the  pre-determined criteria for granting the teaching credential that a person holds.", SortOrder=Convert.ToDecimal("12.00") },
            new ReferenceModelBase { Id=Guid.Parse("c5b9a10d-c8b9-4ab3-9483-0e5daefccd1e"), Code="01241", Description="Relevant experience", Definition="Relevant experience is the  pre-determined criteria for granting the teaching credential that a person holds.", SortOrder=Convert.ToDecimal("14.00") },
            new ReferenceModelBase { Id=Guid.Parse("4e98f15e-a8cd-46b1-82d8-257597266d3b"), Code="01242", Description="Credentials based on reciprocation with another state", Definition="Credentials based on reciprocation with another state is the  pre-determined criteria for granting the teaching credential that a person holds.", SortOrder=Convert.ToDecimal("16.00") },
        };
        #endregion

        #region RefTeachingCredentialType List
        /// <summary>
        /// The complete Supervised Clinical Experience Clock Hours List
        /// </summary>
        private static List<ReferenceModelBase> RefTeachingCredentialTypeList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("0453813b-0b51-4ebc-98ea-7305e55bc15c"), Code="Emergency", Description="Emergency", Definition="Emergency is the category of legal document giving authorization for the person to perform teaching assignment services.", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("01d63249-dd01-4685-ac4e-ba7662da04d2"), Code="Intern", Description="Intern", Definition="Intern is the category of legal document giving authorization for the person to perform teaching assignment services.", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("79646685-20c8-4b52-b693-543d861a5f20"), Code="Master", Description="Master", Definition="Master is the category of legal document giving authorization for the person to perform teaching assignment services.", SortOrder=Convert.ToDecimal("3.00") },
            new ReferenceModelBase { Id=Guid.Parse("dd6d3cfe-b832-4257-bb9d-151ea94509ee"), Code="Nonrenewable", Description="Nonrenewable", Definition="Nonrenewable is the category of legal document giving authorization for the person to perform teaching assignment services.", SortOrder=Convert.ToDecimal("4.00") },
            new ReferenceModelBase { Id=Guid.Parse("f041ce5c-12c5-476c-a261-a23b1c03efe2"), Code="Probationary", Description="Probationary/initial", Definition="Probationary/initial  is the category of legal document giving authorization for the person to perform teaching assignment services.", SortOrder=Convert.ToDecimal("5.00") },
            new ReferenceModelBase { Id=Guid.Parse("41e8d93d-cdeb-4b43-98d3-f6dc6cee0514"), Code="Professional", Description="Professional", Definition="Professional  is the category of legal document giving authorization for the person to perform teaching assignment services.", SortOrder=Convert.ToDecimal("6.00") },
            new ReferenceModelBase { Id=Guid.Parse("5a614d64-e13c-47bb-96ac-9a1e382bd583"), Code="Provisional", Description="Provisional", Definition="Provisional  is the category of legal document giving authorization for the person to perform teaching assignment services.", SortOrder=Convert.ToDecimal("7.00") },
            new ReferenceModelBase { Id=Guid.Parse("4dd6f73f-1b04-4594-8742-cb437b07e2c2"), Code="Regular", Description="Regular/standard", Definition="Regular/standard  is the category of legal document giving authorization for the person to perform teaching assignment services.", SortOrder=Convert.ToDecimal("8.00") },
            new ReferenceModelBase { Id=Guid.Parse("8b97a7ed-5453-40b5-bdcf-b532ea9f3840"), Code="Retired", Description="Retired", Definition="Retired is the category of legal document giving authorization for the person to perform teaching assignment services.", SortOrder=Convert.ToDecimal("9.00") },
            new ReferenceModelBase { Id=Guid.Parse("0cadd0dd-ac73-462f-b89c-16d403941d11"), Code="Specialist", Description="Specialist", Definition="Specialist is the category of legal document giving authorization for the person to perform teaching assignment services.", SortOrder=Convert.ToDecimal("10.00") },
            new ReferenceModelBase { Id=Guid.Parse("6b3389fd-8444-4283-a0ca-d11ef345e53b"), Code="Substitute", Description="Substitute", Definition="Substitute is the category of legal document giving authorization for the person to perform teaching assignment services.", SortOrder=Convert.ToDecimal("11.00") },
            new ReferenceModelBase { Id=Guid.Parse("60b8814e-dab2-4770-9361-ed4bb27f00d0"), Code="TeacherAssistant", Description="Teacher assistant", Definition="Teacher assistant is the category of legal document giving authorization for the person to perform teaching assignment services.", SortOrder=Convert.ToDecimal("12.00") },
            new ReferenceModelBase { Id=Guid.Parse("6060a279-3df5-480e-a41a-85b9d0489d19"), Code="Temporary", Description="Temporary", Definition="Temporary is the category of legal document giving authorization for the person to perform teaching assignment services.", SortOrder=Convert.ToDecimal("13.00") },
            new ReferenceModelBase { Id=Guid.Parse("4afa7380-82d9-44dd-a6b2-f02eb33d62ee"), Code="09999", Description="Other", Definition="Other is the category of legal document giving authorization for the person to perform teaching assignment services.", SortOrder=Convert.ToDecimal("14.00") },
        };
        #endregion
    }
}
