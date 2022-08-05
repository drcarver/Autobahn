//**********************************************************
//* DomainName: Autobahn.LearningResource
//* FileName:   LearningResourceMediaFeatureViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.LearningResource.ViewModels
{
     /// <summary>
     /// The LearningResourceMediaFeatureViewModel
     /// </summary>
    public partial class LearningResourceMediaFeatureViewModel : ViewModelBase, Interfaces.ILearningResourceMediaFeature
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from LearningResourceMediaFeature";

        // member variable for the LearningResourceId property
        private Guid _LearningResourceId;

        // member variable for the RefLearningResourceMediaFeatureTypeId property
        private Guid _RefLearningResourceMediaFeatureTypeId;

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
        /// The title of the LearningResourceMediaFeatureViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="LearningResourceId"/> model
        /// </summary>
        public Guid LearningResourceId { get => _LearningResourceId; set => SetProperty(ref _LearningResourceId, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefLearningResourceMediaFeatureTypeId"/> model
        /// </summary>
        public Guid RefLearningResourceMediaFeatureTypeId { get => _RefLearningResourceMediaFeatureTypeId; set => SetProperty(ref _RefLearningResourceMediaFeatureTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.ILearningResourceMediaFeature model)
        {
            IsBusy = true;
            Id = model.Id;
            LearningResourceId = model.LearningResourceId;
            RefLearningResourceMediaFeatureTypeId = model.RefLearningResourceMediaFeatureTypeId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
