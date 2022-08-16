//**********************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   PsStudentAcademicRecordViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

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
        private  _AcademicYearDesignator;

        // member variable for the AdvancedPlacementCreditsAwarded property
        private Guid? _AdvancedPlacementCreditsAwarded;

        // member variable for the CourseTotal property
        private  _CourseTotal;

        // member variable for the CreditsAttemptedCumulative property
        private  _CreditsAttemptedCumulative;

        // member variable for the CreditsEarnedCumulative property
        private  _CreditsEarnedCumulative;

        // member variable for the DiplomaOrCredentialAwardDate property
        private  _DiplomaOrCredentialAwardDate;

        // member variable for the DualCreditDualEnrollmentCredits property
        private  _DualCreditDualEnrollmentCredits;

        // member variable for the EnteringTerm property
        private  _EnteringTerm;

        // member variable for the GradePointAverage property
        private  _GradePointAverage;

        // member variable for the GradePointAverageCumulative property
        private  _GradePointAverageCumulative;

        // member variable for the NumberOfCreditsAttempted property
        private  _NumberOfCreditsAttempted;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefAcademicTermDesignatorId property
        private  _RefAcademicTermDesignatorId;

        // member variable for the RefCreditHoursAppliedOtherProgramId property
        private  _RefCreditHoursAppliedOtherProgramId;

        // member variable for the RefProfessionalTechCredentialTypeId property
        private  _RefProfessionalTechCredentialTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public  AcademicYearDesignator { get => _AcademicYearDesignator; set => SetProperty(ref _AcademicYearDesignator, value); }

        /// <summary>
        /// </summary>
        public Guid? AdvancedPlacementCreditsAwarded { get => _AdvancedPlacementCreditsAwarded; set => SetProperty(ref _AdvancedPlacementCreditsAwarded, value); }

        /// <summary>
        /// </summary>
        public  CourseTotal { get => _CourseTotal; set => SetProperty(ref _CourseTotal, value); }

        /// <summary>
        /// </summary>
        public  CreditsAttemptedCumulative { get => _CreditsAttemptedCumulative; set => SetProperty(ref _CreditsAttemptedCumulative, value); }

        /// <summary>
        /// </summary>
        public  CreditsEarnedCumulative { get => _CreditsEarnedCumulative; set => SetProperty(ref _CreditsEarnedCumulative, value); }

        /// <summary>
        /// </summary>
        public  DiplomaOrCredentialAwardDate { get => _DiplomaOrCredentialAwardDate; set => SetProperty(ref _DiplomaOrCredentialAwardDate, value); }

        /// <summary>
        /// </summary>
        public  DualCreditDualEnrollmentCredits { get => _DualCreditDualEnrollmentCredits; set => SetProperty(ref _DualCreditDualEnrollmentCredits, value); }

        /// <summary>
        /// </summary>
        public  EnteringTerm { get => _EnteringTerm; set => SetProperty(ref _EnteringTerm, value); }

        /// <summary>
        /// </summary>
        public  GradePointAverage { get => _GradePointAverage; set => SetProperty(ref _GradePointAverage, value); }

        /// <summary>
        /// </summary>
        public  GradePointAverageCumulative { get => _GradePointAverageCumulative; set => SetProperty(ref _GradePointAverageCumulative, value); }

        /// <summary>
        /// </summary>
        public  NumberOfCreditsAttempted { get => _NumberOfCreditsAttempted; set => SetProperty(ref _NumberOfCreditsAttempted, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAcademicTermDesignator"/> model
        /// </summary>
        public  RefAcademicTermDesignatorId { get => _RefAcademicTermDesignatorId; set => SetProperty(ref _RefAcademicTermDesignatorId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCreditHoursAppliedOtherProgram"/> model
        /// </summary>
        public  RefCreditHoursAppliedOtherProgramId { get => _RefCreditHoursAppliedOtherProgramId; set => SetProperty(ref _RefCreditHoursAppliedOtherProgramId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefProfessionalTechCredentialType"/> model
        /// </summary>
        public  RefProfessionalTechCredentialTypeId { get => _RefProfessionalTechCredentialTypeId; set => SetProperty(ref _RefProfessionalTechCredentialTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPsStudentAcademicRecord model)
        {
            IsBusy = true;
            Id = model.Id;
            AcademicYearDesignator = model.AcademicYearDesignator; // 
            AdvancedPlacementCreditsAwarded = model.AdvancedPlacementCreditsAwarded; // 
            CourseTotal = model.CourseTotal; // 
            CreditsAttemptedCumulative = model.CreditsAttemptedCumulative; // 
            CreditsEarnedCumulative = model.CreditsEarnedCumulative; // 
            DiplomaOrCredentialAwardDate = model.DiplomaOrCredentialAwardDate; // 
            DualCreditDualEnrollmentCredits = model.DualCreditDualEnrollmentCredits; // 
            EnteringTerm = model.EnteringTerm; // 
            GradePointAverage = model.GradePointAverage; // 
            GradePointAverageCumulative = model.GradePointAverageCumulative; // 
            NumberOfCreditsAttempted = model.NumberOfCreditsAttempted; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefAcademicTermDesignatorId = model.RefAcademicTermDesignatorId; // 
            RefCreditHoursAppliedOtherProgramId = model.RefCreditHoursAppliedOtherProgramId; // 
            RefProfessionalTechCredentialTypeId = model.RefProfessionalTechCredentialTypeId; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
