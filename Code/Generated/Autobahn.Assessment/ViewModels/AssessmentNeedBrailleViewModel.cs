//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentNeedBrailleViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.Assessment.ViewModels
{
     /// <summary>
     /// The AssessmentNeedBrailleViewModel
     /// </summary>
    public partial class AssessmentNeedBrailleViewModel : ViewModelBase, Interfaces.IAssessmentNeedBrailleViewModel
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from AssessmentNeedBraille";

        // member variable for the AssessmentPersonalNeedsProfileDisplayId property
        private Guid? _AssessmentPersonalNeedsProfileDisplayId;

        // member variable for the RefAssessmentNeedUsageTypeId property
        private Guid? _RefAssessmentNeedUsageTypeId;

        // member variable for the RefAssessmentNeedBrailleGradeTypeId property
        private Guid? _RefAssessmentNeedBrailleGradeTypeId;

        // member variable for the RefAssessmentNeedNumberOfBrailleDotsId property
        private Guid? _RefAssessmentNeedNumberOfBrailleDotsId;

        // member variable for the NumberOfBrailleCells property
        private System.Int32? _NumberOfBrailleCells;

        // member variable for the RefAssessmentNeedBrailleMarkTypeId property
        private Guid? _RefAssessmentNeedBrailleMarkTypeId;

        // member variable for the BrailleDotPressure property
        private System.Decimal? _BrailleDotPressure;

        // member variable for the RefAssessmentNeedBrailleStatusCellTypeId property
        private Guid? _RefAssessmentNeedBrailleStatusCellTypeId;

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
        /// The title of the AssessmentNeedBrailleViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="AssessmentPersonalNeedsProfileDisplayId"/> model
        /// </summary>
        public Guid? AssessmentPersonalNeedsProfileDisplayId { get => _AssessmentPersonalNeedsProfileDisplayId; set => SetProperty(ref _AssessmentPersonalNeedsProfileDisplayId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentNeedUsageTypeId"/> model
        /// </summary>
        public Guid? RefAssessmentNeedUsageTypeId { get => _RefAssessmentNeedUsageTypeId; set => SetProperty(ref _RefAssessmentNeedUsageTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentNeedBrailleGradeTypeId"/> model
        /// </summary>
        public Guid? RefAssessmentNeedBrailleGradeTypeId { get => _RefAssessmentNeedBrailleGradeTypeId; set => SetProperty(ref _RefAssessmentNeedBrailleGradeTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentNeedNumberOfBrailleDotsId"/> model
        /// </summary>
        public Guid? RefAssessmentNeedNumberOfBrailleDotsId { get => _RefAssessmentNeedNumberOfBrailleDotsId; set => SetProperty(ref _RefAssessmentNeedNumberOfBrailleDotsId, value); }

        public System.Int32? NumberOfBrailleCells { get => _NumberOfBrailleCells; set => SetProperty(ref _NumberOfBrailleCells, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentNeedBrailleMarkTypeId"/> model
        /// </summary>
        public Guid? RefAssessmentNeedBrailleMarkTypeId { get => _RefAssessmentNeedBrailleMarkTypeId; set => SetProperty(ref _RefAssessmentNeedBrailleMarkTypeId, value); }

        public System.Decimal? BrailleDotPressure { get => _BrailleDotPressure; set => SetProperty(ref _BrailleDotPressure, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentNeedBrailleStatusCellTypeId"/> model
        /// </summary>
        public Guid? RefAssessmentNeedBrailleStatusCellTypeId { get => _RefAssessmentNeedBrailleStatusCellTypeId; set => SetProperty(ref _RefAssessmentNeedBrailleStatusCellTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAssessmentNeedBraille model)
        {
            IsBusy = true;
            Id = model.Id;
            AssessmentPersonalNeedsProfileDisplayId = model.AssessmentPersonalNeedsProfileDisplayId;
            RefAssessmentNeedUsageTypeId = model.RefAssessmentNeedUsageTypeId;
            RefAssessmentNeedBrailleGradeTypeId = model.RefAssessmentNeedBrailleGradeTypeId;
            RefAssessmentNeedNumberOfBrailleDotsId = model.RefAssessmentNeedNumberOfBrailleDotsId;
            NumberOfBrailleCells = model.NumberOfBrailleCells;
            RefAssessmentNeedBrailleMarkTypeId = model.RefAssessmentNeedBrailleMarkTypeId;
            BrailleDotPressure = model.BrailleDotPressure;
            RefAssessmentNeedBrailleStatusCellTypeId = model.RefAssessmentNeedBrailleStatusCellTypeId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
