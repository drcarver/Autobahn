//**********************************************************
//* DomainName: Assessments
//* FileName:   GoalMeasurementViewModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Assessments.ViewModels
{
     /// <summary>
     /// The GoalMeasurement View Model
     /// </summary>
    public partial class GoalMeasurementViewModel : ViewModelBase, Interfaces.IGoalMeasurement
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from GoalMeasurement";

        // member variable for the GoalId property
        private Guid _GoalId;

        // RefGoalMeasurementTypeId -- (backing property for Goal Measurement Type)
        private Guid? _RefGoalMeasurementTypeId;

        // Schedule -- (backing property for Goal Measurement Schedule)
        private System.String _Schedule;

        // SuccessCriteria -- (backing property for Goal Success Criteria)
        private System.String _SuccessCriteria;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IGoal"/> model
        /// </summary>
        public Guid GoalId { get => _GoalId; set => SetProperty(ref _GoalId, value); }

        /// <summary>
        /// Goal Measurement Type
        /// <para>
        /// Type of evidence appropriate for assessing achievement of a goal or short-term objective.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20678">Goal Measurement Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefGoalMeasurementTypeId { get => _RefGoalMeasurementTypeId; set => SetProperty(ref _RefGoalMeasurementTypeId, value); }

        /// <summary>
        /// Goal Measurement Schedule
        /// <para>
        /// Frequency of evaluation of progress toward meeting the goal or short-term objective.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20677">Goal Measurement Schedule</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String Schedule { get => _Schedule; set => SetProperty(ref _Schedule, value); }

        /// <summary>
        /// Goal Success Criteria
        /// <para>
        /// One or more statements that describes the criteria used by teachers and students to check for attainment of a goal.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19902">Goal Success Criteria</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String SuccessCriteria { get => _SuccessCriteria; set => SetProperty(ref _SuccessCriteria, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IGoalMeasurement model)
        {
            IsBusy = true;
            Id = model.Id;
            GoalId = model.GoalId; // 
            RefGoalMeasurementTypeId = model.RefGoalMeasurementTypeId; // Goal Measurement Type
            Schedule = model.Schedule; // Goal Measurement Schedule
            SuccessCriteria = model.SuccessCriteria; // Goal Success Criteria
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
