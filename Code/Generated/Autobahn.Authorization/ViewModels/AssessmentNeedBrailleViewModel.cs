//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   AssessmentNeedBrailleViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;
using CommunityToolkit.Maui;

namespace Autobahn.Authorization.ViewModels
{
     /// <summary>
     /// The AssessmentNeedBrailleViewModel
     /// </summary>
    public partial class AssessmentNeedBrailleViewModel : ViewModelBase, Interfaces.IAssessmentNeedBraille
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from AssessmentNeedBraille";

        // member variable for the AssessmentPersonalNeedsProfileDisplayId property
        private Guid? _AssessmentPersonalNeedsProfileDisplayId;

        // member variable for the BrailleDotPressure property
        private System.Decimal? _BrailleDotPressure;

        // member variable for the NumberOfBrailleCells property
        private System.Int32? _NumberOfBrailleCells;

        // member variable for the RefAssessmentNeedBrailleGradeTypeId property
        private Guid? _RefAssessmentNeedBrailleGradeTypeId;

        // member variable for the RefAssessmentNeedBrailleMarkTypeId property
        private Guid? _RefAssessmentNeedBrailleMarkTypeId;

        // member variable for the RefAssessmentNeedBrailleStatusCellTypeId property
        private Guid? _RefAssessmentNeedBrailleStatusCellTypeId;

        // member variable for the RefAssessmentNeedNumberOfBrailleDotsId property
        private Guid? _RefAssessmentNeedNumberOfBrailleDotsId;

        // member variable for the RefAssessmentNeedUsageTypeId property
        private Guid? _RefAssessmentNeedUsageTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the AssessmentNeedBrailleViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="AssessmentPersonalNeedsProfileDisplay"/> model
        /// </summary>
        public Guid? AssessmentPersonalNeedsProfileDisplayId { get => _AssessmentPersonalNeedsProfileDisplayId; set => SetProperty(ref _AssessmentPersonalNeedsProfileDisplayId, value); }

        /// <summary>
        /// Defines as part of an Assessment Personal Needs Profile the rating for the collection of Access for All (AfA) needs and preferences.
        /// </summary>
        public System.Decimal? BrailleDotPressure { get => _BrailleDotPressure; set => SetProperty(ref _BrailleDotPressure, value); }

        /// <summary>
        /// Defines as part of an Assessment Personal Needs Profile the rating for the collection of Access for All (AfA) needs and preferences.
        /// </summary>
        public System.Int32? NumberOfBrailleCells { get => _NumberOfBrailleCells; set => SetProperty(ref _NumberOfBrailleCells, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentNeedBrailleGradeType"/> model
        /// </summary>
        public Guid? RefAssessmentNeedBrailleGradeTypeId { get => _RefAssessmentNeedBrailleGradeTypeId; set => SetProperty(ref _RefAssessmentNeedBrailleGradeTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentNeedBrailleMarkType"/> model
        /// </summary>
        public Guid? RefAssessmentNeedBrailleMarkTypeId { get => _RefAssessmentNeedBrailleMarkTypeId; set => SetProperty(ref _RefAssessmentNeedBrailleMarkTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentNeedBrailleStatusCellType"/> model
        /// </summary>
        public Guid? RefAssessmentNeedBrailleStatusCellTypeId { get => _RefAssessmentNeedBrailleStatusCellTypeId; set => SetProperty(ref _RefAssessmentNeedBrailleStatusCellTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentNeedNumberOfBrailleDots"/> model
        /// </summary>
        public Guid? RefAssessmentNeedNumberOfBrailleDotsId { get => _RefAssessmentNeedNumberOfBrailleDotsId; set => SetProperty(ref _RefAssessmentNeedNumberOfBrailleDotsId, value); }

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
            AssessmentPersonalNeedsProfileDisplayId = model.AssessmentPersonalNeedsProfileDisplayId;
            BrailleDotPressure = model.BrailleDotPressure;
            NumberOfBrailleCells = model.NumberOfBrailleCells;
            RefAssessmentNeedBrailleGradeTypeId = model.RefAssessmentNeedBrailleGradeTypeId;
            RefAssessmentNeedBrailleMarkTypeId = model.RefAssessmentNeedBrailleMarkTypeId;
            RefAssessmentNeedBrailleStatusCellTypeId = model.RefAssessmentNeedBrailleStatusCellTypeId;
            RefAssessmentNeedNumberOfBrailleDotsId = model.RefAssessmentNeedNumberOfBrailleDotsId;
            RefAssessmentNeedUsageTypeId = model.RefAssessmentNeedUsageTypeId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
