//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   GoalViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.Assessment.ViewModels
{
     /// <summary>
     /// The GoalViewModel
     /// </summary>
    public partial class GoalViewModel : ViewModelBase, Interfaces.IGoal
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from Goal";

        // member variable for the Description property
        private System.String _Description;

        // member variable for the StartDate property
        private System.DateTime? _StartDate;

        // member variable for the EndDate property
        private System.DateTime? _EndDate;

        // member variable for the OrganizationPersonRoleId property
        private Guid? _OrganizationPersonRoleId;

        // member variable for the CompetencySetId property
        private Guid? _CompetencySetId;

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
        /// The title of the GoalViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        public System.String Description  { get => _Description; set => SetProperty(ref _Description, value); }

        public System.DateTime? StartDate { get => _StartDate; set => SetProperty(ref _StartDate, value); }

        public System.DateTime? EndDate { get => _EndDate; set => SetProperty(ref _EndDate, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="OrganizationPersonRoleId"/> model
        /// </summary>
        public Guid? OrganizationPersonRoleId { get => _OrganizationPersonRoleId; set => SetProperty(ref _OrganizationPersonRoleId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="CompetencySetId"/> model
        /// </summary>
        public Guid? CompetencySetId { get => _CompetencySetId; set => SetProperty(ref _CompetencySetId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IGoal model)
        {
            IsBusy = true;
            Id = model.Id;
            Description = model.Description;
            StartDate = model.StartDate;
            EndDate = model.EndDate;
            OrganizationPersonRoleId = model.OrganizationPersonRoleId;
            CompetencySetId = model.CompetencySetId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
