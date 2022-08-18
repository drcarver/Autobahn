//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationAccreditationViewModel.cs
//* Name:       Accreditation Agency Name
//* Definition: The full name of an agency that accredited a school.
//***************************************************************************

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The full name of an agency that accredited a school.
     /// </summary>
    public partial class OrganizationAccreditationViewModel : ViewModelBase, Interfaces.IOrganizationAccreditation
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from OrganizationAccreditation";

        // AccreditationAgencyName -- (backing property for Accreditation Agency Name)
        private System.String _AccreditationAgencyName;

        // AccreditationAwardDate -- (backing property for Accreditation Award Date)
        private System.DateTime? _AccreditationAwardDate;

        // AccreditationExpirationDate -- (backing property for Accreditation Expiration Date)
        private System.DateTime? _AccreditationExpirationDate;

        // member variable for the AccreditationStatus property
        private System.Boolean? _AccreditationStatus;

        // member variable for the OrganizationId property
        private Guid _OrganizationId;

        // RefAccreditationAgencyId -- (backing property for Accreditation Agency)
        private Guid? _RefAccreditationAgencyId;

        // RefHigherEducationInstitutionAccreditationStatusId -- (backing property for Higher Education Institution Accreditation Status)
        private Guid? _RefHigherEducationInstitutionAccreditationStatusId;

        // SeekingAccreditationDate -- (backing property for Organization Seeking Accreditation Date)
        private System.DateTime? _SeekingAccreditationDate;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Accreditation Agency Name
        /// <para>
        /// The full name of an agency that accredited a school.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20500">Accreditation Agency Name</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String AccreditationAgencyName { get => _AccreditationAgencyName; set => SetProperty(ref _AccreditationAgencyName, value); }

        /// <summary>
        /// Accreditation Award Date
        /// <para>
        /// The year, month and day when an accreditation was awarded.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19840">Accreditation Award Date</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.DateTime? AccreditationAwardDate { get => _AccreditationAwardDate; set => SetProperty(ref _AccreditationAwardDate, value); }

        /// <summary>
        /// Accreditation Expiration Date
        /// <para>
        /// The year, month and day when an accreditation expires.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19841">Accreditation Expiration Date</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.DateTime? AccreditationExpirationDate { get => _AccreditationExpirationDate; set => SetProperty(ref _AccreditationExpirationDate, value); }

        public System.Boolean? AccreditationStatus { get => _AccreditationStatus; set => SetProperty(ref _AccreditationStatus, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganization"/> model
        /// </summary>
        public Guid OrganizationId { get => _OrganizationId; set => SetProperty(ref _OrganizationId, value); }

        /// <summary>
        /// Accreditation Agency
        /// <para>
        /// The agency that accredited a program.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19983">Accreditation Agency</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefAccreditationAgencyId { get => _RefAccreditationAgencyId; set => SetProperty(ref _RefAccreditationAgencyId, value); }

        /// <summary>
        /// Higher Education Institution Accreditation Status
        /// <para>
        /// An indication of the accreditation status of a higher education institution.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19817">Higher Education Institution Accreditation Status</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefHigherEducationInstitutionAccreditationStatusId { get => _RefHigherEducationInstitutionAccreditationStatusId; set => SetProperty(ref _RefHigherEducationInstitutionAccreditationStatusId, value); }

        /// <summary>
        /// Organization Seeking Accreditation Date
        /// <para>
        /// The date in which accreditation process was started (but not officially approved or denied)
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20388">Organization Seeking Accreditation Date</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.DateTime? SeekingAccreditationDate { get => _SeekingAccreditationDate; set => SetProperty(ref _SeekingAccreditationDate, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IOrganizationAccreditation model)
        {
            IsBusy = true;
            Id = model.Id;
            AccreditationAgencyName = model.AccreditationAgencyName; // Accreditation Agency Name
            AccreditationAwardDate = model.AccreditationAwardDate; // Accreditation Award Date
            AccreditationExpirationDate = model.AccreditationExpirationDate; // Accreditation Expiration Date
            AccreditationStatus = model.AccreditationStatus; // 
            OrganizationId = model.OrganizationId; // 
            RefAccreditationAgencyId = model.RefAccreditationAgencyId; // Accreditation Agency
            RefHigherEducationInstitutionAccreditationStatusId = model.RefHigherEducationInstitutionAccreditationStatusId; // Higher Education Institution Accreditation Status
            SeekingAccreditationDate = model.SeekingAccreditationDate; // Organization Seeking Accreditation Date
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
