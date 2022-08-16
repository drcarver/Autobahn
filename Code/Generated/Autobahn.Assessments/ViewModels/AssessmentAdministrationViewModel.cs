//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentAdministrationViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Assessments.ViewModels
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
        private  _AssessmentAdministrationPeriodDescription;

        // member variable for the AssessmentSecureIndicator property
        private Guid? _AssessmentSecureIndicator;

        // member variable for the Code property
        private  _Code;

        // member variable for the FinishDate property
        private  _FinishDate;

        // member variable for the FinishTime property
        private  _FinishTime;

        // member variable for the Name property
        private  _Name;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the StartDate property
        private  _StartDate;

        // member variable for the StartTime property
        private  _StartTime;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public  AssessmentAdministrationPeriodDescription { get => _AssessmentAdministrationPeriodDescription; set => SetProperty(ref _AssessmentAdministrationPeriodDescription, value); }

        /// <summary>
        /// </summary>
        public Guid? AssessmentSecureIndicator { get => _AssessmentSecureIndicator; set => SetProperty(ref _AssessmentSecureIndicator, value); }

        /// <summary>
        /// </summary>
        public  Code { get => _Code; set => SetProperty(ref _Code, value); }

        /// <summary>
        /// </summary>
        public  FinishDate { get => _FinishDate; set => SetProperty(ref _FinishDate, value); }

        /// <summary>
        /// </summary>
        public  FinishTime { get => _FinishTime; set => SetProperty(ref _FinishTime, value); }

        /// <summary>
        /// </summary>
        public  Name { get => _Name; set => SetProperty(ref _Name, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// </summary>
        public  StartDate { get => _StartDate; set => SetProperty(ref _StartDate, value); }

        /// <summary>
        /// </summary>
        public  StartTime { get => _StartTime; set => SetProperty(ref _StartTime, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAssessmentAdministration model)
        {
            IsBusy = true;
            Id = model.Id;
            AssessmentAdministrationPeriodDescription = model.AssessmentAdministrationPeriodDescription; // 
            AssessmentSecureIndicator = model.AssessmentSecureIndicator; // 
            Code = model.Code; // 
            FinishDate = model.FinishDate; // 
            FinishTime = model.FinishTime; // 
            Name = model.Name; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            StartDate = model.StartDate; // 
            StartTime = model.StartTime; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
