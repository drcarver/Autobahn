//**********************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ELChildServicesApplicationViewModel.cs
//* Name:       Application Date
//* Definition: The year, month and day on which an individual  application is received by the organization.
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.EarlyLearning.ViewModels
{
     /// <summary>
     /// The year, month and day on which an individual  application is received by the organization.
     /// </summary>
    public partial class ELChildServicesApplicationViewModel : ViewModelBase, Interfaces.IELChildServicesApplication
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from ELChildServicesApplication";

        // ApplicationDate -- (backing property for Application Date)
        private System.DateTime? _ApplicationDate;

        // ELApplicationIdentifier -- (backing property for Early Learning Application Identifier)
        private System.String _ELApplicationIdentifier;

        // ELApplicationRequiredDocument -- (backing property for Early Learning Application Required Document)
        private System.Boolean? _ELApplicationRequiredDocument;

        // ELEnrollmentApplicationDocumentIdentifier -- (backing property for Early Learning Enrollment Application Document Identifier)
        private System.String _ELEnrollmentApplicationDocumentIdentifier;

        // ELEnrollmentApplicationDocumentName -- (backing property for Early Learning Enrollment Application Document Name)
        private System.String _ELEnrollmentApplicationDocumentName;

        // ELEnrollmentApplicationDocumentType -- (backing property for Early Learning Enrollment Application Document Type)
        private System.String _ELEnrollmentApplicationDocumentType;

        // ELEnrollmentApplicationVerificationDate -- (backing property for Early Learning Enrollment Application Verification Date)
        private System.DateTime? _ELEnrollmentApplicationVerificationDate;

        // ELEnrollmentApplicationVerificationReasonType -- (backing property for Early Learning Enrollment Application Verification Reason Type)
        private System.String _ELEnrollmentApplicationVerificationReasonType;

        // member variable for the OrganizationPersonRoleId property
        private Guid _OrganizationPersonRoleId;

        // SitePreferenceRank -- (backing property for Site Preference Rank)
        private System.String _SitePreferenceRank;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Application Date
        /// <para>
        /// The year, month and day on which an individual  application is received by the organization.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19323">Application Date</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.DateTime? ApplicationDate { get => _ApplicationDate; set => SetProperty(ref _ApplicationDate, value); }

        /// <summary>
        /// Early Learning Application Identifier
        /// <para>
        /// Identifier for the application for enrollment or direct services filled out on behalf of a child
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20576">Early Learning Application Identifier</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String ELApplicationIdentifier { get => _ELApplicationIdentifier; set => SetProperty(ref _ELApplicationIdentifier, value); }

        /// <summary>
        /// Early Learning Application Required Document
        /// <para>
        /// Identifies a specific document required for enrollment.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20578">Early Learning Application Required Document</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Boolean? ELApplicationRequiredDocument { get => _ELApplicationRequiredDocument; set => SetProperty(ref _ELApplicationRequiredDocument, value); }

        /// <summary>
        /// Early Learning Enrollment Application Document Identifier
        /// <para>
        /// Identifier for an enrollment application document record.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20572">Early Learning Enrollment Application Document Identifier</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String ELEnrollmentApplicationDocumentIdentifier { get => _ELEnrollmentApplicationDocumentIdentifier; set => SetProperty(ref _ELEnrollmentApplicationDocumentIdentifier, value); }

        /// <summary>
        /// Early Learning Enrollment Application Document Name
        /// <para>
        /// Document name for an enrollment application document record.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20573">Early Learning Enrollment Application Document Name</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String ELEnrollmentApplicationDocumentName { get => _ELEnrollmentApplicationDocumentName; set => SetProperty(ref _ELEnrollmentApplicationDocumentName, value); }

        /// <summary>
        /// Early Learning Enrollment Application Document Type
        /// <para>
        /// Document type for an enrollment application document record.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20574">Early Learning Enrollment Application Document Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String ELEnrollmentApplicationDocumentType { get => _ELEnrollmentApplicationDocumentType; set => SetProperty(ref _ELEnrollmentApplicationDocumentType, value); }

        /// <summary>
        /// Early Learning Enrollment Application Verification Date
        /// <para>
        /// Date the required document was verified for the enrollment application
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20571">Early Learning Enrollment Application Verification Date</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.DateTime? ELEnrollmentApplicationVerificationDate { get => _ELEnrollmentApplicationVerificationDate; set => SetProperty(ref _ELEnrollmentApplicationVerificationDate, value); }

        /// <summary>
        /// Early Learning Enrollment Application Verification Reason Type
        /// <para>
        /// Identifies the reason for verification of enrollment application information
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20579">Early Learning Enrollment Application Verification Reason Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String ELEnrollmentApplicationVerificationReasonType { get => _ELEnrollmentApplicationVerificationReasonType; set => SetProperty(ref _ELEnrollmentApplicationVerificationReasonType, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get => _OrganizationPersonRoleId; set => SetProperty(ref _OrganizationPersonRoleId, value); }

        /// <summary>
        /// Site Preference Rank
        /// <para>
        /// The applicant preference that the family has for the program sites.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20608">Site Preference Rank</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String SitePreferenceRank { get => _SitePreferenceRank; set => SetProperty(ref _SitePreferenceRank, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IELChildServicesApplication model)
        {
            IsBusy = true;
            Id = model.Id;
            ApplicationDate = model.ApplicationDate; // Application Date
            ELApplicationIdentifier = model.ELApplicationIdentifier; // Early Learning Application Identifier
            ELApplicationRequiredDocument = model.ELApplicationRequiredDocument; // Early Learning Application Required Document
            ELEnrollmentApplicationDocumentIdentifier = model.ELEnrollmentApplicationDocumentIdentifier; // Early Learning Enrollment Application Document Identifier
            ELEnrollmentApplicationDocumentName = model.ELEnrollmentApplicationDocumentName; // Early Learning Enrollment Application Document Name
            ELEnrollmentApplicationDocumentType = model.ELEnrollmentApplicationDocumentType; // Early Learning Enrollment Application Document Type
            ELEnrollmentApplicationVerificationDate = model.ELEnrollmentApplicationVerificationDate; // Early Learning Enrollment Application Verification Date
            ELEnrollmentApplicationVerificationReasonType = model.ELEnrollmentApplicationVerificationReasonType; // Early Learning Enrollment Application Verification Reason Type
            OrganizationPersonRoleId = model.OrganizationPersonRoleId; // 
            SitePreferenceRank = model.SitePreferenceRank; // Site Preference Rank
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
