//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   K12StudentCourseSectionMarkViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.K12.Interfaces;

namespace Autobahn.K12.ViewModels
{
     /// <summary>
     /// The K12StudentCourseSectionMarkViewModel
     /// </summary>
    public partial class K12StudentCourseSectionMarkViewModel : BindableBase, IK12StudentCourseSectionMark
    {
#region "Backing Fields"
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

#endregion

#region Properties
        /// <summary>
        /// Reference to a required instance of the <see cref="K12StudentCourseSectionId"/> model
        /// </summary>
        public Guid K12StudentCourseSectionId { get; set; }

        public System.String MarkingPeriodName  { get => _MarkingPeriodName; set => SetProperty(ref _MarkingPeriodName, value); }

        public System.Boolean? FinalIndicator { get => _FinalIndicator; set => SetProperty(ref _FinalIndicator, value); }

        public System.String GradeEarned  { get => _GradeEarned; set => SetProperty(ref _GradeEarned, value); }

        public System.String MidTermMark  { get => _MidTermMark; set => SetProperty(ref _MidTermMark, value); }

        public System.String GradeValueQualifier  { get => _GradeValueQualifier; set => SetProperty(ref _GradeValueQualifier, value); }

        public System.String StudentCourseSectionGradeNarrative  { get => _StudentCourseSectionGradeNarrative; set => SetProperty(ref _StudentCourseSectionGradeNarrative, value); }

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
        public void Load(IK12StudentCourseSectionMark model)
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
