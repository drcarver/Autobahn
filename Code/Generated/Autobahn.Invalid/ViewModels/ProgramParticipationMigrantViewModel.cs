//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   ProgramParticipationMigrantViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

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
        private System.String _BirthdateVerification;

        // member variable for the ContinuationOfServicesStatus property
        private System.Boolean? _ContinuationOfServicesStatus;

        // member variable for the DesignatedGraduationSchoolId property
        private Guid? _DesignatedGraduationSchoolId;

        // member variable for the ImmunizationRecordFlag property
        private System.Boolean? _ImmunizationRecordFlag;

        // member variable for the LastQualifyingMoveDate property
        private System.DateTime? _LastQualifyingMoveDate;

        // member variable for the MepEligibilityExpirationDate property
        private System.DateTime? _MepEligibilityExpirationDate;

        // member variable for the MigrantStudentQualifyingArrivalDate property
        private System.DateTime? _MigrantStudentQualifyingArrivalDate;

        // member variable for the PersonProgramParticipationId property
        private Guid _PersonProgramParticipationId;

        // member variable for the PrioritizedForServices property
        private System.Boolean? _PrioritizedForServices;

        // member variable for the QualifyingMoveFromCity property
        private System.String _QualifyingMoveFromCity;

        // member variable for the RefContinuationOfServicesReasonId property
        private Guid? _RefContinuationOfServicesReasonId;

        // member variable for the RefMepEnrollmentTypeId property
        private Guid? _RefMepEnrollmentTypeId;

        // member variable for the RefMepProjectBasedId property
        private Guid? _RefMepProjectBasedId;

        // member variable for the RefMepServiceTypeId property
        private Guid? _RefMepServiceTypeId;

        // member variable for the RefQualifyingMoveFromCountryId property
        private Guid? _RefQualifyingMoveFromCountryId;

        // member variable for the RefQualifyingMoveFromStateId property
        private Guid? _RefQualifyingMoveFromStateId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the ProgramParticipationMigrantViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The year, month and day of the last qualifying move of a migrant student.
        /// </summary>
        public System.String BirthdateVerification { get => _BirthdateVerification; set => SetProperty(ref _BirthdateVerification, value); }

        /// <summary>
        /// The year, month and day of the last qualifying move of a migrant student.
        /// </summary>
        public System.Boolean? ContinuationOfServicesStatus { get => _ContinuationOfServicesStatus; set => SetProperty(ref _ContinuationOfServicesStatus, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DesignatedGraduationSchool"/> model
        /// </summary>
        public Guid? DesignatedGraduationSchoolId { get => _DesignatedGraduationSchoolId; set => SetProperty(ref _DesignatedGraduationSchoolId, value); }

        /// <summary>
        /// The year, month and day of the last qualifying move of a migrant student.
        /// </summary>
        public System.Boolean? ImmunizationRecordFlag { get => _ImmunizationRecordFlag; set => SetProperty(ref _ImmunizationRecordFlag, value); }

        /// <summary>
        /// The year, month and day of the last qualifying move of a migrant student.
        /// </summary>
        public System.DateTime? LastQualifyingMoveDate { get => _LastQualifyingMoveDate; set => SetProperty(ref _LastQualifyingMoveDate, value); }

        /// <summary>
        /// The year, month and day of the last qualifying move of a migrant student.
        /// </summary>
        public System.DateTime? MepEligibilityExpirationDate { get => _MepEligibilityExpirationDate; set => SetProperty(ref _MepEligibilityExpirationDate, value); }

        /// <summary>
        /// The year, month and day of the last qualifying move of a migrant student.
        /// </summary>
        public System.DateTime? MigrantStudentQualifyingArrivalDate { get => _MigrantStudentQualifyingArrivalDate; set => SetProperty(ref _MigrantStudentQualifyingArrivalDate, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="PersonProgramParticipation"/> model
        /// </summary>
        public Guid PersonProgramParticipationId { get => _PersonProgramParticipationId; set => SetProperty(ref _PersonProgramParticipationId, value); }

        /// <summary>
        /// The year, month and day of the last qualifying move of a migrant student.
        /// </summary>
        public System.Boolean? PrioritizedForServices { get => _PrioritizedForServices; set => SetProperty(ref _PrioritizedForServices, value); }

        /// <summary>
        /// The year, month and day of the last qualifying move of a migrant student.
        /// </summary>
        public System.String QualifyingMoveFromCity { get => _QualifyingMoveFromCity; set => SetProperty(ref _QualifyingMoveFromCity, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefContinuationOfServicesReason"/> model
        /// </summary>
        public Guid? RefContinuationOfServicesReasonId { get => _RefContinuationOfServicesReasonId; set => SetProperty(ref _RefContinuationOfServicesReasonId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefMepEnrollmentType"/> model
        /// </summary>
        public Guid? RefMepEnrollmentTypeId { get => _RefMepEnrollmentTypeId; set => SetProperty(ref _RefMepEnrollmentTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefMepProjectBased"/> model
        /// </summary>
        public Guid? RefMepProjectBasedId { get => _RefMepProjectBasedId; set => SetProperty(ref _RefMepProjectBasedId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefMepServiceType"/> model
        /// </summary>
        public Guid? RefMepServiceTypeId { get => _RefMepServiceTypeId; set => SetProperty(ref _RefMepServiceTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefQualifyingMoveFromCountry"/> model
        /// </summary>
        public Guid? RefQualifyingMoveFromCountryId { get => _RefQualifyingMoveFromCountryId; set => SetProperty(ref _RefQualifyingMoveFromCountryId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefQualifyingMoveFromState"/> model
        /// </summary>
        public Guid? RefQualifyingMoveFromStateId { get => _RefQualifyingMoveFromStateId; set => SetProperty(ref _RefQualifyingMoveFromStateId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IProgramParticipationMigrant model)
        {
            IsBusy = true;
            Id = model.Id;
            BirthdateVerification = model.BirthdateVerification;
            ContinuationOfServicesStatus = model.ContinuationOfServicesStatus;
            DesignatedGraduationSchoolId = model.DesignatedGraduationSchoolId;
            ImmunizationRecordFlag = model.ImmunizationRecordFlag;
            LastQualifyingMoveDate = model.LastQualifyingMoveDate;
            MepEligibilityExpirationDate = model.MepEligibilityExpirationDate;
            MigrantStudentQualifyingArrivalDate = model.MigrantStudentQualifyingArrivalDate;
            PersonProgramParticipationId = model.PersonProgramParticipationId;
            PrioritizedForServices = model.PrioritizedForServices;
            QualifyingMoveFromCity = model.QualifyingMoveFromCity;
            RefContinuationOfServicesReasonId = model.RefContinuationOfServicesReasonId;
            RefMepEnrollmentTypeId = model.RefMepEnrollmentTypeId;
            RefMepProjectBasedId = model.RefMepProjectBasedId;
            RefMepServiceTypeId = model.RefMepServiceTypeId;
            RefQualifyingMoveFromCountryId = model.RefQualifyingMoveFromCountryId;
            RefQualifyingMoveFromStateId = model.RefQualifyingMoveFromStateId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
