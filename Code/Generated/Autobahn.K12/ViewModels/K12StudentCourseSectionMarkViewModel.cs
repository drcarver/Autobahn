//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12StudentCourseSectionMarkViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

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

        // member variable for the FinalIndicator property
        private  _FinalIndicator;

        // member variable for the GradeEarned property
        private Guid? _GradeEarned;

        // member variable for the GradeValueQualifier property
        private  _GradeValueQualifier;

        // member variable for the MarkingPeriodName property
        private  _MarkingPeriodName;

        // member variable for the MidTermMark property
        private  _MidTermMark;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the StudentCourseSectionGradeNarrative property
        private  _StudentCourseSectionGradeNarrative;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public  FinalIndicator { get => _FinalIndicator; set => SetProperty(ref _FinalIndicator, value); }

        /// <summary>
        /// </summary>
        public Guid? GradeEarned { get => _GradeEarned; set => SetProperty(ref _GradeEarned, value); }

        /// <summary>
        /// </summary>
        public  GradeValueQualifier { get => _GradeValueQualifier; set => SetProperty(ref _GradeValueQualifier, value); }

        /// <summary>
        /// </summary>
        public  MarkingPeriodName { get => _MarkingPeriodName; set => SetProperty(ref _MarkingPeriodName, value); }

        /// <summary>
        /// </summary>
        public  MidTermMark { get => _MidTermMark; set => SetProperty(ref _MidTermMark, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// </summary>
        public  StudentCourseSectionGradeNarrative { get => _StudentCourseSectionGradeNarrative; set => SetProperty(ref _StudentCourseSectionGradeNarrative, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IK12StudentCourseSectionMark model)
        {
            IsBusy = true;
            Id = model.Id;
            FinalIndicator = model.FinalIndicator; // 
            GradeEarned = model.GradeEarned; // 
            GradeValueQualifier = model.GradeValueQualifier; // 
            MarkingPeriodName = model.MarkingPeriodName; // 
            MidTermMark = model.MidTermMark; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            StudentCourseSectionGradeNarrative = model.StudentCourseSectionGradeNarrative; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
