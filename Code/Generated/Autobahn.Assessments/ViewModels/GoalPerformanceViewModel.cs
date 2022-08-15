//**********************************************************
//* DomainName: Assessments
//* FileName:   GoalPerformanceViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Assessments.ViewModels
{
     /// <summary>
     /// The GoalPerformanceViewModel
     /// </summary>
    public partial class GoalPerformanceViewModel : ViewModelBase, Interfaces.IGoalPerformance
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from GoalPerformance";

        // member variable for the CurrentPerformanceDescription property
        private System.String _CurrentPerformanceDescription;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the GoalPerformanceViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Current performance explanation related to the annual goal or short-term objectives.
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20671">Goal Current Performance Description</a>
        /// </para>
        /// </summary>
        [DisplayName("Goal Current Performance Description")]
        public System.String CurrentPerformanceDescription { get => _CurrentPerformanceDescription; set => SetProperty(ref _CurrentPerformanceDescription, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IGoalPerformance model)
        {
            IsBusy = true;
            Id = model.Id;
            CurrentPerformanceDescription = model.CurrentPerformanceDescription; // Goal Current Performance Description
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
