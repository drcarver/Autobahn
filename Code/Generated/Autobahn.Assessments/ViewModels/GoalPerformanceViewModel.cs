//**********************************************************
//* DomainName: Assessments
//* FileName:   GoalPerformanceViewModel.cs
//* Name:       Goal Current Performance Description
//* Definition: Current performance explanation related to the annual goal or short-term objectives.
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Assessments.ViewModels
{
     /// <summary>
     /// Current performance explanation related to the annual goal or short-term objectives.
     /// </summary>
    public partial class GoalPerformanceViewModel : ViewModelBase, Interfaces.IGoalPerformance
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from GoalPerformance";

        // CurrentPerformanceDescription -- (backing property for Goal Current Performance Description)
        private System.String _CurrentPerformanceDescription;

        // member variable for the Date property
        private System.DateTime? _Date;

        // member variable for the GoalId property
        private Guid _GoalId;

        // RefGoalStatusTypeId -- (backing property for Goal Status Type)
        private Guid? _RefGoalStatusTypeId;

        // Status -- (backing property for Goal Status)
        private System.String _Status;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Goal Current Performance Description
        /// <para>
        /// Current performance explanation related to the annual goal or short-term objectives.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20671">Goal Current Performance Description</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String CurrentPerformanceDescription { get => _CurrentPerformanceDescription; set => SetProperty(ref _CurrentPerformanceDescription, value); }

        public System.DateTime? Date { get => _Date; set => SetProperty(ref _Date, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IGoal"/> model
        /// </summary>
        public Guid GoalId { get => _GoalId; set => SetProperty(ref _GoalId, value); }

        /// <summary>
        /// Goal Status Type
        /// <para>
        /// Status toward achievement of the annual goal or short-term objectives.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20683">Goal Status Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefGoalStatusTypeId { get => _RefGoalStatusTypeId; set => SetProperty(ref _RefGoalStatusTypeId, value); }

        /// <summary>
        /// Goal Status
        /// <para>
        /// Description of status toward achievement of the annual goal or short-term objectives.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20684">Goal Status</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String Status { get => _Status; set => SetProperty(ref _Status, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IGoalPerformance model)
        {
            IsBusy = true;
            Id = model.Id;
            CurrentPerformanceDescription = model.CurrentPerformanceDescription; // Goal Current Performance Description
            Date = model.Date; // 
            GoalId = model.GoalId; // 
            RefGoalStatusTypeId = model.RefGoalStatusTypeId; // Goal Status Type
            Status = model.Status; // Goal Status
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
