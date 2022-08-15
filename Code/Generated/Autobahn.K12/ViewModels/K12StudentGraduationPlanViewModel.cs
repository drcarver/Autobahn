//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12StudentGraduationPlanViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.K12.ViewModels
{
     /// <summary>
     /// The K12StudentGraduationPlanViewModel
     /// </summary>
    public partial class K12StudentGraduationPlanViewModel : ViewModelBase, Interfaces.IK12StudentGraduationPlan
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from K12StudentGraduationPlan";

        // member variable for the RefGradeLevelWhenCourseTakenId property
        private Guid? _RefGradeLevelWhenCourseTakenId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the K12StudentGraduationPlanViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefGradeLevelWhenCourseTaken"/> model
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19125">Grade Level When Course Taken</a>
        /// </para>
        /// </summary>
        [DisplayName("Grade Level When Course Taken")]
        public Guid? RefGradeLevelWhenCourseTakenId { get => _RefGradeLevelWhenCourseTakenId; set => SetProperty(ref _RefGradeLevelWhenCourseTakenId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IK12StudentGraduationPlan model)
        {
            IsBusy = true;
            Id = model.Id;
            RefGradeLevelWhenCourseTakenId = model.RefGradeLevelWhenCourseTakenId; // Grade Level When Course Taken
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
