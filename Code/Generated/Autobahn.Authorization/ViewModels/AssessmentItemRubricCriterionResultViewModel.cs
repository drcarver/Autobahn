//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   AssessmentItemRubricCriterionResultViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;
using CommunityToolkit.Maui;

namespace Autobahn.Authorization.ViewModels
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

        #endregion

        #region Properties
        /// <summary>
        /// The title of the AssessmentItemRubricCriterionResultViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="AssessmentItemResponse"/> model
        /// </summary>
        public Guid AssessmentItemResponseId { get => _AssessmentItemResponseId; set => SetProperty(ref _AssessmentItemResponseId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RubricCriterionLevel"/> model
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
