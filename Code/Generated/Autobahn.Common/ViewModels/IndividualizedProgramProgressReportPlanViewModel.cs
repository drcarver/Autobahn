//**********************************************************
//* DomainName: Common Models
//* FileName:   IndividualizedProgramProgressReportPlanViewModel.cs
//***************************************************************************

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The IndividualizedProgramProgressReportPlan View Model
     /// </summary>
    public partial class IndividualizedProgramProgressReportPlanViewModel : ViewModelBase, Interfaces.IIndividualizedProgramProgressReportPlan
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from IndividualizedProgramProgressReportPlan";

        // member variable for the IndividualizedProgramId property
        private Guid _IndividualizedProgramId;

        // RefIPSPProgressReportScheduleId -- (backing property for Individualized Program Service Plan Progress Report Schedule)
        private Guid? _RefIPSPProgressReportScheduleId;

        // RefIPSPProgressReportTypeId -- (backing property for Individualized Program Service Plan Progress Report Type)
        private Guid? _RefIPSPProgressReportTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IIndividualizedProgram"/> model
        /// </summary>
        public Guid IndividualizedProgramId { get => _IndividualizedProgramId; set => SetProperty(ref _IndividualizedProgramId, value); }

        /// <summary>
        /// Individualized Program Service Plan Progress Report Schedule
        /// <para>
        /// Frequency by which parents are notified of the student's progress on annual goals and if the progress is sufficient to achieve the goals by the end of the individualized program service plan year.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20662">Individualized Program Service Plan Progress Report Schedule</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefIPSPProgressReportScheduleId { get => _RefIPSPProgressReportScheduleId; set => SetProperty(ref _RefIPSPProgressReportScheduleId, value); }

        /// <summary>
        /// Individualized Program Service Plan Progress Report Type
        /// <para>
        /// A method by which parents are notified of the student's progress on annual goals and if the progress is sufficient to achieve the goals by the end of the individualized program service plan.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20682">Individualized Program Service Plan Progress Report Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefIPSPProgressReportTypeId { get => _RefIPSPProgressReportTypeId; set => SetProperty(ref _RefIPSPProgressReportTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IIndividualizedProgramProgressReportPlan model)
        {
            IsBusy = true;
            Id = model.Id;
            IndividualizedProgramId = model.IndividualizedProgramId; // 
            RefIPSPProgressReportScheduleId = model.RefIPSPProgressReportScheduleId; // Individualized Program Service Plan Progress Report Schedule
            RefIPSPProgressReportTypeId = model.RefIPSPProgressReportTypeId; // Individualized Program Service Plan Progress Report Type
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
