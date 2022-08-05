//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   K12StudentCourseSectionMarkViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.K12.ViewModels
{
     /// <summary>
     /// The K12StudentCourseSectionMarkViewModel
     /// </summary>
    public partial class K12StudentCourseSectionMarkViewModel : ViewModelBase, Interfaces.IK12StudentCourseSectionMark
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from K12StudentCourseSectionMark";

        // member variable for the K12StudentCourseSectionId property
        private Guid _K12StudentCourseSectionId;

        // member variable for the MarkingPeriodName property
        private System.String _MarkingPeriodName;

        // member variable for the FinalIndicator property
        private System.Boolean? _FinalIndicator;

        // member variable for the GradeEarned property
        private System.String _GradeEarned;

        // member variable for the MidTermMark property
        private System.String _MidTermMark;

        // member variable for the GradeValueQualifier property
        private System.String _GradeValueQualifier;

        // member variable for the StudentCourseSectionGradeNarrative property
        private System.String _StudentCourseSectionGradeNarrative;

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
        /// The title of the K12StudentCourseSectionMarkViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="K12StudentCourseSectionId"/> model
        /// </summary>
        public Guid K12StudentCourseSectionId { get => _K12StudentCourseSectionId; set => SetProperty(ref _K12StudentCourseSectionId, value); }

        public System.String MarkingPeriodName  { get => _MarkingPeriodName; set => SetProperty(ref _MarkingPeriodName, value); }

        public System.Boolean? FinalIndicator { get => _FinalIndicator; set => SetProperty(ref _FinalIndicator, value); }

        public System.String GradeEarned  { get => _GradeEarned; set => SetProperty(ref _GradeEarned, value); }

        public System.String MidTermMark  { get => _MidTermMark; set => SetProperty(ref _MidTermMark, value); }

        public System.String GradeValueQualifier  { get => _GradeValueQualifier; set => SetProperty(ref _GradeValueQualifier, value); }

        public System.String StudentCourseSectionGradeNarrative  { get => _StudentCourseSectionGradeNarrative; set => SetProperty(ref _StudentCourseSectionGradeNarrative, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IK12StudentCourseSectionMark model)
        {
            IsBusy = true;
            Id = model.Id;
            K12StudentCourseSectionId = model.K12StudentCourseSectionId;
            MarkingPeriodName = model.MarkingPeriodName;
            FinalIndicator = model.FinalIndicator;
            GradeEarned = model.GradeEarned;
            MidTermMark = model.MidTermMark;
            GradeValueQualifier = model.GradeValueQualifier;
            StudentCourseSectionGradeNarrative = model.StudentCourseSectionGradeNarrative;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
