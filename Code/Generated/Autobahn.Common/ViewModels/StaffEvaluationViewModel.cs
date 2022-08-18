//**********************************************************
//* DomainName: Common Models
//* FileName:   StaffEvaluationViewModel.cs
//***************************************************************************

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The StaffEvaluation View Model
     /// </summary>
    public partial class StaffEvaluationViewModel : ViewModelBase, Interfaces.IStaffEvaluation
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from StaffEvaluation";

        // member variable for the OrganizationPersonRoleId property
        private Guid _OrganizationPersonRoleId;

        // Outcome -- (backing property for Staff Evaluation Outcome)
        private System.String _Outcome;

        // RefStaffPerformanceLevelId -- (backing property for Faculty and Administration Performance Level)
        private Guid? _RefStaffPerformanceLevelId;

        // Scale -- (backing property for Staff Evaluation Scale)
        private System.String _Scale;

        // ScoreOrRating -- (backing property for Staff Evaluation Score or Rating)
        private System.String _ScoreOrRating;

        // System -- (backing property for Staff Evaluation System)
        private System.String _System;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get => _OrganizationPersonRoleId; set => SetProperty(ref _OrganizationPersonRoleId, value); }

        /// <summary>
        /// Staff Evaluation Outcome
        /// <para>
        /// The result of an assessment of a person's performance.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19102">Staff Evaluation Outcome</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String Outcome { get => _Outcome; set => SetProperty(ref _Outcome, value); }

        /// <summary>
        /// Faculty and Administration Performance Level
        /// <para>
        /// The levels used in district evaluation systems for assigning teacher or principal performance ratings.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19582">Faculty and Administration Performance Level</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefStaffPerformanceLevelId { get => _RefStaffPerformanceLevelId; set => SetProperty(ref _RefStaffPerformanceLevelId, value); }

        /// <summary>
        /// Staff Evaluation Scale
        /// <para>
        /// The quantitative or qualitative range of possible scores/rating for a person's overall performance (e.g., 0 - 10; Poor, Fair, Average, Good, Excellent).
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19103">Staff Evaluation Scale</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String Scale { get => _Scale; set => SetProperty(ref _Scale, value); }

        /// <summary>
        /// Staff Evaluation Score or Rating
        /// <para>
        /// The actual quantitative or qualitative assessment of a person's overall performance.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19104">Staff Evaluation Score or Rating</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String ScoreOrRating { get => _ScoreOrRating; set => SetProperty(ref _ScoreOrRating, value); }

        /// <summary>
        /// Staff Evaluation System
        /// <para>
        /// The instrument and/or set of procedures with which a person's performance is assessed.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19105">Staff Evaluation System</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String System { get => _System; set => SetProperty(ref _System, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IStaffEvaluation model)
        {
            IsBusy = true;
            Id = model.Id;
            OrganizationPersonRoleId = model.OrganizationPersonRoleId; // 
            Outcome = model.Outcome; // Staff Evaluation Outcome
            RefStaffPerformanceLevelId = model.RefStaffPerformanceLevelId; // Faculty and Administration Performance Level
            Scale = model.Scale; // Staff Evaluation Scale
            ScoreOrRating = model.ScoreOrRating; // Staff Evaluation Score or Rating
            System = model.System; // Staff Evaluation System
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
