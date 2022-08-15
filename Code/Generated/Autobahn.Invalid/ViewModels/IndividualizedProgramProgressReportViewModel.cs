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

        // member variable for the ProgressReportDate property
        private System.DateTime? _ProgressReportDate;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the IndividualizedProgramProgressReportViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The date parents are notified of the student's progress on annual goals and if the progress is sufficient to achieve the goals by the end of the individualized program service plan.
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20680">Individualized Program Service Plan Progress Report Date</a>
        /// </para>
        /// </summary>
        [DisplayName("Individualized Program Service Plan Progress Report Date")]
        public System.DateTime? ProgressReportDate { get => _ProgressReportDate; set => SetProperty(ref _ProgressReportDate, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IIndividualizedProgramProgressReport model)
        {
            IsBusy = true;
            Id = model.Id;
            ProgressReportDate = model.ProgressReportDate; // Individualized Program Service Plan Progress Report Date
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
