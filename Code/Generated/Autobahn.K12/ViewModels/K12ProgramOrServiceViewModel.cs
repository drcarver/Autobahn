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
            new ReferenceModelBase { Id=Guid.Parse("381499f9-a975-4323-860c-cb3bb43c1f4d"), Code="SchoolDay", Description="Regular school year - school day only", Definition="The project funded in whole or in part by Migrant Education Program funds is  available during the regular school year - school day only.", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("8255586a-ef54-4669-be80-0ba8fdc35539"), Code="ExtendedDay", Description="Regular school year - school day/extended day", Definition="The project funded in whole or in part by Migrant Education Program funds is  available during the regular school year - school day/extended day.", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("a12ccfca-b97b-44fa-b0b0-6db3cfdc1e48"), Code="SummerIntersession", Description="Summer/intersession only", Definition="The project funded in whole or in part by Migrant Education Program funds is available during summer/intersession only.", SortOrder=Convert.ToDecimal("3.00") },
            new ReferenceModelBase { Id=Guid.Parse("01b29943-bb84-4e74-a1ee-d8562538989a"), Code="YearRound", Description="Year round", Definition="The project funded in whole or in part by Migrant Education Program funds is available year round.", SortOrder=Convert.ToDecimal("4.00") },
        };
        #endregion

        #region RefMepSessionType List
        /// <summary>
        /// The complete <see cref="RefMepSessionType"> List
        /// </summary>
        private static List<ReferenceModelBase> RefMepSessionTypeList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("9391dc99-0b43-4d95-bd92-bbfde62d196a"), Code="RegularSchoolYear", Description="Regular School Year", Definition="The Migrant Education Program operates during the Regular School Year.", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("3af69368-a703-4749-8ca0-27894b3b1792"), Code="SummerTerm", Description="Summer Term or Intersession", Definition="The Migrant Education Program operates during the Summer Term or Intersession.", SortOrder=Convert.ToDecimal("2.00") },
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
            new ReferenceModelBase { Id=Guid.Parse("f0a0f423-5698-427d-a69b-e07f12925088"), Code="13452", Description="General Intellectual Aptitude only", Definition="The student's eligibility for Gifted/Talented program is in the category: General Intellectual Aptitude only.", SortOrder=Convert.ToDecimal("0.00") },
            new ReferenceModelBase { Id=Guid.Parse("22e22e9c-c126-4f44-bbc2-d9a3338549be"), Code="13453", Description="Specific Academic Aptitude only", Definition="The student's eligibility for Gifted/Talented program is in the category: Specific Academic Aptitude only.", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("5152bf85-de10-47d6-a31d-37b97e417a73"), Code="13454", Description="Visual/Performing Arts only", Definition="The student's eligibility for Gifted/Talented program is in the category: Visual/Performing Arts only.", SortOrder=Convert.ToDecimal("4.00") },
            new ReferenceModelBase { Id=Guid.Parse("f81a32a0-034c-42c1-88d7-d2f86b414b97"), Code="13456", Description="General Intellectual Aptitude & Specific Academic Aptitude", Definition="The student's eligibility for Gifted/Talented program is in the category: General Intellectual Aptitude & Specific Academic Aptitude.", SortOrder=Convert.ToDecimal("6.00") },
            new ReferenceModelBase { Id=Guid.Parse("9ad92f64-d8d7-4b7b-8768-2e3e105e3f4c"), Code="13457", Description="General Intellectual Aptitude & Visual/Performing Arts", Definition="The student's eligibility for Gifted/Talented program is in the category: General Intellectual Aptitude & Visual/Performing Arts.", SortOrder=Convert.ToDecimal("8.00") },
            new ReferenceModelBase { Id=Guid.Parse("0a4d6a73-2a74-4932-8760-9bcba3dac952"), Code="13458", Description="General Intellectual Aptitude & Technical/Practical Arts", Definition="The student's eligibility for Gifted/Talented program is in the category: General Intellectual Aptitude & Technical/Practical Arts.", SortOrder=Convert.ToDecimal("10.00") },
            new ReferenceModelBase { Id=Guid.Parse("cf7a494f-4236-4abc-843d-9e6f783a7b1f"), Code="13459", Description="Specific Academic Aptitude & Visual/Performing Arts", Definition="The student's eligibility for Gifted/Talented program is in the category: Specific Academic Aptitude & Visual/Performing Arts.", SortOrder=Convert.ToDecimal("12.00") },
            new ReferenceModelBase { Id=Guid.Parse("e0eda166-6e18-4538-9205-599adf302ff6"), Code="13460", Description="Specific Academic Aptitude & Technical/Practical Arts", Definition="The student's eligibility for Gifted/Talented program is in the category: Specific Academic Aptitude & Technical/Practical Arts.", SortOrder=Convert.ToDecimal("14.00") },
            new ReferenceModelBase { Id=Guid.Parse("cf226c92-4311-495d-bf16-7ea4d2e3d849"), Code="13461", Description="Visual/Performing Arts & Technical/Practical Arts", Definition="The student's eligibility for Gifted/Talented program is in the category: Visual/Performing Arts & Technical/Practical Arts.", SortOrder=Convert.ToDecimal("16.00") },
            new ReferenceModelBase { Id=Guid.Parse("9e8bcd77-e790-4026-922d-3b8aaa3569de"), Code="13462", Description="General Intellectual Aptitude, Specific Academic Aptitude, and Visual Performing Arts", Definition="The student's eligibility for Gifted/Talented program is in the category: General Intellectual Aptitude, Specific Academic Aptitude, and Visual Performing Arts.", SortOrder=Convert.ToDecimal("18.00") },
            new ReferenceModelBase { Id=Guid.Parse("e805885c-65aa-45e3-86f6-b92a01e1172e"), Code="13463", Description="General Intellectual Aptitude, Specific Academic Aptitude, & Technical/Practical Arts", Definition="The student's eligibility for Gifted/Talented program is in the category: General Intellectual Aptitude, Specific Academic Aptitude, & Technical/Practical Arts.", SortOrder=Convert.ToDecimal("20.00") },
            new ReferenceModelBase { Id=Guid.Parse("ba20ef7f-dd2b-4b03-83b3-e279bfce091a"), Code="13464", Description="Specific Academic Aptitude, Visual/Performing Arts, & Technical/Practical Arts", Definition="The student's eligibility for Gifted/Talented program is in the category: Specific Academic Aptitude, Visual/Performing Arts, & Technical/Practical Arts.", SortOrder=Convert.ToDecimal("22.00") },
            new ReferenceModelBase { Id=Guid.Parse("45afdd0f-7b1b-4046-9394-17c157165c4b"), Code="13465", Description="General Intellectual & Specific Academic Aptitude, Visual/Performing Arts & Technical/Practical Arts", Definition="The student's eligibility for Gifted/Talented program is in the category: General Intellectual & Specific Academic Aptitude, Visual/Performing Arts & Technical/Practical Arts.", SortOrder=Convert.ToDecimal("24.00") },
            new ReferenceModelBase { Id=Guid.Parse("2c20a868-f472-4130-a1fb-9bcbfaf2cffc"), Code="06002", Description="Not specified", Definition="The student's eligibility for Gifted/Talented program is in the category is not specified.", SortOrder=Convert.ToDecimal("26.00") },
            new ReferenceModelBase { Id=Guid.Parse("11ed6de7-bf55-4e4f-8589-f42976d9d2d0"), Code="09999", Description="Other", Definition="The student's eligibility for Gifted/Talented program is in a category not yet defined in CEDS.", SortOrder=Convert.ToDecimal("28.00") },
        };
        #endregion

        #region RefTitleIInstructionalServices List
        /// <summary>
        /// The complete <see cref="RefTitleIInstructionalServices"> List
        /// </summary>
        private static List<ReferenceModelBase> RefTitleIInstructionalServicesList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("43e19c25-7b3e-4f2f-95e5-88ecf51777ce"), Code="ReadingLanguageArts", Description="Reading/Language Arts", Definition="The student is participating in and served by a Reading/Language Arts program under Title I, Part A of ESEA as amended.", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("f3cb2586-809f-4ce7-bb32-b6b354eab856"), Code="Mathematics", Description="Mathematics", Definition="The student is participating in and served by a Mathematics program under Title I, Part A of ESEA as amended.", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("53191c0c-94bb-4c54-8b06-ac2b8fc81a1e"), Code="Science", Description="Science", Definition="The student is participating in and served by a Science program under Title I, Part A of ESEA as amended.", SortOrder=Convert.ToDecimal("3.00") },
            new ReferenceModelBase { Id=Guid.Parse("9a904ee8-95e7-4b2b-b62a-e3ab6bddaf6e"), Code="SocialSciences", Description="Social Sciences", Definition="The student is participating in and served by a Social Sciences program under Title I, Part A of ESEA as amended.", SortOrder=Convert.ToDecimal("4.00") },
            new ReferenceModelBase { Id=Guid.Parse("c623556f-ac62-4b4f-bd11-50ec6e11d4ad"), Code="CareerAndTechnical", Description="Career and Technical Education", Definition="The student is participating in and served by a Career and Technical Education program under Title I, Part A of ESEA as amended.", SortOrder=Convert.ToDecimal("5.00") },
            new ReferenceModelBase { Id=Guid.Parse("99a418e0-2e0b-40a9-a6ae-61bb04a2d0d1"), Code="Other", Description="Other", Definition="The student is participating in and served by a program under Title I, Part A of ESEA as amended in a subject/category not yet defined in CEDS.", SortOrder=Convert.ToDecimal("6.00") },
        };
        #endregion

        #region RefTitleIProgramType List
        /// <summary>
        /// The complete <see cref="RefTitleIProgramType"> List
        /// </summary>
        private static List<ReferenceModelBase> RefTitleIProgramTypeList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("5e6f129b-607a-4cb7-baa2-6e50b6971064"), Code="TargetedAssistanceProgram", Description="Public Targeted Assistance Program", Definition="The type of Title I program offered in the school or district Is Public Targeted Assistance Program", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("a267b695-0f38-4277-a81d-a3cf7e9112db"), Code="SchoolwideProgram", Description="Public Schoolwide Program", Definition="The type of Title I program offered in the school or district Is Public Schoolwide Program", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("a741e548-a133-4ff0-89f0-4575c9bcedcf"), Code="PrivateSchoolStudents", Description="Private School Students Participating", Definition="The type of Title I program offered in the school or district Is Private School Students Participating", SortOrder=Convert.ToDecimal("3.00") },
            new ReferenceModelBase { Id=Guid.Parse("56404963-50f2-450a-8734-4caec2bd7993"), Code="LocalNeglectedProgram", Description="Local Neglected Program", Definition="The type of Title I program offered in the school or district Is Local Neglected Program", SortOrder=Convert.ToDecimal("4.00") },
        };
        #endregion
    }
}
