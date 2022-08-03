//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   K12StudentHomeLanguageSurveyViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.K12.Interfaces;

namespace Autobahn.K12.ViewModels
{
     /// <summary>
     /// The K12StudentHomeLanguageSurveyViewModel
     /// </summary>
    public partial class K12StudentHomeLanguageSurveyViewModel : BindableBase, IK12StudentHomeLanguageSurvey
    {
#region "Backing Fields"
        // member variable for the HomeLanguageSurveyAdministrationDate property
        private System.DateTime? _HomeLanguageSurveyAdministrationDate;

        // member variable for the HomeLanguageSurveyAdministrationIndicator property
        private System.Boolean? _HomeLanguageSurveyAdministrationIndicator;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

#endregion

#region Properties
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRoleId"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        public System.DateTime? HomeLanguageSurveyAdministrationDate { get => _HomeLanguageSurveyAdministrationDate; set => SetProperty(ref _HomeLanguageSurveyAdministrationDate, value); }

        public System.Boolean? HomeLanguageSurveyAdministrationIndicator { get => _HomeLanguageSurveyAdministrationIndicator; set => SetProperty(ref _HomeLanguageSurveyAdministrationIndicator, value); }

        public System.DateTime? RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        public System.DateTime? RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatusId"/> model
        /// </summary>
        public Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollectionId"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

#endregion


        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(IK12StudentHomeLanguageSurvey model)
        {
            IsBusy = true;
            Id = model.Id;
            OrganizationPersonRoleId = model.OrganizationPersonRoleId;
            HomeLanguageSurveyAdministrationDate = model.HomeLanguageSurveyAdministrationDate;
            HomeLanguageSurveyAdministrationIndicator = model.HomeLanguageSurveyAdministrationIndicator;
            RecordStartDateTime = model.RecordStartDateTime;
            RecordEndDateTime = model.RecordEndDateTime;
            RecordStatusId = model.RecordStatusId;
            DataCollectionId = model.DataCollectionId;
            IsChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
