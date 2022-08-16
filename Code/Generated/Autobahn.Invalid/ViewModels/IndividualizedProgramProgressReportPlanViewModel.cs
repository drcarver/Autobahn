//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   IndividualizedProgramProgressReportPlanViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Invalid.ViewModels
{
     /// <summary>
     /// The IndividualizedProgramProgressReportPlanViewModel
     /// </summary>
    public partial class IndividualizedProgramProgressReportPlanViewModel : ViewModelBase, Interfaces.IIndividualizedProgramProgressReportPlan
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from IndividualizedProgramProgressReportPlan";

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefIPSPProgressReportScheduleId property
        private Guid? _RefIPSPProgressReportScheduleId;

        // member variable for the RefIPSPProgressReportTypeId property
        private  _RefIPSPProgressReportTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIPSPProgressReportSchedule"/> model
        /// </summary>
        public Guid? RefIPSPProgressReportScheduleId { get => _RefIPSPProgressReportScheduleId; set => SetProperty(ref _RefIPSPProgressReportScheduleId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIPSPProgressReportType"/> model
        /// </summary>
        public  RefIPSPProgressReportTypeId { get => _RefIPSPProgressReportTypeId; set => SetProperty(ref _RefIPSPProgressReportTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IIndividualizedProgramProgressReportPlan model)
        {
            IsBusy = true;
            Id = model.Id;
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefIPSPProgressReportScheduleId = model.RefIPSPProgressReportScheduleId; // 
            RefIPSPProgressReportTypeId = model.RefIPSPProgressReportTypeId; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
