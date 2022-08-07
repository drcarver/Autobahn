//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentFormSection_AssessmentAssetViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.Assessment.ViewModels
{
     /// <summary>
     /// The AssessmentFormSection_AssessmentAssetViewModel
     /// </summary>
    public partial class AssessmentFormSection_AssessmentAssetViewModel : ViewModelBase, Interfaces.IAssessmentFormSection_AssessmentAssetViewModel
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from AssessmentFormSection_AssessmentAsset";

        // member variable for the AssessmentFormSectionId property
        private Guid _AssessmentFormSectionId;

        // member variable for the AssessmentAssetId property
        private Guid _AssessmentAssetId;

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
        /// The title of the AssessmentFormSection_AssessmentAssetViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentFormSectionId"/> model
        /// </summary>
        public Guid AssessmentFormSectionId { get => _AssessmentFormSectionId; set => SetProperty(ref _AssessmentFormSectionId, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentAssetId"/> model
        /// </summary>
        public Guid AssessmentAssetId { get => _AssessmentAssetId; set => SetProperty(ref _AssessmentAssetId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAssessmentFormSection_AssessmentAsset model)
        {
            IsBusy = true;
            Id = model.Id;
            AssessmentFormSectionId = model.AssessmentFormSectionId;
            AssessmentAssetId = model.AssessmentAssetId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
