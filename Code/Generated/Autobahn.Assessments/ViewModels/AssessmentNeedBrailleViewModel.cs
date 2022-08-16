//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentNeedBrailleViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Assessments.ViewModels
{
     /// <summary>
     /// The AssessmentNeedBrailleViewModel
     /// </summary>
    public partial class AssessmentNeedBrailleViewModel : ViewModelBase, Interfaces.IAssessmentNeedBraille
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from AssessmentNeedBraille";

        // member variable for the BrailleDotPressure property
        private  _BrailleDotPressure;

        // member variable for the NumberOfBrailleCells property
        private  _NumberOfBrailleCells;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefAssessmentNeedBrailleGradeTypeId property
        private  _RefAssessmentNeedBrailleGradeTypeId;

        // member variable for the RefAssessmentNeedBrailleMarkTypeId property
        private  _RefAssessmentNeedBrailleMarkTypeId;

        // member variable for the RefAssessmentNeedBrailleStatusCellTypeId property
        private  _RefAssessmentNeedBrailleStatusCellTypeId;

        // member variable for the RefAssessmentNeedNumberOfBrailleDotsId property
        private  _RefAssessmentNeedNumberOfBrailleDotsId;

        // member variable for the RefAssessmentNeedUsageTypeId property
        private Guid? _RefAssessmentNeedUsageTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public  BrailleDotPressure { get => _BrailleDotPressure; set => SetProperty(ref _BrailleDotPressure, value); }

        /// <summary>
        /// </summary>
        public  NumberOfBrailleCells { get => _NumberOfBrailleCells; set => SetProperty(ref _NumberOfBrailleCells, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentNeedBrailleGradeType"/> model
        /// </summary>
        public  RefAssessmentNeedBrailleGradeTypeId { get => _RefAssessmentNeedBrailleGradeTypeId; set => SetProperty(ref _RefAssessmentNeedBrailleGradeTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentNeedBrailleMarkType"/> model
        /// </summary>
        public  RefAssessmentNeedBrailleMarkTypeId { get => _RefAssessmentNeedBrailleMarkTypeId; set => SetProperty(ref _RefAssessmentNeedBrailleMarkTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentNeedBrailleStatusCellType"/> model
        /// </summary>
        public  RefAssessmentNeedBrailleStatusCellTypeId { get => _RefAssessmentNeedBrailleStatusCellTypeId; set => SetProperty(ref _RefAssessmentNeedBrailleStatusCellTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentNeedNumberOfBrailleDots"/> model
        /// </summary>
        public  RefAssessmentNeedNumberOfBrailleDotsId { get => _RefAssessmentNeedNumberOfBrailleDotsId; set => SetProperty(ref _RefAssessmentNeedNumberOfBrailleDotsId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentNeedUsageType"/> model
        /// </summary>
        public Guid? RefAssessmentNeedUsageTypeId { get => _RefAssessmentNeedUsageTypeId; set => SetProperty(ref _RefAssessmentNeedUsageTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAssessmentNeedBraille model)
        {
            IsBusy = true;
            Id = model.Id;
            BrailleDotPressure = model.BrailleDotPressure; // 
            NumberOfBrailleCells = model.NumberOfBrailleCells; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefAssessmentNeedBrailleGradeTypeId = model.RefAssessmentNeedBrailleGradeTypeId; // 
            RefAssessmentNeedBrailleMarkTypeId = model.RefAssessmentNeedBrailleMarkTypeId; // 
            RefAssessmentNeedBrailleStatusCellTypeId = model.RefAssessmentNeedBrailleStatusCellTypeId; // 
            RefAssessmentNeedNumberOfBrailleDotsId = model.RefAssessmentNeedNumberOfBrailleDotsId; // 
            RefAssessmentNeedUsageTypeId = model.RefAssessmentNeedUsageTypeId; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
