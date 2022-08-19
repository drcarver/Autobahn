//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12SchoolStatusViewModel.cs
//* Name:       Consolidated Migrant Education Program Funds Status
//* Definition: An indication of whether the school has a school-wide program, as defined by current law, in which federal Migrant Education Program (MEP) funds are consolidated.
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.K12.ViewModels
{
     /// <summary>
     /// An indication of whether the school has a school-wide program, as defined by current law, in which federal Migrant Education Program (MEP) funds are consolidated.
     /// </summary>
    public partial class K12SchoolStatusViewModel : ViewModelBase, Interfaces.IK12SchoolStatus
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from K12SchoolStatus";

        // ConsolidatedMepFundsStatus -- (backing property for Consolidated Migrant Education Program Funds Status)
        private System.Boolean? _ConsolidatedMepFundsStatus;

        // member variable for the K12SchoolId property
        private Guid _K12SchoolId;

        // ProgressAcheivingEnglishLearnerProficiencyStateDefinedStatus -- (backing property for Progress Achieving English Language Proficiency State Defined Status)
        private System.String _ProgressAcheivingEnglishLearnerProficiencyStateDefinedStatus;

        // RefAlternativeSchoolFocusId -- (backing property for Alternative School Focus Type)
        private Guid? _RefAlternativeSchoolFocusId;

        // RefBlendedLearningModelTypeId -- (backing property for Blended Learning Model Type)
        private Guid? _RefBlendedLearningModelTypeId;

        // member variable for the RefComprehensiveAndTargetedSupportId property
        private Guid? _RefComprehensiveAndTargetedSupportId;

        // member variable for the RefComprehensiveSupportId property
        private Guid? _RefComprehensiveSupportId;

        // RefInternetAccessId -- (backing property for Internet Access)
        private Guid? _RefInternetAccessId;

        // RefMagnetSpecialProgramId -- (backing property for Magnet or Special Program Emphasis School)
        private Guid? _RefMagnetSpecialProgramId;

        // RefNationalSchoolLunchProgramStatusId -- (backing property for National School Lunch Program Status)
        private Guid? _RefNationalSchoolLunchProgramStatusId;

        // member variable for the RefNSLPStatusId property
        private Guid? _RefNSLPStatusId;

        // RefProgressAchievingEnglishLanguageProficiencyIndicatorStatusId -- (backing property for Progress Achieving English Language Proficiency Indicator Type)
        private Guid? _RefProgressAchievingEnglishLanguageProficiencyIndicatorStatusId;

        // RefRestructuringActionId -- (backing property for Restructuring Action)
        private Guid? _RefRestructuringActionId;

        // member variable for the RefSchoolDangerousStatusId property
        private Guid? _RefSchoolDangerousStatusId;

        // member variable for the RefSchoolImprovementStatusId property
        private Guid? _RefSchoolImprovementStatusId;

        // member variable for the RefTargetedSupportId property
        private Guid? _RefTargetedSupportId;

        // RefTitleISchoolStatusId -- (backing property for Title I School Status)
        private Guid? _RefTitleISchoolStatusId;

        // RefVirtualSchoolStatusId -- (backing property for Virtual School Status)
        private Guid? _RefVirtualSchoolStatusId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Consolidated Migrant Education Program Funds Status
        /// <para>
        /// An indication of whether the school has a school-wide program, as defined by current law, in which federal Migrant Education Program (MEP) funds are consolidated.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19533">Consolidated Migrant Education Program Funds Status</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Boolean? ConsolidatedMepFundsStatus { get => _ConsolidatedMepFundsStatus; set => SetProperty(ref _ConsolidatedMepFundsStatus, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IK12School"/> model
        /// </summary>
        public Guid K12SchoolId { get => _K12SchoolId; set => SetProperty(ref _K12SchoolId, value); }

        /// <summary>
        /// Progress Achieving English Language Proficiency State Defined Status
        /// <para>
        /// The state defined status assigned to the school's performance on the progress of achieving the English language proficiency indicator.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20897">Progress Achieving English Language Proficiency State Defined Status</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String ProgressAcheivingEnglishLearnerProficiencyStateDefinedStatus { get => _ProgressAcheivingEnglishLearnerProficiencyStateDefinedStatus; set => SetProperty(ref _ProgressAcheivingEnglishLearnerProficiencyStateDefinedStatus, value); }

        /// <summary>
        /// Alternative School Focus Type
        /// <para>
        /// An indication of the specific group of students whose needs the alternative school is designed to meet.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19015">Alternative School Focus Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefAlternativeSchoolFocusId { get => _RefAlternativeSchoolFocusId; set => SetProperty(ref _RefAlternativeSchoolFocusId, value); }

        /// <summary>
        /// Blended Learning Model Type
        /// <para>
        /// A type of formal education program in which a student learns at least in part through online learning, with some element of student control over time, place, path, and/or pace; at least in part in a supervised brick-and-mortar location away from home; and the modalities along each student's learning path within a course or subject are connected to provide an integrated learning experience.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20253">Blended Learning Model Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefBlendedLearningModelTypeId { get => _RefBlendedLearningModelTypeId; set => SetProperty(ref _RefBlendedLearningModelTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefComprehensiveAndTargetedSupport"/> model
        /// </summary>
        public Guid? RefComprehensiveAndTargetedSupportId { get => _RefComprehensiveAndTargetedSupportId; set => SetProperty(ref _RefComprehensiveAndTargetedSupportId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefComprehensiveSupport"/> model
        /// </summary>
        public Guid? RefComprehensiveSupportId { get => _RefComprehensiveSupportId; set => SetProperty(ref _RefComprehensiveSupportId, value); }

        /// <summary>
        /// Internet Access
        /// <para>
        /// The type of internet access available.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19580">Internet Access</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefInternetAccessId { get => _RefInternetAccessId; set => SetProperty(ref _RefInternetAccessId, value); }

        /// <summary>
        /// Magnet or Special Program Emphasis School
        /// <para>
        /// A school that has been designed: 1) to attract students of different racial/ethnic backgrounds for the purpose of reducing, preventing, or eliminating racial isolation; and/or 2)to provide an academic or social focus on a particular theme (e.g., science/math, performing arts, gifted/talented, career academy or foreign language).
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19181">Magnet or Special Program Emphasis School</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefMagnetSpecialProgramId { get => _RefMagnetSpecialProgramId; set => SetProperty(ref _RefMagnetSpecialProgramId, value); }

        /// <summary>
        /// National School Lunch Program Status
        /// <para>
        /// The classification of participation by a school in the National School Lunch Program.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20748">National School Lunch Program Status</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefNationalSchoolLunchProgramStatusId { get => _RefNationalSchoolLunchProgramStatusId; set => SetProperty(ref _RefNationalSchoolLunchProgramStatusId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefNSLPStatus"/> model
        /// </summary>
        public Guid? RefNSLPStatusId { get => _RefNSLPStatusId; set => SetProperty(ref _RefNSLPStatusId, value); }

        /// <summary>
        /// Progress Achieving English Language Proficiency Indicator Type
        /// <para>
        /// The category used to report the school's performance on the progress of achieving the English language proficiency indicator.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20896">Progress Achieving English Language Proficiency Indicator Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefProgressAchievingEnglishLanguageProficiencyIndicatorStatusId { get => _RefProgressAchievingEnglishLanguageProficiencyIndicatorStatusId; set => SetProperty(ref _RefProgressAchievingEnglishLanguageProficiencyIndicatorStatusId, value); }

        /// <summary>
        /// Restructuring Action
        /// <para>
        /// The types of actions being implemented in Title I schools as a result of the school being in an improvement status of restructuring - year 2 (implementation year).
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19232">Restructuring Action</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefRestructuringActionId { get => _RefRestructuringActionId; set => SetProperty(ref _RefRestructuringActionId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefSchoolDangerousStatus"/> model
        /// </summary>
        public Guid? RefSchoolDangerousStatusId { get => _RefSchoolDangerousStatusId; set => SetProperty(ref _RefSchoolDangerousStatusId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefSchoolImprovementStatus"/> model
        /// </summary>
        public Guid? RefSchoolImprovementStatusId { get => _RefSchoolImprovementStatusId; set => SetProperty(ref _RefSchoolImprovementStatusId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTargetedSupport"/> model
        /// </summary>
        public Guid? RefTargetedSupportId { get => _RefTargetedSupportId; set => SetProperty(ref _RefTargetedSupportId, value); }

        /// <summary>
        /// Title I School Status
        /// <para>
        /// An indication that a school is designated under state and federal regulations as being eligible for participation in programs authorized by Title I of ESEA as amended and whether it has a Title I program.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19285">Title I School Status</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefTitleISchoolStatusId { get => _RefTitleISchoolStatusId; set => SetProperty(ref _RefTitleISchoolStatusId, value); }

        /// <summary>
        /// Virtual School Status
        /// <para>
        /// An indication of the extent to which a public school offers instruction in which students and teachers are separated by time and/or location, and interaction occurs via computers and/or telecommunications technologies.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20747">Virtual School Status</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefVirtualSchoolStatusId { get => _RefVirtualSchoolStatusId; set => SetProperty(ref _RefVirtualSchoolStatusId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IK12SchoolStatus model)
        {
            IsBusy = true;
            Id = model.Id;
            ConsolidatedMepFundsStatus = model.ConsolidatedMepFundsStatus; // Consolidated Migrant Education Program Funds Status
            K12SchoolId = model.K12SchoolId; // 
            ProgressAcheivingEnglishLearnerProficiencyStateDefinedStatus = model.ProgressAcheivingEnglishLearnerProficiencyStateDefinedStatus; // Progress Achieving English Language Proficiency State Defined Status
            RefAlternativeSchoolFocusId = model.RefAlternativeSchoolFocusId; // Alternative School Focus Type
            RefBlendedLearningModelTypeId = model.RefBlendedLearningModelTypeId; // Blended Learning Model Type
            RefComprehensiveAndTargetedSupportId = model.RefComprehensiveAndTargetedSupportId; // 
            RefComprehensiveSupportId = model.RefComprehensiveSupportId; // 
            RefInternetAccessId = model.RefInternetAccessId; // Internet Access
            RefMagnetSpecialProgramId = model.RefMagnetSpecialProgramId; // Magnet or Special Program Emphasis School
            RefNationalSchoolLunchProgramStatusId = model.RefNationalSchoolLunchProgramStatusId; // National School Lunch Program Status
            RefNSLPStatusId = model.RefNSLPStatusId; // 
            RefProgressAchievingEnglishLanguageProficiencyIndicatorStatusId = model.RefProgressAchievingEnglishLanguageProficiencyIndicatorStatusId; // Progress Achieving English Language Proficiency Indicator Type
            RefRestructuringActionId = model.RefRestructuringActionId; // Restructuring Action
            RefSchoolDangerousStatusId = model.RefSchoolDangerousStatusId; // 
            RefSchoolImprovementStatusId = model.RefSchoolImprovementStatusId; // 
            RefTargetedSupportId = model.RefTargetedSupportId; // 
            RefTitleISchoolStatusId = model.RefTitleISchoolStatusId; // Title I School Status
            RefVirtualSchoolStatusId = model.RefVirtualSchoolStatusId; // Virtual School Status
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }

        #region RefMagnetSpecialProgram List
        /// <summary>
        /// The complete Consolidated Migrant Education Program Funds Status List
        /// </summary>
        private static List<ReferenceModelBase> RefMagnetSpecialProgramList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("3c2db044-efbe-4859-8211-6f00931b5928"), Code="All", Description="All students participate", Definition="All students participate in the academic or social focus of the magnet or special program emphasis school.", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("722979fb-07a6-42d2-8b99-8b9b91479049"), Code="None", Description="No students participate", Definition="No students participate in the academic or social focus of the magnet or special program emphasis school.", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("08a55338-40c3-4dfe-b6fd-37b4e72b5c54"), Code="Some", Description="Some, but not all, students participate", Definition="Some, but not all, students participate in the academic or social focus of the magnet or special program emphasis school.", SortOrder=Convert.ToDecimal("3.00") },
        };
        #endregion

        #region RefNationalSchoolLunchProgramStatus List
        /// <summary>
        /// The complete Consolidated Migrant Education Program Funds Status List
        /// </summary>
        private static List<ReferenceModelBase> RefNationalSchoolLunchProgramStatusList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("cc0fb3af-6095-4529-966e-92c00688890f"), Code="NSLPCEO", Description="Community Eligibility Option", Definition="The classification of participation by the school in the National School Lunch Program is participating under the Community Eligibility Option.", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("446870f9-d708-4715-8b04-0da3138413ca"), Code="NSLPNO", Description="Not Participating", Definition="The classification of participation by the school in the National School Lunch Program is not participating.", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("3a473220-b898-4521-82de-24861b2ec898"), Code="NSLPWOPRO", Description="Participating Without Provision or Community Eligibility Option", Definition="The classification of participation by the school in the National School Lunch Program is participating without using any Provision or the Community Eligibility Option.", SortOrder=Convert.ToDecimal("3.00") },
            new ReferenceModelBase { Id=Guid.Parse("4c7b146e-1d7c-4196-9866-aee254e5a324"), Code="NSLPPRO1", Description="Provision 1", Definition="The classification of participation by the school in the National School Lunch Program is participating under Provision 1.", SortOrder=Convert.ToDecimal("4.00") },
            new ReferenceModelBase { Id=Guid.Parse("d63226c8-d382-4203-b665-c010ef363e75"), Code="NSLPPRO2", Description="Provision 2", Definition="The classification of participation by the school in the National School Lunch Program is participating under Provision 2.", SortOrder=Convert.ToDecimal("5.00") },
            new ReferenceModelBase { Id=Guid.Parse("4bc66487-e17e-4b2e-b5d0-86481dcf4a60"), Code="NSLPPRO3", Description="Provision 3", Definition="The classification of participation by the school in the National School Lunch Program is participating under Provision 3.", SortOrder=Convert.ToDecimal("6.00") },
        };
        #endregion

        #region RefNSLPStatus List
        /// <summary>
        /// The complete Consolidated Migrant Education Program Funds Status List
        /// </summary>
        private static List<ReferenceModelBase> RefNSLPStatusList = new List<ReferenceModelBase>
        {
        };
        #endregion

        #region RefProgressAchievingEnglishLanguageProficiencyIndicatorStatus List
        /// <summary>
        /// The complete Consolidated Migrant Education Program Funds Status List
        /// </summary>
        private static List<ReferenceModelBase> RefProgressAchievingEnglishLanguageProficiencyIndicatorStatusList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("dabd1ff1-cc6f-417b-b1b2-97e02e000395"), Code="NOSTUDENTS", Description="No students in the subgroup", Definition="There are no students in a student subgroup.", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("cbc5bb8d-875c-4b89-9d85-3b487a167ccf"), Code="STTDEF", Description="State defined status", Definition="A status defined by the state.", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("87e60075-801c-428d-996a-64c09ea39f43"), Code="TOOFEW", Description="Too few students", Definition="The number of students in the school or for a student group was less than the minimum group size necessary or required to reliably calculate the indicator.", SortOrder=Convert.ToDecimal("3.00") },
        };
        #endregion

        #region RefRestructuringAction List
        /// <summary>
        /// The complete Consolidated Migrant Education Program Funds Status List
        /// </summary>
        private static List<ReferenceModelBase> RefRestructuringActionList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("4be087f7-5371-4c36-8fb7-f503c042298d"), Code="RA1", Description="Replacement of all or most of the school staff (which may include the principal)", Definition="Replacement of all or most of the school staff (which may include the principal) is the type of actions being implemented in Title I schools as a result of the school being in an improvement status of restructuring - year 2 (implementation year).", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("ecbce284-3cf8-406a-b53e-d9d2a363e662"), Code="RA2", Description="Reopening the school as a public charter school", Definition="Reopening the school as a public charter school is the type of actions being implemented in Title I schools as a result of the school being in an improvement status of restructuring - year 2 (implementation year).", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("bd327c1f-5154-47ca-8be8-4f163fa79418"), Code="RA3", Description="Entering into a contract with a private entity to operate the school", Definition="Entering into a contract with a private entity to operate the school is the type of actions being implemented in Title I schools as a result of the school being in an improvement status of restructuring - year 2 (implementation year).", SortOrder=Convert.ToDecimal("3.00") },
            new ReferenceModelBase { Id=Guid.Parse("68ccf8b5-5ded-46a0-8694-9ace4dcd8a6f"), Code="RA4", Description="Take of the school by the state", Definition="Take of the school by the state is the type of actions being implemented in Title I schools as a result of the school being in an improvement status of restructuring - year 2 (implementation year).", SortOrder=Convert.ToDecimal("4.00") },
            new ReferenceModelBase { Id=Guid.Parse("52628174-0a07-41db-b7d8-197f234272f2"), Code="RA5", Description="Other major restructuring of the school governance", Definition="Other major restructuring of the school governance is the type of actions being implemented in Title I schools as a result of the school being in an improvement status of restructuring - year 2 (implementation year).", SortOrder=Convert.ToDecimal("5.00") },
        };
        #endregion

        #region RefSchoolDangerousStatus List
        /// <summary>
        /// The complete Consolidated Migrant Education Program Funds Status List
        /// </summary>
        private static List<ReferenceModelBase> RefSchoolDangerousStatusList = new List<ReferenceModelBase>
        {
        };
        #endregion

        #region RefTargetedSupport List
        /// <summary>
        /// The complete Consolidated Migrant Education Program Funds Status List
        /// </summary>
        private static List<ReferenceModelBase> RefTargetedSupportList = new List<ReferenceModelBase>
        {
        };
        #endregion

        #region RefTitleISchoolStatus List
        /// <summary>
        /// The complete Consolidated Migrant Education Program Funds Status List
        /// </summary>
        private static List<ReferenceModelBase> RefTitleISchoolStatusList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("5a924b5c-5de8-4682-9b94-5a61c1fa936f"), Code="TGELGBNOPROG", Description="Title I Targeted Assistance Eligible School- No Program", Definition="The school is designated under state and federal regulations as being eligible for participation in Title I Targeted Assistance Eligible School- No Program.", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("534f7a27-a6ef-4559-8b40-c899eab9fae6"), Code="TGELGBTGPROG", Description="Title I Targeted Assistance School", Definition="The school is designated under state and federal regulations as being eligible for participation in Title I Targeted Assistance School.", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("f7735cfe-4f48-445f-9147-1992ae38285a"), Code="SWELIGTGPROG", Description="Title I, Schoolwide eligible-Title I Targeted Assistance Program", Definition="The school is designated under state and federal regulations as being eligible for participation in Title I, Schoolwide eligible-Title I Targeted Assistance Program.", SortOrder=Convert.ToDecimal("3.00") },
            new ReferenceModelBase { Id=Guid.Parse("575568a9-590e-409a-af94-360fd87619ea"), Code="SWELIGNOPROG", Description="Title I Schoolwide Eligible School - No Program", Definition="The school is designated under state and federal regulations as being eligible for participation in Title I Schoolwide Eligible School - No Program.", SortOrder=Convert.ToDecimal("4.00") },
            new ReferenceModelBase { Id=Guid.Parse("b8e6dfad-d675-4cb9-934b-7e71ec0d39e5"), Code="SWELIGSWPROG", Description="Title I Schoolwide School", Definition="The school is designated under state and federal regulations as being eligible for participation in Title I Schoolwide School.", SortOrder=Convert.ToDecimal("5.00") },
            new ReferenceModelBase { Id=Guid.Parse("e0b0c7aa-8b73-45f2-baaa-bfbccffa0e11"), Code="NOTTITLE1ELIG", Description="Not a Title I School", Definition="The school is designated under state and federal regulations as being Not a Title I School.", SortOrder=Convert.ToDecimal("6.00") },
        };
        #endregion

        #region RefVirtualSchoolStatus List
        /// <summary>
        /// The complete Consolidated Migrant Education Program Funds Status List
        /// </summary>
        private static List<ReferenceModelBase> RefVirtualSchoolStatusList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("3aaf7e8f-dfc6-4391-825f-f4a8f2c1781e"), Code="FaceVirtual", Description="Face Virtual", Definition="The school focuses on a systematic program of virtual instruction but includes some physical meetings among students or with teachers.", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("15af0dcc-8649-4627-af6e-66e7ed29f137"), Code="FullVirtual", Description="Full Virtual", Definition="The school has no physical building where students meet with each other or with teachers and all instruction is virtual.", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("08fbb218-4e1a-43ca-ba5c-39bcb763e482"), Code="NotVirtual", Description="Not Virtual", Definition="The school does not offer any virtual instruction.", SortOrder=Convert.ToDecimal("3.00") },
            new ReferenceModelBase { Id=Guid.Parse("9f69e562-27e1-4692-a38b-5f843701c450"), Code="SupplementalVirtual", Description="Supplemental Virtual", Definition="The school offers virtual courses but virtual instruction is not the primary means of instruction.", SortOrder=Convert.ToDecimal("4.00") },
        };
        #endregion
    }
}
