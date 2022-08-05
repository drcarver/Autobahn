//**********************************************************
//* DomainName: Autobahn.LearningResource
//* FileName:   PeerRatingSystemViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.LearningResource.ViewModels
{
     /// <summary>
     /// The PeerRatingSystemViewModel
     /// </summary>
    public partial class PeerRatingSystemViewModel : ViewModelBase, Interfaces.IPeerRatingSystem
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PeerRatingSystem";

        // member variable for the Name property
        private System.String _Name;

        // member variable for the MaximumValue property
        private System.Decimal? _MaximumValue;

        // member variable for the MinimumValue property
        private System.Decimal _MinimumValue;

        // member variable for the OptimumValue property
        private System.Decimal? _OptimumValue;

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
        /// The title of the PeerRatingSystemViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        public System.String Name  { get => _Name; set => SetProperty(ref _Name, value); }

        public System.Decimal? MaximumValue { get => _MaximumValue; set => SetProperty(ref _MaximumValue, value); }

        public System.Decimal MinimumValue  { get => _MinimumValue; set => SetProperty(ref _MinimumValue, value); }

        public System.Decimal? OptimumValue { get => _OptimumValue; set => SetProperty(ref _OptimumValue, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPeerRatingSystem model)
        {
            IsBusy = true;
            Id = model.Id;
            Name = model.Name;
            MaximumValue = model.MaximumValue;
            MinimumValue = model.MinimumValue;
            OptimumValue = model.OptimumValue;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
