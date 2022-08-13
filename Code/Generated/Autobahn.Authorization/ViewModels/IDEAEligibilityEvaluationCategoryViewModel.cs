//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   IDEAEligibilityEvaluationCategoryViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;
using CommunityToolkit.Maui;

namespace Autobahn.Authorization.ViewModels
{
     /// <summary>
     /// The IDEAEligibilityEvaluationCategoryViewModel
     /// </summary>
    public partial class IDEAEligibilityEvaluationCategoryViewModel : ViewModelBase, Interfaces.IIDEAEligibilityEvaluationCategory
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from IDEAEligibilityEvaluationCategory";

        // member variable for the EligibilityEvaluationId property
        private Guid _EligibilityEvaluationId;

        // member variable for the RefIDEAEligibilityEvaluationCategoryId property
        private Guid _RefIDEAEligibilityEvaluationCategoryId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the IDEAEligibilityEvaluationCategoryViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="EligibilityEvaluation"/> model
        /// </summary>
        public Guid EligibilityEvaluationId { get => _EligibilityEvaluationId; set => SetProperty(ref _EligibilityEvaluationId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIDEAEligibilityEvaluationCategory"/> model
        /// </summary>
        public Guid RefIDEAEligibilityEvaluationCategoryId { get => _RefIDEAEligibilityEvaluationCategoryId; set => SetProperty(ref _RefIDEAEligibilityEvaluationCategoryId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IIDEAEligibilityEvaluationCategory model)
        {
            IsBusy = true;
            Id = model.Id;
            EligibilityEvaluationId = model.EligibilityEvaluationId;
            RefIDEAEligibilityEvaluationCategoryId = model.RefIDEAEligibilityEvaluationCategoryId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
