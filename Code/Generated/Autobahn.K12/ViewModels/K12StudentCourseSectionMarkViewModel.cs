//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12StudentCourseSectionMarkViewModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.K12.ViewModels
{
     /// <summary>
     /// The K12StudentCourseSectionMark View Model
     /// </summary>
    public partial class K12StudentCourseSectionMarkViewModel : ViewModelBase, Interfaces.IK12StudentCourseSectionMark
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from K12StudentCourseSectionMark";

        // FinalIndicator -- (backing property for Student Course Section Mark Final Indicator)
        private System.Boolean? _FinalIndicator;

        // GradeEarned -- (backing property for Student Course Section Grade Earned)
        private System.String _GradeEarned;

        // GradeValueQualifier -- (backing property for Grade Value Qualifier)
        private System.String _GradeValueQualifier;

        // member variable for the K12StudentCourseSectionId property
        private Guid _K12StudentCourseSectionId;

        // MarkingPeriodName -- (backing property for Marking Period Name)
        private System.String _MarkingPeriodName;

        // MidTermMark -- (backing property for Mid Term Mark)
        private System.String _MidTermMark;

        // StudentCourseSectionGradeNarrative -- (backing property for Student Course Section Grade Narrative)
        private System.String _StudentCourseSectionGradeNarrative;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Student Course Section Mark Final Indicator
        /// <para>
        /// Indicates that the mark is a final mark the learner has earned for the course section.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20191">Student Course Section Mark Final Indicator</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Boolean? FinalIndicator { get => _FinalIndicator; set => SetProperty(ref _FinalIndicator, value); }

        /// <summary>
        /// Student Course Section Grade Earned
        /// <para>
        /// A final indicator of student performance in a course section as submitted by the instructor.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19124">Student Course Section Grade Earned</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String GradeEarned { get => _GradeEarned; set => SetProperty(ref _GradeEarned, value); }

        /// <summary>
        /// Grade Value Qualifier
        /// <para>
        /// The scale of equivalents, if applicable, for grades awarded as indicators of performance in schoolwork. For example, numerical equivalents for letter grades used in determining a student's Grade Point Average (A=4, B=3, C=2, D=1 in a four-point system) or letter equivalents for percentage grades (90-100%=A, 80-90%=B, etc.)
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19609">Grade Value Qualifier</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String GradeValueQualifier { get => _GradeValueQualifier; set => SetProperty(ref _GradeValueQualifier, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IK12StudentCourseSection"/> model
        /// </summary>
        public Guid K12StudentCourseSectionId { get => _K12StudentCourseSectionId; set => SetProperty(ref _K12StudentCourseSectionId, value); }

        /// <summary>
        /// Marking Period Name
        /// <para>
        /// The name or description of the marking period (e.g., fall, first marking period).
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19182">Marking Period Name</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String MarkingPeriodName { get => _MarkingPeriodName; set => SetProperty(ref _MarkingPeriodName, value); }

        /// <summary>
        /// Mid Term Mark
        /// <para>
        /// Indicator of student performance at the mid-point of the marking period.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19183">Mid Term Mark</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String MidTermMark { get => _MidTermMark; set => SetProperty(ref _MidTermMark, value); }

        /// <summary>
        /// Student Course Section Grade Narrative
        /// <para>
        /// The narrative of the student performance in a course section as submitted by the instructor.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20552">Student Course Section Grade Narrative</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String StudentCourseSectionGradeNarrative { get => _StudentCourseSectionGradeNarrative; set => SetProperty(ref _StudentCourseSectionGradeNarrative, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IK12StudentCourseSectionMark model)
        {
            IsBusy = true;
            Id = model.Id;
            FinalIndicator = model.FinalIndicator; // Student Course Section Mark Final Indicator
            GradeEarned = model.GradeEarned; // Student Course Section Grade Earned
            GradeValueQualifier = model.GradeValueQualifier; // Grade Value Qualifier
            K12StudentCourseSectionId = model.K12StudentCourseSectionId; // 
            MarkingPeriodName = model.MarkingPeriodName; // Marking Period Name
            MidTermMark = model.MidTermMark; // Mid Term Mark
            StudentCourseSectionGradeNarrative = model.StudentCourseSectionGradeNarrative; // Student Course Section Grade Narrative
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
