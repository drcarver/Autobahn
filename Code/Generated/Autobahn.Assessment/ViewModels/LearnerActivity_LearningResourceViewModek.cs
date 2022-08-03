//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   LearnerActivity_LearningResourceViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Assessment.Interfaces;

namespace Autobahn.Assessment.ViewModels
{
     /// <summary>
     /// The LearnerActivity_LearningResourceViewModel
     /// </summary>
    public partial class LearnerActivity_LearningResourceViewModel : BindableBase, ILearnerActivity_LearningResource
    {
#region "Backing Fields"
        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

#endregion

#region Properties
        /// <summary>
        /// Reference to a required instance of the <see cref="LearnerActivityId"/> model
        /// </summary>
        public Guid LearnerActivityId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="LearningResourceId"/> model
        /// </summary>
        public Guid LearningResourceId { get; set; }

        public System.DateTime? RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        public System.DateTime? RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatusId"/> model
        /// </summary>
        public Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollectionId"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

#endregion


        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(ILearnerActivity_LearningResource model)
        {
            IsBusy = true;
            Id = model.Id;
            LearnerActivityId = model.LearnerActivityId;
            LearningResourceId = model.LearningResourceId;
            RecordStartDateTime = model.RecordStartDateTime;
            RecordEndDateTime = model.RecordEndDateTime;
            RecordStatusId = model.RecordStatusId;
            DataCollectionId = model.DataCollectionId;
            IsChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
