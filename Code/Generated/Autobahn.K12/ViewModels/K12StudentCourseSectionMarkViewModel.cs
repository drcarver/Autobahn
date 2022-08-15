//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12StudentCourseSectionMarkViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.K12.ViewModels
{
     /// <summary>
     /// The K12StudentCourseSectionMarkViewModel
     /// </summary>
    public partial class K12StudentCourseSectionMarkViewModel : ViewModelBase, Interfaces.IK12StudentCourseSectionMark
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from K12StudentCourseSectionMark";

        // member variable for the GradeEarned property
        private System.String _GradeEarned;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the K12StudentCourseSectionMarkViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// A final indicator of student performance in a course section as submitted by the instructor.
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19124">Student Course Section Grade Earned</a>
        /// </para>
        /// </summary>
        [DisplayName("Student Course Section Grade Earned")]
        public System.String GradeEarned { get => _GradeEarned; set => SetProperty(ref _GradeEarned, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IK12StudentCourseSectionMark model)
        {
            IsBusy = true;
            Id = model.Id;
            GradeEarned = model.GradeEarned; // Student Course Section Grade Earned
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
