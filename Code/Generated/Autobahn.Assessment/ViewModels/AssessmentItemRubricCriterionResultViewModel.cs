//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentItemRubricCriterionResultViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.Assessment.ViewModels
{
     /// <summary>
     /// The AssessmentItemRubricCriterionResultViewModel
     /// </summary>
    public partial class AssessmentItemRubricCriterionResultViewModel : ViewModelBase, Interfaces.IAssessmentItemRubricCriterionResult
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from AssessmentItemRubricCriterionResult";

        // member variable for the AssessmentItemResponseId property
        private Guid _AssessmentItemResponseId;

        // member variable for the RubricCriterionLevelId property
        private Guid _RubricCriterionLevelId;

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
        /// The title of the AssessmentItemRubricCriterionResultViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentItemResponseId"/> model
        /// </summary>
        public Guid AssessmentItemResponseId { get => _AssessmentItemResponseId; set => SetProperty(ref _AssessmentItemResponseId, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="RubricCriterionLevelId"/> model
        /// </summary>
        public Guid RubricCriterionLevelId { get => _RubricCriterionLevelId; set => SetProperty(ref _RubricCriterionLevelId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAssessmentItemRubricCriterionResult model)
        {
            IsBusy = true;
            Id = model.Id;
            AssessmentItemResponseId = model.AssessmentItemResponseId;
            RubricCriterionLevelId = model.RubricCriterionLevelId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
