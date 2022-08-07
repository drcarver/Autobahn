//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentSubtest_AssessmentItemViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.Assessment.ViewModels
{
     /// <summary>
     /// The AssessmentSubtest_AssessmentItemViewModel
     /// </summary>
    public partial class AssessmentSubtest_AssessmentItemViewModel : ViewModelBase, Interfaces.IAssessmentSubtest_AssessmentItemViewModel
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from AssessmentSubtest_AssessmentItem";

        // member variable for the AssessmentSubtestItemId property
        private Guid _AssessmentSubtestItemId;

        // member variable for the AssessmentSubtestId property
        private Guid _AssessmentSubtestId;

        // member variable for the AssessmentItemId property
        private Guid _AssessmentItemId;

        // member variable for the ItemWeightCorrect property
        private System.Decimal? _ItemWeightCorrect;

        // member variable for the ItemWeightIncorrect property
        private System.Decimal? _ItemWeightIncorrect;

        // member variable for the ItemWeightNotAttempted property
        private System.Decimal? _ItemWeightNotAttempted;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

        // member variable for the RecordStatusId property
        private Guid? _RecordStatusId;

        // member variable for the DataCollectionId property
        private Guid? _DataCollectionId;

#endregion

        #region Properties
        /// <summary>
        /// The title of the AssessmentSubtest_AssessmentItemViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentSubtestItemId"/> model
        /// </summary>
        public Guid AssessmentSubtestItemId { get => _AssessmentSubtestItemId; set => SetProperty(ref _AssessmentSubtestItemId, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentSubtestId"/> model
        /// </summary>
        public Guid AssessmentSubtestId { get => _AssessmentSubtestId; set => SetProperty(ref _AssessmentSubtestId, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentItemId"/> model
        /// </summary>
        public Guid AssessmentItemId { get => _AssessmentItemId; set => SetProperty(ref _AssessmentItemId, value); }

        public System.Decimal? ItemWeightCorrect { get => _ItemWeightCorrect; set => SetProperty(ref _ItemWeightCorrect, value); }

        public System.Decimal? ItemWeightIncorrect { get => _ItemWeightIncorrect; set => SetProperty(ref _ItemWeightIncorrect, value); }

        public System.Decimal? ItemWeightNotAttempted { get => _ItemWeightNotAttempted; set => SetProperty(ref _ItemWeightNotAttempted, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAssessmentSubtest_AssessmentItem model)
        {
            IsBusy = true;
            Id = model.Id;
            AssessmentSubtestItemId = model.AssessmentSubtestItemId;
            AssessmentSubtestId = model.AssessmentSubtestId;
            AssessmentItemId = model.AssessmentItemId;
            ItemWeightCorrect = model.ItemWeightCorrect;
            ItemWeightIncorrect = model.ItemWeightIncorrect;
            ItemWeightNotAttempted = model.ItemWeightNotAttempted;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
