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
            new ReferenceModelBase { Id=Guid.Parse("c761399d-584b-4c7b-9269-261390ecaafb"), Code="Alias", Description="Alias", Definition="The value specified for Other Name is the person's Alias.", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("b4e908e2-5cc4-4aa6-a83e-c275d81c23b9"), Code="Nickname", Description="Nickname", Definition="The value specified for Other Name is the person's Nickname.", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("e24351de-efd7-4c83-951e-c353abb0ba1c"), Code="OtherName", Description="Other name", Definition="The value specified for Other Name is the person's Other name.", SortOrder=Convert.ToDecimal("3.00") },
            new ReferenceModelBase { Id=Guid.Parse("bfa773e9-6d6e-464b-a4c0-7352868d1656"), Code="PreviousLegalName", Description="Previous legal name", Definition="The value specified for Other Name is the person's Previous legal name.", SortOrder=Convert.ToDecimal("4.00") },
            new ReferenceModelBase { Id=Guid.Parse("03e7ae14-d67e-4991-8bb3-c9062044dd14"), Code="PreferredFamilyName", Description="Preferred Family Name", Definition="The value specified for Other Name is the person's Preferred Family Name.", SortOrder=Convert.ToDecimal("6.00") },
            new ReferenceModelBase { Id=Guid.Parse("09a1be49-8e3b-46bb-9b4a-c342df294612"), Code="PreferredGivenName", Description="Preferred Given Name", Definition="The value specified for Other Name is the person's Preferred Given Name.", SortOrder=Convert.ToDecimal("8.00") },
            new ReferenceModelBase { Id=Guid.Parse("0c0f30b8-23f7-4ca7-a630-978765daa3e6"), Code="FullName", Description="Full Name", Definition="The value specified for Other Name is the person's  Full Name.", SortOrder=Convert.ToDecimal("10.00") },
        };
        #endregion
    }
}
