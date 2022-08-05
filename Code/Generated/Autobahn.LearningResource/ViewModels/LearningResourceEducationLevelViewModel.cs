//**********************************************************
//* DomainName: Autobahn.LearningResource
//* FileName:   LearningResourceEducationLevelViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.LearningResource.ViewModels
{
     /// <summary>
     /// The LearningResourceEducationLevelViewModel
     /// </summary>
    public partial class LearningResourceEducationLevelViewModel : ViewModelBase, Interfaces.ILearningResourceEducationLevel
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from LearningResourceEducationLevel";

        // member variable for the LearningResourceId property
        private Guid _LearningResourceId;

        // member variable for the RefEducationLevelId property
        private Guid _RefEducationLevelId;

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
        /// The title of the LearningResourceEducationLevelViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="LearningResourceId"/> model
        /// </summary>
        public Guid LearningResourceId { get => _LearningResourceId; set => SetProperty(ref _LearningResourceId, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefEducationLevelId"/> model
        /// </summary>
        public Guid RefEducationLevelId { get => _RefEducationLevelId; set => SetProperty(ref _RefEducationLevelId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.ILearningResourceEducationLevel model)
        {
            IsBusy = true;
            Id = model.Id;
            LearningResourceId = model.LearningResourceId;
            RefEducationLevelId = model.RefEducationLevelId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
