//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonOtherNameViewModel.cs
//***************************************************************************

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The PersonOtherName View Model
     /// </summary>
    public partial class PersonOtherNameViewModel : ViewModelBase, Interfaces.IPersonOtherName
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PersonOtherName";

        // FirstName -- (backing property for Other First Name)
        private System.String _FirstName;

        // LastName -- (backing property for Other Last Name)
        private System.String _LastName;

        // MiddleName -- (backing property for Other Middle Name)
        private System.String _MiddleName;

        // OtherName -- (backing property for Other Name)
        private System.String _OtherName;

        // member variable for the PersonId property
        private Guid _PersonId;

        // RefOtherNameTypeId -- (backing property for Other Name Type)
        private Guid? _RefOtherNameTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Other First Name
        /// <para>
        /// A first name given to a person.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20486">Other First Name</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String FirstName { get => _FirstName; set => SetProperty(ref _FirstName, value); }

        /// <summary>
        /// Other Last Name
        /// <para>
        /// A last name given to a person.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20485">Other Last Name</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String LastName { get => _LastName; set => SetProperty(ref _LastName, value); }

        /// <summary>
        /// Other Middle Name
        /// <para>
        /// A middle name given to a person.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20487">Other Middle Name</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String MiddleName { get => _MiddleName; set => SetProperty(ref _MiddleName, value); }

        /// <summary>
        /// Other Name
        /// <para>
        /// Previous, alternate or other names or aliases associated with the person.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19206">Other Name</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String OtherName { get => _OtherName; set => SetProperty(ref _OtherName, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IPerson"/> model
        /// </summary>
        public Guid PersonId { get => _PersonId; set => SetProperty(ref _PersonId, value); }

        /// <summary>
        /// Other Name Type
        /// <para>
        /// The types of previous, alternate or other names for a person.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19627">Other Name Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefOtherNameTypeId { get => _RefOtherNameTypeId; set => SetProperty(ref _RefOtherNameTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPersonOtherName model)
        {
            IsBusy = true;
            Id = model.Id;
            FirstName = model.FirstName; // Other First Name
            LastName = model.LastName; // Other Last Name
            MiddleName = model.MiddleName; // Other Middle Name
            OtherName = model.OtherName; // Other Name
            PersonId = model.PersonId; // 
            RefOtherNameTypeId = model.RefOtherNameTypeId; // Other Name Type
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }

        #region RefOtherNameType List
        /// <summary>
        /// The complete <see cref="RefOtherNameType"> List
        /// </summary>
        private static List<ReferenceModelBase> RefOtherNameTypeList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("79a91b69-ae81-4a89-a76d-42df3c656d8a"), Code="Alias", Description="Alias", Definition="The value specified for Other Name is the person's Alias.", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("19e82f16-45de-4da0-8a35-911a3a82737b"), Code="Nickname", Description="Nickname", Definition="The value specified for Other Name is the person's Nickname.", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("47c8524f-f7cb-4f12-8edc-b2d5202ffe8c"), Code="OtherName", Description="Other name", Definition="The value specified for Other Name is the person's Other name.", SortOrder=Convert.ToDecimal("3.00") },
            new ReferenceModelBase { Id=Guid.Parse("91689172-dd8d-4ddb-bf44-23d3b7546f7e"), Code="PreviousLegalName", Description="Previous legal name", Definition="The value specified for Other Name is the person's Previous legal name.", SortOrder=Convert.ToDecimal("4.00") },
            new ReferenceModelBase { Id=Guid.Parse("72aeaa7c-3492-49de-aac3-4e13c1be6f3c"), Code="PreferredFamilyName", Description="Preferred Family Name", Definition="The value specified for Other Name is the person's Preferred Family Name.", SortOrder=Convert.ToDecimal("6.00") },
            new ReferenceModelBase { Id=Guid.Parse("13ae4da8-60f2-424e-bb98-792e8f978523"), Code="PreferredGivenName", Description="Preferred Given Name", Definition="The value specified for Other Name is the person's Preferred Given Name.", SortOrder=Convert.ToDecimal("8.00") },
            new ReferenceModelBase { Id=Guid.Parse("ed2d016a-b886-4deb-861a-696f734baccd"), Code="FullName", Description="Full Name", Definition="The value specified for Other Name is the person's  Full Name.", SortOrder=Convert.ToDecimal("10.00") },
        };
        #endregion
    }
}
