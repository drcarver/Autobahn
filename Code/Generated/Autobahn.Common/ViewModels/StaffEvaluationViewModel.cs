//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   StaffEvaluationViewModel.cs
//**********************************************************


namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The StaffEvaluationViewModel
     /// </summary>
    public partial class StaffEvaluationViewModel : ViewModelBase, Interfaces.IStaffEvaluationViewModel
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from StaffEvaluation";

        // member variable for the OrganizationPersonRoleId property
        private Guid _OrganizationPersonRoleId;

        // member variable for the System property
        private System.String _System;

        // member variable for the Scale property
        private System.String _Scale;

        // member variable for the ScoreOrRating property
        private System.String _ScoreOrRating;

        // member variable for the Outcome property
        private System.String _Outcome;

        // member variable for the RefStaffPerformanceLevelId property
        private Guid? _RefStaffPerformanceLevelId;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

        // member variable for the RecordStatusId property
        private Guid? _RecordStatusId;

        // member variable for the DataCollectionId property
        private Guid? _DataCollectionId;

#endregion

        #region Properties
        /// <summary>
        /// The title of the StaffEvaluationViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRoleId"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get => _OrganizationPersonRoleId; set => SetProperty(ref _OrganizationPersonRoleId, value); }

        public System.String System  { get => _System; set => SetProperty(ref _System, value); }

        public System.String Scale  { get => _Scale; set => SetProperty(ref _Scale, value); }

        public System.String ScoreOrRating  { get => _ScoreOrRating; set => SetProperty(ref _ScoreOrRating, value); }

        public System.String Outcome  { get => _Outcome; set => SetProperty(ref _Outcome, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefStaffPerformanceLevelId"/> model
        /// </summary>
        public Guid? RefStaffPerformanceLevelId { get => _RefStaffPerformanceLevelId; set => SetProperty(ref _RefStaffPerformanceLevelId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IStaffEvaluation model)
        {
            IsBusy = true;
            Id = model.Id;
            OrganizationPersonRoleId = model.OrganizationPersonRoleId;
            System = model.System;
            Scale = model.Scale;
            ScoreOrRating = model.ScoreOrRating;
            Outcome = model.Outcome;
            RefStaffPerformanceLevelId = model.RefStaffPerformanceLevelId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
