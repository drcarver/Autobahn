//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentSubtestLevelsForWhichDesignedViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.Assessment.ViewModels
{
     /// <summary>
     /// The AssessmentSubtestLevelsForWhichDesignedViewModel
     /// </summary>
    public partial class AssessmentSubtestLevelsForWhichDesignedViewModel : ViewModelBase, Interfaces.IAssessmentSubtestLevelsForWhichDesignedViewModel
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from AssessmentSubtestLevelsForWhichDesigned";

        // member variable for the AssessmentSubTestId property
        private Guid _AssessmentSubTestId;

        // member variable for the RefGradeId property
        private Guid _RefGradeId;

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
        /// The title of the AssessmentSubtestLevelsForWhichDesignedViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentSubTestId"/> model
        /// </summary>
        public Guid AssessmentSubTestId { get => _AssessmentSubTestId; set => SetProperty(ref _AssessmentSubTestId, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefGradeId"/> model
        /// </summary>
        public Guid RefGradeId { get => _RefGradeId; set => SetProperty(ref _RefGradeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAssessmentSubtestLevelsForWhichDesigned model)
        {
            IsBusy = true;
            Id = model.Id;
            AssessmentSubTestId = model.AssessmentSubTestId;
            RefGradeId = model.RefGradeId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
