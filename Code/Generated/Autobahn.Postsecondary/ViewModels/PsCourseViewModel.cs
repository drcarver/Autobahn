//**********************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   PsCourseViewModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Postsecondary.ViewModels
{
     /// <summary>
     /// The PsCourse View Model
     /// </summary>
    public partial class PsCourseViewModel : ViewModelBase, Interfaces.IPsCourse
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PsCourse";

        // member variable for the CourseId property
        private Guid _CourseId;

        // CourseNumber -- (backing property for Course Number)
        private System.String _CourseNumber;

        // NCAAEligibilityInd -- (backing property for National Collegiate Athletic Association Eligibility)
        private System.Int32? _NCAAEligibilityInd;

        // OriginalCourseIdentifier -- (backing property for Original Course Identifier)
        private System.String _OriginalCourseIdentifier;

        // OverrideSchoolCourseNumber -- (backing property for Override School Course Number)
        private System.String _OverrideSchoolCourseNumber;

        // RefCipCodeId -- (backing property for Classification of Instructional Program Code)
        private Guid? _RefCipCodeId;

        // RefCourseCreditBasisTypeId -- (backing property for Course Credit Basis Type)
        private Guid? _RefCourseCreditBasisTypeId;

        // RefCourseCreditLevelTypeId -- (backing property for Course Credit Level Type)
        private Guid? _RefCourseCreditLevelTypeId;

        // RefNCESCollegeCourseMapCodeId -- (backing property for NCES College Course Map Code)
        private Guid? _RefNCESCollegeCourseMapCodeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="ICourse"/> model
        /// </summary>
        public Guid CourseId { get => _CourseId; set => SetProperty(ref _CourseId, value); }

        /// <summary>
        /// Course Number
        /// <para>
        /// The official reference number portion of a course identifier.  This number normally designates the level of the course as well as the level of the individual expected to enroll in the course.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20280">Course Number</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String CourseNumber { get => _CourseNumber; set => SetProperty(ref _CourseNumber, value); }

        /// <summary>
        /// National Collegiate Athletic Association Eligibility
        /// <para>
        /// An indication that the course is approved for determining NCAA eligibility.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20382">National Collegiate Athletic Association Eligibility</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Int32? NCAAEligibilityInd { get => _NCAAEligibilityInd; set => SetProperty(ref _NCAAEligibilityInd, value); }

        /// <summary>
        /// Original Course Identifier
        /// <para>
        /// The course identifier as it was listed when the credit was earned (e.g. before a system conversion) to show consistency between present transcripts and older ones.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20389">Original Course Identifier</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String OriginalCourseIdentifier { get => _OriginalCourseIdentifier; set => SetProperty(ref _OriginalCourseIdentifier, value); }

        /// <summary>
        /// Override School Course Number
        /// <para>
        /// An indication of the way an academic course was identified at an educational institution.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20391">Override School Course Number</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String OverrideSchoolCourseNumber { get => _OverrideSchoolCourseNumber; set => SetProperty(ref _OverrideSchoolCourseNumber, value); }

        /// <summary>
        /// Classification of Instructional Program Code
        /// <para>
        /// A six-digit code in the form xx.xxxx that identifies instructional program specialties within educational institutions.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19043">Classification of Instructional Program Code</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefCipCodeId { get => _RefCipCodeId; set => SetProperty(ref _RefCipCodeId, value); }

        /// <summary>
        /// Course Credit Basis Type
        /// <para>
        /// The type of enrollment associated with the credit hours for the course.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20269">Course Credit Basis Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefCourseCreditBasisTypeId { get => _RefCourseCreditBasisTypeId; set => SetProperty(ref _RefCourseCreditBasisTypeId, value); }

        /// <summary>
        /// Course Credit Level Type
        /// <para>
        /// The level of credit associated with the credit hours earned for the course.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20270">Course Credit Level Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefCourseCreditLevelTypeId { get => _RefCourseCreditLevelTypeId; set => SetProperty(ref _RefCourseCreditLevelTypeId, value); }

        /// <summary>
        /// NCES College Course Map Code
        /// <para>
        /// A taxonomy system for coding postsecondary courses in NCES research studies.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20383">NCES College Course Map Code</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefNCESCollegeCourseMapCodeId { get => _RefNCESCollegeCourseMapCodeId; set => SetProperty(ref _RefNCESCollegeCourseMapCodeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPsCourse model)
        {
            IsBusy = true;
            Id = model.Id;
            CourseId = model.CourseId; // 
            CourseNumber = model.CourseNumber; // Course Number
            NCAAEligibilityInd = model.NCAAEligibilityInd; // National Collegiate Athletic Association Eligibility
            OriginalCourseIdentifier = model.OriginalCourseIdentifier; // Original Course Identifier
            OverrideSchoolCourseNumber = model.OverrideSchoolCourseNumber; // Override School Course Number
            RefCipCodeId = model.RefCipCodeId; // Classification of Instructional Program Code
            RefCourseCreditBasisTypeId = model.RefCourseCreditBasisTypeId; // Course Credit Basis Type
            RefCourseCreditLevelTypeId = model.RefCourseCreditLevelTypeId; // Course Credit Level Type
            RefNCESCollegeCourseMapCodeId = model.RefNCESCollegeCourseMapCodeId; // NCES College Course Map Code
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }

        #region RefNCESCollegeCourseMapCode List
        /// <summary>
        /// The complete <see cref="RefNCESCollegeCourseMapCode"> List
        /// </summary>
        private static List<ReferenceModelBase> RefNCESCollegeCourseMapCodeList = new List<ReferenceModelBase>
        {
        };
        #endregion
    }
}
