//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentSubtestAssessmentItemViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Assessments.ViewModels
{
     /// <summary>
     /// The AssessmentSubtestAssessmentItemViewModel
     /// </summary>
    public partial class AssessmentSubtestAssessmentItemViewModel : ViewModelBase, Interfaces.IAssessmentSubtestAssessmentItem
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from AssessmentSubtestAssessmentItem";

        // member variable for the ItemWeightCorrect property
        private System.Decimal? _ItemWeightCorrect;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the AssessmentSubtestAssessmentItemViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// A weighting factor for how the item score is used to compute a sub-test score when the item is correct or partially correct. Item weight of 1 indicates the full item score is used. A weight of .5 would indicate the item only contributes one half of the item score to the subtest. A weight of 0 indicates the item does not affect the sub test score.
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20013">Assessment Form Subtest Item Weight Correct</a>
        /// </para>
        /// </summary>
        [DisplayName("Assessment Form Subtest Item Weight Correct")]
        public System.Decimal? ItemWeightCorrect { get => _ItemWeightCorrect; set => SetProperty(ref _ItemWeightCorrect, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAssessmentSubtestAssessmentItem model)
        {
            IsBusy = true;
            Id = model.Id;
            ItemWeightCorrect = model.ItemWeightCorrect; // Assessment Form Subtest Item Weight Correct
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
