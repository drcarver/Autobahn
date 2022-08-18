//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12StudentGraduationPlanViewModel.cs
//* Name:       Credits Required
//* Definition: The total number of credits required for a student to graduate from the school of enrollment or complete a program.
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.K12.ViewModels
{
     /// <summary>
     /// The total number of credits required for a student to graduate from the school of enrollment or complete a program.
     /// </summary>
    public partial class K12StudentGraduationPlanViewModel : ViewModelBase, Interfaces.IK12StudentGraduationPlan
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from K12StudentGraduationPlan";

        // CreditsRequired -- (backing property for Credits Required)
        private System.Decimal? _CreditsRequired;

        // member variable for the K12CourseId property
        private Guid _K12CourseId;

        // member variable for the OrganizationPersonRoleId property
        private Guid _OrganizationPersonRoleId;

        // RefGradeLevelWhenCourseTakenId -- (backing property for Grade Level When Course Taken)
        private Guid? _RefGradeLevelWhenCourseTakenId;

        // RefSCEDCourseSubjectAreaId -- (backing property for School Courses for the Exchange of Data Course Subject Area)
        private Guid? _RefSCEDCourseSubjectAreaId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Credits Required
        /// <para>
        /// The total number of credits required for a student to graduate from the school of enrollment or complete a program.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20553">Credits Required</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Decimal? CreditsRequired { get => _CreditsRequired; set => SetProperty(ref _CreditsRequired, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IK12Course"/> model
        /// </summary>
        public Guid K12CourseId { get => _K12CourseId; set => SetProperty(ref _K12CourseId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get => _OrganizationPersonRoleId; set => SetProperty(ref _OrganizationPersonRoleId, value); }

        /// <summary>
        /// Grade Level When Course Taken
        /// <para>
        /// Student's grade level at time of course.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19125">Grade Level When Course Taken</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefGradeLevelWhenCourseTakenId { get => _RefGradeLevelWhenCourseTakenId; set => SetProperty(ref _RefGradeLevelWhenCourseTakenId, value); }

        /// <summary>
        /// School Courses for the Exchange of Data Course Subject Area
        /// <para>
        /// The intended major subject area of the education course.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20491">School Courses for the Exchange of Data Course Subject Area</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefSCEDCourseSubjectAreaId { get => _RefSCEDCourseSubjectAreaId; set => SetProperty(ref _RefSCEDCourseSubjectAreaId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IK12StudentGraduationPlan model)
        {
            IsBusy = true;
            Id = model.Id;
            CreditsRequired = model.CreditsRequired; // Credits Required
            K12CourseId = model.K12CourseId; // 
            OrganizationPersonRoleId = model.OrganizationPersonRoleId; // 
            RefGradeLevelWhenCourseTakenId = model.RefGradeLevelWhenCourseTakenId; // Grade Level When Course Taken
            RefSCEDCourseSubjectAreaId = model.RefSCEDCourseSubjectAreaId; // School Courses for the Exchange of Data Course Subject Area
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
