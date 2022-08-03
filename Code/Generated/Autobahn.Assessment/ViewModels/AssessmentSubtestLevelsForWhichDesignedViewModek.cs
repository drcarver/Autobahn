//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentSubtestLevelsForWhichDesignedViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Assessment.Interfaces;

namespace Autobahn.Assessment.ViewModels
{
     /// <summary>
     /// The AssessmentSubtestLevelsForWhichDesignedViewModel
     /// </summary>
    public partial class AssessmentSubtestLevelsForWhichDesignedViewModel : BindableBase, IAssessmentSubtestLevelsForWhichDesigned
    {
#region "Backing Fields"
        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

#endregion

#region Properties
        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentSubTestId"/> model
        /// </summary>
        public Guid AssessmentSubTestId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefGradeId"/> model
        /// </summary>
        public Guid RefGradeId { get; set; }

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
        public void Load(IAssessmentSubtestLevelsForWhichDesigned model)
        {
            IsBusy = true;
            Id = model.Id;
            AssessmentSubTestId = model.AssessmentSubTestId;
            RefGradeId = model.RefGradeId;
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
