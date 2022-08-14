//**********************************************************
//* DomainName: Postsecondary (PS)
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

        // member variable for the AcademicYearDesignator property
        private System.String _AcademicYearDesignator;

        // member variable for the AdvancedPlacementCreditsAwarded property
        private System.Int32? _AdvancedPlacementCreditsAwarded;

        // member variable for the CourseTotal property
        private System.Int32? _CourseTotal;

        // member variable for the CreditsAttemptedCumulative property
        private System.Decimal? _CreditsAttemptedCumulative;

        // member variable for the CreditsEarnedCumulative property
        private System.Decimal? _CreditsEarnedCumulative;

        // member variable for the DiplomaOrCredentialAwardDate property
        private System.String _DiplomaOrCredentialAwardDate;

        // member variable for the DualCreditDualEnrollmentCredits property
        private System.Decimal? _DualCreditDualEnrollmentCredits;

        // member variable for the EnteringTerm property
        private System.String _EnteringTerm;

        // member variable for the GradePointAverage property
        private System.Decimal? _GradePointAverage;

        // member variable for the GradePointAverageCumulative property
        private System.Decimal? _GradePointAverageCumulative;

        // member variable for the NumberOfCreditsAttempted property
        private System.Decimal? _NumberOfCreditsAttempted;

        // member variable for the OrganizationPersonRoleId property
        private Guid _OrganizationPersonRoleId;

        // member variable for the RefAcademicTermDesignatorId property
        private Guid? _RefAcademicTermDesignatorId;

        // member variable for the RefCreditHoursAppliedOtherProgramId property
        private Guid? _RefCreditHoursAppliedOtherProgramId;

        // member variable for the RefProfessionalTechCredentialTypeId property
        private Guid? _RefProfessionalTechCredentialTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the PsStudentAcademicRecordViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The number of credits awarded a student by the postsecondary institution based on successful completion of advanced placement courses and/or advanced placement tests. 
        /// </summary>
        public System.String AcademicYearDesignator { get => _AcademicYearDesignator; set => SetProperty(ref _AcademicYearDesignator, value); }

        /// <summary>
        /// The number of credits awarded a student by the postsecondary institution based on successful completion of advanced placement courses and/or advanced placement tests. 
        /// </summary>
        public System.Int32? AdvancedPlacementCreditsAwarded { get => _AdvancedPlacementCreditsAwarded; set => SetProperty(ref _AdvancedPlacementCreditsAwarded, value); }

        /// <summary>
        /// The number of credits awarded a student by the postsecondary institution based on successful completion of advanced placement courses and/or advanced placement tests. 
        /// </summary>
        public System.Int32? CourseTotal { get => _CourseTotal; set => SetProperty(ref _CourseTotal, value); }

        /// <summary>
        /// The number of credits awarded a student by the postsecondary institution based on successful completion of advanced placement courses and/or advanced placement tests. 
        /// </summary>
        public System.Decimal? CreditsAttemptedCumulative { get => _CreditsAttemptedCumulative; set => SetProperty(ref _CreditsAttemptedCumulative, value); }

        /// <summary>
        /// The number of credits awarded a student by the postsecondary institution based on successful completion of advanced placement courses and/or advanced placement tests. 
        /// </summary>
        public System.Decimal? CreditsEarnedCumulative { get => _CreditsEarnedCumulative; set => SetProperty(ref _CreditsEarnedCumulative, value); }

        /// <summary>
        /// The number of credits awarded a student by the postsecondary institution based on successful completion of advanced placement courses and/or advanced placement tests. 
        /// </summary>
        public System.String DiplomaOrCredentialAwardDate { get => _DiplomaOrCredentialAwardDate; set => SetProperty(ref _DiplomaOrCredentialAwardDate, value); }

        /// <summary>
        /// The number of credits awarded a student by the postsecondary institution based on successful completion of advanced placement courses and/or advanced placement tests. 
        /// </summary>
        public System.Decimal? DualCreditDualEnrollmentCredits { get => _DualCreditDualEnrollmentCredits; set => SetProperty(ref _DualCreditDualEnrollmentCredits, value); }

        /// <summary>
        /// The number of credits awarded a student by the postsecondary institution based on successful completion of advanced placement courses and/or advanced placement tests. 
        /// </summary>
        public System.String EnteringTerm { get => _EnteringTerm; set => SetProperty(ref _EnteringTerm, value); }

        /// <summary>
        /// The number of credits awarded a student by the postsecondary institution based on successful completion of advanced placement courses and/or advanced placement tests. 
        /// </summary>
        public System.Decimal? GradePointAverage { get => _GradePointAverage; set => SetProperty(ref _GradePointAverage, value); }

        /// <summary>
        /// The number of credits awarded a student by the postsecondary institution based on successful completion of advanced placement courses and/or advanced placement tests. 
        /// </summary>
        public System.Decimal? GradePointAverageCumulative { get => _GradePointAverageCumulative; set => SetProperty(ref _GradePointAverageCumulative, value); }

        /// <summary>
        /// The number of credits awarded a student by the postsecondary institution based on successful completion of advanced placement courses and/or advanced placement tests. 
        /// </summary>
        public System.Decimal? NumberOfCreditsAttempted { get => _NumberOfCreditsAttempted; set => SetProperty(ref _NumberOfCreditsAttempted, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get => _OrganizationPersonRoleId; set => SetProperty(ref _OrganizationPersonRoleId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAcademicTermDesignator"/> model
        /// </summary>
        public Guid? RefAcademicTermDesignatorId { get => _RefAcademicTermDesignatorId; set => SetProperty(ref _RefAcademicTermDesignatorId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCreditHoursAppliedOtherProgram"/> model
        /// </summary>
        public Guid? RefCreditHoursAppliedOtherProgramId { get => _RefCreditHoursAppliedOtherProgramId; set => SetProperty(ref _RefCreditHoursAppliedOtherProgramId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefProfessionalTechCredentialType"/> model
        /// </summary>
        public Guid? RefProfessionalTechCredentialTypeId { get => _RefProfessionalTechCredentialTypeId; set => SetProperty(ref _RefProfessionalTechCredentialTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPsStudentAcademicRecord model)
        {
            IsBusy = true;
            Id = model.Id;
            AcademicYearDesignator = model.AcademicYearDesignator;
            AdvancedPlacementCreditsAwarded = model.AdvancedPlacementCreditsAwarded;
            CourseTotal = model.CourseTotal;
            CreditsAttemptedCumulative = model.CreditsAttemptedCumulative;
            CreditsEarnedCumulative = model.CreditsEarnedCumulative;
            DiplomaOrCredentialAwardDate = model.DiplomaOrCredentialAwardDate;
            DualCreditDualEnrollmentCredits = model.DualCreditDualEnrollmentCredits;
            EnteringTerm = model.EnteringTerm;
            GradePointAverage = model.GradePointAverage;
            GradePointAverageCumulative = model.GradePointAverageCumulative;
            NumberOfCreditsAttempted = model.NumberOfCreditsAttempted;
            OrganizationPersonRoleId = model.OrganizationPersonRoleId;
            RefAcademicTermDesignatorId = model.RefAcademicTermDesignatorId;
            RefCreditHoursAppliedOtherProgramId = model.RefCreditHoursAppliedOtherProgramId;
            RefProfessionalTechCredentialTypeId = model.RefProfessionalTechCredentialTypeId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
