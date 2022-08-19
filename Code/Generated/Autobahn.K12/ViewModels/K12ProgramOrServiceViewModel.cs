//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12ProgramOrServiceViewModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.K12.ViewModels
{
     /// <summary>
     /// The K12ProgramOrService View Model
     /// </summary>
    public partial class K12ProgramOrServiceViewModel : ViewModelBase, Interfaces.IK12ProgramOrService
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from K12ProgramOrService";

        // member variable for the OrganizationId property
        private Guid _OrganizationId;

        // ProgramInMultiplePurposeFacility -- (backing property for Program in Multiple Purpose Facility)
        private System.Boolean? _ProgramInMultiplePurposeFacility;

        // RefKindergartenDailyLengthId -- (backing property for Kindergarten Daily Length)
        private Guid? _RefKindergartenDailyLengthId;

        // RefMepProjectTypeId -- (backing property for Migrant Education Program Project Type)
        private Guid? _RefMepProjectTypeId;

        // RefMepSessionTypeId -- (backing property for Migrant Education Program Session Type)
        private Guid? _RefMepSessionTypeId;

        // RefPrekindergartenDailyLengthId -- (backing property for Prekindergarten Daily Length)
        private Guid? _RefPrekindergartenDailyLengthId;

        // RefProgramGiftedEligibilityId -- (backing property for Program Gifted Eligibility Criteria)
        private Guid? _RefProgramGiftedEligibilityId;

        // RefTitleIInstructionalServicesId -- (backing property for Title I Instructional Services)
        private Guid? _RefTitleIInstructionalServicesId;

        // RefTitleIProgramTypeId -- (backing property for Title I Program Type)
        private Guid? _RefTitleIProgramTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganization"/> model
        /// </summary>
        public Guid OrganizationId { get => _OrganizationId; set => SetProperty(ref _OrganizationId, value); }

        /// <summary>
        /// Program in Multiple Purpose Facility
        /// <para>
        /// An institution/facility/program that serves more than one programming purpose.  For example, the same facility may run both a juvenile correction program and a juvenile detention program.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19476">Program in Multiple Purpose Facility</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Boolean? ProgramInMultiplePurposeFacility { get => _ProgramInMultiplePurposeFacility; set => SetProperty(ref _ProgramInMultiplePurposeFacility, value); }

        /// <summary>
        /// Kindergarten Daily Length
        /// <para>
        /// The portion of a day that a kindergarten program is provided to the students it serves.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19482">Kindergarten Daily Length</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefKindergartenDailyLengthId { get => _RefKindergartenDailyLengthId; set => SetProperty(ref _RefKindergartenDailyLengthId, value); }

        /// <summary>
        /// Migrant Education Program Project Type
        /// <para>
        /// Type of project funded in whole or in part by MEP funds.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19453">Migrant Education Program Project Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefMepProjectTypeId { get => _RefMepProjectTypeId; set => SetProperty(ref _RefMepProjectTypeId, value); }

        /// <summary>
        /// Migrant Education Program Session Type
        /// <para>
        /// The time of year that a Migrant Education Program operates.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19187">Migrant Education Program Session Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefMepSessionTypeId { get => _RefMepSessionTypeId; set => SetProperty(ref _RefMepSessionTypeId, value); }

        /// <summary>
        /// Prekindergarten Daily Length
        /// <para>
        /// The portion of a day that a pre-kindergarten program is provided to the students it serves.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19481">Prekindergarten Daily Length</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefPrekindergartenDailyLengthId { get => _RefPrekindergartenDailyLengthId; set => SetProperty(ref _RefPrekindergartenDailyLengthId, value); }

        /// <summary>
        /// Program Gifted Eligibility Criteria
        /// <para>
        /// State/local code used to determine a student's eligibility for Gifted/Talented program.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20210">Program Gifted Eligibility Criteria</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefProgramGiftedEligibilityId { get => _RefProgramGiftedEligibilityId; set => SetProperty(ref _RefProgramGiftedEligibilityId, value); }

        /// <summary>
        /// Title I Instructional Services
        /// <para>
        /// The type of instructional services provided to students in ESEA Title I programs.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19282">Title I Instructional Services</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefTitleIInstructionalServicesId { get => _RefTitleIInstructionalServicesId; set => SetProperty(ref _RefTitleIInstructionalServicesId, value); }

        /// <summary>
        /// Title I Program Type
        /// <para>
        /// The type of Title I program offered in the school or district.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19284">Title I Program Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefTitleIProgramTypeId { get => _RefTitleIProgramTypeId; set => SetProperty(ref _RefTitleIProgramTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IK12ProgramOrService model)
        {
            IsBusy = true;
            Id = model.Id;
            OrganizationId = model.OrganizationId; // 
            ProgramInMultiplePurposeFacility = model.ProgramInMultiplePurposeFacility; // Program in Multiple Purpose Facility
            RefKindergartenDailyLengthId = model.RefKindergartenDailyLengthId; // Kindergarten Daily Length
            RefMepProjectTypeId = model.RefMepProjectTypeId; // Migrant Education Program Project Type
            RefMepSessionTypeId = model.RefMepSessionTypeId; // Migrant Education Program Session Type
            RefPrekindergartenDailyLengthId = model.RefPrekindergartenDailyLengthId; // Prekindergarten Daily Length
            RefProgramGiftedEligibilityId = model.RefProgramGiftedEligibilityId; // Program Gifted Eligibility Criteria
            RefTitleIInstructionalServicesId = model.RefTitleIInstructionalServicesId; // Title I Instructional Services
            RefTitleIProgramTypeId = model.RefTitleIProgramTypeId; // Title I Program Type
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }

        #region RefKindergartenDailyLength List
        /// <summary>
        /// The complete <see cref="RefKindergartenDailyLength"> List
        /// </summary>
        private static List<ReferenceModelBase> RefKindergartenDailyLengthList = new List<ReferenceModelBase>
        {
        };
        #endregion

        #region RefMepProjectType List
        /// <summary>
        /// The complete <see cref="RefMepProjectType"> List
        /// </summary>
        private static List<ReferenceModelBase> RefMepProjectTypeList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("459cbd78-58ca-4dec-a905-efcdf39bc885"), Code="SchoolDay", Description="Regular school year - school day only", Definition="The project funded in whole or in part by Migrant Education Program funds is  available during the regular school year - school day only.", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("fd62c4de-aa71-4d67-99b7-8ab26f750859"), Code="ExtendedDay", Description="Regular school year - school day/extended day", Definition="The project funded in whole or in part by Migrant Education Program funds is  available during the regular school year - school day/extended day.", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("47b6ea87-ad31-480b-85cd-3da2a06df52e"), Code="SummerIntersession", Description="Summer/intersession only", Definition="The project funded in whole or in part by Migrant Education Program funds is available during summer/intersession only.", SortOrder=Convert.ToDecimal("3.00") },
            new ReferenceModelBase { Id=Guid.Parse("055ab8cf-8f27-4d69-866c-57f2693af22b"), Code="YearRound", Description="Year round", Definition="The project funded in whole or in part by Migrant Education Program funds is available year round.", SortOrder=Convert.ToDecimal("4.00") },
        };
        #endregion

        #region RefMepSessionType List
        /// <summary>
        /// The complete <see cref="RefMepSessionType"> List
        /// </summary>
        private static List<ReferenceModelBase> RefMepSessionTypeList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("9233d50d-cd67-4bae-ba01-eea6f46ea4d8"), Code="RegularSchoolYear", Description="Regular School Year", Definition="The Migrant Education Program operates during the Regular School Year.", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("715e8c2f-cb5a-4164-9381-80086d367245"), Code="SummerTerm", Description="Summer Term or Intersession", Definition="The Migrant Education Program operates during the Summer Term or Intersession.", SortOrder=Convert.ToDecimal("2.00") },
        };
        #endregion

        #region RefPrekindergartenDailyLength List
        /// <summary>
        /// The complete <see cref="RefPrekindergartenDailyLength"> List
        /// </summary>
        private static List<ReferenceModelBase> RefPrekindergartenDailyLengthList = new List<ReferenceModelBase>
        {
        };
        #endregion

        #region RefProgramGiftedEligibility List
        /// <summary>
        /// The complete <see cref="RefProgramGiftedEligibility"> List
        /// </summary>
        private static List<ReferenceModelBase> RefProgramGiftedEligibilityList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("a9a3bb61-efdd-4aff-977e-1eeb916bc1b7"), Code="13452", Description="General Intellectual Aptitude only", Definition="The student's eligibility for Gifted/Talented program is in the category: General Intellectual Aptitude only.", SortOrder=Convert.ToDecimal("0.00") },
            new ReferenceModelBase { Id=Guid.Parse("549a6486-a587-4c52-a387-4f563274a21f"), Code="13453", Description="Specific Academic Aptitude only", Definition="The student's eligibility for Gifted/Talented program is in the category: Specific Academic Aptitude only.", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("b899f2f9-d02d-4d8a-a729-72faeed6c2cc"), Code="13454", Description="Visual/Performing Arts only", Definition="The student's eligibility for Gifted/Talented program is in the category: Visual/Performing Arts only.", SortOrder=Convert.ToDecimal("4.00") },
            new ReferenceModelBase { Id=Guid.Parse("f4b84a1d-6c2b-4bea-aacc-c93979369974"), Code="13456", Description="General Intellectual Aptitude & Specific Academic Aptitude", Definition="The student's eligibility for Gifted/Talented program is in the category: General Intellectual Aptitude & Specific Academic Aptitude.", SortOrder=Convert.ToDecimal("6.00") },
            new ReferenceModelBase { Id=Guid.Parse("f802cf90-aca1-462c-9255-89e2ad5765c7"), Code="13457", Description="General Intellectual Aptitude & Visual/Performing Arts", Definition="The student's eligibility for Gifted/Talented program is in the category: General Intellectual Aptitude & Visual/Performing Arts.", SortOrder=Convert.ToDecimal("8.00") },
            new ReferenceModelBase { Id=Guid.Parse("3a048a6c-997e-4ae8-9328-a190c373855a"), Code="13458", Description="General Intellectual Aptitude & Technical/Practical Arts", Definition="The student's eligibility for Gifted/Talented program is in the category: General Intellectual Aptitude & Technical/Practical Arts.", SortOrder=Convert.ToDecimal("10.00") },
            new ReferenceModelBase { Id=Guid.Parse("f304aa74-e781-43f4-b88c-b72d38bd9fa0"), Code="13459", Description="Specific Academic Aptitude & Visual/Performing Arts", Definition="The student's eligibility for Gifted/Talented program is in the category: Specific Academic Aptitude & Visual/Performing Arts.", SortOrder=Convert.ToDecimal("12.00") },
            new ReferenceModelBase { Id=Guid.Parse("ba012bf2-be9d-460d-86f4-1bd38ddd1730"), Code="13460", Description="Specific Academic Aptitude & Technical/Practical Arts", Definition="The student's eligibility for Gifted/Talented program is in the category: Specific Academic Aptitude & Technical/Practical Arts.", SortOrder=Convert.ToDecimal("14.00") },
            new ReferenceModelBase { Id=Guid.Parse("2d68ebb5-83be-4498-ae5c-b01bd85719f0"), Code="13461", Description="Visual/Performing Arts & Technical/Practical Arts", Definition="The student's eligibility for Gifted/Talented program is in the category: Visual/Performing Arts & Technical/Practical Arts.", SortOrder=Convert.ToDecimal("16.00") },
            new ReferenceModelBase { Id=Guid.Parse("5e019c9e-cae1-4848-9dca-2d1aaf134011"), Code="13462", Description="General Intellectual Aptitude, Specific Academic Aptitude, and Visual Performing Arts", Definition="The student's eligibility for Gifted/Talented program is in the category: General Intellectual Aptitude, Specific Academic Aptitude, and Visual Performing Arts.", SortOrder=Convert.ToDecimal("18.00") },
            new ReferenceModelBase { Id=Guid.Parse("43d2a8b0-9cd5-4aa8-acc9-3c939b27110a"), Code="13463", Description="General Intellectual Aptitude, Specific Academic Aptitude, & Technical/Practical Arts", Definition="The student's eligibility for Gifted/Talented program is in the category: General Intellectual Aptitude, Specific Academic Aptitude, & Technical/Practical Arts.", SortOrder=Convert.ToDecimal("20.00") },
            new ReferenceModelBase { Id=Guid.Parse("9a679957-2640-4808-91cc-36c225618071"), Code="13464", Description="Specific Academic Aptitude, Visual/Performing Arts, & Technical/Practical Arts", Definition="The student's eligibility for Gifted/Talented program is in the category: Specific Academic Aptitude, Visual/Performing Arts, & Technical/Practical Arts.", SortOrder=Convert.ToDecimal("22.00") },
            new ReferenceModelBase { Id=Guid.Parse("88b78036-5993-4015-adb4-475736cce17f"), Code="13465", Description="General Intellectual & Specific Academic Aptitude, Visual/Performing Arts & Technical/Practical Arts", Definition="The student's eligibility for Gifted/Talented program is in the category: General Intellectual & Specific Academic Aptitude, Visual/Performing Arts & Technical/Practical Arts.", SortOrder=Convert.ToDecimal("24.00") },
            new ReferenceModelBase { Id=Guid.Parse("c516190f-f32c-4f93-85b7-6534632652c2"), Code="06002", Description="Not specified", Definition="The student's eligibility for Gifted/Talented program is in the category is not specified.", SortOrder=Convert.ToDecimal("26.00") },
            new ReferenceModelBase { Id=Guid.Parse("e50fd004-d843-4caa-824c-9503651e1c77"), Code="09999", Description="Other", Definition="The student's eligibility for Gifted/Talented program is in a category not yet defined in CEDS.", SortOrder=Convert.ToDecimal("28.00") },
        };
        #endregion

        #region RefTitleIInstructionalServices List
        /// <summary>
        /// The complete <see cref="RefTitleIInstructionalServices"> List
        /// </summary>
        private static List<ReferenceModelBase> RefTitleIInstructionalServicesList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("35c9386a-ed21-4d5e-9e7e-c34e74e1410d"), Code="ReadingLanguageArts", Description="Reading/Language Arts", Definition="The student is participating in and served by a Reading/Language Arts program under Title I, Part A of ESEA as amended.", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("d5086bc1-f4ee-46dc-9ec1-32078dd0cb91"), Code="Mathematics", Description="Mathematics", Definition="The student is participating in and served by a Mathematics program under Title I, Part A of ESEA as amended.", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("dd3fabb8-c251-41c5-9eed-142765506caf"), Code="Science", Description="Science", Definition="The student is participating in and served by a Science program under Title I, Part A of ESEA as amended.", SortOrder=Convert.ToDecimal("3.00") },
            new ReferenceModelBase { Id=Guid.Parse("ff9b4004-fbaa-470d-a638-34c34a1107f0"), Code="SocialSciences", Description="Social Sciences", Definition="The student is participating in and served by a Social Sciences program under Title I, Part A of ESEA as amended.", SortOrder=Convert.ToDecimal("4.00") },
            new ReferenceModelBase { Id=Guid.Parse("622d4b27-039b-472c-9d0f-0f0df3227062"), Code="CareerAndTechnical", Description="Career and Technical Education", Definition="The student is participating in and served by a Career and Technical Education program under Title I, Part A of ESEA as amended.", SortOrder=Convert.ToDecimal("5.00") },
            new ReferenceModelBase { Id=Guid.Parse("497fcd42-5cb0-4b8c-84f2-de7387d6d0e7"), Code="Other", Description="Other", Definition="The student is participating in and served by a program under Title I, Part A of ESEA as amended in a subject/category not yet defined in CEDS.", SortOrder=Convert.ToDecimal("6.00") },
        };
        #endregion

        #region RefTitleIProgramType List
        /// <summary>
        /// The complete <see cref="RefTitleIProgramType"> List
        /// </summary>
        private static List<ReferenceModelBase> RefTitleIProgramTypeList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("a159ab76-a7c5-41b2-b331-53c859755bbb"), Code="TargetedAssistanceProgram", Description="Public Targeted Assistance Program", Definition="The type of Title I program offered in the school or district Is Public Targeted Assistance Program", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("b6634bdf-3eb0-4052-abe1-0a634eb0d2a2"), Code="SchoolwideProgram", Description="Public Schoolwide Program", Definition="The type of Title I program offered in the school or district Is Public Schoolwide Program", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("17c18106-3591-4dc3-881a-27cbbccaeced"), Code="PrivateSchoolStudents", Description="Private School Students Participating", Definition="The type of Title I program offered in the school or district Is Private School Students Participating", SortOrder=Convert.ToDecimal("3.00") },
            new ReferenceModelBase { Id=Guid.Parse("adae1df5-cb96-434c-a44f-683f2678d46b"), Code="LocalNeglectedProgram", Description="Local Neglected Program", Definition="The type of Title I program offered in the school or district Is Local Neglected Program", SortOrder=Convert.ToDecimal("4.00") },
        };
        #endregion
    }
}
