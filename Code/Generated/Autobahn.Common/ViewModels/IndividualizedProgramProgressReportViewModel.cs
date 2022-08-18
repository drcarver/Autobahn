//**********************************************************
//* DomainName: Common Models
//* FileName:   IndividualizedProgramProgressReportViewModel.cs
//***************************************************************************

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The IndividualizedProgramProgressReport View Model
     /// </summary>
    public partial class IndividualizedProgramProgressReportViewModel : ViewModelBase, Interfaces.IIndividualizedProgramProgressReport
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from IndividualizedProgramProgressReport";

        // member variable for the IndividualizedProgramId property
        private Guid _IndividualizedProgramId;

        // member variable for the IndividualizedProgramProgressReportPlanId property
        private Guid _IndividualizedProgramProgressReportPlanId;

        // ProgressDescription -- (backing property for Individualized Program Service Plan Progress Report Description)
        private System.String _ProgressDescription;

        // ProgressReportDate -- (backing property for Individualized Program Service Plan Progress Report Date)
        private System.DateTime? _ProgressReportDate;

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
        /// Reference to an optional instance of the <see cref="IIndividualizedProgramProgressReportPlan"/> model
        /// </summary>
        public Guid IndividualizedProgramProgressReportPlanId { get => _IndividualizedProgramProgressReportPlanId; set => SetProperty(ref _IndividualizedProgramProgressReportPlanId, value); }

        /// <summary>
        /// Individualized Program Service Plan Progress Report Description
        /// <para>
        /// A description of the progress report used to notify parents of the student's progress on annual goals and if the progress is sufficient to achieve the goals by the end of the individualized program service plan.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20681">Individualized Program Service Plan Progress Report Description</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String ProgressDescription { get => _ProgressDescription; set => SetProperty(ref _ProgressDescription, value); }

        /// <summary>
        /// Individualized Program Service Plan Progress Report Date
        /// <para>
        /// The date parents are notified of the student's progress on annual goals and if the progress is sufficient to achieve the goals by the end of the individualized program service plan.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20680">Individualized Program Service Plan Progress Report Date</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.DateTime? ProgressReportDate { get => _ProgressReportDate; set => SetProperty(ref _ProgressReportDate, value); }

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
        public void Load(Interfaces.IIndividualizedProgramProgressReport model)
        {
            IsBusy = true;
            Id = model.Id;
            IndividualizedProgramId = model.IndividualizedProgramId; // 
            IndividualizedProgramProgressReportPlanId = model.IndividualizedProgramProgressReportPlanId; // 
            ProgressDescription = model.ProgressDescription; // Individualized Program Service Plan Progress Report Description
            ProgressReportDate = model.ProgressReportDate; // Individualized Program Service Plan Progress Report Date
            RefIPSPProgressReportTypeId = model.RefIPSPProgressReportTypeId; // Individualized Program Service Plan Progress Report Type
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
