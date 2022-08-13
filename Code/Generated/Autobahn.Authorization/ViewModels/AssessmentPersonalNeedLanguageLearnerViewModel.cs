//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   AssessmentPersonalNeedLanguageLearnerViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;
using CommunityToolkit.Maui;

namespace Autobahn.Authorization.ViewModels
{
     /// <summary>
     /// The AssessmentPersonalNeedLanguageLearnerViewModel
     /// </summary>
    public partial class AssessmentPersonalNeedLanguageLearnerViewModel : ViewModelBase, Interfaces.IAssessmentPersonalNeedLanguageLearner
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from AssessmentPersonalNeedLanguageLearner";

        // member variable for the ActivateByDefault property
        private System.Boolean? _ActivateByDefault;

        // member variable for the AssessmentNeedsProfileContentId property
        private Guid _AssessmentNeedsProfileContentId;

        // member variable for the AssignedSupport property
        private System.Boolean? _AssignedSupport;

        // member variable for the RefAssessmentNeedsProfileContentLanguageLearnerTypeId property
        private Guid _RefAssessmentNeedsProfileContentLanguageLearnerTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the AssessmentPersonalNeedLanguageLearnerViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Defines whether or not the individual needs the kind of support defined by the entity.
        /// </summary>
        public System.Boolean? ActivateByDefault { get => _ActivateByDefault; set => SetProperty(ref _ActivateByDefault, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="AssessmentNeedsProfileContent"/> model
        /// </summary>
        public Guid AssessmentNeedsProfileContentId { get => _AssessmentNeedsProfileContentId; set => SetProperty(ref _AssessmentNeedsProfileContentId, value); }

        /// <summary>
        /// Defines whether or not the individual needs the kind of support defined by the entity.
        /// </summary>
        public System.Boolean? AssignedSupport { get => _AssignedSupport; set => SetProperty(ref _AssignedSupport, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentNeedsProfileContentLanguageLearnerType"/> model
        /// </summary>
        public Guid RefAssessmentNeedsProfileContentLanguageLearnerTypeId { get => _RefAssessmentNeedsProfileContentLanguageLearnerTypeId; set => SetProperty(ref _RefAssessmentNeedsProfileContentLanguageLearnerTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAssessmentPersonalNeedLanguageLearner model)
        {
            IsBusy = true;
            Id = model.Id;
            ActivateByDefault = model.ActivateByDefault;
            AssessmentNeedsProfileContentId = model.AssessmentNeedsProfileContentId;
            AssignedSupport = model.AssignedSupport;
            RefAssessmentNeedsProfileContentLanguageLearnerTypeId = model.RefAssessmentNeedsProfileContentLanguageLearnerTypeId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
