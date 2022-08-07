//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   LearnerActivity_LearningResourceViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.Assessment.ViewModels
{
     /// <summary>
     /// The LearnerActivity_LearningResourceViewModel
     /// </summary>
    public partial class LearnerActivity_LearningResourceViewModel : ViewModelBase, Interfaces.ILearnerActivity_LearningResourceViewModel
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from LearnerActivity_LearningResource";

        // member variable for the LearnerActivityId property
        private Guid _LearnerActivityId;

        // member variable for the LearningResourceId property
        private Guid _LearningResourceId;

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
        /// The title of the LearnerActivity_LearningResourceViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="LearnerActivityId"/> model
        /// </summary>
        public Guid LearnerActivityId { get => _LearnerActivityId; set => SetProperty(ref _LearnerActivityId, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="LearningResourceId"/> model
        /// </summary>
        public Guid LearningResourceId { get => _LearningResourceId; set => SetProperty(ref _LearningResourceId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.ILearnerActivity_LearningResource model)
        {
            IsBusy = true;
            Id = model.Id;
            LearnerActivityId = model.LearnerActivityId;
            LearningResourceId = model.LearningResourceId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
