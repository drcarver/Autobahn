//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentItemResponseTheoryViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Assessments.ViewModels
{
     /// <summary>
     /// The AssessmentItemResponseTheoryViewModel
     /// </summary>
    public partial class AssessmentItemResponseTheoryViewModel : ViewModelBase, Interfaces.IAssessmentItemResponseTheory
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from AssessmentItemResponseTheory";

        // member variable for the ParameterA property
        private System.Int32? _ParameterA;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the AssessmentItemResponseTheoryViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The Item Response Theory value representing the discrimination of the item. The a parameter is found by taking the slope of the line tangent to the item characteristic curve at the inflection point, B. The parameter is the steepness of the curve at its steepest point.
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20217">Assessment Item Response Theory Parameter A</a>
        /// </para>
        /// </summary>
        [DisplayName("Assessment Item Response Theory Parameter A")]
        public System.Int32? ParameterA { get => _ParameterA; set => SetProperty(ref _ParameterA, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAssessmentItemResponseTheory model)
        {
            IsBusy = true;
            Id = model.Id;
            ParameterA = model.ParameterA; // Assessment Item Response Theory Parameter A
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
