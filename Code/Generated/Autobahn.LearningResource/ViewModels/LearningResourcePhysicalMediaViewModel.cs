//**********************************************************
//* DomainName: Autobahn.LearningResource
//* FileName:   LearningResourcePhysicalMediaViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.LearningResource.ViewModels
{
     /// <summary>
     /// The LearningResourcePhysicalMediaViewModel
     /// </summary>
    public partial class LearningResourcePhysicalMediaViewModel : ViewModelBase, Interfaces.ILearningResourcePhysicalMediaViewModel
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from LearningResourcePhysicalMedia";

        // member variable for the LearningResourceId property
        private Guid _LearningResourceId;

        // member variable for the RefLearningResourcePhysicalMediaTypeId property
        private Guid _RefLearningResourcePhysicalMediaTypeId;

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
        /// The title of the LearningResourcePhysicalMediaViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="LearningResourceId"/> model
        /// </summary>
        public Guid LearningResourceId { get => _LearningResourceId; set => SetProperty(ref _LearningResourceId, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefLearningResourcePhysicalMediaTypeId"/> model
        /// </summary>
        public Guid RefLearningResourcePhysicalMediaTypeId { get => _RefLearningResourcePhysicalMediaTypeId; set => SetProperty(ref _RefLearningResourcePhysicalMediaTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.ILearningResourcePhysicalMedia model)
        {
            IsBusy = true;
            Id = model.Id;
            LearningResourceId = model.LearningResourceId;
            RefLearningResourcePhysicalMediaTypeId = model.RefLearningResourcePhysicalMediaTypeId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
