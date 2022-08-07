//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentLevelsForWhichDesignedViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.Assessment.ViewModels
{
     /// <summary>
     /// The AssessmentLevelsForWhichDesignedViewModel
     /// </summary>
    public partial class AssessmentLevelsForWhichDesignedViewModel : ViewModelBase, Interfaces.IAssessmentLevelsForWhichDesignedViewModel
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from AssessmentLevelsForWhichDesigned";

        // member variable for the AssessmentId property
        private Guid _AssessmentId;

        // member variable for the RefGradeLevelId property
        private Guid _RefGradeLevelId;

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
        /// The title of the AssessmentLevelsForWhichDesignedViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentId"/> model
        /// </summary>
        public Guid AssessmentId { get => _AssessmentId; set => SetProperty(ref _AssessmentId, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefGradeLevelId"/> model
        /// </summary>
        public Guid RefGradeLevelId { get => _RefGradeLevelId; set => SetProperty(ref _RefGradeLevelId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAssessmentLevelsForWhichDesigned model)
        {
            IsBusy = true;
            Id = model.Id;
            AssessmentId = model.AssessmentId;
            RefGradeLevelId = model.RefGradeLevelId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
