//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12StudentCohortViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.K12.ViewModels
{
     /// <summary>
     /// The K12StudentCohortViewModel
     /// </summary>
    public partial class K12StudentCohortViewModel : ViewModelBase, Interfaces.IK12StudentCohort
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from K12StudentCohort";

        // member variable for the CohortYear property
        private System.String _CohortYear;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the K12StudentCohortViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The school year in which the student entered the baseline group used for computing completion rates (e.g., high school, program).
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19046">Cohort Year</a>
        /// </para>
        /// </summary>
        [DisplayName("Cohort Year")]
        public System.String CohortYear { get => _CohortYear; set => SetProperty(ref _CohortYear, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IK12StudentCohort model)
        {
            IsBusy = true;
            Id = model.Id;
            CohortYear = model.CohortYear; // Cohort Year
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
