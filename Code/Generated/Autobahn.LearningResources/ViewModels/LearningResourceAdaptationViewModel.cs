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
        private Guid? _AdaptationURL;

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
        public Guid? AdaptationURL { get => _AdaptationURL; set => SetProperty(ref _AdaptationURL, value); }

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
        public void Load(Interfaces.ILearningResourceAdaptation model)
        {
            IsBusy = true;
            Id = model.Id;
            AdaptationURL = model.AdaptationURL; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
