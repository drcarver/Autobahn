//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   K12StudentHomeLanguageSurveyViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

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

        // member variable for the OrganizationPersonRoleId property
        private Guid _OrganizationPersonRoleId;

        // member variable for the HomeLanguageSurveyAdministrationDate property
        private System.DateTime? _HomeLanguageSurveyAdministrationDate;

        // member variable for the HomeLanguageSurveyAdministrationIndicator property
        private System.Boolean? _HomeLanguageSurveyAdministrationIndicator;

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
        /// The title of the K12StudentHomeLanguageSurveyViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRoleId"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get => _OrganizationPersonRoleId; set => SetProperty(ref _OrganizationPersonRoleId, value); }

        public System.DateTime? HomeLanguageSurveyAdministrationDate { get => _HomeLanguageSurveyAdministrationDate; set => SetProperty(ref _HomeLanguageSurveyAdministrationDate, value); }

        public System.Boolean? HomeLanguageSurveyAdministrationIndicator { get => _HomeLanguageSurveyAdministrationIndicator; set => SetProperty(ref _HomeLanguageSurveyAdministrationIndicator, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IK12StudentHomeLanguageSurvey model)
        {
            IsBusy = true;
            Id = model.Id;
            OrganizationPersonRoleId = model.OrganizationPersonRoleId;
            HomeLanguageSurveyAdministrationDate = model.HomeLanguageSurveyAdministrationDate;
            HomeLanguageSurveyAdministrationIndicator = model.HomeLanguageSurveyAdministrationIndicator;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
