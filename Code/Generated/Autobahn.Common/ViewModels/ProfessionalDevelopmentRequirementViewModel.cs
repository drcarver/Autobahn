//**********************************************************
//* DomainName: Common Models
//* FileName:   ProfessionalDevelopmentRequirementViewModel.cs
//***************************************************************************

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The ProfessionalDevelopmentRequirement View Model
     /// </summary>
    public partial class ProfessionalDevelopmentRequirementViewModel : ViewModelBase, Interfaces.IProfessionalDevelopmentRequirement
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from ProfessionalDevelopmentRequirement";

        // member variable for the CompetencySetId property
        private Guid? _CompetencySetId;

        // member variable for the OrganizationPersonRoleId property
        private Guid _OrganizationPersonRoleId;

        // RequiredTrainingClockHours -- (backing property for Required Training Clock Hours)
        private System.Decimal? _RequiredTrainingClockHours;

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
        /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get => _OrganizationPersonRoleId; set => SetProperty(ref _OrganizationPersonRoleId, value); }

        /// <summary>
        /// Required Training Clock Hours
        /// <para>
        /// Number of clock hours of training required for providers to meet requirements of the state.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19803">Required Training Clock Hours</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Decimal? RequiredTrainingClockHours { get => _RequiredTrainingClockHours; set => SetProperty(ref _RequiredTrainingClockHours, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IProfessionalDevelopmentRequirement model)
        {
            IsBusy = true;
            Id = model.Id;
            CompetencySetId = model.CompetencySetId; // 
            OrganizationPersonRoleId = model.OrganizationPersonRoleId; // 
            RequiredTrainingClockHours = model.RequiredTrainingClockHours; // Required Training Clock Hours
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
