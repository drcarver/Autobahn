//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentSubtest_AssessmentItemViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.Assessments.ViewModels
{
     /// <summary>
     /// The AssessmentSubtest_AssessmentItemViewModel
     /// </summary>
    public partial class AssessmentSubtest_AssessmentItemViewModel : ViewModelBase, Interfaces.IAssessmentSubtest_AssessmentItem
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from AssessmentSubtest_AssessmentItem";

        // member variable for the AssessmentItemId property
        private Guid _AssessmentItemId;

        // member variable for the AssessmentSubtestId property
        private Guid _AssessmentSubtestId;

        // member variable for the AssessmentSubtestItemId property
        private Guid _AssessmentSubtestItemId;

        // member variable for the ItemWeightCorrect property
        private System.Decimal? _ItemWeightCorrect;

        // member variable for the ItemWeightIncorrect property
        private System.Decimal? _ItemWeightIncorrect;

        // member variable for the ItemWeightNotAttempted property
        private System.Decimal? _ItemWeightNotAttempted;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the AssessmentSubtest_AssessmentItemViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="AssessmentItem"/> model
        /// </summary>
        public Guid AssessmentItemId { get => _AssessmentItemId; set => SetProperty(ref _AssessmentItemId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="AssessmentSubtest"/> model
        /// </summary>
        public Guid AssessmentSubtestId { get => _AssessmentSubtestId; set => SetProperty(ref _AssessmentSubtestId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="AssessmentSubtestItem"/> model
        /// </summary>
        public Guid AssessmentSubtestItemId { get => _AssessmentSubtestItemId; set => SetProperty(ref _AssessmentSubtestItemId, value); }

        /// <summary>
        /// A weighting factor for how the item score is used to compute a sub-test score when the item is correct or partially correct. Item weight of 1 indicates the full item score is used. A weight of .5 would indicate the item only contributes one half of the item score to the subtest. A weight of 0 indicates the item does not affect the sub test score.
        /// </summary>
        public System.Decimal? ItemWeightCorrect { get => _ItemWeightCorrect; set => SetProperty(ref _ItemWeightCorrect, value); }

        /// <summary>
        /// A weighting factor for how the item score is used to compute a sub-test score when the item is correct or partially correct. Item weight of 1 indicates the full item score is used. A weight of .5 would indicate the item only contributes one half of the item score to the subtest. A weight of 0 indicates the item does not affect the sub test score.
        /// </summary>
        public System.Decimal? ItemWeightIncorrect { get => _ItemWeightIncorrect; set => SetProperty(ref _ItemWeightIncorrect, value); }

        /// <summary>
        /// A weighting factor for how the item score is used to compute a sub-test score when the item is correct or partially correct. Item weight of 1 indicates the full item score is used. A weight of .5 would indicate the item only contributes one half of the item score to the subtest. A weight of 0 indicates the item does not affect the sub test score.
        /// </summary>
        public System.Decimal? ItemWeightNotAttempted { get => _ItemWeightNotAttempted; set => SetProperty(ref _ItemWeightNotAttempted, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAssessmentSubtest_AssessmentItem model)
        {
            IsBusy = true;
            Id = model.Id;
            AssessmentItemId = model.AssessmentItemId;
            AssessmentSubtestId = model.AssessmentSubtestId;
            AssessmentSubtestItemId = model.AssessmentSubtestItemId;
            ItemWeightCorrect = model.ItemWeightCorrect;
            ItemWeightIncorrect = model.ItemWeightIncorrect;
            ItemWeightNotAttempted = model.ItemWeightNotAttempted;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
