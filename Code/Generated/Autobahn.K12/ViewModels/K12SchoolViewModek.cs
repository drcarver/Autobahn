//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   K12SchoolViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.K12.Interfaces;

namespace Autobahn.K12.ViewModels
{
     /// <summary>
     /// The K12SchoolViewModel
     /// </summary>
    public partial class K12SchoolViewModel : BindableBase, IK12School
    {
#region "Backing Fields"
        // member variable for the CharterSchoolIndicator property
        private System.Boolean? _CharterSchoolIndicator;

        // member variable for the CharterSchoolApprovalYear property
        private System.String _CharterSchoolApprovalYear;

        // member variable for the AccreditationAgencyName property
        private System.String _AccreditationAgencyName;

        // member variable for the CharterSchoolOpenEnrollmentIndicator property
        private System.Boolean? _CharterSchoolOpenEnrollmentIndicator;

        // member variable for the CharterSchoolContractApprovalDate property
        private System.DateTime? _CharterSchoolContractApprovalDate;

        // member variable for the CharterSchoolContractIdNumber property
        private System.String _CharterSchoolContractIdNumber;

        // member variable for the CharterSchoolContractRenewalDate property
        private System.DateTime? _CharterSchoolContractRenewalDate;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

#endregion

#region Properties
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationId"/> model
        /// </summary>
        public Guid OrganizationId { get; set; }

        public System.Boolean? CharterSchoolIndicator { get => _CharterSchoolIndicator; set => SetProperty(ref _CharterSchoolIndicator, value); }

        public System.String CharterSchoolApprovalYear  { get => _CharterSchoolApprovalYear; set => SetProperty(ref _CharterSchoolApprovalYear, value); }

        public System.String AccreditationAgencyName  { get => _AccreditationAgencyName; set => SetProperty(ref _AccreditationAgencyName, value); }

        public System.Boolean? CharterSchoolOpenEnrollmentIndicator { get => _CharterSchoolOpenEnrollmentIndicator; set => SetProperty(ref _CharterSchoolOpenEnrollmentIndicator, value); }

        public System.DateTime? CharterSchoolContractApprovalDate { get => _CharterSchoolContractApprovalDate; set => SetProperty(ref _CharterSchoolContractApprovalDate, value); }

        public System.String CharterSchoolContractIdNumber  { get => _CharterSchoolContractIdNumber; set => SetProperty(ref _CharterSchoolContractIdNumber, value); }

        public System.DateTime? CharterSchoolContractRenewalDate { get => _CharterSchoolContractRenewalDate; set => SetProperty(ref _CharterSchoolContractRenewalDate, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="K12CharterSchoolManagementOrganizationId"/> model
        /// </summary>
        public Guid? K12CharterSchoolManagementOrganizationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="K12CharterSchoolAuthorizerAgencyId"/> model
        /// </summary>
        public Guid? K12CharterSchoolAuthorizerAgencyId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefSchoolTypeId"/> model
        /// </summary>
        public Guid? RefSchoolTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefSchoolLevelId"/> model
        /// </summary>
        public Guid? RefSchoolLevelId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAdministrativeFundingControlId"/> model
        /// </summary>
        public Guid? RefAdministrativeFundingControlId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCharterSchoolTypeId"/> model
        /// </summary>
        public Guid? RefCharterSchoolTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIncreasedLearningTimeTypeId"/> model
        /// </summary>
        public Guid? RefIncreasedLearningTimeTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefStatePovertyDesignationId"/> model
        /// </summary>
        public Guid? RefStatePovertyDesignationId { get; set; }

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
        public void Load(IK12School model)
        {
            IsBusy = true;
            Id = model.Id;
            OrganizationId = model.OrganizationId;
            CharterSchoolIndicator = model.CharterSchoolIndicator;
            CharterSchoolApprovalYear = model.CharterSchoolApprovalYear;
            AccreditationAgencyName = model.AccreditationAgencyName;
            CharterSchoolOpenEnrollmentIndicator = model.CharterSchoolOpenEnrollmentIndicator;
            CharterSchoolContractApprovalDate = model.CharterSchoolContractApprovalDate;
            CharterSchoolContractIdNumber = model.CharterSchoolContractIdNumber;
            CharterSchoolContractRenewalDate = model.CharterSchoolContractRenewalDate;
            K12CharterSchoolManagementOrganizationId = model.K12CharterSchoolManagementOrganizationId;
            K12CharterSchoolAuthorizerAgencyId = model.K12CharterSchoolAuthorizerAgencyId;
            RefSchoolTypeId = model.RefSchoolTypeId;
            RefSchoolLevelId = model.RefSchoolLevelId;
            RefAdministrativeFundingControlId = model.RefAdministrativeFundingControlId;
            RefCharterSchoolTypeId = model.RefCharterSchoolTypeId;
            RefIncreasedLearningTimeTypeId = model.RefIncreasedLearningTimeTypeId;
            RefStatePovertyDesignationId = model.RefStatePovertyDesignationId;
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
