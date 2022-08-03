//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentLevelsForWhichDesignedViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Assessment.Interfaces;

namespace Autobahn.Assessment.ViewModels
{
     /// <summary>
     /// The AssessmentLevelsForWhichDesignedViewModel
     /// </summary>
    public partial class AssessmentLevelsForWhichDesignedViewModel : BindableBase, IAssessmentLevelsForWhichDesigned
    {
#region "Backing Fields"
        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

#endregion

#region Properties
        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentId"/> model
        /// </summary>
        public Guid AssessmentId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefGradeLevelId"/> model
        /// </summary>
        public Guid RefGradeLevelId { get; set; }

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
        public void Load(IAssessmentLevelsForWhichDesigned model)
        {
            IsBusy = true;
            Id = model.Id;
            AssessmentId = model.AssessmentId;
            RefGradeLevelId = model.RefGradeLevelId;
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