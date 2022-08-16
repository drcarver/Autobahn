//**********************************************************
//* DomainName: Learning Resources
//* FileName:   LearningResourceEducationLevelViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.LearningResources.ViewModels
{
     /// <summary>
     /// The LearningResourceEducationLevelViewModel
     /// </summary>
    public partial class LearningResourceEducationLevelViewModel : ViewModelBase, Interfaces.ILearningResourceEducationLevel
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from LearningResourceEducationLevel";

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefEducationLevelId property
        private Guid? _RefEducationLevelId;

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
        /// Reference to an optional instance of the <see cref="RefEducationLevel"/> model
        /// </summary>
        public Guid? RefEducationLevelId { get => _RefEducationLevelId; set => SetProperty(ref _RefEducationLevelId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.ILearningResourceEducationLevel model)
        {
            IsBusy = true;
            Id = model.Id;
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefEducationLevelId = model.RefEducationLevelId; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
