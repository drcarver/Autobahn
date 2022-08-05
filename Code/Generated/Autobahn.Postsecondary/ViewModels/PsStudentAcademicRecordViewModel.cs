//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   PsStudentAcademicRecordViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.Postsecondary.ViewModels
{
     /// <summary>
     /// The PsStudentAcademicRecordViewModel
     /// </summary>
    public partial class PsStudentAcademicRecordViewModel : ViewModelBase, Interfaces.IPsStudentAcademicRecord
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PsStudentAcademicRecord";

        // member variable for the OrganizationPersonRoleId property
        private Guid _OrganizationPersonRoleId;

        // member variable for the AcademicYearDesignator property
        private System.String _AcademicYearDesignator;

        // member variable for the RefAcademicTermDesignatorId property
        private Guid? _RefAcademicTermDesignatorId;

        // member variable for the GradePointAverage property
        private System.Decimal? _GradePointAverage;

        // member variable for the GradePointAverageCumulative property
        private System.Decimal? _GradePointAverageCumulative;

        // member variable for the DualCreditDualEnrollmentCredits property
        private System.Decimal? _DualCreditDualEnrollmentCredits;

        // member variable for the AdvancedPlacementCreditsAwarded property
        private System.Int32? _AdvancedPlacementCreditsAwarded;

        // member variable for the RefProfessionalTechCredentialTypeId property
        private Guid? _RefProfessionalTechCredentialTypeId;

        // member variable for the DiplomaOrCredentialAwardDate property
        private System.String _DiplomaOrCredentialAwardDate;

        // member variable for the EnteringTerm property
        private System.String _EnteringTerm;

        // member variable for the CourseTotal property
        private System.Int32? _CourseTotal;

        // member variable for the RefCreditHoursAppliedOtherProgramId property
        private Guid? _RefCreditHoursAppliedOtherProgramId;

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

        // member variable for the RecordStatusId property
        private Guid? _RecordStatusId;

        // member variable for the DataCollectionId property
        private Guid? _DataCollectionId;

#endregion

        #region Properties
        /// <summary>
        /// The title of the PsStudentAcademicRecordViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRoleId"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get => _OrganizationPersonRoleId; set => SetProperty(ref _OrganizationPersonRoleId, value); }

        public System.String AcademicYearDesignator  { get => _AcademicYearDesignator; set => SetProperty(ref _AcademicYearDesignator, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAcademicTermDesignatorId"/> model
        /// </summary>
        public Guid? RefAcademicTermDesignatorId { get => _RefAcademicTermDesignatorId; set => SetProperty(ref _RefAcademicTermDesignatorId, value); }

        public System.Decimal? GradePointAverage { get => _GradePointAverage; set => SetProperty(ref _GradePointAverage, value); }

        public System.Decimal? GradePointAverageCumulative { get => _GradePointAverageCumulative; set => SetProperty(ref _GradePointAverageCumulative, value); }

        public System.Decimal? DualCreditDualEnrollmentCredits { get => _DualCreditDualEnrollmentCredits; set => SetProperty(ref _DualCreditDualEnrollmentCredits, value); }

        public System.Int32? AdvancedPlacementCreditsAwarded { get => _AdvancedPlacementCreditsAwarded; set => SetProperty(ref _AdvancedPlacementCreditsAwarded, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefProfessionalTechCredentialTypeId"/> model
        /// </summary>
        public Guid? RefProfessionalTechCredentialTypeId { get => _RefProfessionalTechCredentialTypeId; set => SetProperty(ref _RefProfessionalTechCredentialTypeId, value); }

        public System.String DiplomaOrCredentialAwardDate  { get => _DiplomaOrCredentialAwardDate; set => SetProperty(ref _DiplomaOrCredentialAwardDate, value); }

        public System.String EnteringTerm  { get => _EnteringTerm; set => SetProperty(ref _EnteringTerm, value); }

        public System.Int32? CourseTotal { get => _CourseTotal; set => SetProperty(ref _CourseTotal, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCreditHoursAppliedOtherProgramId"/> model
        /// </summary>
        public Guid? RefCreditHoursAppliedOtherProgramId { get => _RefCreditHoursAppliedOtherProgramId; set => SetProperty(ref _RefCreditHoursAppliedOtherProgramId, value); }

        public System.Decimal? CreditsAttemptedCumulative { get => _CreditsAttemptedCumulative; set => SetProperty(ref _CreditsAttemptedCumulative, value); }

        public System.Decimal? CreditsEarnedCumulative { get => _CreditsEarnedCumulative; set => SetProperty(ref _CreditsEarnedCumulative, value); }

        public System.Decimal? NumberOfCreditsAttempted { get => _NumberOfCreditsAttempted; set => SetProperty(ref _NumberOfCreditsAttempted, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPsStudentAcademicRecord model)
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
            CreditsAttemptedCumulative = model.CreditsAttemptedCumulative;
            CreditsEarnedCumulative = model.CreditsEarnedCumulative;
            NumberOfCreditsAttempted = model.NumberOfCreditsAttempted;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
