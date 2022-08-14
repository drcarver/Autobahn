//**********************************************************
//* DomainName: Learning Resources
//* FileName:   LearningResourceAdaptationViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.LearningResources.ViewModels
{
     /// <summary>
     /// The LearningResourceAdaptationViewModel
     /// </summary>
    public partial class LearningResourceAdaptationViewModel : ViewModelBase, Interfaces.ILearningResourceAdaptation
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from LearningResourceAdaptation";

        // member variable for the AdaptationURL property
        private System.String _AdaptationURL;

        // member variable for the LearningResourceId property
        private Guid _LearningResourceId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the LearningResourceAdaptationViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The Uniform Resource Locator of a learning resource that is an adaptation for this resource.
        /// </summary>
        public System.String AdaptationURL { get => _AdaptationURL; set => SetProperty(ref _AdaptationURL, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="LearningResource"/> model
        /// </summary>
        public Guid LearningResourceId { get => _LearningResourceId; set => SetProperty(ref _LearningResourceId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.ILearningResourceAdaptation model)
        {
            IsBusy = true;
            Id = model.Id;
            AdaptationURL = model.AdaptationURL;
            LearningResourceId = model.LearningResourceId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
