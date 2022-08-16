//**********************************************************
//* DomainName: Competencies
//* FileName:   CompetencyFrameworkViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Competencies.ViewModels
{
     /// <summary>
     /// The CompetencyFrameworkViewModel
     /// </summary>
    public partial class CompetencyFrameworkViewModel : ViewModelBase, Interfaces.ICompetencyFramework
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from CompetencyFramework";

        // member variable for the CompetencyFrameworkPublicationDate property
        private  _CompetencyFrameworkPublicationDate;

        // member variable for the CompetencyFrameworkSourceUrl property
        private  _CompetencyFrameworkSourceUrl;

        // member variable for the Creator property
        private  _Creator;

        // member variable for the Description property
        private  _Description;

        // member variable for the Jurisdiction property
        private  _Jurisdiction;

        // member variable for the License property
        private  _License;

        // member variable for the Publisher property
        private  _Publisher;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefCompetencyFrameworkPublicationStatusId property
        private  _RefCompetencyFrameworkPublicationStatusId;

        // member variable for the RefLanguageId property
        private  _RefLanguageId;

        // member variable for the Rights property
        private  _Rights;

        // member variable for the RightsHolder property
        private  _RightsHolder;

        // member variable for the Subject property
        private  _Subject;

        // member variable for the Title property
        private  _Title;

        // member variable for the URI property
        private Guid? _URI;

        // member variable for the ValidEndDate property
        private  _ValidEndDate;

        // member variable for the ValidStartDate property
        private  _ValidStartDate;

        // member variable for the Version property
        private  _Version;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public  CompetencyFrameworkPublicationDate { get => _CompetencyFrameworkPublicationDate; set => SetProperty(ref _CompetencyFrameworkPublicationDate, value); }

        /// <summary>
        /// </summary>
        public  CompetencyFrameworkSourceUrl { get => _CompetencyFrameworkSourceUrl; set => SetProperty(ref _CompetencyFrameworkSourceUrl, value); }

        /// <summary>
        /// </summary>
        public  Creator { get => _Creator; set => SetProperty(ref _Creator, value); }

        /// <summary>
        /// </summary>
        public  Description { get => _Description; set => SetProperty(ref _Description, value); }

        /// <summary>
        /// </summary>
        public  Jurisdiction { get => _Jurisdiction; set => SetProperty(ref _Jurisdiction, value); }

        /// <summary>
        /// </summary>
        public  License { get => _License; set => SetProperty(ref _License, value); }

        /// <summary>
        /// </summary>
        public  Publisher { get => _Publisher; set => SetProperty(ref _Publisher, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCompetencyFrameworkPublicationStatus"/> model
        /// </summary>
        public  RefCompetencyFrameworkPublicationStatusId { get => _RefCompetencyFrameworkPublicationStatusId; set => SetProperty(ref _RefCompetencyFrameworkPublicationStatusId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLanguage"/> model
        /// </summary>
        public  RefLanguageId { get => _RefLanguageId; set => SetProperty(ref _RefLanguageId, value); }

        /// <summary>
        /// </summary>
        public  Rights { get => _Rights; set => SetProperty(ref _Rights, value); }

        /// <summary>
        /// </summary>
        public  RightsHolder { get => _RightsHolder; set => SetProperty(ref _RightsHolder, value); }

        /// <summary>
        /// </summary>
        public  Subject { get => _Subject; set => SetProperty(ref _Subject, value); }

        /// <summary>
        /// </summary>
        public  Title { get => _Title; set => SetProperty(ref _Title, value); }

        /// <summary>
        /// </summary>
        public Guid? URI { get => _URI; set => SetProperty(ref _URI, value); }

        /// <summary>
        /// </summary>
        public  ValidEndDate { get => _ValidEndDate; set => SetProperty(ref _ValidEndDate, value); }

        /// <summary>
        /// </summary>
        public  ValidStartDate { get => _ValidStartDate; set => SetProperty(ref _ValidStartDate, value); }

        /// <summary>
        /// </summary>
        public  Version { get => _Version; set => SetProperty(ref _Version, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.ICompetencyFramework model)
        {
            IsBusy = true;
            Id = model.Id;
            CompetencyFrameworkPublicationDate = model.CompetencyFrameworkPublicationDate; // 
            CompetencyFrameworkSourceUrl = model.CompetencyFrameworkSourceUrl; // 
            Creator = model.Creator; // 
            Description = model.Description; // 
            Jurisdiction = model.Jurisdiction; // 
            License = model.License; // 
            Publisher = model.Publisher; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefCompetencyFrameworkPublicationStatusId = model.RefCompetencyFrameworkPublicationStatusId; // 
            RefLanguageId = model.RefLanguageId; // 
            Rights = model.Rights; // 
            RightsHolder = model.RightsHolder; // 
            Subject = model.Subject; // 
            Title = model.Title; // 
            URI = model.URI; // 
            ValidEndDate = model.ValidEndDate; // 
            ValidStartDate = model.ValidStartDate; // 
            Version = model.Version; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
