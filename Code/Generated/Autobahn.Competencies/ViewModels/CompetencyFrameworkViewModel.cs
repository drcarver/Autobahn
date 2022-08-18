//**********************************************************
//* DomainName: Competencies
//* FileName:   CompetencyFrameworkViewModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Competencies.ViewModels
{
     /// <summary>
     /// The CompetencyFramework View Model
     /// </summary>
    public partial class CompetencyFrameworkViewModel : ViewModelBase, Interfaces.ICompetencyFramework
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from CompetencyFramework";

        // CompetencyFrameworkPublicationDate -- (backing property for Competency Framework Publication Date)
        private System.DateTime? _CompetencyFrameworkPublicationDate;

        // CompetencyFrameworkSourceUrl -- (backing property for Competency Framework Source URL)
        private System.String _CompetencyFrameworkSourceUrl;

        // Creator -- (backing property for Competency Framework Creator)
        private System.String _Creator;

        // Jurisdiction -- (backing property for Competency Framework Jurisdiction)
        private System.String _Jurisdiction;

        // License -- (backing property for Competency Framework License)
        private System.String _License;

        // Publisher -- (backing property for Competency Framework Publisher)
        private System.String _Publisher;

        // RefCompetencyFrameworkPublicationStatusId -- (backing property for Competency Framework Publication Status)
        private Guid? _RefCompetencyFrameworkPublicationStatusId;

        // RefLanguageId -- (backing property for Competency Framework Language)
        private Guid? _RefLanguageId;

        // Rights -- (backing property for Competency Framework Rights)
        private System.String _Rights;

        // RightsHolder -- (backing property for Competency Framework Rights Holder)
        private System.String _RightsHolder;

        // Subject -- (backing property for Competency Framework Subject)
        private System.String _Subject;

        // Title -- (backing property for Competency Framework Title)
        private System.String _Title;

        // URI -- (backing property for Competency Framework Identifier URI)
        private System.String _URI;

        // ValidEndDate -- (backing property for Competency Framework Valid End Date)
        private System.DateTime _ValidEndDate;

        // ValidStartDate -- (backing property for Competency Framework Valid Start Date)
        private System.DateTime _ValidStartDate;

        // Version -- (backing property for Competency Framework Version)
        private System.String _Version;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Competency Framework Publication Date
        /// <para>
        /// The date on which this content was first published.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20548">Competency Framework Publication Date</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.DateTime? CompetencyFrameworkPublicationDate { get => _CompetencyFrameworkPublicationDate; set => SetProperty(ref _CompetencyFrameworkPublicationDate, value); }

        /// <summary>
        /// Competency Framework Source URL
        /// <para>
        /// A URL that resolves to the original or authoritative competency framework document.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20888">Competency Framework Source URL</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String CompetencyFrameworkSourceUrl { get => _CompetencyFrameworkSourceUrl; set => SetProperty(ref _CompetencyFrameworkSourceUrl, value); }

        /// <summary>
        /// Competency Framework Creator
        /// <para>
        /// The person or organization chiefly responsible for the intellectual content of the competency framework.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19673">Competency Framework Creator</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String Creator { get => _Creator; set => SetProperty(ref _Creator, value); }

        /// <summary>
        /// Competency Framework Jurisdiction
        /// <para>
        /// A legal, quasi-legal, organizational or institutional domain of the entity mandating the use of the statement--e.g., California.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19676">Competency Framework Jurisdiction</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String Jurisdiction { get => _Jurisdiction; set => SetProperty(ref _Jurisdiction, value); }

        /// <summary>
        /// Competency Framework License
        /// <para>
        /// A legal document giving official permission to do something with the competency framework.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19882">Competency Framework License</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String License { get => _License; set => SetProperty(ref _License, value); }

        /// <summary>
        /// Competency Framework Publisher
        /// <para>
        /// The entity responsible for making the competency framework available.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19884">Competency Framework Publisher</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String Publisher { get => _Publisher; set => SetProperty(ref _Publisher, value); }

        /// <summary>
        /// Competency Framework Publication Status
        /// <para>
        /// The publication status of the competency framework.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19675">Competency Framework Publication Status</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefCompetencyFrameworkPublicationStatusId { get => _RefCompetencyFrameworkPublicationStatusId; set => SetProperty(ref _RefCompetencyFrameworkPublicationStatusId, value); }

        /// <summary>
        /// Competency Framework Language
        /// <para>
        /// The default language of the text used for the content in the competency framework.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19880">Competency Framework Language</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefLanguageId { get => _RefLanguageId; set => SetProperty(ref _RefLanguageId, value); }

        /// <summary>
        /// Competency Framework Rights
        /// <para>
        /// The information about rights held in and over the resource.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19885">Competency Framework Rights</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String Rights { get => _Rights; set => SetProperty(ref _Rights, value); }

        /// <summary>
        /// Competency Framework Rights Holder
        /// <para>
        /// The person or organization owning or managing rights over the competency framework.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19886">Competency Framework Rights Holder</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String RightsHolder { get => _RightsHolder; set => SetProperty(ref _RightsHolder, value); }

        /// <summary>
        /// Competency Framework Subject
        /// <para>
        /// The topic or academic subject of the competency framework.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19679">Competency Framework Subject</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String Subject { get => _Subject; set => SetProperty(ref _Subject, value); }

        /// <summary>
        /// Competency Framework Title
        /// <para>
        /// The name of the competency framework.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19671">Competency Framework Title</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String Title { get => _Title; set => SetProperty(ref _Title, value); }

        /// <summary>
        /// Competency Framework Identifier URI
        /// <para>
        /// An unambiguous reference to the competency framework using a network-resolvable URI.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19670">Competency Framework Identifier URI</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String URI { get => _URI; set => SetProperty(ref _URI, value); }

        /// <summary>
        /// Competency Framework Valid End Date
        /// <para>
        /// The year, month and day the competency framework was deprecated/replaced by the jurisdiction in which it was intended to apply.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19678">Competency Framework Valid End Date</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.DateTime ValidEndDate { get => _ValidEndDate; set => SetProperty(ref _ValidEndDate, value); }

        /// <summary>
        /// Competency Framework Valid Start Date
        /// <para>
        /// The year, month and day the competency framework was adopted by the jurisdiction in which it was intended to apply.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19677">Competency Framework Valid Start Date</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.DateTime ValidStartDate { get => _ValidStartDate; set => SetProperty(ref _ValidStartDate, value); }

        /// <summary>
        /// Competency Framework Version
        /// <para>
        /// Defines the revision of the competency framework as a version number or date.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19672">Competency Framework Version</a>
        /// </para>
        /// </summary>
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
            CompetencyFrameworkPublicationDate = model.CompetencyFrameworkPublicationDate; // Competency Framework Publication Date
            CompetencyFrameworkSourceUrl = model.CompetencyFrameworkSourceUrl; // Competency Framework Source URL
            Creator = model.Creator; // Competency Framework Creator
            Jurisdiction = model.Jurisdiction; // Competency Framework Jurisdiction
            License = model.License; // Competency Framework License
            Publisher = model.Publisher; // Competency Framework Publisher
            RefCompetencyFrameworkPublicationStatusId = model.RefCompetencyFrameworkPublicationStatusId; // Competency Framework Publication Status
            RefLanguageId = model.RefLanguageId; // Competency Framework Language
            Rights = model.Rights; // Competency Framework Rights
            RightsHolder = model.RightsHolder; // Competency Framework Rights Holder
            Subject = model.Subject; // Competency Framework Subject
            Title = model.Title; // Competency Framework Title
            URI = model.URI; // Competency Framework Identifier URI
            ValidEndDate = model.ValidEndDate; // Competency Framework Valid End Date
            ValidStartDate = model.ValidStartDate; // Competency Framework Valid Start Date
            Version = model.Version; // Competency Framework Version
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
