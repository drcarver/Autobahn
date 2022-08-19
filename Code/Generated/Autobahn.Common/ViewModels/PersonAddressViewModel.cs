//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonAddressViewModel.cs
//* Name:       Address County Name
//* Definition: The name of the county, parish, borough, or comparable unit (within a state) in which an address is located.
//***************************************************************************

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The name of the county, parish, borough, or comparable unit (within a state) in which an address is located.
     /// </summary>
    public partial class PersonAddressViewModel : ViewModelBase, Interfaces.IPersonAddress
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PersonAddress";

        // AddressCountyName -- (backing property for Address County Name)
        private System.String _AddressCountyName;

        // ApartmentRoomOrSuiteNumber -- (backing property for Address Apartment Room or Suite Number)
        private System.String _ApartmentRoomOrSuiteNumber;

        // City -- (backing property for Address City)
        private System.String _City;

        // DoNotPublishIndicator -- (backing property for Do Not Publish Indicator)
        private System.Boolean? _DoNotPublishIndicator;

        // Latitude -- (backing property for Latitude)
        private System.String _Latitude;

        // Longitude -- (backing property for Longitude)
        private System.String _Longitude;

        // member variable for the PersonId property
        private Guid _PersonId;

        // PostalCode -- (backing property for Address Postal Code)
        private System.String _PostalCode;

        // RefCountryId -- (backing property for Country Code)
        private Guid? _RefCountryId;

        // member variable for the RefCountyId property
        private Guid? _RefCountyId;

        // RefPersonalInformationVerificationId -- (backing property for Personal Information Verification)
        private Guid? _RefPersonalInformationVerificationId;

        // RefPersonLocationTypeId -- (backing property for Address Type for Learner or Family)
        private Guid _RefPersonLocationTypeId;

        // RefStateId -- (backing property for State Abbreviation)
        private Guid? _RefStateId;

        // StreetNumberAndName -- (backing property for Address Street Number and Name)
        private System.String _StreetNumberAndName;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Address County Name
        /// <para>
        /// The name of the county, parish, borough, or comparable unit (within a state) in which an address is located.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19190">Address County Name</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String AddressCountyName { get => _AddressCountyName; set => SetProperty(ref _AddressCountyName, value); }

        /// <summary>
        /// Address Apartment Room or Suite Number
        /// <para>
        /// The apartment, room, or suite number of an address.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19019">Address Apartment Room or Suite Number</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String ApartmentRoomOrSuiteNumber { get => _ApartmentRoomOrSuiteNumber; set => SetProperty(ref _ApartmentRoomOrSuiteNumber, value); }

        /// <summary>
        /// Address City
        /// <para>
        /// The name of the city in which an address is located.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19040">Address City</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String City { get => _City; set => SetProperty(ref _City, value); }

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
        /// Latitude
        /// <para>
        /// The north or south angular distance from the equator that, when combined with longitude, reflects an estimation of where the address is physically situated.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19599">Latitude</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String Latitude { get => _Latitude; set => SetProperty(ref _Latitude, value); }

        /// <summary>
        /// Longitude
        /// <para>
        /// The east or west angular distance from the prime meridian that, when combined with latitude, reflects an estimation of where the address is physically situated.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19600">Longitude</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String Longitude { get => _Longitude; set => SetProperty(ref _Longitude, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IPerson"/> model
        /// </summary>
        public Guid PersonId { get => _PersonId; set => SetProperty(ref _PersonId, value); }

        /// <summary>
        /// Address Postal Code
        /// <para>
        /// A number that identifies each postal delivery area in the United States used as a portion of an address.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19214">Address Postal Code</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String PostalCode { get => _PostalCode; set => SetProperty(ref _PostalCode, value); }

        /// <summary>
        /// Country Code
        /// <para>
        /// The unique two character International Organization for Standardization (ISO) code for the country in which an address is located.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19050">Country Code</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefCountryId { get => _RefCountryId; set => SetProperty(ref _RefCountryId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCounty"/> model
        /// </summary>
        public Guid? RefCountyId { get => _RefCountyId; set => SetProperty(ref _RefCountyId, value); }

        /// <summary>
        /// Personal Information Verification
        /// <para>
        /// The evidence by which a persons name, address, date of birth, etc. is confirmed.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19611">Personal Information Verification</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefPersonalInformationVerificationId { get => _RefPersonalInformationVerificationId; set => SetProperty(ref _RefPersonalInformationVerificationId, value); }

        /// <summary>
        /// Address Type for Learner or Family
        /// <para>
        /// The type of address listed for a learner or a parent, guardian, family member or related person.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19358">Address Type for Learner or Family</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid RefPersonLocationTypeId { get => _RefPersonLocationTypeId; set => SetProperty(ref _RefPersonLocationTypeId, value); }

        /// <summary>
        /// State Abbreviation
        /// <para>
        /// The abbreviation for the state (within the United States) or outlying area in which an address is located.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19267">State Abbreviation</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefStateId { get => _RefStateId; set => SetProperty(ref _RefStateId, value); }

        /// <summary>
        /// Address Street Number and Name
        /// <para>
        /// The street number and street name or post office box number of an address.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19269">Address Street Number and Name</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String StreetNumberAndName { get => _StreetNumberAndName; set => SetProperty(ref _StreetNumberAndName, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPersonAddress model)
        {
            IsBusy = true;
            Id = model.Id;
            AddressCountyName = model.AddressCountyName; // Address County Name
            ApartmentRoomOrSuiteNumber = model.ApartmentRoomOrSuiteNumber; // Address Apartment Room or Suite Number
            City = model.City; // Address City
            DoNotPublishIndicator = model.DoNotPublishIndicator; // Do Not Publish Indicator
            Latitude = model.Latitude; // Latitude
            Longitude = model.Longitude; // Longitude
            PersonId = model.PersonId; // 
            PostalCode = model.PostalCode; // Address Postal Code
            RefCountryId = model.RefCountryId; // Country Code
            RefCountyId = model.RefCountyId; // 
            RefPersonalInformationVerificationId = model.RefPersonalInformationVerificationId; // Personal Information Verification
            RefPersonLocationTypeId = model.RefPersonLocationTypeId; // Address Type for Learner or Family
            RefStateId = model.RefStateId; // State Abbreviation
            StreetNumberAndName = model.StreetNumberAndName; // Address Street Number and Name
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }

        #region RefPersonLocationType List
        /// <summary>
        /// The complete Address County Name List
        /// </summary>
        private static List<ReferenceModelBase> RefPersonLocationTypeList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("ae7eccbb-e7d1-4eed-8ed9-657f516c0dc2"), Code="Mailing", Description="Mailing", Definition="Mailing is specified as the type of address listed for a learner or a parent, guardian, family member or related person.", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("f7a742e8-186a-4434-867b-1ece5db55bd8"), Code="Physical", Description="Physical", Definition="Physical is specified as the type of address listed for a learner or a parent, guardian, family member or related person.", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("a5d2346b-53d1-495a-bed2-2509446ffc0c"), Code="Billing", Description="Billing address", Definition="Billing address is specified as the type of address listed for a learner or a parent, guardian, family member or related person.", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("1d0ebc9c-ffa3-4222-ba08-252d5b173955"), Code="Shipping", Description="Shipping", Definition="Shipping is specified as the type of address listed for a learner or a parent, guardian, family member or related person.", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("349800c5-2f48-4223-ad4d-6c27ce69a35d"), Code="OnCampus", Description="On campus", Definition="On campus is specified as the type of address listed for a learner or a parent, guardian, family member or related person.", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("0521b069-b534-4f1a-878a-4363935dc832"), Code="OffCampus", Description="Off-campus, temporary", Definition="Off-campus, temporary is specified as the type of address listed for a learner or a parent, guardian, family member or related person.", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("e4c3e7ee-5e54-464e-8b89-49a00ffb3ac0"), Code="PermanentStudent", Description="Permanent, student", Definition="Permanent, student is specified as the type of address listed for a learner or a parent, guardian, family member or related person.", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("0b945561-b9d6-42d0-89f5-ccce231a7f2b"), Code="PermanentAdmission", Description="Permanent, at time of admission", Definition="Permanent, at time of admission is specified as the type of address listed for a learner or a parent, guardian, family member or related person.", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("82ab5197-068d-4377-b2d8-e5f9a510c3cf"), Code="FatherAddress", Description="Father's address", Definition="Father's address is specified as the type of address listed for a learner or a parent, guardian, family member or related person.", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("d2687f92-6a03-4bde-aac3-5f02c9e7e316"), Code="MotherAddress", Description="Mother's address", Definition="Mother's address is specified as the type of address listed for a learner or a parent, guardian, family member or related person.", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("8e1b7ab2-fe5c-408a-8235-4da2fbe9c351"), Code="GuardianAddress", Description="Guardian's address", Definition="Guardian's address is specified as the type of address listed for a learner or a parent, guardian, family member or related person.", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("6f29b4f7-579f-442d-aa67-f39f6a684fc5"), Code="Mailing", Description="Mailing", Definition="Mailing is specified as the address type for a staff member.", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("1879d40e-0df0-4e2f-8944-766b878acae2"), Code="Physical", Description="Physical", Definition="Physical is specified as the address type for a staff member.", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("3685562f-f9df-4031-8f76-545457d8cda9"), Code="OtherHome", Description="Other home address", Definition="Other home address is specified as the address type for a staff member.", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("244c4f10-668c-4312-be8a-6becb6c49f2e"), Code="Employers", Description="Employer's address", Definition="Employer's address is specified as the address type for a staff member.", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("c1c94667-c362-4e23-9947-3671e040386e"), Code="Employment", Description="Employment address", Definition="Employment address is specified as the address type for a staff member.", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("625b434a-b1dd-4b69-af13-f30032cad6e0"), Code="Billing", Description="Billing address", Definition="Billing address is specified as the address type for a staff member.", SortOrder=Convert.ToDecimal("") },
        };
        #endregion
    }
}
