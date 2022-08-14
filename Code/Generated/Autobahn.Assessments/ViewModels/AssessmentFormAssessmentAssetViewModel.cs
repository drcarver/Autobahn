//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentFormAssessmentAssetViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.Assessments.ViewModels
{
     /// <summary>
     /// The AssessmentFormAssessmentAssetViewModel
     /// </summary>
    public partial class AssessmentFormAssessmentAssetViewModel : ViewModelBase, Interfaces.IAssessmentFormAssessmentAsset
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from AssessmentFormAssessmentAsset";

        // member variable for the AssessmentAssetId property
        private Guid _AssessmentAssetId;

        // member variable for the AssessmentFormId property
        private Guid _AssessmentFormId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the AssessmentFormAssessmentAssetViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="AssessmentAsset"/> model
        /// </summary>
        public Guid AssessmentAssetId { get => _AssessmentAssetId; set => SetProperty(ref _AssessmentAssetId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="AssessmentForm"/> model
        /// </summary>
        public Guid AssessmentFormId { get => _AssessmentFormId; set => SetProperty(ref _AssessmentFormId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAssessmentFormAssessmentAsset model)
        {
            IsBusy = true;
            Id = model.Id;
            AssessmentAssetId = model.AssessmentAssetId;
            AssessmentFormId = model.AssessmentFormId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
