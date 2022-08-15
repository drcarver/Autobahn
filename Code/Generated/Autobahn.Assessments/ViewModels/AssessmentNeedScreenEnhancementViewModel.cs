//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentNeedScreenEnhancementViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Assessments.ViewModels
{
     /// <summary>
     /// The AssessmentNeedScreenEnhancementViewModel
     /// </summary>
    public partial class AssessmentNeedScreenEnhancementViewModel : ViewModelBase, Interfaces.IAssessmentNeedScreenEnhancement
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from AssessmentNeedScreenEnhancement";

        // member variable for the InvertColorChoice property
        private System.Boolean? _InvertColorChoice;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the AssessmentNeedScreenEnhancementViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Defines as part of an Assessment Personal Needs Profile the Access for All (AfA) preference to invert the foreground and background Colors.
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20033">Assessment Need Invert Color Choice</a>
        /// </para>
        /// </summary>
        [DisplayName("Assessment Need Invert Color Choice")]
        public System.Boolean? InvertColorChoice { get => _InvertColorChoice; set => SetProperty(ref _InvertColorChoice, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAssessmentNeedScreenEnhancement model)
        {
            IsBusy = true;
            Id = model.Id;
            InvertColorChoice = model.InvertColorChoice; // Assessment Need Invert Color Choice
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
