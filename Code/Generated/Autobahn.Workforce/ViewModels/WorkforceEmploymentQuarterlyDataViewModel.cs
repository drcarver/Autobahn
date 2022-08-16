//**********************************************************
//* DomainName: Workforce
//* FileName:   WorkforceEmploymentQuarterlyDataViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Workforce.ViewModels
{
     /// <summary>
     /// The WorkforceEmploymentQuarterlyDataViewModel
     /// </summary>
    public partial class WorkforceEmploymentQuarterlyDataViewModel : ViewModelBase, Interfaces.IWorkforceEmploymentQuarterlyData
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from WorkforceEmploymentQuarterlyData";

        // member variable for the EmployedInMultipleJobsCount property
        private  _EmployedInMultipleJobsCount;

        // member variable for the MilitaryEnlistmentAfterExit property
        private  _MilitaryEnlistmentAfterExit;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefEmployedAfterExitId property
        private  _RefEmployedAfterExitId;

        // member variable for the RefEmployedWhileEnrolledId property
        private Guid? _RefEmployedWhileEnrolledId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public  EmployedInMultipleJobsCount { get => _EmployedInMultipleJobsCount; set => SetProperty(ref _EmployedInMultipleJobsCount, value); }

        /// <summary>
        /// </summary>
        public  MilitaryEnlistmentAfterExit { get => _MilitaryEnlistmentAfterExit; set => SetProperty(ref _MilitaryEnlistmentAfterExit, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEmployedAfterExit"/> model
        /// </summary>
        public  RefEmployedAfterExitId { get => _RefEmployedAfterExitId; set => SetProperty(ref _RefEmployedAfterExitId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEmployedWhileEnrolled"/> model
        /// </summary>
        public Guid? RefEmployedWhileEnrolledId { get => _RefEmployedWhileEnrolledId; set => SetProperty(ref _RefEmployedWhileEnrolledId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IWorkforceEmploymentQuarterlyData model)
        {
            IsBusy = true;
            Id = model.Id;
            EmployedInMultipleJobsCount = model.EmployedInMultipleJobsCount; // 
            MilitaryEnlistmentAfterExit = model.MilitaryEnlistmentAfterExit; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefEmployedAfterExitId = model.RefEmployedAfterExitId; // 
            RefEmployedWhileEnrolledId = model.RefEmployedWhileEnrolledId; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
