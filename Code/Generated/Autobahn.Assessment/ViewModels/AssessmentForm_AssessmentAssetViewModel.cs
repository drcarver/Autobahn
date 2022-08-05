//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentForm_AssessmentAssetViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.Assessment.ViewModels
{
     /// <summary>
     /// The AssessmentForm_AssessmentAssetViewModel
     /// </summary>
    public partial class AssessmentForm_AssessmentAssetViewModel : ViewModelBase, Interfaces.IAssessmentForm_AssessmentAsset
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from AssessmentForm_AssessmentAsset";

        // member variable for the AssessmentFormId property
        private Guid _AssessmentFormId;

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
        /// The title of the AssessmentForm_AssessmentAssetViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentFormId"/> model
        /// </summary>
        public Guid AssessmentFormId { get => _AssessmentFormId; set => SetProperty(ref _AssessmentFormId, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentAssetId"/> model
        /// </summary>
        public Guid AssessmentAssetId { get => _AssessmentAssetId; set => SetProperty(ref _AssessmentAssetId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAssessmentForm_AssessmentAsset model)
        {
            IsBusy = true;
            Id = model.Id;
            AssessmentFormId = model.AssessmentFormId;
            AssessmentAssetId = model.AssessmentAssetId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
