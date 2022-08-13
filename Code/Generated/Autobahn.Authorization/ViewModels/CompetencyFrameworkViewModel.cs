//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   CompetencyFrameworkViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;
using CommunityToolkit.Maui;

namespace Autobahn.Authorization.ViewModels
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
        private System.DateTime? _CompetencyFrameworkPublicationDate;

        // member variable for the CompetencyFrameworkSourceUrl property
        private System.String _CompetencyFrameworkSourceUrl;

        // member variable for the Creator property
        private System.String _Creator;

        // member variable for the Jurisdiction property
        private System.String _Jurisdiction;

        // member variable for the License property
        private System.String _License;

        // member variable for the Publisher property
        private System.String _Publisher;

        // member variable for the RefCompetencyFrameworkPublicationStatusId property
        private Guid? _RefCompetencyFrameworkPublicationStatusId;

        // member variable for the RefLanguageId property
        private Guid? _RefLanguageId;

        // member variable for the Rights property
        private System.String _Rights;

        // member variable for the RightsHolder property
        private System.String _RightsHolder;

        // member variable for the Subject property
        private System.String _Subject;

        // member variable for the Title property
        private System.String _Title;

        // member variable for the URI property
        private System.String _URI;

        // member variable for the ValidEndDate property
        private System.DateTime _ValidEndDate;

        // member variable for the ValidStartDate property
        private System.DateTime _ValidStartDate;

        // member variable for the Version property
        private System.String _Version;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the CompetencyFrameworkViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// An unambiguous reference to the competency framework using a network-resolvable URI.
        /// </summary>
        public System.DateTime? CompetencyFrameworkPublicationDate { get => _CompetencyFrameworkPublicationDate; set => SetProperty(ref _CompetencyFrameworkPublicationDate, value); }

        /// <summary>
        /// An unambiguous reference to the competency framework using a network-resolvable URI.
        /// </summary>
        public System.String CompetencyFrameworkSourceUrl { get => _CompetencyFrameworkSourceUrl; set => SetProperty(ref _CompetencyFrameworkSourceUrl, value); }

        /// <summary>
        /// An unambiguous reference to the competency framework using a network-resolvable URI.
        /// </summary>
        public System.String Creator { get => _Creator; set => SetProperty(ref _Creator, value); }

        /// <summary>
        /// An unambiguous reference to the competency framework using a network-resolvable URI.
        /// </summary>
        public System.String Jurisdiction { get => _Jurisdiction; set => SetProperty(ref _Jurisdiction, value); }

        /// <summary>
        /// An unambiguous reference to the competency framework using a network-resolvable URI.
        /// </summary>
        public System.String License { get => _License; set => SetProperty(ref _License, value); }

        /// <summary>
        /// An unambiguous reference to the competency framework using a network-resolvable URI.
        /// </summary>
        public System.String Publisher { get => _Publisher; set => SetProperty(ref _Publisher, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCompetencyFrameworkPublicationStatus"/> model
        /// </summary>
        public Guid? RefCompetencyFrameworkPublicationStatusId { get => _RefCompetencyFrameworkPublicationStatusId; set => SetProperty(ref _RefCompetencyFrameworkPublicationStatusId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLanguage"/> model
        /// </summary>
        public Guid? RefLanguageId { get => _RefLanguageId; set => SetProperty(ref _RefLanguageId, value); }

        /// <summary>
        /// An unambiguous reference to the competency framework using a network-resolvable URI.
        /// </summary>
        public System.String Rights { get => _Rights; set => SetProperty(ref _Rights, value); }

        /// <summary>
        /// An unambiguous reference to the competency framework using a network-resolvable URI.
        /// </summary>
        public System.String RightsHolder { get => _RightsHolder; set => SetProperty(ref _RightsHolder, value); }

        /// <summary>
        /// An unambiguous reference to the competency framework using a network-resolvable URI.
        /// </summary>
        public System.String Subject { get => _Subject; set => SetProperty(ref _Subject, value); }

        /// <summary>
        /// An unambiguous reference to the competency framework using a network-resolvable URI.
        /// </summary>
        public System.String Title { get => _Title; set => SetProperty(ref _Title, value); }

        /// <summary>
        /// An unambiguous reference to the competency framework using a network-resolvable URI.
        /// </summary>
        public System.String URI { get => _URI; set => SetProperty(ref _URI, value); }

        /// <summary>
        /// An unambiguous reference to the competency framework using a network-resolvable URI.
        /// </summary>
        public System.DateTime ValidEndDate { get => _ValidEndDate; set => SetProperty(ref _ValidEndDate, value); }

        /// <summary>
        /// An unambiguous reference to the competency framework using a network-resolvable URI.
        /// </summary>
        public System.DateTime ValidStartDate { get => _ValidStartDate; set => SetProperty(ref _ValidStartDate, value); }

        /// <summary>
        /// An unambiguous reference to the competency framework using a network-resolvable URI.
        /// </summary>
        public System.String Version { get => _Version; set => SetProperty(ref _Version, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.ICompetencyFramework model)
        {
            IsBusy = true;
            Id = model.Id;
            CompetencyFrameworkPublicationDate = model.CompetencyFrameworkPublicationDate;
            CompetencyFrameworkSourceUrl = model.CompetencyFrameworkSourceUrl;
            Creator = model.Creator;
            Jurisdiction = model.Jurisdiction;
            License = model.License;
            Publisher = model.Publisher;
            RefCompetencyFrameworkPublicationStatusId = model.RefCompetencyFrameworkPublicationStatusId;
            RefLanguageId = model.RefLanguageId;
            Rights = model.Rights;
            RightsHolder = model.RightsHolder;
            Subject = model.Subject;
            Title = model.Title;
            URI = model.URI;
            ValidEndDate = model.ValidEndDate;
            ValidStartDate = model.ValidStartDate;
            Version = model.Version;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
