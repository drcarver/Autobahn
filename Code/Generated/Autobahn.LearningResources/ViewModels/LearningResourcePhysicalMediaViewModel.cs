//**********************************************************
//* DomainName: Learning Resources
//* FileName:   LearningResourcePhysicalMediaViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.LearningResources.ViewModels
{
     /// <summary>
     /// The LearningResourcePhysicalMediaViewModel
     /// </summary>
    public partial class LearningResourcePhysicalMediaViewModel : ViewModelBase, Interfaces.ILearningResourcePhysicalMedia
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from LearningResourcePhysicalMedia";

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefLearningResourcePhysicalMediaTypeId property
        private Guid? _RefLearningResourcePhysicalMediaTypeId;

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
        /// Reference to an optional instance of the <see cref="RefLearningResourcePhysicalMediaType"/> model
        /// </summary>
        public Guid? RefLearningResourcePhysicalMediaTypeId { get => _RefLearningResourcePhysicalMediaTypeId; set => SetProperty(ref _RefLearningResourcePhysicalMediaTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.ILearningResourcePhysicalMedia model)
        {
            IsBusy = true;
            Id = model.Id;
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefLearningResourcePhysicalMediaTypeId = model.RefLearningResourcePhysicalMediaTypeId; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
