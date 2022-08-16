//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12StaffAssignmentViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.K12.ViewModels
{
     /// <summary>
     /// The K12StaffAssignmentViewModel
     /// </summary>
    public partial class K12StaffAssignmentViewModel : ViewModelBase, Interfaces.IK12StaffAssignment
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from K12StaffAssignment";

        // member variable for the ContributionPercentage property
        private  _ContributionPercentage;

        // member variable for the FullTimeEquivalency property
        private  _FullTimeEquivalency;

        // member variable for the HighlyQualifiedTeacherIndicator property
        private  _HighlyQualifiedTeacherIndicator;

        // member variable for the ItinerantTeacher property
        private  _ItinerantTeacher;

        // member variable for the PrimaryAssignment property
        private  _PrimaryAssignment;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefClassroomPositionTypeId property
        private  _RefClassroomPositionTypeId;

        // member variable for the RefEDFactsTeacherInexperiencedStatusId property
        private  _RefEDFactsTeacherInexperiencedStatusId;

        // member variable for the RefK12StaffClassificationId property
        private Guid? _RefK12StaffClassificationId;

        // member variable for the RefMepStaffCategoryId property
        private  _RefMepStaffCategoryId;

        // member variable for the RefOutOfFieldStatusId property
        private  _RefOutOfFieldStatusId;

        // member variable for the RefProfessionalEducationJobClassificationId property
        private  _RefProfessionalEducationJobClassificationId;

        // member variable for the RefSpecialEducationAgeGroupTaughtId property
        private  _RefSpecialEducationAgeGroupTaughtId;

        // member variable for the RefSpecialEducationStaffCategoryId property
        private  _RefSpecialEducationStaffCategoryId;

        // member variable for the RefTeachingAssignmentRoleId property
        private  _RefTeachingAssignmentRoleId;

        // member variable for the RefTitleIProgramStaffCategoryId property
        private  _RefTitleIProgramStaffCategoryId;

        // member variable for the SpecialEducationParaprofessional property
        private  _SpecialEducationParaprofessional;

        // member variable for the SpecialEducationRelatedServicesPersonnel property
        private  _SpecialEducationRelatedServicesPersonnel;

        // member variable for the SpecialEducationTeacher property
        private  _SpecialEducationTeacher;

        // member variable for the TeacherOfRecord property
        private  _TeacherOfRecord;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public  ContributionPercentage { get => _ContributionPercentage; set => SetProperty(ref _ContributionPercentage, value); }

        /// <summary>
        /// </summary>
        public  FullTimeEquivalency { get => _FullTimeEquivalency; set => SetProperty(ref _FullTimeEquivalency, value); }

        /// <summary>
        /// </summary>
        public  HighlyQualifiedTeacherIndicator { get => _HighlyQualifiedTeacherIndicator; set => SetProperty(ref _HighlyQualifiedTeacherIndicator, value); }

        /// <summary>
        /// </summary>
        public  ItinerantTeacher { get => _ItinerantTeacher; set => SetProperty(ref _ItinerantTeacher, value); }

        /// <summary>
        /// </summary>
        public  PrimaryAssignment { get => _PrimaryAssignment; set => SetProperty(ref _PrimaryAssignment, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefClassroomPositionType"/> model
        /// </summary>
        public  RefClassroomPositionTypeId { get => _RefClassroomPositionTypeId; set => SetProperty(ref _RefClassroomPositionTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEDFactsTeacherInexperiencedStatus"/> model
        /// </summary>
        public  RefEDFactsTeacherInexperiencedStatusId { get => _RefEDFactsTeacherInexperiencedStatusId; set => SetProperty(ref _RefEDFactsTeacherInexperiencedStatusId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefK12StaffClassification"/> model
        /// </summary>
        public Guid? RefK12StaffClassificationId { get => _RefK12StaffClassificationId; set => SetProperty(ref _RefK12StaffClassificationId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefMepStaffCategory"/> model
        /// </summary>
        public  RefMepStaffCategoryId { get => _RefMepStaffCategoryId; set => SetProperty(ref _RefMepStaffCategoryId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefOutOfFieldStatus"/> model
        /// </summary>
        public  RefOutOfFieldStatusId { get => _RefOutOfFieldStatusId; set => SetProperty(ref _RefOutOfFieldStatusId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefProfessionalEducationJobClassification"/> model
        /// </summary>
        public  RefProfessionalEducationJobClassificationId { get => _RefProfessionalEducationJobClassificationId; set => SetProperty(ref _RefProfessionalEducationJobClassificationId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefSpecialEducationAgeGroupTaught"/> model
        /// </summary>
        public  RefSpecialEducationAgeGroupTaughtId { get => _RefSpecialEducationAgeGroupTaughtId; set => SetProperty(ref _RefSpecialEducationAgeGroupTaughtId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefSpecialEducationStaffCategory"/> model
        /// </summary>
        public  RefSpecialEducationStaffCategoryId { get => _RefSpecialEducationStaffCategoryId; set => SetProperty(ref _RefSpecialEducationStaffCategoryId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTeachingAssignmentRole"/> model
        /// </summary>
        public  RefTeachingAssignmentRoleId { get => _RefTeachingAssignmentRoleId; set => SetProperty(ref _RefTeachingAssignmentRoleId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTitleIProgramStaffCategory"/> model
        /// </summary>
        public  RefTitleIProgramStaffCategoryId { get => _RefTitleIProgramStaffCategoryId; set => SetProperty(ref _RefTitleIProgramStaffCategoryId, value); }

        /// <summary>
        /// </summary>
        public  SpecialEducationParaprofessional { get => _SpecialEducationParaprofessional; set => SetProperty(ref _SpecialEducationParaprofessional, value); }

        /// <summary>
        /// </summary>
        public  SpecialEducationRelatedServicesPersonnel { get => _SpecialEducationRelatedServicesPersonnel; set => SetProperty(ref _SpecialEducationRelatedServicesPersonnel, value); }

        /// <summary>
        /// </summary>
        public  SpecialEducationTeacher { get => _SpecialEducationTeacher; set => SetProperty(ref _SpecialEducationTeacher, value); }

        /// <summary>
        /// </summary>
        public  TeacherOfRecord { get => _TeacherOfRecord; set => SetProperty(ref _TeacherOfRecord, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IK12StaffAssignment model)
        {
            IsBusy = true;
            Id = model.Id;
            ContributionPercentage = model.ContributionPercentage; // 
            FullTimeEquivalency = model.FullTimeEquivalency; // 
            HighlyQualifiedTeacherIndicator = model.HighlyQualifiedTeacherIndicator; // 
            ItinerantTeacher = model.ItinerantTeacher; // 
            PrimaryAssignment = model.PrimaryAssignment; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefClassroomPositionTypeId = model.RefClassroomPositionTypeId; // 
            RefEDFactsTeacherInexperiencedStatusId = model.RefEDFactsTeacherInexperiencedStatusId; // 
            RefK12StaffClassificationId = model.RefK12StaffClassificationId; // 
            RefMepStaffCategoryId = model.RefMepStaffCategoryId; // 
            RefOutOfFieldStatusId = model.RefOutOfFieldStatusId; // 
            RefProfessionalEducationJobClassificationId = model.RefProfessionalEducationJobClassificationId; // 
            RefSpecialEducationAgeGroupTaughtId = model.RefSpecialEducationAgeGroupTaughtId; // 
            RefSpecialEducationStaffCategoryId = model.RefSpecialEducationStaffCategoryId; // 
            RefTeachingAssignmentRoleId = model.RefTeachingAssignmentRoleId; // 
            RefTitleIProgramStaffCategoryId = model.RefTitleIProgramStaffCategoryId; // 
            SpecialEducationParaprofessional = model.SpecialEducationParaprofessional; // 
            SpecialEducationRelatedServicesPersonnel = model.SpecialEducationRelatedServicesPersonnel; // 
            SpecialEducationTeacher = model.SpecialEducationTeacher; // 
            TeacherOfRecord = model.TeacherOfRecord; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
