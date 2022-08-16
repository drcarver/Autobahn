//**********************************************************
//* DomainName: Learning Resources
//* FileName:   LearningResourceMediaFeatureViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.LearningResources.ViewModels
{
     /// <summary>
     /// The LearningResourceMediaFeatureViewModel
     /// </summary>
    public partial class LearningResourceMediaFeatureViewModel : ViewModelBase, Interfaces.ILearningResourceMediaFeature
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from LearningResourceMediaFeature";

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefLearningResourceMediaFeatureTypeId property
        private Guid? _RefLearningResourceMediaFeatureTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLearningResourceMediaFeatureType"/> model
        /// </summary>
        public Guid? RefLearningResourceMediaFeatureTypeId { get => _RefLearningResourceMediaFeatureTypeId; set => SetProperty(ref _RefLearningResourceMediaFeatureTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.ILearningResourceMediaFeature model)
        {
            IsBusy = true;
            Id = model.Id;
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefLearningResourceMediaFeatureTypeId = model.RefLearningResourceMediaFeatureTypeId; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}