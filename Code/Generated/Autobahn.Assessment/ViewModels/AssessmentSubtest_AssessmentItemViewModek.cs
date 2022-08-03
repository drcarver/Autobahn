//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentSubtest_AssessmentItemViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Assessment.Interfaces;

namespace Autobahn.Assessment.ViewModels
{
     /// <summary>
     /// The AssessmentSubtest_AssessmentItemViewModel
     /// </summary>
    public partial class AssessmentSubtest_AssessmentItemViewModel : BindableBase, IAssessmentSubtest_AssessmentItem
    {
#region "Backing Fields"
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

#endregion

#region Properties
        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentSubtestItemId"/> model
        /// </summary>
        public Guid AssessmentSubtestItemId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentSubtestId"/> model
        /// </summary>
        public Guid AssessmentSubtestId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentItemId"/> model
        /// </summary>
        public Guid AssessmentItemId { get; set; }

        public System.Decimal? ItemWeightCorrect { get => _ItemWeightCorrect; set => SetProperty(ref _ItemWeightCorrect, value); }

        public System.Decimal? ItemWeightIncorrect { get => _ItemWeightIncorrect; set => SetProperty(ref _ItemWeightIncorrect, value); }

        public System.Decimal? ItemWeightNotAttempted { get => _ItemWeightNotAttempted; set => SetProperty(ref _ItemWeightNotAttempted, value); }

        public System.DateTime? RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        public System.DateTime? RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatusId"/> model
        /// </summary>
        public Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollectionId"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

#endregion


        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(IAssessmentSubtest_AssessmentItem model)
        {
            IsBusy = true;
            Id = model.Id;
            AssessmentSubtestItemId = model.AssessmentSubtestItemId;
            AssessmentSubtestId = model.AssessmentSubtestId;
            AssessmentItemId = model.AssessmentItemId;
            ItemWeightCorrect = model.ItemWeightCorrect;
            ItemWeightIncorrect = model.ItemWeightIncorrect;
            ItemWeightNotAttempted = model.ItemWeightNotAttempted;
            RecordStartDateTime = model.RecordStartDateTime;
            RecordEndDateTime = model.RecordEndDateTime;
            RecordStatusId = model.RecordStatusId;
            DataCollectionId = model.DataCollectionId;
            IsChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
