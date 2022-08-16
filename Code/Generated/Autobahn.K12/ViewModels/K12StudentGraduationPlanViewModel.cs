//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12StudentGraduationPlanViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.K12.ViewModels
{
     /// <summary>
     /// The K12StudentGraduationPlanViewModel
     /// </summary>
    public partial class K12StudentGraduationPlanViewModel : ViewModelBase, Interfaces.IK12StudentGraduationPlan
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from K12StudentGraduationPlan";

        // member variable for the CreditsRequired property
        private  _CreditsRequired;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefGradeLevelWhenCourseTakenId property
        private Guid? _RefGradeLevelWhenCourseTakenId;

        // member variable for the RefSCEDCourseSubjectAreaId property
        private  _RefSCEDCourseSubjectAreaId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public  CreditsRequired { get => _CreditsRequired; set => SetProperty(ref _CreditsRequired, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefGradeLevelWhenCourseTaken"/> model
        /// </summary>
        public Guid? RefGradeLevelWhenCourseTakenId { get => _RefGradeLevelWhenCourseTakenId; set => SetProperty(ref _RefGradeLevelWhenCourseTakenId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefSCEDCourseSubjectArea"/> model
        /// </summary>
        public  RefSCEDCourseSubjectAreaId { get => _RefSCEDCourseSubjectAreaId; set => SetProperty(ref _RefSCEDCourseSubjectAreaId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IK12StudentGraduationPlan model)
        {
            IsBusy = true;
            Id = model.Id;
            CreditsRequired = model.CreditsRequired; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefGradeLevelWhenCourseTakenId = model.RefGradeLevelWhenCourseTakenId; // 
            RefSCEDCourseSubjectAreaId = model.RefSCEDCourseSubjectAreaId; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
