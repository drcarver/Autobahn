//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   AssessmentResultRubricCriterionResultViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;
using CommunityToolkit.Maui;

namespace Autobahn.Authorization.ViewModels
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

        #endregion

        #region Properties
        /// <summary>
        /// The title of the AssessmentResultRubricCriterionResultViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="AssessmentResult"/> model
        /// </summary>
        public Guid AssessmentResultId { get => _AssessmentResultId; set => SetProperty(ref _AssessmentResultId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RubricCriterionLevel"/> model
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
