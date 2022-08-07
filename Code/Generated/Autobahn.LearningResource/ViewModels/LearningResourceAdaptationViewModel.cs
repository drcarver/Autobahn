//**********************************************************
//* DomainName: Autobahn.LearningResource
//* FileName:   LearningResourceAdaptationViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.LearningResource.ViewModels
{
     /// <summary>
     /// The LearningResourceAdaptationViewModel
     /// </summary>
    public partial class LearningResourceAdaptationViewModel : ViewModelBase, Interfaces.ILearningResourceAdaptationViewModel
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from LearningResourceAdaptation";

        // member variable for the LearningResourceId property
        private Guid _LearningResourceId;

        // member variable for the AdaptationURL property
        private System.String _AdaptationURL;

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
        /// The title of the LearningResourceAdaptationViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="LearningResourceId"/> model
        /// </summary>
        public Guid LearningResourceId { get => _LearningResourceId; set => SetProperty(ref _LearningResourceId, value); }

        public System.String AdaptationURL  { get => _AdaptationURL; set => SetProperty(ref _AdaptationURL, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.ILearningResourceAdaptation model)
        {
            IsBusy = true;
            Id = model.Id;
            LearningResourceId = model.LearningResourceId;
            AdaptationURL = model.AdaptationURL;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
