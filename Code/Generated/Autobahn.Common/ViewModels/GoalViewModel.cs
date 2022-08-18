//**********************************************************
//* DomainName: Common Models
//* FileName:   GoalViewModel.cs
//***************************************************************************

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The Goal View Model
     /// </summary>
    public partial class GoalViewModel : ViewModelBase, Interfaces.IGoal
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from Goal";

        // member variable for the CompetencySetId property
        private Guid? _CompetencySetId;

        // EndDate -- (backing property for Goal End Date)
        private System.DateTime? _EndDate;

        // member variable for the OrganizationPersonRoleId property
        private Guid? _OrganizationPersonRoleId;

        // StartDate -- (backing property for Goal Start Date)
        private System.DateTime? _StartDate;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="ICompetencySet"/> model
        /// </summary>
        public Guid? CompetencySetId { get => _CompetencySetId; set => SetProperty(ref _CompetencySetId, value); }

        /// <summary>
        /// Goal End Date
        /// <para>
        /// The date on which the goal expires or has been achieved.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20170">Goal End Date</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.DateTime? EndDate { get => _EndDate; set => SetProperty(ref _EndDate, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
        /// </summary>
        public Guid? OrganizationPersonRoleId { get => _OrganizationPersonRoleId; set => SetProperty(ref _OrganizationPersonRoleId, value); }

        /// <summary>
        /// Goal Start Date
        /// <para>
        /// The date on which the goal becomes active.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20169">Goal Start Date</a>
        /// </para>
        /// </summary>
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
            CompetencySetId = model.CompetencySetId; // 
            EndDate = model.EndDate; // Goal End Date
            OrganizationPersonRoleId = model.OrganizationPersonRoleId; // 
            StartDate = model.StartDate; // Goal Start Date
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
