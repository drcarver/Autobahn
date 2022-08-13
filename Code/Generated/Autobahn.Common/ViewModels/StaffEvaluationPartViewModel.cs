//**********************************************************
//* DomainName: Common Models
//* FileName:   StaffEvaluationPartViewModel.cs
//**********************************************************

using CommunityToolkit.Maui;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The StaffEvaluationPartViewModel
     /// </summary>
    public partial class StaffEvaluationPartViewModel : ViewModelBase, Interfaces.IStaffEvaluationPart
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from StaffEvaluationPart";

        // member variable for the OrganizationPersonRoleId property
        private Guid _OrganizationPersonRoleId;

        // member variable for the PartName property
        private System.String _PartName;

        // member variable for the Scale property
        private System.String _Scale;

        // member variable for the ScoreOrRating property
        private System.String _ScoreOrRating;

        // member variable for the StaffEvaluationId property
        private Guid? _StaffEvaluationId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the StaffEvaluationPartViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get => _OrganizationPersonRoleId; set => SetProperty(ref _OrganizationPersonRoleId, value); }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public System.String PartName { get => _PartName; set => SetProperty(ref _PartName, value); }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public System.String Scale { get => _Scale; set => SetProperty(ref _Scale, value); }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public System.String ScoreOrRating { get => _ScoreOrRating; set => SetProperty(ref _ScoreOrRating, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="StaffEvaluation"/> model
        /// </summary>
        public Guid? StaffEvaluationId { get => _StaffEvaluationId; set => SetProperty(ref _StaffEvaluationId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IStaffEvaluationPart model)
        {
            IsBusy = true;
            Id = model.Id;
            OrganizationPersonRoleId = model.OrganizationPersonRoleId;
            PartName = model.PartName;
            Scale = model.Scale;
            ScoreOrRating = model.ScoreOrRating;
            StaffEvaluationId = model.StaffEvaluationId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
