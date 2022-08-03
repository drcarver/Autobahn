//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentAdministrationViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Assessment.Interfaces;

namespace Autobahn.Assessment.ViewModels
{
     /// <summary>
     /// The AssessmentAdministrationViewModel
     /// </summary>
    public partial class AssessmentAdministrationViewModel : BindableBase, IAssessmentAdministration
    {
#region "Backing Fields"
        // member variable for the Name property
        private System.String _Name;

        // member variable for the Code property
        private System.String _Code;

        // member variable for the StartDate property
        private System.DateTime? _StartDate;

        // member variable for the StartTime property
        private System.TimeSpan? _StartTime;

        // member variable for the FinishDate property
        private System.DateTime? _FinishDate;

        // member variable for the FinishTime property
        private System.TimeSpan? _FinishTime;

        // member variable for the AssessmentSecureIndicator property
        private System.Boolean? _AssessmentSecureIndicator;

        // member variable for the AssessmentAdministrationPeriodDescription property
        private System.String _AssessmentAdministrationPeriodDescription;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

#endregion

#region Properties
        /// <summary>
        /// Reference to an optional instance of the <see cref="AssessmentId"/> model
        /// </summary>
        public Guid? AssessmentId { get; set; }

        public System.String Name  { get => _Name; set => SetProperty(ref _Name, value); }

        public System.String Code  { get => _Code; set => SetProperty(ref _Code, value); }

        public System.DateTime? StartDate { get => _StartDate; set => SetProperty(ref _StartDate, value); }

        public System.TimeSpan? StartTime { get => _StartTime; set => SetProperty(ref _StartTime, value); }

        public System.DateTime? FinishDate { get => _FinishDate; set => SetProperty(ref _FinishDate, value); }

        public System.TimeSpan? FinishTime { get => _FinishTime; set => SetProperty(ref _FinishTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentReportingMethodId"/> model
        /// </summary>
        public Guid? RefAssessmentReportingMethodId { get; set; }

        public System.Boolean? AssessmentSecureIndicator { get => _AssessmentSecureIndicator; set => SetProperty(ref _AssessmentSecureIndicator, value); }

        public System.String AssessmentAdministrationPeriodDescription  { get => _AssessmentAdministrationPeriodDescription; set => SetProperty(ref _AssessmentAdministrationPeriodDescription, value); }

        public System.DateTime? RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        public System.DateTime? RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

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
        public void Load(IAssessmentAdministration model)
        {
            IsBusy = true;
            Id = model.Id;
            AssessmentId = model.AssessmentId;
            Name = model.Name;
            Code = model.Code;
            StartDate = model.StartDate;
            StartTime = model.StartTime;
            FinishDate = model.FinishDate;
            FinishTime = model.FinishTime;
            RefAssessmentReportingMethodId = model.RefAssessmentReportingMethodId;
            AssessmentSecureIndicator = model.AssessmentSecureIndicator;
            AssessmentAdministrationPeriodDescription = model.AssessmentAdministrationPeriodDescription;
            RecordStartDateTime = model.RecordStartDateTime;
            RecordEndDateTime = model.RecordEndDateTime;
            RecordStatusId = model.RecordStatusId;
            DataCollectionId = model.DataCollectionId;
            IsChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
