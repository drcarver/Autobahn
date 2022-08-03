//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   PsStudentAcademicRecordViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Postsecondary.Interfaces;

namespace Autobahn.Postsecondary.ViewModels
{
     /// <summary>
     /// The PsStudentAcademicRecordViewModel
     /// </summary>
    public partial class PsStudentAcademicRecordViewModel : BindableBase, IPsStudentAcademicRecord
    {
#region "Backing Fields"
        // member variable for the AcademicYearDesignator property
        private System.String _AcademicYearDesignator;

        // member variable for the GradePointAverage property
        private System.Decimal? _GradePointAverage;

        // member variable for the GradePointAverageCumulative property
        private System.Decimal? _GradePointAverageCumulative;

        // member variable for the DualCreditDualEnrollmentCredits property
        private System.Decimal? _DualCreditDualEnrollmentCredits;

        // member variable for the AdvancedPlacementCreditsAwarded property
        private System.Int32? _AdvancedPlacementCreditsAwarded;

        // member variable for the DiplomaOrCredentialAwardDate property
        private System.String _DiplomaOrCredentialAwardDate;

        // member variable for the EnteringTerm property
        private System.String _EnteringTerm;

        // member variable for the CourseTotal property
        private System.Int32? _CourseTotal;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

        // member variable for the CreditsAttemptedCumulative property
        private System.Decimal? _CreditsAttemptedCumulative;

        // member variable for the CreditsEarnedCumulative property
        private System.Decimal? _CreditsEarnedCumulative;

        // member variable for the NumberOfCreditsAttempted property
        private System.Decimal? _NumberOfCreditsAttempted;

#endregion

#region Properties
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRoleId"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        public System.String AcademicYearDesignator  { get => _AcademicYearDesignator; set => SetProperty(ref _AcademicYearDesignator, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAcademicTermDesignatorId"/> model
        /// </summary>
        public Guid? RefAcademicTermDesignatorId { get; set; }

        public System.Decimal? GradePointAverage { get => _GradePointAverage; set => SetProperty(ref _GradePointAverage, value); }

        public System.Decimal? GradePointAverageCumulative { get => _GradePointAverageCumulative; set => SetProperty(ref _GradePointAverageCumulative, value); }

        public System.Decimal? DualCreditDualEnrollmentCredits { get => _DualCreditDualEnrollmentCredits; set => SetProperty(ref _DualCreditDualEnrollmentCredits, value); }

        public System.Int32? AdvancedPlacementCreditsAwarded { get => _AdvancedPlacementCreditsAwarded; set => SetProperty(ref _AdvancedPlacementCreditsAwarded, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefProfessionalTechCredentialTypeId"/> model
        /// </summary>
        public Guid? RefProfessionalTechCredentialTypeId { get; set; }

        public System.String DiplomaOrCredentialAwardDate  { get => _DiplomaOrCredentialAwardDate; set => SetProperty(ref _DiplomaOrCredentialAwardDate, value); }

        public System.String EnteringTerm  { get => _EnteringTerm; set => SetProperty(ref _EnteringTerm, value); }

        public System.Int32? CourseTotal { get => _CourseTotal; set => SetProperty(ref _CourseTotal, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCreditHoursAppliedOtherProgramId"/> model
        /// </summary>
        public Guid? RefCreditHoursAppliedOtherProgramId { get; set; }

        public System.DateTime? RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        public System.DateTime? RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        public System.Decimal? CreditsAttemptedCumulative { get => _CreditsAttemptedCumulative; set => SetProperty(ref _CreditsAttemptedCumulative, value); }

        public System.Decimal? CreditsEarnedCumulative { get => _CreditsEarnedCumulative; set => SetProperty(ref _CreditsEarnedCumulative, value); }

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
        public void Load(IPsStudentAcademicRecord model)
        {
            IsBusy = true;
            Id = model.Id;
            OrganizationPersonRoleId = model.OrganizationPersonRoleId;
            AcademicYearDesignator = model.AcademicYearDesignator;
            RefAcademicTermDesignatorId = model.RefAcademicTermDesignatorId;
            GradePointAverage = model.GradePointAverage;
            GradePointAverageCumulative = model.GradePointAverageCumulative;
            DualCreditDualEnrollmentCredits = model.DualCreditDualEnrollmentCredits;
            AdvancedPlacementCreditsAwarded = model.AdvancedPlacementCreditsAwarded;
            RefProfessionalTechCredentialTypeId = model.RefProfessionalTechCredentialTypeId;
            DiplomaOrCredentialAwardDate = model.DiplomaOrCredentialAwardDate;
            EnteringTerm = model.EnteringTerm;
            CourseTotal = model.CourseTotal;
            RefCreditHoursAppliedOtherProgramId = model.RefCreditHoursAppliedOtherProgramId;
            RecordStartDateTime = model.RecordStartDateTime;
            RecordEndDateTime = model.RecordEndDateTime;
            CreditsAttemptedCumulative = model.CreditsAttemptedCumulative;
            CreditsEarnedCumulative = model.CreditsEarnedCumulative;
            NumberOfCreditsAttempted = model.NumberOfCreditsAttempted;
            RecordStatusId = model.RecordStatusId;
            DataCollectionId = model.DataCollectionId;
            IsChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
