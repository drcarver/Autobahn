//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonTelephoneViewModel.cs
//***************************************************************************

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The PersonTelephone View Model
     /// </summary>
    public partial class PersonTelephoneViewModel : ViewModelBase, Interfaces.IPersonTelephone
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PersonTelephone";

        // DoNotPublishIndicator -- (backing property for Do Not Publish Indicator)
        private System.Boolean? _DoNotPublishIndicator;

        // member variable for the PersonId property
        private Guid _PersonId;

        // PrimaryTelephoneNumberIndicator -- (backing property for Primary Telephone Number Indicator)
        private System.Boolean _PrimaryTelephoneNumberIndicator;

        // RefPersonTelephoneNumberTypeId -- (backing property for Telephone Number Type)
        private Guid? _RefPersonTelephoneNumberTypeId;

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
        /// Reference to an optional instance of the <see cref="IPerson"/> model
        /// </summary>
        public Guid PersonId { get => _PersonId; set => SetProperty(ref _PersonId, value); }

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
        /// Telephone Number Type
        /// <para>
        /// The type of communication number listed for a person.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19280">Telephone Number Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefPersonTelephoneNumberTypeId { get => _RefPersonTelephoneNumberTypeId; set => SetProperty(ref _RefPersonTelephoneNumberTypeId, value); }

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
        public void Load(Interfaces.IPersonTelephone model)
        {
            IsBusy = true;
            Id = model.Id;
            DoNotPublishIndicator = model.DoNotPublishIndicator; // Do Not Publish Indicator
            PersonId = model.PersonId; // 
            PrimaryTelephoneNumberIndicator = model.PrimaryTelephoneNumberIndicator; // Primary Telephone Number Indicator
            RefPersonTelephoneNumberTypeId = model.RefPersonTelephoneNumberTypeId; // Telephone Number Type
            RefTelephoneNumberListedStatusId = model.RefTelephoneNumberListedStatusId; // Telephone Number Listed Status
            TelephoneNumber = model.TelephoneNumber; // Telephone Number
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }

        #region RefPersonTelephoneNumberType List
        /// <summary>
        /// The complete <see cref="RefPersonTelephoneNumberType"> List
        /// </summary>
        private static List<ReferenceModelBase> RefPersonTelephoneNumberTypeList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("518a282a-6c43-4d52-aad2-16c0d65fbf24"), Code="Home", Description="Home phone number", Definition="Home phone number is the type of communication number listed for a person.", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("2f38de67-f58c-4674-a136-65c22c7e23f8"), Code="Work", Description="Work phone number", Definition="Work phone number is the type of communication number listed for a person.", SortOrder=Convert.ToDecimal("3.00") },
            new ReferenceModelBase { Id=Guid.Parse("ed5dd815-af2f-496b-9e70-402b264ef40e"), Code="Mobile", Description="Mobile phone number", Definition="Mobile phone number is the type of communication number listed for a person.", SortOrder=Convert.ToDecimal("5.00") },
            new ReferenceModelBase { Id=Guid.Parse("02061c9f-cf62-4558-bc51-97decfc6f5a2"), Code="Fax", Description="Fax number", Definition="Fax number is the type of communication number listed for a person.", SortOrder=Convert.ToDecimal("7.00") },
            new ReferenceModelBase { Id=Guid.Parse("f6ee6cff-fa23-430d-9b66-f29e88429458"), Code="Other", Description="Other", Definition="The type of communication number listed for a person is in a category not yet defined in CEDS.", SortOrder=Convert.ToDecimal("9.00") },
        };
        #endregion
    }
}
