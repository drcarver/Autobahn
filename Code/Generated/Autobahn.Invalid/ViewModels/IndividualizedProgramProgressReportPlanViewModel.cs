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

        // member variable for the RefIPSPProgressReportScheduleId property
        private Guid? _RefIPSPProgressReportScheduleId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the IndividualizedProgramProgressReportPlanViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIPSPProgressReportSchedule"/> model
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20662">Individualized Program Service Plan Progress Report Schedule</a>
        /// </para>
        /// </summary>
        [DisplayName("Individualized Program Service Plan Progress Report Schedule")]
        public Guid? RefIPSPProgressReportScheduleId { get => _RefIPSPProgressReportScheduleId; set => SetProperty(ref _RefIPSPProgressReportScheduleId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IIndividualizedProgramProgressReportPlan model)
        {
            IsBusy = true;
            Id = model.Id;
            RefIPSPProgressReportScheduleId = model.RefIPSPProgressReportScheduleId; // Individualized Program Service Plan Progress Report Schedule
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
