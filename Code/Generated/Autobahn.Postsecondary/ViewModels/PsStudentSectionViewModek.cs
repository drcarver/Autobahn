//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   PsStudentSectionViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Postsecondary.Interfaces;

namespace Autobahn.Postsecondary.ViewModels
{
     /// <summary>
     /// The PsStudentSectionViewModel
     /// </summary>
    public partial class PsStudentSectionViewModel : BindableBase, IPsStudentSection
    {
#region "Backing Fields"
        // member variable for the CourseOverrideSchool property
        private System.String _CourseOverrideSchool;

        // member variable for the DegreeApplicability property
        private System.Boolean? _DegreeApplicability;

        // member variable for the AcademicGrade property
        private System.String _AcademicGrade;

        // member variable for the NumberOfCreditsEarned property
        private System.Decimal? _NumberOfCreditsEarned;

        // member variable for the QualityPointsEarned property
        private System.Decimal? _QualityPointsEarned;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

        // member variable for the NumberOfCreditsAttempted property
        private System.Decimal? _NumberOfCreditsAttempted;

#endregion

#region Properties
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRoleId"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        public System.String CourseOverrideSchool  { get => _CourseOverrideSchool; set => SetProperty(ref _CourseOverrideSchool, value); }

        public System.Boolean? DegreeApplicability { get => _DegreeApplicability; set => SetProperty(ref _DegreeApplicability, value); }

        public System.String AcademicGrade  { get => _AcademicGrade; set => SetProperty(ref _AcademicGrade, value); }

        public System.Decimal? NumberOfCreditsEarned { get => _NumberOfCreditsEarned; set => SetProperty(ref _NumberOfCreditsEarned, value); }

        public System.Decimal? QualityPointsEarned { get => _QualityPointsEarned; set => SetProperty(ref _QualityPointsEarned, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCourseRepeatCodeId"/> model
        /// </summary>
        public Guid? RefCourseRepeatCodeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCourseAcademicGradeStatusCodeId"/> model
        /// </summary>
        public Guid? RefCourseAcademicGradeStatusCodeId { get; set; }

        public System.DateTime? RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        public System.DateTime? RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        public System.Decimal? NumberOfCreditsAttempted { get => _NumberOfCreditsAttempted; set => SetProperty(ref _NumberOfCreditsAttempted, value); }

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
        public void Load(IPsStudentSection model)
        {
            IsBusy = true;
            Id = model.Id;
            OrganizationPersonRoleId = model.OrganizationPersonRoleId;
            CourseOverrideSchool = model.CourseOverrideSchool;
            DegreeApplicability = model.DegreeApplicability;
            AcademicGrade = model.AcademicGrade;
            NumberOfCreditsEarned = model.NumberOfCreditsEarned;
            QualityPointsEarned = model.QualityPointsEarned;
            RefCourseRepeatCodeId = model.RefCourseRepeatCodeId;
            RefCourseAcademicGradeStatusCodeId = model.RefCourseAcademicGradeStatusCodeId;
            RecordStartDateTime = model.RecordStartDateTime;
            RecordEndDateTime = model.RecordEndDateTime;
            NumberOfCreditsAttempted = model.NumberOfCreditsAttempted;
            RecordStatusId = model.RecordStatusId;
            DataCollectionId = model.DataCollectionId;
            IsChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
