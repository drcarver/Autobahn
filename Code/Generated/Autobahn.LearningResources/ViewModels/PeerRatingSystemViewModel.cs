//**********************************************************
//* DomainName: Learning Resources
//* FileName:   PeerRatingSystemViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.LearningResources.ViewModels
{
     /// <summary>
     /// The PeerRatingSystemViewModel
     /// </summary>
    public partial class PeerRatingSystemViewModel : ViewModelBase, Interfaces.IPeerRatingSystem
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PeerRatingSystem";

        // member variable for the MaximumValue property
        private System.Decimal? _MaximumValue;

        // member variable for the MinimumValue property
        private System.Decimal _MinimumValue;

        // member variable for the Name property
        private System.String _Name;

        // member variable for the OptimumValue property
        private System.Decimal? _OptimumValue;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the PeerRatingSystemViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The name of the scaling system used to specify the Peer Rating.
        /// </summary>
        public System.Decimal? MaximumValue { get => _MaximumValue; set => SetProperty(ref _MaximumValue, value); }

        /// <summary>
        /// The name of the scaling system used to specify the Peer Rating.
        /// </summary>
        public System.Decimal MinimumValue { get => _MinimumValue; set => SetProperty(ref _MinimumValue, value); }

        /// <summary>
        /// The name of the scaling system used to specify the Peer Rating.
        /// </summary>
        public System.String Name { get => _Name; set => SetProperty(ref _Name, value); }

        /// <summary>
        /// The name of the scaling system used to specify the Peer Rating.
        /// </summary>
        public System.Decimal? OptimumValue { get => _OptimumValue; set => SetProperty(ref _OptimumValue, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPeerRatingSystem model)
        {
            IsBusy = true;
            Id = model.Id;
            MaximumValue = model.MaximumValue;
            MinimumValue = model.MinimumValue;
            Name = model.Name;
            OptimumValue = model.OptimumValue;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
