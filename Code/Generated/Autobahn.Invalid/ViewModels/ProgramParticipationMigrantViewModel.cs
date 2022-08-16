//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   ProgramParticipationMigrantViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Invalid.ViewModels
{
     /// <summary>
     /// The ProgramParticipationMigrantViewModel
     /// </summary>
    public partial class ProgramParticipationMigrantViewModel : ViewModelBase, Interfaces.IProgramParticipationMigrant
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from ProgramParticipationMigrant";

        // member variable for the BirthdateVerification property
        private  _BirthdateVerification;

        // member variable for the ContinuationOfServicesStatus property
        private  _ContinuationOfServicesStatus;

        // member variable for the DesignatedGraduationSchoolId property
        private  _DesignatedGraduationSchoolId;

        // member variable for the ImmunizationRecordFlag property
        private  _ImmunizationRecordFlag;

        // member variable for the LastQualifyingMoveDate property
        private Guid? _LastQualifyingMoveDate;

        // member variable for the MepEligibilityExpirationDate property
        private  _MepEligibilityExpirationDate;

        // member variable for the MigrantStudentQualifyingArrivalDate property
        private  _MigrantStudentQualifyingArrivalDate;

        // member variable for the PrioritizedForServices property
        private  _PrioritizedForServices;

        // member variable for the QualifyingMoveFromCity property
        private  _QualifyingMoveFromCity;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefContinuationOfServicesReasonId property
        private  _RefContinuationOfServicesReasonId;

        // member variable for the RefMepEnrollmentTypeId property
        private  _RefMepEnrollmentTypeId;

        // member variable for the RefMepProjectBasedId property
        private  _RefMepProjectBasedId;

        // member variable for the RefMepServiceTypeId property
        private  _RefMepServiceTypeId;

        // member variable for the RefQualifyingMoveFromCountryId property
        private  _RefQualifyingMoveFromCountryId;

        // member variable for the RefQualifyingMoveFromStateId property
        private  _RefQualifyingMoveFromStateId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public  BirthdateVerification { get => _BirthdateVerification; set => SetProperty(ref _BirthdateVerification, value); }

        /// <summary>
        /// </summary>
        public  ContinuationOfServicesStatus { get => _ContinuationOfServicesStatus; set => SetProperty(ref _ContinuationOfServicesStatus, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DesignatedGraduationSchool"/> model
        /// </summary>
        public  DesignatedGraduationSchoolId { get => _DesignatedGraduationSchoolId; set => SetProperty(ref _DesignatedGraduationSchoolId, value); }

        /// <summary>
        /// </summary>
        public  ImmunizationRecordFlag { get => _ImmunizationRecordFlag; set => SetProperty(ref _ImmunizationRecordFlag, value); }

        /// <summary>
        /// </summary>
        public Guid? LastQualifyingMoveDate { get => _LastQualifyingMoveDate; set => SetProperty(ref _LastQualifyingMoveDate, value); }

        /// <summary>
        /// </summary>
        public  MepEligibilityExpirationDate { get => _MepEligibilityExpirationDate; set => SetProperty(ref _MepEligibilityExpirationDate, value); }

        /// <summary>
        /// </summary>
        public  MigrantStudentQualifyingArrivalDate { get => _MigrantStudentQualifyingArrivalDate; set => SetProperty(ref _MigrantStudentQualifyingArrivalDate, value); }

        /// <summary>
        /// </summary>
        public  PrioritizedForServices { get => _PrioritizedForServices; set => SetProperty(ref _PrioritizedForServices, value); }

        /// <summary>
        /// </summary>
        public  QualifyingMoveFromCity { get => _QualifyingMoveFromCity; set => SetProperty(ref _QualifyingMoveFromCity, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefContinuationOfServicesReason"/> model
        /// </summary>
        public  RefContinuationOfServicesReasonId { get => _RefContinuationOfServicesReasonId; set => SetProperty(ref _RefContinuationOfServicesReasonId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefMepEnrollmentType"/> model
        /// </summary>
        public  RefMepEnrollmentTypeId { get => _RefMepEnrollmentTypeId; set => SetProperty(ref _RefMepEnrollmentTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefMepProjectBased"/> model
        /// </summary>
        public  RefMepProjectBasedId { get => _RefMepProjectBasedId; set => SetProperty(ref _RefMepProjectBasedId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefMepServiceType"/> model
        /// </summary>
        public  RefMepServiceTypeId { get => _RefMepServiceTypeId; set => SetProperty(ref _RefMepServiceTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefQualifyingMoveFromCountry"/> model
        /// </summary>
        public  RefQualifyingMoveFromCountryId { get => _RefQualifyingMoveFromCountryId; set => SetProperty(ref _RefQualifyingMoveFromCountryId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefQualifyingMoveFromState"/> model
        /// </summary>
        public  RefQualifyingMoveFromStateId { get => _RefQualifyingMoveFromStateId; set => SetProperty(ref _RefQualifyingMoveFromStateId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IProgramParticipationMigrant model)
        {
            IsBusy = true;
            Id = model.Id;
            BirthdateVerification = model.BirthdateVerification; // 
            ContinuationOfServicesStatus = model.ContinuationOfServicesStatus; // 
            DesignatedGraduationSchoolId = model.DesignatedGraduationSchoolId; // 
            ImmunizationRecordFlag = model.ImmunizationRecordFlag; // 
            LastQualifyingMoveDate = model.LastQualifyingMoveDate; // 
            MepEligibilityExpirationDate = model.MepEligibilityExpirationDate; // 
            MigrantStudentQualifyingArrivalDate = model.MigrantStudentQualifyingArrivalDate; // 
            PrioritizedForServices = model.PrioritizedForServices; // 
            QualifyingMoveFromCity = model.QualifyingMoveFromCity; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefContinuationOfServicesReasonId = model.RefContinuationOfServicesReasonId; // 
            RefMepEnrollmentTypeId = model.RefMepEnrollmentTypeId; // 
            RefMepProjectBasedId = model.RefMepProjectBasedId; // 
            RefMepServiceTypeId = model.RefMepServiceTypeId; // 
            RefQualifyingMoveFromCountryId = model.RefQualifyingMoveFromCountryId; // 
            RefQualifyingMoveFromStateId = model.RefQualifyingMoveFromStateId; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
