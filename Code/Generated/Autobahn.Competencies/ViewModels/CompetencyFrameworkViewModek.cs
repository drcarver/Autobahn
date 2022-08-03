//**********************************************************
//* DomainName: Autobahn.Competencies
//* FileName:   CompetencyFrameworkViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Competencies.Interfaces;

namespace Autobahn.Competencies.ViewModels
{
     /// <summary>
     /// The CompetencyFrameworkViewModel
     /// </summary>
    public partial class CompetencyFrameworkViewModel : BindableBase, ICompetencyFramework
    {
#region "Backing Fields"
        // member variable for the URI property
        private System.String _URI;

        // member variable for the Title property
        private System.String _Title;

        // member variable for the Subject property
        private System.String _Subject;

        // member variable for the Version property
        private System.String _Version;

        // member variable for the Creator property
        private System.String _Creator;

        // member variable for the Jurisdiction property
        private System.String _Jurisdiction;

        // member variable for the Description property
        private System.String _Description;

        // member variable for the Publisher property
        private System.String _Publisher;

        // member variable for the ValidStartDate property
        private System.DateTime _ValidStartDate;

        // member variable for the ValidEndDate property
        private System.DateTime _ValidEndDate;

        // member variable for the License property
        private System.String _License;

        // member variable for the Rights property
        private System.String _Rights;

        // member variable for the RightsHolder property
        private System.String _RightsHolder;

        // member variable for the CompetencyFrameworkPublicationDate property
        private System.DateTime? _CompetencyFrameworkPublicationDate;

        // member variable for the CompetencyFrameworkSourceUrl property
        private System.String _CompetencyFrameworkSourceUrl;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

#endregion

#region Properties
        public System.String URI  { get => _URI; set => SetProperty(ref _URI, value); }

        public System.String Title  { get => _Title; set => SetProperty(ref _Title, value); }

        public System.String Subject  { get => _Subject; set => SetProperty(ref _Subject, value); }

        public System.String Version  { get => _Version; set => SetProperty(ref _Version, value); }

        public System.String Creator  { get => _Creator; set => SetProperty(ref _Creator, value); }

        public System.String Jurisdiction  { get => _Jurisdiction; set => SetProperty(ref _Jurisdiction, value); }

        public System.String Description  { get => _Description; set => SetProperty(ref _Description, value); }

        public System.String Publisher  { get => _Publisher; set => SetProperty(ref _Publisher, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCompetencyFrameworkPublicationStatusId"/> model
        /// </summary>
        public Guid? RefCompetencyFrameworkPublicationStatusId { get; set; }

        public System.DateTime ValidStartDate  { get => _ValidStartDate; set => SetProperty(ref _ValidStartDate, value); }

        public System.DateTime ValidEndDate  { get => _ValidEndDate; set => SetProperty(ref _ValidEndDate, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLanguageId"/> model
        /// </summary>
        public Guid? RefLanguageId { get; set; }

        public System.String License  { get => _License; set => SetProperty(ref _License, value); }

        public System.String Rights  { get => _Rights; set => SetProperty(ref _Rights, value); }

        public System.String RightsHolder  { get => _RightsHolder; set => SetProperty(ref _RightsHolder, value); }

        public System.DateTime? CompetencyFrameworkPublicationDate { get => _CompetencyFrameworkPublicationDate; set => SetProperty(ref _CompetencyFrameworkPublicationDate, value); }

        public System.String CompetencyFrameworkSourceUrl  { get => _CompetencyFrameworkSourceUrl; set => SetProperty(ref _CompetencyFrameworkSourceUrl, value); }

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
        public void Load(ICompetencyFramework model)
        {
            IsBusy = true;
            Id = model.Id;
            URI = model.URI;
            Title = model.Title;
            Subject = model.Subject;
            Version = model.Version;
            Creator = model.Creator;
            Jurisdiction = model.Jurisdiction;
            Description = model.Description;
            Publisher = model.Publisher;
            RefCompetencyFrameworkPublicationStatusId = model.RefCompetencyFrameworkPublicationStatusId;
            ValidStartDate = model.ValidStartDate;
            ValidEndDate = model.ValidEndDate;
            RefLanguageId = model.RefLanguageId;
            License = model.License;
            Rights = model.Rights;
            RightsHolder = model.RightsHolder;
            CompetencyFrameworkPublicationDate = model.CompetencyFrameworkPublicationDate;
            CompetencyFrameworkSourceUrl = model.CompetencyFrameworkSourceUrl;
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
