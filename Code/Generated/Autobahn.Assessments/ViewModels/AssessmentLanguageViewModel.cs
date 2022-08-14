//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentLanguageViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.Assessments.ViewModels
{
     /// <summary>
     /// The AssessmentLanguageViewModel
     /// </summary>
    public partial class AssessmentLanguageViewModel : ViewModelBase, Interfaces.IAssessmentLanguage
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from AssessmentLanguage";

        // member variable for the AssessmentId property
        private Guid _AssessmentId;

        // member variable for the RefLanguageId property
        private Guid _RefLanguageId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the AssessmentLanguageViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="Assessment"/> model
        /// </summary>
        public Guid AssessmentId { get => _AssessmentId; set => SetProperty(ref _AssessmentId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLanguage"/> model
        /// </summary>
        public Guid RefLanguageId { get => _RefLanguageId; set => SetProperty(ref _RefLanguageId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAssessmentLanguage model)
        {
            IsBusy = true;
            Id = model.Id;
            AssessmentId = model.AssessmentId;
            RefLanguageId = model.RefLanguageId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
