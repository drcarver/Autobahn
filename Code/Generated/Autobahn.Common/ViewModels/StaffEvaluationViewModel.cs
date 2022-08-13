//**********************************************************
//* DomainName: Common Models
//* FileName:   StaffEvaluationViewModel.cs
//**********************************************************

using CommunityToolkit.Maui;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The StaffEvaluationViewModel
     /// </summary>
    public partial class StaffEvaluationViewModel : ViewModelBase, Interfaces.IStaffEvaluation
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from StaffEvaluation";

        // member variable for the OrganizationPersonRoleId property
        private Guid _OrganizationPersonRoleId;

        // member variable for the Outcome property
        private System.String _Outcome;

        // member variable for the RefStaffPerformanceLevelId property
        private Guid? _RefStaffPerformanceLevelId;

        // member variable for the Scale property
        private System.String _Scale;

        // member variable for the ScoreOrRating property
        private System.String _ScoreOrRating;

        // member variable for the System property
        private System.String _System;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the StaffEvaluationViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get => _OrganizationPersonRoleId; set => SetProperty(ref _OrganizationPersonRoleId, value); }

        /// <summary>
        /// The result of an assessment of a person's performance.
        /// </summary>
        public System.String Outcome { get => _Outcome; set => SetProperty(ref _Outcome, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefStaffPerformanceLevel"/> model
        /// </summary>
        public Guid? RefStaffPerformanceLevelId { get => _RefStaffPerformanceLevelId; set => SetProperty(ref _RefStaffPerformanceLevelId, value); }

        /// <summary>
        /// The result of an assessment of a person's performance.
        /// </summary>
        public System.String Scale { get => _Scale; set => SetProperty(ref _Scale, value); }

        /// <summary>
        /// The result of an assessment of a person's performance.
        /// </summary>
        public System.String ScoreOrRating { get => _ScoreOrRating; set => SetProperty(ref _ScoreOrRating, value); }

        /// <summary>
        /// The result of an assessment of a person's performance.
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
            OrganizationPersonRoleId = model.OrganizationPersonRoleId;
            Outcome = model.Outcome;
            RefStaffPerformanceLevelId = model.RefStaffPerformanceLevelId;
            Scale = model.Scale;
            ScoreOrRating = model.ScoreOrRating;
            System = model.System;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
