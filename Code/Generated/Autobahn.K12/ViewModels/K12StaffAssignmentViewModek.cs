//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   K12StaffAssignmentViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.K12.Interfaces;

namespace Autobahn.K12.ViewModels
{
     /// <summary>
     /// The K12StaffAssignmentViewModel
     /// </summary>
    public partial class K12StaffAssignmentViewModel : BindableBase, IK12StaffAssignment
    {
#region "Backing Fields"
        // member variable for the PrimaryAssignment property
        private System.Boolean? _PrimaryAssignment;

        // member variable for the TeacherOfRecord property
        private System.Boolean? _TeacherOfRecord;

        // member variable for the FullTimeEquivalency property
        private System.Decimal? _FullTimeEquivalency;

        // member variable for the ContributionPercentage property
        private System.Decimal? _ContributionPercentage;

        // member variable for the ItinerantTeacher property
        private System.Boolean? _ItinerantTeacher;

        // member variable for the HighlyQualifiedTeacherIndicator property
        private System.Boolean? _HighlyQualifiedTeacherIndicator;

        // member variable for the SpecialEducationTeacher property
        private System.Boolean? _SpecialEducationTeacher;

        // member variable for the SpecialEducationRelatedServicesPersonnel property
        private System.Boolean? _SpecialEducationRelatedServicesPersonnel;

        // member variable for the SpecialEducationParaprofessional property
        private System.Boolean? _SpecialEducationParaprofessional;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

#endregion

#region Properties
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRoleId"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        public System.Boolean? PrimaryAssignment { get => _PrimaryAssignment; set => SetProperty(ref _PrimaryAssignment, value); }

        public System.Boolean? TeacherOfRecord { get => _TeacherOfRecord; set => SetProperty(ref _TeacherOfRecord, value); }

        public System.Decimal? FullTimeEquivalency { get => _FullTimeEquivalency; set => SetProperty(ref _FullTimeEquivalency, value); }

        public System.Decimal? ContributionPercentage { get => _ContributionPercentage; set => SetProperty(ref _ContributionPercentage, value); }

        public System.Boolean? ItinerantTeacher { get => _ItinerantTeacher; set => SetProperty(ref _ItinerantTeacher, value); }

        public System.Boolean? HighlyQualifiedTeacherIndicator { get => _HighlyQualifiedTeacherIndicator; set => SetProperty(ref _HighlyQualifiedTeacherIndicator, value); }

        public System.Boolean? SpecialEducationTeacher { get => _SpecialEducationTeacher; set => SetProperty(ref _SpecialEducationTeacher, value); }

        public System.Boolean? SpecialEducationRelatedServicesPersonnel { get => _SpecialEducationRelatedServicesPersonnel; set => SetProperty(ref _SpecialEducationRelatedServicesPersonnel, value); }

        public System.Boolean? SpecialEducationParaprofessional { get => _SpecialEducationParaprofessional; set => SetProperty(ref _SpecialEducationParaprofessional, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefK12StaffClassificationId"/> model
        /// </summary>
        public Guid? RefK12StaffClassificationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefProfessionalEducationJobClassificationId"/> model
        /// </summary>
        public Guid? RefProfessionalEducationJobClassificationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTeachingAssignmentRoleId"/> model
        /// </summary>
        public Guid? RefTeachingAssignmentRoleId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefClassroomPositionTypeId"/> model
        /// </summary>
        public Guid? RefClassroomPositionTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefSpecialEducationStaffCategoryId"/> model
        /// </summary>
        public Guid? RefSpecialEducationStaffCategoryId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefSpecialEducationAgeGroupTaughtId"/> model
        /// </summary>
        public Guid? RefSpecialEducationAgeGroupTaughtId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefMepStaffCategoryId"/> model
        /// </summary>
        public Guid? RefMepStaffCategoryId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTitleIProgramStaffCategoryId"/> model
        /// </summary>
        public Guid? RefTitleIProgramStaffCategoryId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEDFactsTeacherInexperiencedStatusId"/> model
        /// </summary>
        public Guid? RefEDFactsTeacherInexperiencedStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEmergencyOrProvisionalCredentialStatusId"/> model
        /// </summary>
        public Guid? RefEmergencyOrProvisionalCredentialStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefOutOfFieldStatusId"/> model
        /// </summary>
        public Guid? RefOutOfFieldStatusId { get; set; }

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
        public void Load(IK12StaffAssignment model)
        {
            IsBusy = true;
            Id = model.Id;
            OrganizationPersonRoleId = model.OrganizationPersonRoleId;
            PrimaryAssignment = model.PrimaryAssignment;
            TeacherOfRecord = model.TeacherOfRecord;
            FullTimeEquivalency = model.FullTimeEquivalency;
            ContributionPercentage = model.ContributionPercentage;
            ItinerantTeacher = model.ItinerantTeacher;
            HighlyQualifiedTeacherIndicator = model.HighlyQualifiedTeacherIndicator;
            SpecialEducationTeacher = model.SpecialEducationTeacher;
            SpecialEducationRelatedServicesPersonnel = model.SpecialEducationRelatedServicesPersonnel;
            SpecialEducationParaprofessional = model.SpecialEducationParaprofessional;
            RefK12StaffClassificationId = model.RefK12StaffClassificationId;
            RefProfessionalEducationJobClassificationId = model.RefProfessionalEducationJobClassificationId;
            RefTeachingAssignmentRoleId = model.RefTeachingAssignmentRoleId;
            RefClassroomPositionTypeId = model.RefClassroomPositionTypeId;
            RefSpecialEducationStaffCategoryId = model.RefSpecialEducationStaffCategoryId;
            RefSpecialEducationAgeGroupTaughtId = model.RefSpecialEducationAgeGroupTaughtId;
            RefMepStaffCategoryId = model.RefMepStaffCategoryId;
            RefTitleIProgramStaffCategoryId = model.RefTitleIProgramStaffCategoryId;
            RefEDFactsTeacherInexperiencedStatusId = model.RefEDFactsTeacherInexperiencedStatusId;
            RefEmergencyOrProvisionalCredentialStatusId = model.RefEmergencyOrProvisionalCredentialStatusId;
            RefOutOfFieldStatusId = model.RefOutOfFieldStatusId;
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
