//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12StudentHomeLanguageSurveyViewModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.K12.ViewModels
{
     /// <summary>
     /// The K12StudentHomeLanguageSurvey View Model
     /// </summary>
    public partial class K12StudentHomeLanguageSurveyViewModel : ViewModelBase, Interfaces.IK12StudentHomeLanguageSurvey
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from K12StudentHomeLanguageSurvey";

        // HomeLanguageSurveyAdministrationDate -- (backing property for Home Language Survey Administration Date)
        private System.DateTime? _HomeLanguageSurveyAdministrationDate;

        // HomeLanguageSurveyAdministrationIndicator -- (backing property for Home Language Survey Administration Indicator)
        private System.Boolean? _HomeLanguageSurveyAdministrationIndicator;

        // member variable for the OrganizationPersonRoleId property
        private Guid _OrganizationPersonRoleId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Home Language Survey Administration Date
        /// <para>
        /// The year, month, and day on which the Home Language Survey is known to have been administered to the parent or guardian of this student.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20934">Home Language Survey Administration Date</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.DateTime? HomeLanguageSurveyAdministrationDate { get => _HomeLanguageSurveyAdministrationDate; set => SetProperty(ref _HomeLanguageSurveyAdministrationDate, value); }

        /// <summary>
        /// Home Language Survey Administration Indicator
        /// <para>
        /// An indication that the parent or guardian of this student was administered the Home Language Survey - a questionnaire given to parents or guardians that helps schools and local education agencies identify which students are potential English Learners and who will require assessment of their English language proficiency to determine whether they are eligible for language assistance services.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20935">Home Language Survey Administration Indicator</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Boolean? HomeLanguageSurveyAdministrationIndicator { get => _HomeLanguageSurveyAdministrationIndicator; set => SetProperty(ref _HomeLanguageSurveyAdministrationIndicator, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get => _OrganizationPersonRoleId; set => SetProperty(ref _OrganizationPersonRoleId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IK12StudentHomeLanguageSurvey model)
        {
            IsBusy = true;
            Id = model.Id;
            HomeLanguageSurveyAdministrationDate = model.HomeLanguageSurveyAdministrationDate; // Home Language Survey Administration Date
            HomeLanguageSurveyAdministrationIndicator = model.HomeLanguageSurveyAdministrationIndicator; // Home Language Survey Administration Indicator
            OrganizationPersonRoleId = model.OrganizationPersonRoleId; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
