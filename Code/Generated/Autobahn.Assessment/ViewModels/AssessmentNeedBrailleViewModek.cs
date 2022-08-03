//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentNeedBrailleViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Assessment.Interfaces;

namespace Autobahn.Assessment.ViewModels
{
     /// <summary>
     /// The AssessmentNeedBrailleViewModel
     /// </summary>
    public partial class AssessmentNeedBrailleViewModel : BindableBase, IAssessmentNeedBraille
    {
#region "Backing Fields"
        // member variable for the NumberOfBrailleCells property
        private System.Int32? _NumberOfBrailleCells;

        // member variable for the BrailleDotPressure property
        private System.Decimal? _BrailleDotPressure;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

#endregion

#region Properties
        /// <summary>
        /// Reference to an optional instance of the <see cref="AssessmentPersonalNeedsProfileDisplayId"/> model
        /// </summary>
        public Guid? AssessmentPersonalNeedsProfileDisplayId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentNeedUsageTypeId"/> model
        /// </summary>
        public Guid? RefAssessmentNeedUsageTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentNeedBrailleGradeTypeId"/> model
        /// </summary>
        public Guid? RefAssessmentNeedBrailleGradeTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentNeedNumberOfBrailleDotsId"/> model
        /// </summary>
        public Guid? RefAssessmentNeedNumberOfBrailleDotsId { get; set; }

        public System.Int32? NumberOfBrailleCells { get => _NumberOfBrailleCells; set => SetProperty(ref _NumberOfBrailleCells, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentNeedBrailleMarkTypeId"/> model
        /// </summary>
        public Guid? RefAssessmentNeedBrailleMarkTypeId { get; set; }

        public System.Decimal? BrailleDotPressure { get => _BrailleDotPressure; set => SetProperty(ref _BrailleDotPressure, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentNeedBrailleStatusCellTypeId"/> model
        /// </summary>
        public Guid? RefAssessmentNeedBrailleStatusCellTypeId { get; set; }

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
        public void Load(IAssessmentNeedBraille model)
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
