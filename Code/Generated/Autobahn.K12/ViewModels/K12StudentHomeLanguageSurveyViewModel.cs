//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12StudentHomeLanguageSurveyViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;
using CommunityToolkit.Maui;

namespace Autobahn.K12.ViewModels
{
     /// <summary>
     /// The K12StudentHomeLanguageSurveyViewModel
     /// </summary>
    public partial class K12StudentHomeLanguageSurveyViewModel : ViewModelBase, Interfaces.IK12StudentHomeLanguageSurvey
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from K12StudentHomeLanguageSurvey";

        // member variable for the HomeLanguageSurveyAdministrationDate property
        private System.DateTime? _HomeLanguageSurveyAdministrationDate;

        // member variable for the HomeLanguageSurveyAdministrationIndicator property
        private System.Boolean? _HomeLanguageSurveyAdministrationIndicator;

        // member variable for the OrganizationPersonRoleId property
        private Guid _OrganizationPersonRoleId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the K12StudentHomeLanguageSurveyViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public System.DateTime? HomeLanguageSurveyAdministrationDate { get => _HomeLanguageSurveyAdministrationDate; set => SetProperty(ref _HomeLanguageSurveyAdministrationDate, value); }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public System.Boolean? HomeLanguageSurveyAdministrationIndicator { get => _HomeLanguageSurveyAdministrationIndicator; set => SetProperty(ref _HomeLanguageSurveyAdministrationIndicator, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="OrganizationPersonRole"/> model
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
            HomeLanguageSurveyAdministrationDate = model.HomeLanguageSurveyAdministrationDate;
            HomeLanguageSurveyAdministrationIndicator = model.HomeLanguageSurveyAdministrationIndicator;
            OrganizationPersonRoleId = model.OrganizationPersonRoleId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
