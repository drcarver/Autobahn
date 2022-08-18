//**********************************************************
//* DomainName: Learning Resources
//* FileName:   LearningResourceAdaptationViewModel.cs
//* Name:       Learning Resource Adaptation URL
//* Definition: The Uniform Resource Locator of a learning resource that is an adaptation for this resource.
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.LearningResources.ViewModels
{
     /// <summary>
     /// The Uniform Resource Locator of a learning resource that is an adaptation for this resource.
     /// </summary>
    public partial class LearningResourceAdaptationViewModel : ViewModelBase, Interfaces.ILearningResourceAdaptation
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from LearningResourceAdaptation";

        // AdaptationURL -- (backing property for Learning Resource Adaptation URL)
        private System.String _AdaptationURL;

        // member variable for the LearningResourceId property
        private Guid _LearningResourceId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Learning Resource Adaptation URL
        /// <para>
        /// The Uniform Resource Locator of a learning resource that is an adaptation for this resource.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20361">Learning Resource Adaptation URL</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String AdaptationURL { get => _AdaptationURL; set => SetProperty(ref _AdaptationURL, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="ILearningResource"/> model
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
            AdaptationURL = model.AdaptationURL; // Learning Resource Adaptation URL
            LearningResourceId = model.LearningResourceId; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
