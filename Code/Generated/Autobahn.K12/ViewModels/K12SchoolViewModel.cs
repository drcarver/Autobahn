//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12SchoolViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

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
        private  _AccreditationAgencyName;

        // member variable for the CharterSchoolApprovalYear property
        private  _CharterSchoolApprovalYear;

        // member variable for the CharterSchoolContractApprovalDate property
        private  _CharterSchoolContractApprovalDate;

        // member variable for the CharterSchoolContractIdNumber property
        private  _CharterSchoolContractIdNumber;

        // member variable for the CharterSchoolContractRenewalDate property
        private  _CharterSchoolContractRenewalDate;

        // member variable for the CharterSchoolIndicator property
        private  _CharterSchoolIndicator;

        // member variable for the CharterSchoolOpenEnrollmentIndicator property
        private  _CharterSchoolOpenEnrollmentIndicator;

        // member variable for the K12CharterSchoolApprovalAgencyId property
        private  _K12CharterSchoolApprovalAgencyId;

        // member variable for the K12CharterSchoolManagementOrganizationId property
        private  _K12CharterSchoolManagementOrganizationId;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefAdministrativeFundingControlId property
        private Guid? _RefAdministrativeFundingControlId;

        // member variable for the RefCharterSchoolTypeId property
        private  _RefCharterSchoolTypeId;

        // member variable for the RefIncreasedLearningTimeTypeId property
        private  _RefIncreasedLearningTimeTypeId;

        // member variable for the RefSchoolLevelId property
        private  _RefSchoolLevelId;

        // member variable for the RefSchoolTypeId property
        private  _RefSchoolTypeId;

        // member variable for the RefStatePovertyDesignationId property
        private  _RefStatePovertyDesignationId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public  AccreditationAgencyName { get => _AccreditationAgencyName; set => SetProperty(ref _AccreditationAgencyName, value); }

        /// <summary>
        /// </summary>
        public  CharterSchoolApprovalYear { get => _CharterSchoolApprovalYear; set => SetProperty(ref _CharterSchoolApprovalYear, value); }

        /// <summary>
        /// </summary>
        public  CharterSchoolContractApprovalDate { get => _CharterSchoolContractApprovalDate; set => SetProperty(ref _CharterSchoolContractApprovalDate, value); }

        /// <summary>
        /// </summary>
        public  CharterSchoolContractIdNumber { get => _CharterSchoolContractIdNumber; set => SetProperty(ref _CharterSchoolContractIdNumber, value); }

        /// <summary>
        /// </summary>
        public  CharterSchoolContractRenewalDate { get => _CharterSchoolContractRenewalDate; set => SetProperty(ref _CharterSchoolContractRenewalDate, value); }

        /// <summary>
        /// </summary>
        public  CharterSchoolIndicator { get => _CharterSchoolIndicator; set => SetProperty(ref _CharterSchoolIndicator, value); }

        /// <summary>
        /// </summary>
        public  CharterSchoolOpenEnrollmentIndicator { get => _CharterSchoolOpenEnrollmentIndicator; set => SetProperty(ref _CharterSchoolOpenEnrollmentIndicator, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="K12CharterSchoolApprovalAgency"/> model
        /// </summary>
        public  K12CharterSchoolApprovalAgencyId { get => _K12CharterSchoolApprovalAgencyId; set => SetProperty(ref _K12CharterSchoolApprovalAgencyId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="K12CharterSchoolManagementOrganization"/> model
        /// </summary>
        public  K12CharterSchoolManagementOrganizationId { get => _K12CharterSchoolManagementOrganizationId; set => SetProperty(ref _K12CharterSchoolManagementOrganizationId, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAdministrativeFundingControl"/> model
        /// </summary>
        public Guid? RefAdministrativeFundingControlId { get => _RefAdministrativeFundingControlId; set => SetProperty(ref _RefAdministrativeFundingControlId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCharterSchoolType"/> model
        /// </summary>
        public  RefCharterSchoolTypeId { get => _RefCharterSchoolTypeId; set => SetProperty(ref _RefCharterSchoolTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIncreasedLearningTimeType"/> model
        /// </summary>
        public  RefIncreasedLearningTimeTypeId { get => _RefIncreasedLearningTimeTypeId; set => SetProperty(ref _RefIncreasedLearningTimeTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefSchoolLevel"/> model
        /// </summary>
        public  RefSchoolLevelId { get => _RefSchoolLevelId; set => SetProperty(ref _RefSchoolLevelId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefSchoolType"/> model
        /// </summary>
        public  RefSchoolTypeId { get => _RefSchoolTypeId; set => SetProperty(ref _RefSchoolTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefStatePovertyDesignation"/> model
        /// </summary>
        public  RefStatePovertyDesignationId { get => _RefStatePovertyDesignationId; set => SetProperty(ref _RefStatePovertyDesignationId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IK12School model)
        {
            IsBusy = true;
            Id = model.Id;
            AccreditationAgencyName = model.AccreditationAgencyName; // 
            CharterSchoolApprovalYear = model.CharterSchoolApprovalYear; // 
            CharterSchoolContractApprovalDate = model.CharterSchoolContractApprovalDate; // 
            CharterSchoolContractIdNumber = model.CharterSchoolContractIdNumber; // 
            CharterSchoolContractRenewalDate = model.CharterSchoolContractRenewalDate; // 
            CharterSchoolIndicator = model.CharterSchoolIndicator; // 
            CharterSchoolOpenEnrollmentIndicator = model.CharterSchoolOpenEnrollmentIndicator; // 
            K12CharterSchoolApprovalAgencyId = model.K12CharterSchoolApprovalAgencyId; // 
            K12CharterSchoolManagementOrganizationId = model.K12CharterSchoolManagementOrganizationId; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefAdministrativeFundingControlId = model.RefAdministrativeFundingControlId; // 
            RefCharterSchoolTypeId = model.RefCharterSchoolTypeId; // 
            RefIncreasedLearningTimeTypeId = model.RefIncreasedLearningTimeTypeId; // 
            RefSchoolLevelId = model.RefSchoolLevelId; // 
            RefSchoolTypeId = model.RefSchoolTypeId; // 
            RefStatePovertyDesignationId = model.RefStatePovertyDesignationId; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
