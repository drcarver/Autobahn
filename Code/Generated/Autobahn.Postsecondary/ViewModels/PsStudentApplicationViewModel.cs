//**********************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   PsStudentApplicationViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Postsecondary.ViewModels
{
     /// <summary>
     /// The PsStudentApplicationViewModel
     /// </summary>
    public partial class PsStudentApplicationViewModel : ViewModelBase, Interfaces.IPsStudentApplication
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PsStudentApplication";

        // member variable for the GradePointAverageCumulative property
        private  _GradePointAverageCumulative;

        // member variable for the HighSchoolGraduatingClassSize property
        private  _HighSchoolGraduatingClassSize;

        // member variable for the HighSchoolPercentile property
        private  _HighSchoolPercentile;

        // member variable for the HighSchoolStudentClassRank property
        private Guid? _HighSchoolStudentClassRank;

        // member variable for the PostsecondaryApplicant property
        private  _PostsecondaryApplicant;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefAdmittedStudentId property
        private  _RefAdmittedStudentId;

        // member variable for the RefGpaWeightedIndicatorId property
        private  _RefGpaWeightedIndicatorId;

        // member variable for the RefGradePointAverageDomainId property
        private  _RefGradePointAverageDomainId;

        // member variable for the WaitListedStudent property
        private  _WaitListedStudent;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public  GradePointAverageCumulative { get => _GradePointAverageCumulative; set => SetProperty(ref _GradePointAverageCumulative, value); }

        /// <summary>
        /// </summary>
        public  HighSchoolGraduatingClassSize { get => _HighSchoolGraduatingClassSize; set => SetProperty(ref _HighSchoolGraduatingClassSize, value); }

        /// <summary>
        /// </summary>
        public  HighSchoolPercentile { get => _HighSchoolPercentile; set => SetProperty(ref _HighSchoolPercentile, value); }

        /// <summary>
        /// </summary>
        public Guid? HighSchoolStudentClassRank { get => _HighSchoolStudentClassRank; set => SetProperty(ref _HighSchoolStudentClassRank, value); }

        /// <summary>
        /// </summary>
        public  PostsecondaryApplicant { get => _PostsecondaryApplicant; set => SetProperty(ref _PostsecondaryApplicant, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAdmittedStudent"/> model
        /// </summary>
        public  RefAdmittedStudentId { get => _RefAdmittedStudentId; set => SetProperty(ref _RefAdmittedStudentId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefGpaWeightedIndicator"/> model
        /// </summary>
        public  RefGpaWeightedIndicatorId { get => _RefGpaWeightedIndicatorId; set => SetProperty(ref _RefGpaWeightedIndicatorId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefGradePointAverageDomain"/> model
        /// </summary>
        public  RefGradePointAverageDomainId { get => _RefGradePointAverageDomainId; set => SetProperty(ref _RefGradePointAverageDomainId, value); }

        /// <summary>
        /// </summary>
        public  WaitListedStudent { get => _WaitListedStudent; set => SetProperty(ref _WaitListedStudent, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPsStudentApplication model)
        {
            IsBusy = true;
            Id = model.Id;
            GradePointAverageCumulative = model.GradePointAverageCumulative; // 
            HighSchoolGraduatingClassSize = model.HighSchoolGraduatingClassSize; // 
            HighSchoolPercentile = model.HighSchoolPercentile; // 
            HighSchoolStudentClassRank = model.HighSchoolStudentClassRank; // 
            PostsecondaryApplicant = model.PostsecondaryApplicant; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefAdmittedStudentId = model.RefAdmittedStudentId; // 
            RefGpaWeightedIndicatorId = model.RefGpaWeightedIndicatorId; // 
            RefGradePointAverageDomainId = model.RefGradePointAverageDomainId; // 
            WaitListedStudent = model.WaitListedStudent; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
