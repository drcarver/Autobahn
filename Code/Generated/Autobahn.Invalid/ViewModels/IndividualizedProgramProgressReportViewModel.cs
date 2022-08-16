//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   IndividualizedProgramProgressReportViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Invalid.ViewModels
{
     /// <summary>
     /// The IndividualizedProgramProgressReportViewModel
     /// </summary>
    public partial class IndividualizedProgramProgressReportViewModel : ViewModelBase, Interfaces.IIndividualizedProgramProgressReport
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from IndividualizedProgramProgressReport";

        // member variable for the ProgressDescription property
        private  _ProgressDescription;

        // member variable for the ProgressReportDate property
        private Guid? _ProgressReportDate;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

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
        public  ProgressDescription { get => _ProgressDescription; set => SetProperty(ref _ProgressDescription, value); }

        /// <summary>
        /// </summary>
        public Guid? ProgressReportDate { get => _ProgressReportDate; set => SetProperty(ref _ProgressReportDate, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIPSPProgressReportType"/> model
        /// </summary>
        public  RefIPSPProgressReportTypeId { get => _RefIPSPProgressReportTypeId; set => SetProperty(ref _RefIPSPProgressReportTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IIndividualizedProgramProgressReport model)
        {
            IsBusy = true;
            Id = model.Id;
            ProgressDescription = model.ProgressDescription; // 
            ProgressReportDate = model.ProgressReportDate; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefIPSPProgressReportTypeId = model.RefIPSPProgressReportTypeId; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
