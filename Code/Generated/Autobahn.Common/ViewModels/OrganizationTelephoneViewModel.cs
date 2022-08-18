//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationTelephoneViewModel.cs
//***************************************************************************

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The OrganizationTelephone View Model
     /// </summary>
    public partial class OrganizationTelephoneViewModel : ViewModelBase, Interfaces.IOrganizationTelephone
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from OrganizationTelephone";

        // DoNotPublishIndicator -- (backing property for Do Not Publish Indicator)
        private System.Boolean? _DoNotPublishIndicator;

        // member variable for the OrganizationId property
        private Guid _OrganizationId;

        // PrimaryTelephoneNumberIndicator -- (backing property for Primary Telephone Number Indicator)
        private System.Boolean _PrimaryTelephoneNumberIndicator;

        // RefInstitutionTelephoneTypeId -- (backing property for Institution Telephone Number Type)
        private Guid? _RefInstitutionTelephoneTypeId;

        // RefTelephoneNumberListedStatusId -- (backing property for Telephone Number Listed Status)
        private Guid? _RefTelephoneNumberListedStatusId;

        // TelephoneNumber -- (backing property for Telephone Number)
        private System.String _TelephoneNumber;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Do Not Publish Indicator
        /// <para>
        /// An indication that the record should not be published.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20905">Do Not Publish Indicator</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Boolean? DoNotPublishIndicator { get => _DoNotPublishIndicator; set => SetProperty(ref _DoNotPublishIndicator, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganization"/> model
        /// </summary>
        public Guid OrganizationId { get => _OrganizationId; set => SetProperty(ref _OrganizationId, value); }

        /// <summary>
        /// Primary Telephone Number Indicator
        /// <para>
        /// An indication that the telephone number should be used as the principal number for a person or organization.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19219">Primary Telephone Number Indicator</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Boolean PrimaryTelephoneNumberIndicator { get => _PrimaryTelephoneNumberIndicator; set => SetProperty(ref _PrimaryTelephoneNumberIndicator, value); }

        /// <summary>
        /// Institution Telephone Number Type
        /// <para>
        /// The type of communication number listed for an organization.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19167">Institution Telephone Number Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefInstitutionTelephoneTypeId { get => _RefInstitutionTelephoneTypeId; set => SetProperty(ref _RefInstitutionTelephoneTypeId, value); }

        /// <summary>
        /// Telephone Number Listed Status
        /// <para>
        /// An indication of whether a telephone number is listed under a directory assistance service.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20911">Telephone Number Listed Status</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefTelephoneNumberListedStatusId { get => _RefTelephoneNumberListedStatusId; set => SetProperty(ref _RefTelephoneNumberListedStatusId, value); }

        /// <summary>
        /// Telephone Number
        /// <para>
        /// The telephone number including the area code, and extension, if applicable.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19279">Telephone Number</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String TelephoneNumber { get => _TelephoneNumber; set => SetProperty(ref _TelephoneNumber, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IOrganizationTelephone model)
        {
            IsBusy = true;
            Id = model.Id;
            DoNotPublishIndicator = model.DoNotPublishIndicator; // Do Not Publish Indicator
            OrganizationId = model.OrganizationId; // 
            PrimaryTelephoneNumberIndicator = model.PrimaryTelephoneNumberIndicator; // Primary Telephone Number Indicator
            RefInstitutionTelephoneTypeId = model.RefInstitutionTelephoneTypeId; // Institution Telephone Number Type
            RefTelephoneNumberListedStatusId = model.RefTelephoneNumberListedStatusId; // Telephone Number Listed Status
            TelephoneNumber = model.TelephoneNumber; // Telephone Number
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }

        #region RefTelephoneNumberListedStatus List
        /// <summary>
        /// The complete <see cref="RefTelephoneNumberListedStatus"> List
        /// </summary>
        private static List<ReferenceModelBase> RefTelephoneNumberListedStatusList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("4e2d3bee-7e4e-49fa-b0d6-0ba26aaeab30"), Code="Listed", Description="Listed", Definition="The telephone number is listed under a directory assistance service.", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("f4a1ac98-e0d6-4562-a3fc-c9ef5015c3cf"), Code="Unknown", Description="Unknown", Definition="It is not known if the telephone number is listed under a directory assistance service.", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("0bebe544-c50e-426e-8d1b-5ca9f967b55c"), Code="Unlisted", Description="Unlisted", Definition="The telephone number is not listed under a directory assistance service.", SortOrder=Convert.ToDecimal("3.00") },
        };
        #endregion
    }
}
