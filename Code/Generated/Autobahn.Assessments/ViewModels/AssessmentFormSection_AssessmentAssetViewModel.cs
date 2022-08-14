//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentFormSection_AssessmentAssetViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.Assessments.ViewModels
{
     /// <summary>
     /// The AssessmentFormSection_AssessmentAssetViewModel
     /// </summary>
    public partial class AssessmentFormSection_AssessmentAssetViewModel : ViewModelBase, Interfaces.IAssessmentFormSection_AssessmentAsset
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from AssessmentFormSection_AssessmentAsset";

        // member variable for the AssessmentAssetId property
        private Guid _AssessmentAssetId;

        // member variable for the AssessmentFormSectionId property
        private Guid _AssessmentFormSectionId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the AssessmentFormSection_AssessmentAssetViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="AssessmentAsset"/> model
        /// </summary>
        public Guid AssessmentAssetId { get => _AssessmentAssetId; set => SetProperty(ref _AssessmentAssetId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="AssessmentFormSection"/> model
        /// </summary>
        public Guid AssessmentFormSectionId { get => _AssessmentFormSectionId; set => SetProperty(ref _AssessmentFormSectionId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAssessmentFormSection_AssessmentAsset model)
        {
            IsBusy = true;
            Id = model.Id;
            AssessmentAssetId = model.AssessmentAssetId;
            AssessmentFormSectionId = model.AssessmentFormSectionId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
