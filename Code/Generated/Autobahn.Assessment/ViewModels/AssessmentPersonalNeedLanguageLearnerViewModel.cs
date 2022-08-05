//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentPersonalNeedLanguageLearnerViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.Assessment.ViewModels
{
     /// <summary>
     /// The AssessmentPersonalNeedLanguageLearnerViewModel
     /// </summary>
    public partial class AssessmentPersonalNeedLanguageLearnerViewModel : ViewModelBase, Interfaces.IAssessmentPersonalNeedLanguageLearner
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from AssessmentPersonalNeedLanguageLearner";

        // member variable for the AssessmentNeedsProfileContentId property
        private Guid _AssessmentNeedsProfileContentId;

        // member variable for the AssignedSupport property
        private System.Boolean? _AssignedSupport;

        // member variable for the ActivateByDefault property
        private System.Boolean? _ActivateByDefault;

        // member variable for the RefAssessmentNeedsProfileContentLanguageLearnerTypeId property
        private Guid _RefAssessmentNeedsProfileContentLanguageLearnerTypeId;

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
        /// The title of the AssessmentPersonalNeedLanguageLearnerViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentNeedsProfileContentId"/> model
        /// </summary>
        public Guid AssessmentNeedsProfileContentId { get => _AssessmentNeedsProfileContentId; set => SetProperty(ref _AssessmentNeedsProfileContentId, value); }

        public System.Boolean? AssignedSupport { get => _AssignedSupport; set => SetProperty(ref _AssignedSupport, value); }

        public System.Boolean? ActivateByDefault { get => _ActivateByDefault; set => SetProperty(ref _ActivateByDefault, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefAssessmentNeedsProfileContentLanguageLearnerTypeId"/> model
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
            AssessmentNeedsProfileContentId = model.AssessmentNeedsProfileContentId;
            AssignedSupport = model.AssignedSupport;
            ActivateByDefault = model.ActivateByDefault;
            RefAssessmentNeedsProfileContentLanguageLearnerTypeId = model.RefAssessmentNeedsProfileContentLanguageLearnerTypeId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
