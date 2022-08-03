//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   ProgramParticipationMigrantViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Common.Interfaces;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The ProgramParticipationMigrantViewModel
     /// </summary>
    public partial class ProgramParticipationMigrantViewModel : BindableBase, IProgramParticipationMigrant
    {
#region "Backing Fields"
        // member variable for the MepEligibilityExpirationDate property
        private System.DateTime? _MepEligibilityExpirationDate;

        // member variable for the ContinuationOfServicesStatus property
        private System.Boolean? _ContinuationOfServicesStatus;

        // member variable for the BirthdateVerification property
        private System.String _BirthdateVerification;

        // member variable for the ImmunizationRecordFlag property
        private System.Boolean? _ImmunizationRecordFlag;

        // member variable for the MigrantStudentQualifyingArrivalDate property
        private System.DateTime? _MigrantStudentQualifyingArrivalDate;

        // member variable for the LastQualifyingMoveDate property
        private System.DateTime? _LastQualifyingMoveDate;

        // member variable for the QualifyingMoveFromCity property
        private System.String _QualifyingMoveFromCity;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

        // member variable for the PrioritizedForServices property
        private System.Boolean? _PrioritizedForServices;

#endregion

#region Properties
        /// <summary>
        /// Reference to a required instance of the <see cref="PersonProgramParticipationId"/> model
        /// </summary>
        public Guid PersonProgramParticipationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefMepEnrollmentTypeId"/> model
        /// </summary>
        public Guid? RefMepEnrollmentTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefMepProjectBasedId"/> model
        /// </summary>
        public Guid? RefMepProjectBasedId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefMepServiceTypeId"/> model
        /// </summary>
        public Guid? RefMepServiceTypeId { get; set; }

        public System.DateTime? MepEligibilityExpirationDate { get => _MepEligibilityExpirationDate; set => SetProperty(ref _MepEligibilityExpirationDate, value); }

        public System.Boolean? ContinuationOfServicesStatus { get => _ContinuationOfServicesStatus; set => SetProperty(ref _ContinuationOfServicesStatus, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefContinuationOfServicesReasonId"/> model
        /// </summary>
        public Guid? RefContinuationOfServicesReasonId { get; set; }

        public System.String BirthdateVerification  { get => _BirthdateVerification; set => SetProperty(ref _BirthdateVerification, value); }

        public System.Boolean? ImmunizationRecordFlag { get => _ImmunizationRecordFlag; set => SetProperty(ref _ImmunizationRecordFlag, value); }

        public System.DateTime? MigrantStudentQualifyingArrivalDate { get => _MigrantStudentQualifyingArrivalDate; set => SetProperty(ref _MigrantStudentQualifyingArrivalDate, value); }

        public System.DateTime? LastQualifyingMoveDate { get => _LastQualifyingMoveDate; set => SetProperty(ref _LastQualifyingMoveDate, value); }

        public System.String QualifyingMoveFromCity  { get => _QualifyingMoveFromCity; set => SetProperty(ref _QualifyingMoveFromCity, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefQualifyingMoveFromStateId"/> model
        /// </summary>
        public Guid? RefQualifyingMoveFromStateId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefQualifyingMoveFromCountryId"/> model
        /// </summary>
        public Guid? RefQualifyingMoveFromCountryId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DesignatedGraduationSchoolId"/> model
        /// </summary>
        public Guid? DesignatedGraduationSchoolId { get; set; }

        public System.DateTime? RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        public System.DateTime? RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        public System.Boolean? PrioritizedForServices { get => _PrioritizedForServices; set => SetProperty(ref _PrioritizedForServices, value); }

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
        public void Load(IProgramParticipationMigrant model)
        {
            IsBusy = true;
            Id = model.Id;
            PersonProgramParticipationId = model.PersonProgramParticipationId;
            RefMepEnrollmentTypeId = model.RefMepEnrollmentTypeId;
            RefMepProjectBasedId = model.RefMepProjectBasedId;
            RefMepServiceTypeId = model.RefMepServiceTypeId;
            MepEligibilityExpirationDate = model.MepEligibilityExpirationDate;
            ContinuationOfServicesStatus = model.ContinuationOfServicesStatus;
            RefContinuationOfServicesReasonId = model.RefContinuationOfServicesReasonId;
            BirthdateVerification = model.BirthdateVerification;
            ImmunizationRecordFlag = model.ImmunizationRecordFlag;
            MigrantStudentQualifyingArrivalDate = model.MigrantStudentQualifyingArrivalDate;
            LastQualifyingMoveDate = model.LastQualifyingMoveDate;
            QualifyingMoveFromCity = model.QualifyingMoveFromCity;
            RefQualifyingMoveFromStateId = model.RefQualifyingMoveFromStateId;
            RefQualifyingMoveFromCountryId = model.RefQualifyingMoveFromCountryId;
            DesignatedGraduationSchoolId = model.DesignatedGraduationSchoolId;
            RecordStartDateTime = model.RecordStartDateTime;
            RecordEndDateTime = model.RecordEndDateTime;
            PrioritizedForServices = model.PrioritizedForServices;
            RecordStatusId = model.RecordStatusId;
            DataCollectionId = model.DataCollectionId;
            IsChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
