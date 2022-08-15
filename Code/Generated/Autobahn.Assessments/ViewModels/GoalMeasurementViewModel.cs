//**********************************************************
//* DomainName: Assessments
//* FileName:   GoalMeasurementViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Assessments.ViewModels
{
     /// <summary>
     /// The GoalMeasurementViewModel
     /// </summary>
    public partial class GoalMeasurementViewModel : ViewModelBase, Interfaces.IGoalMeasurement
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from GoalMeasurement";

        // member variable for the SuccessCriteria property
        private System.String _SuccessCriteria;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the GoalMeasurementViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// One or more statements that describes the criteria used by teachers and students to check for attainment of a goal.
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19902">Goal Success Criteria</a>
        /// </para>
        /// </summary>
        [DisplayName("Goal Success Criteria")]
        public System.String SuccessCriteria { get => _SuccessCriteria; set => SetProperty(ref _SuccessCriteria, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IGoalMeasurement model)
        {
            IsBusy = true;
            Id = model.Id;
            SuccessCriteria = model.SuccessCriteria; // Goal Success Criteria
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
