//**********************************************************
//* DomainName: Learning Resources
//* FileName:   PeerRatingSystemViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

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
        private  _MaximumValue;

        // member variable for the MinimumValue property
        private  _MinimumValue;

        // member variable for the Name property
        private Guid? _Name;

        // member variable for the OptimumValue property
        private  _OptimumValue;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public  MaximumValue { get => _MaximumValue; set => SetProperty(ref _MaximumValue, value); }

        /// <summary>
        /// </summary>
        public  MinimumValue { get => _MinimumValue; set => SetProperty(ref _MinimumValue, value); }

        /// <summary>
        /// </summary>
        public Guid? Name { get => _Name; set => SetProperty(ref _Name, value); }

        /// <summary>
        /// </summary>
        public  OptimumValue { get => _OptimumValue; set => SetProperty(ref _OptimumValue, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPeerRatingSystem model)
        {
            IsBusy = true;
            Id = model.Id;
            MaximumValue = model.MaximumValue; // 
            MinimumValue = model.MinimumValue; // 
            Name = model.Name; // 
            OptimumValue = model.OptimumValue; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
