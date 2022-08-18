//**********************************************************
//* DomainName: Common Models
//* FileName:   CourseViewModel.cs
//* Name:       Course Certification Description
//* Definition: A description of the certification or recognition associated with this course (ex. Networking, CAD, etc.)
//***************************************************************************

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// A description of the certification or recognition associated with this course (ex. Networking, CAD, etc.)
     /// </summary>
    public partial class CourseViewModel : ViewModelBase, Interfaces.ICourse
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from Course";

        // CertificationDescription -- (backing property for Course Certification Description)
        private System.String _CertificationDescription;

        // CreditValue -- (backing property for Credit Value)
        private System.Decimal? _CreditValue;

        // InstructionalMinutes -- (backing property for Instructional Minutes)
        private System.Int32? _InstructionalMinutes;

        // member variable for the OrganizationId property
        private Guid _OrganizationId;

        // RefCourseApplicableEducationLevelId -- (backing property for Course Applicable Education Level)
        private Guid? _RefCourseApplicableEducationLevelId;

        // RefCourseCreditUnitId -- (backing property for Course Credit Units)
        private Guid? _RefCourseCreditUnitId;

        // RefCourseLevelCharacteristicsId -- (backing property for Course Level Characteristic)
        private Guid? _RefCourseLevelCharacteristicsId;

        // RefInstructionLanguageId -- (backing property for Instruction Language)
        private Guid? _RefInstructionLanguageId;

        // RepeatabilityMaximumNumber -- (backing property for Course Repeatability Maximum Number)
        private System.Int32? _RepeatabilityMaximumNumber;

        // SCEDSequenceOfCourse -- (backing property for School Courses for the Exchange of Data Sequence of Course)
        private System.String _SCEDSequenceOfCourse;

        // SubjectAbbreviation -- (backing property for Course Subject Abbreviation)
        private System.String _SubjectAbbreviation;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Course Certification Description
        /// <para>
        /// A description of the certification or recognition associated with this course (ex. Networking, CAD, etc.)
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20268">Course Certification Description</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String CertificationDescription { get => _CertificationDescription; set => SetProperty(ref _CertificationDescription, value); }

        /// <summary>
        /// Credit Value
        /// <para>
        /// The amount of credit available to the student who successfully meets the objectives of the course or learning opportunity based on the units defined by Credit Unit Type.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19058">Credit Value</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Decimal? CreditValue { get => _CreditValue; set => SetProperty(ref _CreditValue, value); }

        /// <summary>
        /// Instructional Minutes
        /// <para>
        /// The total number of instruction minutes in a given session, as determined by time in class, time on task (e.g., engaged in a class), or as estimated by a qualified course designer.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19490">Instructional Minutes</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Int32? InstructionalMinutes { get => _InstructionalMinutes; set => SetProperty(ref _InstructionalMinutes, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganization"/> model
        /// </summary>
        public Guid OrganizationId { get => _OrganizationId; set => SetProperty(ref _OrganizationId, value); }

        /// <summary>
        /// Course Applicable Education Level
        /// <para>
        /// The education level, grade level or primary instructional level at which a course is intended.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20267">Course Applicable Education Level</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefCourseApplicableEducationLevelId { get => _RefCourseApplicableEducationLevelId; set => SetProperty(ref _RefCourseApplicableEducationLevelId, value); }

        /// <summary>
        /// Course Credit Units
        /// <para>
        /// The type of credit (unit, semester, or quarter) associated with the credit hours earned for the course. 
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19057">Course Credit Units</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefCourseCreditUnitId { get => _RefCourseCreditUnitId; set => SetProperty(ref _RefCourseCreditUnitId, value); }

        /// <summary>
        /// Course Level Characteristic
        /// <para>
        /// An indication of the general nature and difficulty of instruction provided throughout a course.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19061">Course Level Characteristic</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefCourseLevelCharacteristicsId { get => _RefCourseLevelCharacteristicsId; set => SetProperty(ref _RefCourseLevelCharacteristicsId, value); }

        /// <summary>
        /// Instruction Language
        /// <para>
        /// The language of instruction, other than English, used in the program or course.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19438">Instruction Language</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefInstructionLanguageId { get => _RefInstructionLanguageId; set => SetProperty(ref _RefInstructionLanguageId, value); }

        /// <summary>
        /// Course Repeatability Maximum Number
        /// <para>
        /// The maximum number of times the course may be taken or completed for credit.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20648">Course Repeatability Maximum Number</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Int32? RepeatabilityMaximumNumber { get => _RepeatabilityMaximumNumber; set => SetProperty(ref _RepeatabilityMaximumNumber, value); }

        /// <summary>
        /// School Courses for the Exchange of Data Sequence of Course
        /// <para>
        /// Where a specific course lies when it is part of a consecutive sequence of courses. This element should be interpreted as "part 'n' of 'm' parts.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19250">School Courses for the Exchange of Data Sequence of Course</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String SCEDSequenceOfCourse { get => _SCEDSequenceOfCourse; set => SetProperty(ref _SCEDSequenceOfCourse, value); }

        /// <summary>
        /// Course Subject Abbreviation
        /// <para>
        /// The alphabetic abbreviation of the academic department or discipline offering the course. It is one part of the total course identifier number. 
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19066">Course Subject Abbreviation</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String SubjectAbbreviation { get => _SubjectAbbreviation; set => SetProperty(ref _SubjectAbbreviation, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.ICourse model)
        {
            IsBusy = true;
            Id = model.Id;
            CertificationDescription = model.CertificationDescription; // Course Certification Description
            CreditValue = model.CreditValue; // Credit Value
            InstructionalMinutes = model.InstructionalMinutes; // Instructional Minutes
            OrganizationId = model.OrganizationId; // 
            RefCourseApplicableEducationLevelId = model.RefCourseApplicableEducationLevelId; // Course Applicable Education Level
            RefCourseCreditUnitId = model.RefCourseCreditUnitId; // Course Credit Units
            RefCourseLevelCharacteristicsId = model.RefCourseLevelCharacteristicsId; // Course Level Characteristic
            RefInstructionLanguageId = model.RefInstructionLanguageId; // Instruction Language
            RepeatabilityMaximumNumber = model.RepeatabilityMaximumNumber; // Course Repeatability Maximum Number
            SCEDSequenceOfCourse = model.SCEDSequenceOfCourse; // School Courses for the Exchange of Data Sequence of Course
            SubjectAbbreviation = model.SubjectAbbreviation; // Course Subject Abbreviation
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }

        #region RefCourseLevelCharacteristics List
        /// <summary>
        /// The complete Course Certification Description List
        /// </summary>
        private static List<ReferenceModelBase> RefCourseLevelCharacteristicsList = new List<ReferenceModelBase>
        {
        };
        #endregion

        #region RefInstructionLanguage List
        /// <summary>
        /// The complete Course Certification Description List
        /// </summary>
        private static List<ReferenceModelBase> RefInstructionLanguageList = new List<ReferenceModelBase>
        {
        };
        #endregion
    }
}
