//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12SchoolViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.K12.ViewModels
{
     /// <summary>
     /// The K12SchoolViewModel
     /// </summary>
    public partial class K12SchoolViewModel : ViewModelBase, Interfaces.IK12School
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from K12School";

        // member variable for the AccreditationAgencyName property
        private System.String _AccreditationAgencyName;

        // member variable for the CharterSchoolApprovalYear property
        private System.String _CharterSchoolApprovalYear;

        // member variable for the CharterSchoolContractApprovalDate property
        private System.DateTime? _CharterSchoolContractApprovalDate;

        // member variable for the CharterSchoolContractIdNumber property
        private System.String _CharterSchoolContractIdNumber;

        // member variable for the CharterSchoolContractRenewalDate property
        private System.DateTime? _CharterSchoolContractRenewalDate;

        // member variable for the CharterSchoolIndicator property
        private System.Boolean? _CharterSchoolIndicator;

        // member variable for the CharterSchoolOpenEnrollmentIndicator property
        private System.Boolean? _CharterSchoolOpenEnrollmentIndicator;

        // member variable for the K12CharterSchoolAuthorizerAgencyId property
        private Guid? _K12CharterSchoolAuthorizerAgencyId;

        // member variable for the K12CharterSchoolManagementOrganizationId property
        private Guid? _K12CharterSchoolManagementOrganizationId;

        // member variable for the OrganizationId property
        private Guid _OrganizationId;

        // member variable for the RefAdministrativeFundingControlId property
        private Guid? _RefAdministrativeFundingControlId;

        // member variable for the RefCharterSchoolTypeId property
        private Guid? _RefCharterSchoolTypeId;

        // member variable for the RefIncreasedLearningTimeTypeId property
        private Guid? _RefIncreasedLearningTimeTypeId;

        // member variable for the RefSchoolLevelId property
        private Guid? _RefSchoolLevelId;

        // member variable for the RefSchoolTypeId property
        private Guid? _RefSchoolTypeId;

        // member variable for the RefStatePovertyDesignationId property
        private Guid? _RefStatePovertyDesignationId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the K12SchoolViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The type of education institution as classified by its funding source.
        /// </summary>
        public System.String AccreditationAgencyName { get => _AccreditationAgencyName; set => SetProperty(ref _AccreditationAgencyName, value); }

        /// <summary>
        /// The type of education institution as classified by its funding source.
        /// </summary>
        public System.String CharterSchoolApprovalYear { get => _CharterSchoolApprovalYear; set => SetProperty(ref _CharterSchoolApprovalYear, value); }

        /// <summary>
        /// The type of education institution as classified by its funding source.
        /// </summary>
        public System.DateTime? CharterSchoolContractApprovalDate { get => _CharterSchoolContractApprovalDate; set => SetProperty(ref _CharterSchoolContractApprovalDate, value); }

        /// <summary>
        /// The type of education institution as classified by its funding source.
        /// </summary>
        public System.String CharterSchoolContractIdNumber { get => _CharterSchoolContractIdNumber; set => SetProperty(ref _CharterSchoolContractIdNumber, value); }

        /// <summary>
        /// The type of education institution as classified by its funding source.
        /// </summary>
        public System.DateTime? CharterSchoolContractRenewalDate { get => _CharterSchoolContractRenewalDate; set => SetProperty(ref _CharterSchoolContractRenewalDate, value); }

        /// <summary>
        /// The type of education institution as classified by its funding source.
        /// </summary>
        public System.Boolean? CharterSchoolIndicator { get => _CharterSchoolIndicator; set => SetProperty(ref _CharterSchoolIndicator, value); }

        /// <summary>
        /// The type of education institution as classified by its funding source.
        /// </summary>
        public System.Boolean? CharterSchoolOpenEnrollmentIndicator { get => _CharterSchoolOpenEnrollmentIndicator; set => SetProperty(ref _CharterSchoolOpenEnrollmentIndicator, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="K12CharterSchoolAuthorizerAgency"/> model
        /// </summary>
        public Guid? K12CharterSchoolAuthorizerAgencyId { get => _K12CharterSchoolAuthorizerAgencyId; set => SetProperty(ref _K12CharterSchoolAuthorizerAgencyId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="K12CharterSchoolManagementOrganization"/> model
        /// </summary>
        public Guid? K12CharterSchoolManagementOrganizationId { get => _K12CharterSchoolManagementOrganizationId; set => SetProperty(ref _K12CharterSchoolManagementOrganizationId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="Organization"/> model
        /// </summary>
        public Guid OrganizationId { get => _OrganizationId; set => SetProperty(ref _OrganizationId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAdministrativeFundingControl"/> model
        /// </summary>
        public Guid? RefAdministrativeFundingControlId { get => _RefAdministrativeFundingControlId; set => SetProperty(ref _RefAdministrativeFundingControlId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCharterSchoolType"/> model
        /// </summary>
        public Guid? RefCharterSchoolTypeId { get => _RefCharterSchoolTypeId; set => SetProperty(ref _RefCharterSchoolTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIncreasedLearningTimeType"/> model
        /// </summary>
        public Guid? RefIncreasedLearningTimeTypeId { get => _RefIncreasedLearningTimeTypeId; set => SetProperty(ref _RefIncreasedLearningTimeTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefSchoolLevel"/> model
        /// </summary>
        public Guid? RefSchoolLevelId { get => _RefSchoolLevelId; set => SetProperty(ref _RefSchoolLevelId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefSchoolType"/> model
        /// </summary>
        public Guid? RefSchoolTypeId { get => _RefSchoolTypeId; set => SetProperty(ref _RefSchoolTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefStatePovertyDesignation"/> model
        /// </summary>
        public Guid? RefStatePovertyDesignationId { get => _RefStatePovertyDesignationId; set => SetProperty(ref _RefStatePovertyDesignationId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IK12School model)
        {
            IsBusy = true;
            Id = model.Id;
            AccreditationAgencyName = model.AccreditationAgencyName;
            CharterSchoolApprovalYear = model.CharterSchoolApprovalYear;
            CharterSchoolContractApprovalDate = model.CharterSchoolContractApprovalDate;
            CharterSchoolContractIdNumber = model.CharterSchoolContractIdNumber;
            CharterSchoolContractRenewalDate = model.CharterSchoolContractRenewalDate;
            CharterSchoolIndicator = model.CharterSchoolIndicator;
            CharterSchoolOpenEnrollmentIndicator = model.CharterSchoolOpenEnrollmentIndicator;
            K12CharterSchoolAuthorizerAgencyId = model.K12CharterSchoolAuthorizerAgencyId;
            K12CharterSchoolManagementOrganizationId = model.K12CharterSchoolManagementOrganizationId;
            OrganizationId = model.OrganizationId;
            RefAdministrativeFundingControlId = model.RefAdministrativeFundingControlId;
            RefCharterSchoolTypeId = model.RefCharterSchoolTypeId;
            RefIncreasedLearningTimeTypeId = model.RefIncreasedLearningTimeTypeId;
            RefSchoolLevelId = model.RefSchoolLevelId;
            RefSchoolTypeId = model.RefSchoolTypeId;
            RefStatePovertyDesignationId = model.RefStatePovertyDesignationId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
