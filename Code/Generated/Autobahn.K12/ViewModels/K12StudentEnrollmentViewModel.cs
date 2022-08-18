//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12StudentEnrollmentViewModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.K12.ViewModels
{
     /// <summary>
     /// The K12StudentEnrollment View Model
     /// </summary>
    public partial class K12StudentEnrollmentViewModel : ViewModelBase, Interfaces.IK12StudentEnrollment
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from K12StudentEnrollment";

        // DisplacedStudentStatus -- (backing property for Displaced Student Status)
        private System.Boolean? _DisplacedStudentStatus;

        // FirstEntryDateIntoUSSchool -- (backing property for First Entry Date into a US School)
        private System.DateTime? _FirstEntryDateIntoUSSchool;

        // NSLPDirectCertificationIndicator -- (backing property for National School Lunch Program Direct Certification Indicator)
        private System.Boolean? _NSLPDirectCertificationIndicator;

        // member variable for the OrganizationPersonRoleId property
        private Guid _OrganizationPersonRoleId;

        // RefDirectoryInformationBlockStatusId -- (backing property for Directory Information Block Status)
        private Guid? _RefDirectoryInformationBlockStatusId;

        // RefEndOfTermStatusId -- (backing property for End of Term Status)
        private Guid? _RefEndOfTermStatusId;

        // RefEnrollmentStatusId -- (backing property for Enrollment Status)
        private Guid? _RefEnrollmentStatusId;

        // RefEntryGradeLevelId -- (backing property for Entry Grade Level)
        private Guid? _RefEntryGradeLevelId;

        // RefEntryType -- (backing property for Entry Type)
        private System.Int32? _RefEntryType;

        // RefExitGradeLevelId -- (backing property for Exit Grade Level)
        private Guid? _RefExitGradeLevelId;

        // RefExitOrWithdrawalStatusId -- (backing property for Exit or Withdrawal Status)
        private Guid? _RefExitOrWithdrawalStatusId;

        // RefExitOrWithdrawalTypeId -- (backing property for Exit or Withdrawal Type)
        private Guid? _RefExitOrWithdrawalTypeId;

        // RefFoodServiceEligibilityId -- (backing property for Eligibility Status for School Food Service Programs)
        private Guid? _RefFoodServiceEligibilityId;

        // RefNonPromotionReasonId -- (backing property for Nonpromotion Reason)
        private Guid? _RefNonPromotionReasonId;

        // RefPromotionReasonId -- (backing property for Promotion Reason)
        private Guid? _RefPromotionReasonId;

        // RefPublicSchoolResidence -- (backing property for Public School Residence Status)
        private System.Int32? _RefPublicSchoolResidence;

        // RefStudentEnrollmentAccessTypeId -- (backing property for Student Enrollment Access Type)
        private Guid? _RefStudentEnrollmentAccessTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Displaced Student Status
        /// <para>
        /// A student who was enrolled, or eligible for enrollment, but has enrolled in another place because of a crisis.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19603">Displaced Student Status</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Boolean? DisplacedStudentStatus { get => _DisplacedStudentStatus; set => SetProperty(ref _DisplacedStudentStatus, value); }

        /// <summary>
        /// First Entry Date into a US School
        /// <para>
        /// The year, month and day of a person's initial enrollment into a United States school.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19520">First Entry Date into a US School</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.DateTime? FirstEntryDateIntoUSSchool { get => _FirstEntryDateIntoUSSchool; set => SetProperty(ref _FirstEntryDateIntoUSSchool, value); }

        /// <summary>
        /// National School Lunch Program Direct Certification Indicator
        /// <para>
        /// Indicates that the student's National School Lunch Program (NSLP) eligibility has been determined through direct certification.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20635">National School Lunch Program Direct Certification Indicator</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Boolean? NSLPDirectCertificationIndicator { get => _NSLPDirectCertificationIndicator; set => SetProperty(ref _NSLPDirectCertificationIndicator, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get => _OrganizationPersonRoleId; set => SetProperty(ref _OrganizationPersonRoleId, value); }

        /// <summary>
        /// Directory Information Block Status
        /// <para>
        /// An indication of whether a individual requested a Family Education Rights and Privacy Act (FERPA) block to withhold the release of the person's directory information.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20569">Directory Information Block Status</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefDirectoryInformationBlockStatusId { get => _RefDirectoryInformationBlockStatusId; set => SetProperty(ref _RefDirectoryInformationBlockStatusId, value); }

        /// <summary>
        /// End of Term Status
        /// <para>
        /// The nature of the student's progress at the end of a given school term.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19093">End of Term Status</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefEndOfTermStatusId { get => _RefEndOfTermStatusId; set => SetProperty(ref _RefEndOfTermStatusId, value); }

        /// <summary>
        /// Enrollment Status
        /// <para>
        /// An indication as to whether a student's name was, is, or will be officially registered on the roll of a school or schools.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19094">Enrollment Status</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefEnrollmentStatusId { get => _RefEnrollmentStatusId; set => SetProperty(ref _RefEnrollmentStatusId, value); }

        /// <summary>
        /// Entry Grade Level
        /// <para>
        /// The grade level or primary instructional level at which a student enters and receives services in a school or an educational institution during a given academic session.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19100">Entry Grade Level</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefEntryGradeLevelId { get => _RefEntryGradeLevelId; set => SetProperty(ref _RefEntryGradeLevelId, value); }

        /// <summary>
        /// Entry Type
        /// <para>
        /// The process by which a student enters a school during a given academic session.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19099">Entry Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Int32? RefEntryType { get => _RefEntryType; set => SetProperty(ref _RefEntryType, value); }

        /// <summary>
        /// Exit Grade Level
        /// <para>
        /// The grade level or primary instructional level at which a student exits a school, program, or an educational institution.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20177">Exit Grade Level</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefExitGradeLevelId { get => _RefExitGradeLevelId; set => SetProperty(ref _RefExitGradeLevelId, value); }

        /// <summary>
        /// Exit or Withdrawal Status
        /// <para>
        /// An indication as to whether an instance of student exit/withdrawal is considered to be of a permanent or temporary nature.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19108">Exit or Withdrawal Status</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefExitOrWithdrawalStatusId { get => _RefExitOrWithdrawalStatusId; set => SetProperty(ref _RefExitOrWithdrawalStatusId, value); }

        /// <summary>
        /// Exit or Withdrawal Type
        /// <para>
        /// The circumstances under which the student exited from membership in an educational institution. 
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefExitOrWithdrawalTypeId { get => _RefExitOrWithdrawalTypeId; set => SetProperty(ref _RefExitOrWithdrawalTypeId, value); }

        /// <summary>
        /// Eligibility Status for School Food Service Programs
        /// <para>
        /// An indication of a student's level of eligibility to participate in the National School Lunch Program for breakfast, lunch, snack, supper, and milk programs.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19092">Eligibility Status for School Food Service Programs</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefFoodServiceEligibilityId { get => _RefFoodServiceEligibilityId; set => SetProperty(ref _RefFoodServiceEligibilityId, value); }

        /// <summary>
        /// Nonpromotion Reason
        /// <para>
        /// The primary reason as to why a staff member determined that a student should not be promoted (or be demoted).
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19522">Nonpromotion Reason</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefNonPromotionReasonId { get => _RefNonPromotionReasonId; set => SetProperty(ref _RefNonPromotionReasonId, value); }

        /// <summary>
        /// Promotion Reason
        /// <para>
        /// The nature of the student's promotion or progress at the end of a given school term.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19521">Promotion Reason</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefPromotionReasonId { get => _RefPromotionReasonId; set => SetProperty(ref _RefPromotionReasonId, value); }

        /// <summary>
        /// Public School Residence Status
        /// <para>
        /// An indication of the location of a persons legal residence relative to (within or outside) the boundaries of the public school attended and its administrative unit.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19523">Public School Residence Status</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Int32? RefPublicSchoolResidence { get => _RefPublicSchoolResidence; set => SetProperty(ref _RefPublicSchoolResidence, value); }

        /// <summary>
        /// Student Enrollment Access Type
        /// <para>
        /// The designation of how students secure access to age appropriate public schools, or publicly funded charter or private schools.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20843">Student Enrollment Access Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefStudentEnrollmentAccessTypeId { get => _RefStudentEnrollmentAccessTypeId; set => SetProperty(ref _RefStudentEnrollmentAccessTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IK12StudentEnrollment model)
        {
            IsBusy = true;
            Id = model.Id;
            DisplacedStudentStatus = model.DisplacedStudentStatus; // Displaced Student Status
            FirstEntryDateIntoUSSchool = model.FirstEntryDateIntoUSSchool; // First Entry Date into a US School
            NSLPDirectCertificationIndicator = model.NSLPDirectCertificationIndicator; // National School Lunch Program Direct Certification Indicator
            OrganizationPersonRoleId = model.OrganizationPersonRoleId; // 
            RefDirectoryInformationBlockStatusId = model.RefDirectoryInformationBlockStatusId; // Directory Information Block Status
            RefEndOfTermStatusId = model.RefEndOfTermStatusId; // End of Term Status
            RefEnrollmentStatusId = model.RefEnrollmentStatusId; // Enrollment Status
            RefEntryGradeLevelId = model.RefEntryGradeLevelId; // Entry Grade Level
            RefEntryType = model.RefEntryType; // Entry Type
            RefExitGradeLevelId = model.RefExitGradeLevelId; // Exit Grade Level
            RefExitOrWithdrawalStatusId = model.RefExitOrWithdrawalStatusId; // Exit or Withdrawal Status
            RefExitOrWithdrawalTypeId = model.RefExitOrWithdrawalTypeId; // Exit or Withdrawal Type
            RefFoodServiceEligibilityId = model.RefFoodServiceEligibilityId; // Eligibility Status for School Food Service Programs
            RefNonPromotionReasonId = model.RefNonPromotionReasonId; // Nonpromotion Reason
            RefPromotionReasonId = model.RefPromotionReasonId; // Promotion Reason
            RefPublicSchoolResidence = model.RefPublicSchoolResidence; // Public School Residence Status
            RefStudentEnrollmentAccessTypeId = model.RefStudentEnrollmentAccessTypeId; // Student Enrollment Access Type
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }

        #region RefEntryGradeLevel List
        /// <summary>
        /// The complete <see cref="RefEntryGradeLevel"> List
        /// </summary>
        private static List<ReferenceModelBase> RefEntryGradeLevelList = new List<ReferenceModelBase>
        {
        };
        #endregion

        #region RefExitGradeLevel List
        /// <summary>
        /// The complete <see cref="RefExitGradeLevel"> List
        /// </summary>
        private static List<ReferenceModelBase> RefExitGradeLevelList = new List<ReferenceModelBase>
        {
        };
        #endregion

        #region RefNonPromotionReason List
        /// <summary>
        /// The complete <see cref="RefNonPromotionReason"> List
        /// </summary>
        private static List<ReferenceModelBase> RefNonPromotionReasonList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("3a2cd328-137b-4937-909a-cce64f331c23"), Code="FailedTestingRequirements", Description="Failed to meet testing requirements", Definition="Failed to meet testing requirements is the primary reason  why a staff member determined that a student should not be promoted (or be demoted).", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("915546a8-fd00-4da1-a38b-235f90653c99"), Code="Illness", Description="Illness", Definition="Illness is the primary reason  why a staff member determined that a student should not be promoted (or be demoted).", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("ed0cc7c6-6f7f-4012-986a-ea10cc64dfb6"), Code="Immaturity", Description="Immaturity", Definition="Immaturity is the primary reason  why a staff member determined that a student should not be promoted (or be demoted).", SortOrder=Convert.ToDecimal("3.00") },
            new ReferenceModelBase { Id=Guid.Parse("bc942e1c-0465-40df-9088-6250e046f2c9"), Code="InadequatePerformance", Description="Inadequate performance", Definition="Inadequate performance is the primary reason  why a staff member determined that a student should not be promoted (or be demoted).", SortOrder=Convert.ToDecimal("4.00") },
            new ReferenceModelBase { Id=Guid.Parse("532f2100-66a3-4891-8cac-9b029d7257ef"), Code="InsufficientCredits", Description="Insufficient credits", Definition="Insufficient credits is the primary reason  why a staff member determined that a student should not be promoted (or be demoted).", SortOrder=Convert.ToDecimal("5.00") },
            new ReferenceModelBase { Id=Guid.Parse("2c213ad2-260e-4fa0-9c7a-53d85f6432d7"), Code="Other", Description="Other", Definition="Other is the primary reason  why a staff member determined that a student should not be promoted (or be demoted).", SortOrder=Convert.ToDecimal("6.00") },
            new ReferenceModelBase { Id=Guid.Parse("2a7afbea-6600-41ec-b898-5dbacdffcbb5"), Code="ProlongedAbsence", Description="Prolonged absence", Definition="Prolonged absence is the primary reason  why a staff member determined that a student should not be promoted (or be demoted).", SortOrder=Convert.ToDecimal("7.00") },
        };
        #endregion

        #region RefPromotionReason List
        /// <summary>
        /// The complete <see cref="RefPromotionReason"> List
        /// </summary>
        private static List<ReferenceModelBase> RefPromotionReasonList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("8016172d-6697-41fd-9262-1dce2aee8002"), Code="AcceleratedPromotion", Description="Accelerated promotion", Definition="Accelerated promotion is the nature of the student's promotion or progress at the end of a given school term.", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("b82ff8ca-2509-4209-99bb-bc27ba4cce68"), Code="ContinuousPromotion", Description="Continuous promotion", Definition="Continuous promotion is the nature of the student's promotion or progress at the end of a given school term.", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("da7234a7-691b-43ea-9b59-3dbaf41dc3e3"), Code="Other", Description="Other", Definition="The nature of the student's promotion or progress at the end of a given school term is in a category not yet defined in CEDS.", SortOrder=Convert.ToDecimal("3.00") },
            new ReferenceModelBase { Id=Guid.Parse("f1ac9db4-d236-4e18-b1b6-ec4bda92cdcb"), Code="ProbationaryPromotion", Description="Probationary promotion", Definition="Probationary promotion is the nature of the student's promotion or progress at the end of a given school term.", SortOrder=Convert.ToDecimal("4.00") },
            new ReferenceModelBase { Id=Guid.Parse("591651fb-f0d5-4674-86e1-c62c6621618f"), Code="RegularPromotion", Description="Regular promotion", Definition="Regular promotion is the nature of the student's promotion or progress at the end of a given school term.", SortOrder=Convert.ToDecimal("5.00") },
            new ReferenceModelBase { Id=Guid.Parse("8ffe4ac4-6f5b-49ae-8794-1ef054cc8b12"), Code="VariableProgress", Description="Variable progress", Definition="Variable progress is the nature of the student's promotion or progress at the end of a given school term.", SortOrder=Convert.ToDecimal("6.00") },
        };
        #endregion

        #region RefStudentEnrollmentAccessType List
        /// <summary>
        /// The complete <see cref="RefStudentEnrollmentAccessType"> List
        /// </summary>
        private static List<ReferenceModelBase> RefStudentEnrollmentAccessTypeList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("f52d3652-4ac5-420e-9ed9-fc42c1efdbd1"), Code="75027", Description="Feeder school rights", Definition="Feeder school rights is specified as the designation of how students secure access to age appropriate public schools, or publicly funded charter or private schools.", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("93cb8f51-cf3d-43c0-b17c-723827db5594"), Code="75028", Description="Geographic right", Definition="Geographic right is specified as the designation of how students secure access to age appropriate public schools, or publicly funded charter or private schools.", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("7a29cb38-c247-498b-801b-da7fdecfda71"), Code="75029", Description="Lottery", Definition="Lottery is specified as the designation of how students secure access to age appropriate public schools, or publicly funded charter or private schools.", SortOrder=Convert.ToDecimal("3.00") },
            new ReferenceModelBase { Id=Guid.Parse("1c140df5-c9be-4e6b-b5d3-ea24d185d0fa"), Code="75030", Description="Policy preference", Definition="Policy that modifies student assignment based on preferences associated with such things as walk distances, racial or ethnic diversity, and family risk factors.", SortOrder=Convert.ToDecimal("4.00") },
            new ReferenceModelBase { Id=Guid.Parse("57c59af3-4ccd-4cbe-91fb-7e3e5386f745"), Code="75031", Description="Selective admissions", Definition="Selective admissions is specified as the designation of how students secure access to age appropriate public schools, or publicly funded charter or private schools.", SortOrder=Convert.ToDecimal("5.00") },
        };
        #endregion
    }
}
