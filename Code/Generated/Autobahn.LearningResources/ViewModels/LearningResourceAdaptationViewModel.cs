//**********************************************************
//* DomainName: Learning Resources
//* FileName:   LearningResourceAdaptationViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

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

        #endregion

        #region Properties
        /// <summary>
        /// The title of the LearningResourceAdaptationViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The Uniform Resource Locator of a learning resource that is an adaptation for this resource.
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20361">Learning Resource Adaptation URL</a>
        /// </para>
        /// </summary>
        [DisplayName("Learning Resource Adaptation URL")]
        public System.String AdaptationURL { get => _AdaptationURL; set => SetProperty(ref _AdaptationURL, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.ILearningResourceAdaptation model)
        {
            IsBusy = true;
            Id = model.Id;
            AdaptationURL = model.AdaptationURL; // Learning Resource Adaptation URL
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
