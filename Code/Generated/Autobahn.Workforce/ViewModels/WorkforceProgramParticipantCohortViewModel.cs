//**********************************************************
//* DomainName: Workforce
//* FileName:   WorkforceProgramParticipantCohortViewModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Workforce.ViewModels
{
     /// <summary>
     /// The WorkforceProgramParticipantCohort View Model
     /// </summary>
    public partial class WorkforceProgramParticipantCohortViewModel : ViewModelBase, Interfaces.IWorkforceProgramParticipantCohort
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from WorkforceProgramParticipantCohort";

        // member variable for the CohortDescription property
        private System.String _CohortDescription;

        // CohortMedianEarnings -- (backing property for Cohort Median Earnings)
        private System.Decimal? _CohortMedianEarnings;

        // member variable for the OrganizationPersonRoleId property
        private Guid _OrganizationPersonRoleId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        public System.String CohortDescription { get => _CohortDescription; set => SetProperty(ref _CohortDescription, value); }

        /// <summary>
        /// Cohort Median Earnings
        /// <para>
        /// The midpoint between the lowest and highest quarterly wage, in U.S. dollars, for the total number of persons included in the cohort for the period of time between the Employment Record Reference Period Start Date and Employment Record Reference Period End Date.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20918">Cohort Median Earnings</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Decimal? CohortMedianEarnings { get => _CohortMedianEarnings; set => SetProperty(ref _CohortMedianEarnings, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get => _OrganizationPersonRoleId; set => SetProperty(ref _OrganizationPersonRoleId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IWorkforceProgramParticipantCohort model)
        {
            IsBusy = true;
            Id = model.Id;
            CohortDescription = model.CohortDescription; // 
            CohortMedianEarnings = model.CohortMedianEarnings; // Cohort Median Earnings
            OrganizationPersonRoleId = model.OrganizationPersonRoleId; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
