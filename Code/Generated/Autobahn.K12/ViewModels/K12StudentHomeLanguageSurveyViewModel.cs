//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12StudentHomeLanguageSurveyViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

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
        private  _HomeLanguageSurveyAdministrationDate;

        // member variable for the HomeLanguageSurveyAdministrationIndicator property
        private  _HomeLanguageSurveyAdministrationIndicator;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private Guid? _RecordStartDateTime;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public  HomeLanguageSurveyAdministrationDate { get => _HomeLanguageSurveyAdministrationDate; set => SetProperty(ref _HomeLanguageSurveyAdministrationDate, value); }

        /// <summary>
        /// </summary>
        public  HomeLanguageSurveyAdministrationIndicator { get => _HomeLanguageSurveyAdministrationIndicator; set => SetProperty(ref _HomeLanguageSurveyAdministrationIndicator, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public Guid? RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IK12StudentHomeLanguageSurvey model)
        {
            IsBusy = true;
            Id = model.Id;
            HomeLanguageSurveyAdministrationDate = model.HomeLanguageSurveyAdministrationDate; // 
            HomeLanguageSurveyAdministrationIndicator = model.HomeLanguageSurveyAdministrationIndicator; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
