//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12StaffAssignmentViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

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
        private System.Decimal? _ContributionPercentage;

        // member variable for the FullTimeEquivalency property
        private System.Decimal? _FullTimeEquivalency;

        // member variable for the HighlyQualifiedTeacherIndicator property
        private System.Boolean? _HighlyQualifiedTeacherIndicator;

        // member variable for the ItinerantTeacher property
        private System.Boolean? _ItinerantTeacher;

        // member variable for the OrganizationPersonRoleId property
        private Guid _OrganizationPersonRoleId;

        // member variable for the PrimaryAssignment property
        private System.Boolean? _PrimaryAssignment;

        // member variable for the RefClassroomPositionTypeId property
        private Guid? _RefClassroomPositionTypeId;

        // member variable for the RefEDFactsTeacherInexperiencedStatusId property
        private Guid? _RefEDFactsTeacherInexperiencedStatusId;

        // member variable for the RefEmergencyOrProvisionalCredentialStatusId property
        private Guid? _RefEmergencyOrProvisionalCredentialStatusId;

        // member variable for the RefK12StaffClassificationId property
        private Guid? _RefK12StaffClassificationId;

        // member variable for the RefMepStaffCategoryId property
        private Guid? _RefMepStaffCategoryId;

        // member variable for the RefOutOfFieldStatusId property
        private Guid? _RefOutOfFieldStatusId;

        // member variable for the RefProfessionalEducationJobClassificationId property
        private Guid? _RefProfessionalEducationJobClassificationId;

        // member variable for the RefSpecialEducationAgeGroupTaughtId property
        private Guid? _RefSpecialEducationAgeGroupTaughtId;

        // member variable for the RefSpecialEducationStaffCategoryId property
        private Guid? _RefSpecialEducationStaffCategoryId;

        // member variable for the RefTeachingAssignmentRoleId property
        private Guid? _RefTeachingAssignmentRoleId;

        // member variable for the RefTitleIProgramStaffCategoryId property
        private Guid? _RefTitleIProgramStaffCategoryId;

        // member variable for the SpecialEducationParaprofessional property
        private System.Boolean? _SpecialEducationParaprofessional;

        // member variable for the SpecialEducationRelatedServicesPersonnel property
        private System.Boolean? _SpecialEducationRelatedServicesPersonnel;

        // member variable for the SpecialEducationTeacher property
        private System.Boolean? _SpecialEducationTeacher;

        // member variable for the TeacherOfRecord property
        private System.Boolean? _TeacherOfRecord;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the K12StaffAssignmentViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The titles of employment, official status, or rank of education staff.
        /// </summary>
        public System.Decimal? ContributionPercentage { get => _ContributionPercentage; set => SetProperty(ref _ContributionPercentage, value); }

        /// <summary>
        /// The titles of employment, official status, or rank of education staff.
        /// </summary>
        public System.Decimal? FullTimeEquivalency { get => _FullTimeEquivalency; set => SetProperty(ref _FullTimeEquivalency, value); }

        /// <summary>
        /// The titles of employment, official status, or rank of education staff.
        /// </summary>
        public System.Boolean? HighlyQualifiedTeacherIndicator { get => _HighlyQualifiedTeacherIndicator; set => SetProperty(ref _HighlyQualifiedTeacherIndicator, value); }

        /// <summary>
        /// The titles of employment, official status, or rank of education staff.
        /// </summary>
        public System.Boolean? ItinerantTeacher { get => _ItinerantTeacher; set => SetProperty(ref _ItinerantTeacher, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get => _OrganizationPersonRoleId; set => SetProperty(ref _OrganizationPersonRoleId, value); }

        /// <summary>
        /// The titles of employment, official status, or rank of education staff.
        /// </summary>
        public System.Boolean? PrimaryAssignment { get => _PrimaryAssignment; set => SetProperty(ref _PrimaryAssignment, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefClassroomPositionType"/> model
        /// </summary>
        public Guid? RefClassroomPositionTypeId { get => _RefClassroomPositionTypeId; set => SetProperty(ref _RefClassroomPositionTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEDFactsTeacherInexperiencedStatus"/> model
        /// </summary>
        public Guid? RefEDFactsTeacherInexperiencedStatusId { get => _RefEDFactsTeacherInexperiencedStatusId; set => SetProperty(ref _RefEDFactsTeacherInexperiencedStatusId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEmergencyOrProvisionalCredentialStatus"/> model
        /// </summary>
        public Guid? RefEmergencyOrProvisionalCredentialStatusId { get => _RefEmergencyOrProvisionalCredentialStatusId; set => SetProperty(ref _RefEmergencyOrProvisionalCredentialStatusId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefK12StaffClassification"/> model
        /// </summary>
        public Guid? RefK12StaffClassificationId { get => _RefK12StaffClassificationId; set => SetProperty(ref _RefK12StaffClassificationId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefMepStaffCategory"/> model
        /// </summary>
        public Guid? RefMepStaffCategoryId { get => _RefMepStaffCategoryId; set => SetProperty(ref _RefMepStaffCategoryId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefOutOfFieldStatus"/> model
        /// </summary>
        public Guid? RefOutOfFieldStatusId { get => _RefOutOfFieldStatusId; set => SetProperty(ref _RefOutOfFieldStatusId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefProfessionalEducationJobClassification"/> model
        /// </summary>
        public Guid? RefProfessionalEducationJobClassificationId { get => _RefProfessionalEducationJobClassificationId; set => SetProperty(ref _RefProfessionalEducationJobClassificationId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefSpecialEducationAgeGroupTaught"/> model
        /// </summary>
        public Guid? RefSpecialEducationAgeGroupTaughtId { get => _RefSpecialEducationAgeGroupTaughtId; set => SetProperty(ref _RefSpecialEducationAgeGroupTaughtId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefSpecialEducationStaffCategory"/> model
        /// </summary>
        public Guid? RefSpecialEducationStaffCategoryId { get => _RefSpecialEducationStaffCategoryId; set => SetProperty(ref _RefSpecialEducationStaffCategoryId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTeachingAssignmentRole"/> model
        /// </summary>
        public Guid? RefTeachingAssignmentRoleId { get => _RefTeachingAssignmentRoleId; set => SetProperty(ref _RefTeachingAssignmentRoleId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTitleIProgramStaffCategory"/> model
        /// </summary>
        public Guid? RefTitleIProgramStaffCategoryId { get => _RefTitleIProgramStaffCategoryId; set => SetProperty(ref _RefTitleIProgramStaffCategoryId, value); }

        /// <summary>
        /// The titles of employment, official status, or rank of education staff.
        /// </summary>
        public System.Boolean? SpecialEducationParaprofessional { get => _SpecialEducationParaprofessional; set => SetProperty(ref _SpecialEducationParaprofessional, value); }

        /// <summary>
        /// The titles of employment, official status, or rank of education staff.
        /// </summary>
        public System.Boolean? SpecialEducationRelatedServicesPersonnel { get => _SpecialEducationRelatedServicesPersonnel; set => SetProperty(ref _SpecialEducationRelatedServicesPersonnel, value); }

        /// <summary>
        /// The titles of employment, official status, or rank of education staff.
        /// </summary>
        public System.Boolean? SpecialEducationTeacher { get => _SpecialEducationTeacher; set => SetProperty(ref _SpecialEducationTeacher, value); }

        /// <summary>
        /// The titles of employment, official status, or rank of education staff.
        /// </summary>
        public System.Boolean? TeacherOfRecord { get => _TeacherOfRecord; set => SetProperty(ref _TeacherOfRecord, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IK12StaffAssignment model)
        {
            IsBusy = true;
            Id = model.Id;
            ContributionPercentage = model.ContributionPercentage;
            FullTimeEquivalency = model.FullTimeEquivalency;
            HighlyQualifiedTeacherIndicator = model.HighlyQualifiedTeacherIndicator;
            ItinerantTeacher = model.ItinerantTeacher;
            OrganizationPersonRoleId = model.OrganizationPersonRoleId;
            PrimaryAssignment = model.PrimaryAssignment;
            RefClassroomPositionTypeId = model.RefClassroomPositionTypeId;
            RefEDFactsTeacherInexperiencedStatusId = model.RefEDFactsTeacherInexperiencedStatusId;
            RefEmergencyOrProvisionalCredentialStatusId = model.RefEmergencyOrProvisionalCredentialStatusId;
            RefK12StaffClassificationId = model.RefK12StaffClassificationId;
            RefMepStaffCategoryId = model.RefMepStaffCategoryId;
            RefOutOfFieldStatusId = model.RefOutOfFieldStatusId;
            RefProfessionalEducationJobClassificationId = model.RefProfessionalEducationJobClassificationId;
            RefSpecialEducationAgeGroupTaughtId = model.RefSpecialEducationAgeGroupTaughtId;
            RefSpecialEducationStaffCategoryId = model.RefSpecialEducationStaffCategoryId;
            RefTeachingAssignmentRoleId = model.RefTeachingAssignmentRoleId;
            RefTitleIProgramStaffCategoryId = model.RefTitleIProgramStaffCategoryId;
            SpecialEducationParaprofessional = model.SpecialEducationParaprofessional;
            SpecialEducationRelatedServicesPersonnel = model.SpecialEducationRelatedServicesPersonnel;
            SpecialEducationTeacher = model.SpecialEducationTeacher;
            TeacherOfRecord = model.TeacherOfRecord;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
