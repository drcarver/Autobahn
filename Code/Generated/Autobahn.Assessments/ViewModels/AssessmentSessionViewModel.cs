//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentSessionViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Assessments.ViewModels
{
     /// <summary>
     /// The AssessmentSessionViewModel
     /// </summary>
    public partial class AssessmentSessionViewModel : ViewModelBase, Interfaces.IAssessmentSession
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from AssessmentSession";

        // member variable for the ActualEndDateTime property
        private  _ActualEndDateTime;

        // member variable for the ActualStartDateTime property
        private  _ActualStartDateTime;

        // member variable for the AllottedTime property
        private  _AllottedTime;

        // member variable for the Location property
        private  _Location;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefAssessmentSessionSpecialCircumstanceTypeId property
        private Guid? _RefAssessmentSessionSpecialCircumstanceTypeId;

        // member variable for the RefAssessmentSessionTypeId property
        private  _RefAssessmentSessionTypeId;

        // member variable for the ScheduledEndDateTime property
        private  _ScheduledEndDateTime;

        // member variable for the ScheduledStartDateTime property
        private  _ScheduledStartDateTime;

        // member variable for the SecurityIssue property
        private  _SecurityIssue;

        // member variable for the SpecialEventDescription property
        private  _SpecialEventDescription;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public  ActualEndDateTime { get => _ActualEndDateTime; set => SetProperty(ref _ActualEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  ActualStartDateTime { get => _ActualStartDateTime; set => SetProperty(ref _ActualStartDateTime, value); }

        /// <summary>
        /// </summary>
        public  AllottedTime { get => _AllottedTime; set => SetProperty(ref _AllottedTime, value); }

        /// <summary>
        /// </summary>
        public  Location { get => _Location; set => SetProperty(ref _Location, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentSessionSpecialCircumstanceType"/> model
        /// </summary>
        public Guid? RefAssessmentSessionSpecialCircumstanceTypeId { get => _RefAssessmentSessionSpecialCircumstanceTypeId; set => SetProperty(ref _RefAssessmentSessionSpecialCircumstanceTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentSessionType"/> model
        /// </summary>
        public  RefAssessmentSessionTypeId { get => _RefAssessmentSessionTypeId; set => SetProperty(ref _RefAssessmentSessionTypeId, value); }

        /// <summary>
        /// </summary>
        public  ScheduledEndDateTime { get => _ScheduledEndDateTime; set => SetProperty(ref _ScheduledEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  ScheduledStartDateTime { get => _ScheduledStartDateTime; set => SetProperty(ref _ScheduledStartDateTime, value); }

        /// <summary>
        /// </summary>
        public  SecurityIssue { get => _SecurityIssue; set => SetProperty(ref _SecurityIssue, value); }

        /// <summary>
        /// </summary>
        public  SpecialEventDescription { get => _SpecialEventDescription; set => SetProperty(ref _SpecialEventDescription, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAssessmentSession model)
        {
            IsBusy = true;
            Id = model.Id;
            ActualEndDateTime = model.ActualEndDateTime; // 
            ActualStartDateTime = model.ActualStartDateTime; // 
            AllottedTime = model.AllottedTime; // 
            Location = model.Location; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefAssessmentSessionSpecialCircumstanceTypeId = model.RefAssessmentSessionSpecialCircumstanceTypeId; // 
            RefAssessmentSessionTypeId = model.RefAssessmentSessionTypeId; // 
            ScheduledEndDateTime = model.ScheduledEndDateTime; // 
            ScheduledStartDateTime = model.ScheduledStartDateTime; // 
            SecurityIssue = model.SecurityIssue; // 
            SpecialEventDescription = model.SpecialEventDescription; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
