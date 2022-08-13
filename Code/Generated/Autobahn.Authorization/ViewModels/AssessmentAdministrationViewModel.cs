//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   AssessmentAdministrationViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;
using CommunityToolkit.Maui;

namespace Autobahn.Authorization.ViewModels
{
     /// <summary>
     /// The AssessmentAdministrationViewModel
     /// </summary>
    public partial class AssessmentAdministrationViewModel : ViewModelBase, Interfaces.IAssessmentAdministration
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from AssessmentAdministration";

        // member variable for the AssessmentAdministrationPeriodDescription property
        private System.String _AssessmentAdministrationPeriodDescription;

        // member variable for the AssessmentId property
        private Guid? _AssessmentId;

        // member variable for the AssessmentSecureIndicator property
        private System.Boolean? _AssessmentSecureIndicator;

        // member variable for the FinishDate property
        private System.DateTime? _FinishDate;

        // member variable for the FinishTime property
        private System.TimeSpan? _FinishTime;

        // member variable for the Name property
        private System.String _Name;

        // member variable for the RefAssessmentReportingMethodId property
        private Guid? _RefAssessmentReportingMethodId;

        // member variable for the StartDate property
        private System.DateTime? _StartDate;

        // member variable for the StartTime property
        private System.TimeSpan? _StartTime;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the AssessmentAdministrationViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Indicates whether or not the assessment is a secure assessment.
        /// </summary>
        public System.String AssessmentAdministrationPeriodDescription { get => _AssessmentAdministrationPeriodDescription; set => SetProperty(ref _AssessmentAdministrationPeriodDescription, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="Assessment"/> model
        /// </summary>
        public Guid? AssessmentId { get => _AssessmentId; set => SetProperty(ref _AssessmentId, value); }

        /// <summary>
        /// Indicates whether or not the assessment is a secure assessment.
        /// </summary>
        public System.Boolean? AssessmentSecureIndicator { get => _AssessmentSecureIndicator; set => SetProperty(ref _AssessmentSecureIndicator, value); }

        /// <summary>
        /// Indicates whether or not the assessment is a secure assessment.
        /// </summary>
        public System.DateTime? FinishDate { get => _FinishDate; set => SetProperty(ref _FinishDate, value); }

        /// <summary>
        /// Indicates whether or not the assessment is a secure assessment.
        /// </summary>
        public System.TimeSpan? FinishTime { get => _FinishTime; set => SetProperty(ref _FinishTime, value); }

        /// <summary>
        /// Indicates whether or not the assessment is a secure assessment.
        /// </summary>
        public System.String Name { get => _Name; set => SetProperty(ref _Name, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentReportingMethod"/> model
        /// </summary>
        public Guid? RefAssessmentReportingMethodId { get => _RefAssessmentReportingMethodId; set => SetProperty(ref _RefAssessmentReportingMethodId, value); }

        /// <summary>
        /// Indicates whether or not the assessment is a secure assessment.
        /// </summary>
        public System.DateTime? StartDate { get => _StartDate; set => SetProperty(ref _StartDate, value); }

        /// <summary>
        /// Indicates whether or not the assessment is a secure assessment.
        /// </summary>
        public System.TimeSpan? StartTime { get => _StartTime; set => SetProperty(ref _StartTime, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAssessmentAdministration model)
        {
            IsBusy = true;
            Id = model.Id;
            AssessmentAdministrationPeriodDescription = model.AssessmentAdministrationPeriodDescription;
            AssessmentId = model.AssessmentId;
            AssessmentSecureIndicator = model.AssessmentSecureIndicator;
            FinishDate = model.FinishDate;
            FinishTime = model.FinishTime;
            Name = model.Name;
            RefAssessmentReportingMethodId = model.RefAssessmentReportingMethodId;
            StartDate = model.StartDate;
            StartTime = model.StartTime;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
