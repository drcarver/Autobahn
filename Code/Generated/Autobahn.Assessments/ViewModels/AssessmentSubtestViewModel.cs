//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentSubtestViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Assessments.ViewModels
{
     /// <summary>
     /// The AssessmentSubtestViewModel
     /// </summary>
    public partial class AssessmentSubtestViewModel : ViewModelBase, Interfaces.IAssessmentSubtest
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from AssessmentSubtest";

        // member variable for the RefAcademicSubjectId property
        private Guid _RefAcademicSubjectId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the AssessmentSubtestViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAcademicSubject"/> model
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19021">Assessment Academic Subject</a>
        /// </para>
        /// </summary>
        [DisplayName("Assessment Academic Subject")]
        public Guid RefAcademicSubjectId { get => _RefAcademicSubjectId; set => SetProperty(ref _RefAcademicSubjectId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAssessmentSubtest model)
        {
            IsBusy = true;
            Id = model.Id;
            RefAcademicSubjectId = model.RefAcademicSubjectId; // Assessment Academic Subject
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
