//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentResultRubricCriterionResultViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.Assessment.ViewModels
{
     /// <summary>
     /// The AssessmentResultRubricCriterionResultViewModel
     /// </summary>
    public partial class AssessmentResultRubricCriterionResultViewModel : ViewModelBase, Interfaces.IAssessmentResultRubricCriterionResult
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from AssessmentResultRubricCriterionResult";

        // member variable for the AssessmentResultId property
        private Guid _AssessmentResultId;

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
        /// The title of the AssessmentResultRubricCriterionResultViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentResultId"/> model
        /// </summary>
        public Guid AssessmentResultId { get => _AssessmentResultId; set => SetProperty(ref _AssessmentResultId, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="RubricCriterionLevelId"/> model
        /// </summary>
        public Guid RubricCriterionLevelId { get => _RubricCriterionLevelId; set => SetProperty(ref _RubricCriterionLevelId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAssessmentResultRubricCriterionResult model)
        {
            IsBusy = true;
            Id = model.Id;
            AssessmentResultId = model.AssessmentResultId;
            RubricCriterionLevelId = model.RubricCriterionLevelId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
