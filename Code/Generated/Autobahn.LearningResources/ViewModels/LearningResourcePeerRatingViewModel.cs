//**********************************************************
//* DomainName: Learning Resources
//* FileName:   LearningResourcePeerRatingViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.LearningResources.ViewModels
{
     /// <summary>
     /// The LearningResourcePeerRatingViewModel
     /// </summary>
    public partial class LearningResourcePeerRatingViewModel : ViewModelBase, Interfaces.ILearningResourcePeerRating
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from LearningResourcePeerRating";

        #endregion

        #region Properties
        /// <summary>
        /// The title of the LearningResourcePeerRatingViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.ILearningResourcePeerRating model)
        {
            IsBusy = true;
            Id = model.Id;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
