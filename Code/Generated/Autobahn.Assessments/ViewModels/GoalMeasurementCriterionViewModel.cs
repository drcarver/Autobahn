//**********************************************************
//* DomainName: Assessments
//* FileName:   GoalMeasurementCriterionViewModel.cs
//* Name:       Goal Measurement Criterion Accuracy Percent
//* Definition: The percent of correct results that will be considered to represent successful achievement of a goal.
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Assessments.ViewModels
{
     /// <summary>
     /// The percent of correct results that will be considered to represent successful achievement of a goal.
     /// </summary>
    public partial class GoalMeasurementCriterionViewModel : ViewModelBase, Interfaces.IGoalMeasurementCriterion
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from GoalMeasurementCriterion";

        // AccuracyPercent -- (backing property for Goal Measurement Criterion Accuracy Percent)
        private System.Decimal? _AccuracyPercent;

        // AttemptsCount -- (backing property for Goal Measurement Criterion Attempts Count)
        private System.Int32? _AttemptsCount;

        // member variable for the GoalMeasurementId property
        private Guid _GoalMeasurementId;

        // Metric -- (backing property for Goal Measurement Criterion Metric)
        private System.String _Metric;

        // SuccessCount -- (backing property for Goal Measurement Criterion Success Count)
        private System.Int32? _SuccessCount;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Goal Measurement Criterion Accuracy Percent
        /// <para>
        /// The percent of correct results that will be considered to represent successful achievement of a goal.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20672">Goal Measurement Criterion Accuracy Percent</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Decimal? AccuracyPercent { get => _AccuracyPercent; set => SetProperty(ref _AccuracyPercent, value); }

        /// <summary>
        /// Goal Measurement Criterion Attempts Count
        /// <para>
        /// The number of attempts representing a completed trial for assessing achievement of a goal.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20673">Goal Measurement Criterion Attempts Count</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Int32? AttemptsCount { get => _AttemptsCount; set => SetProperty(ref _AttemptsCount, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IGoalMeasurement"/> model
        /// </summary>
        public Guid GoalMeasurementId { get => _GoalMeasurementId; set => SetProperty(ref _GoalMeasurementId, value); }

        /// <summary>
        /// Goal Measurement Criterion Metric
        /// <para>
        /// A metric used for evaluating achievement of a goal.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20674">Goal Measurement Criterion Metric</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String Metric { get => _Metric; set => SetProperty(ref _Metric, value); }

        /// <summary>
        /// Goal Measurement Criterion Success Count
        /// <para>
        /// The number of correct results that will be considered to represent successful achievement of a goal.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20675">Goal Measurement Criterion Success Count</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Int32? SuccessCount { get => _SuccessCount; set => SetProperty(ref _SuccessCount, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IGoalMeasurementCriterion model)
        {
            IsBusy = true;
            Id = model.Id;
            AccuracyPercent = model.AccuracyPercent; // Goal Measurement Criterion Accuracy Percent
            AttemptsCount = model.AttemptsCount; // Goal Measurement Criterion Attempts Count
            GoalMeasurementId = model.GoalMeasurementId; // 
            Metric = model.Metric; // Goal Measurement Criterion Metric
            SuccessCount = model.SuccessCount; // Goal Measurement Criterion Success Count
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
