//**********************************************************
//* DomainName: Assessments
//* FileName:   GoalMeasurementCriterionViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Assessments.ViewModels
{
     /// <summary>
     /// The GoalMeasurementCriterionViewModel
     /// </summary>
    public partial class GoalMeasurementCriterionViewModel : ViewModelBase, Interfaces.IGoalMeasurementCriterion
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from GoalMeasurementCriterion";

        // member variable for the AccuracyPercent property
        private System.Decimal? _AccuracyPercent;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the GoalMeasurementCriterionViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The percent of correct results that will be considered to represent successful achievement of a goal.
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20672">Goal Measurement Criterion Accuracy Percent</a>
        /// </para>
        /// </summary>
        [DisplayName("Goal Measurement Criterion Accuracy Percent")]
        public System.Decimal? AccuracyPercent { get => _AccuracyPercent; set => SetProperty(ref _AccuracyPercent, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IGoalMeasurementCriterion model)
        {
            IsBusy = true;
            Id = model.Id;
            AccuracyPercent = model.AccuracyPercent; // Goal Measurement Criterion Accuracy Percent
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
