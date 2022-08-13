//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   GoalViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;
using CommunityToolkit.Maui;

namespace Autobahn.Authorization.ViewModels
{
     /// <summary>
     /// The GoalViewModel
     /// </summary>
    public partial class GoalViewModel : ViewModelBase, Interfaces.IGoal
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from Goal";

        // member variable for the CompetencySetId property
        private Guid? _CompetencySetId;

        // member variable for the EndDate property
        private System.DateTime? _EndDate;

        // member variable for the OrganizationPersonRoleId property
        private Guid? _OrganizationPersonRoleId;

        // member variable for the StartDate property
        private System.DateTime? _StartDate;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the GoalViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="CompetencySet"/> model
        /// </summary>
        public Guid? CompetencySetId { get => _CompetencySetId; set => SetProperty(ref _CompetencySetId, value); }

        /// <summary>
        /// A statement that describes the desired outcomes.
        /// </summary>
        public System.DateTime? EndDate { get => _EndDate; set => SetProperty(ref _EndDate, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        public Guid? OrganizationPersonRoleId { get => _OrganizationPersonRoleId; set => SetProperty(ref _OrganizationPersonRoleId, value); }

        /// <summary>
        /// A statement that describes the desired outcomes.
        /// </summary>
        public System.DateTime? StartDate { get => _StartDate; set => SetProperty(ref _StartDate, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IGoal model)
        {
            IsBusy = true;
            Id = model.Id;
            CompetencySetId = model.CompetencySetId;
            EndDate = model.EndDate;
            OrganizationPersonRoleId = model.OrganizationPersonRoleId;
            StartDate = model.StartDate;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
