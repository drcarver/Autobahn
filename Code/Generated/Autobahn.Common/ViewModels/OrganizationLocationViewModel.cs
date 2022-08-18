//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationLocationViewModel.cs
//***************************************************************************

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The OrganizationLocation View Model
     /// </summary>
    public partial class OrganizationLocationViewModel : ViewModelBase, Interfaces.IOrganizationLocation
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from OrganizationLocation";

        // member variable for the LocationId property
        private Guid _LocationId;

        // member variable for the OrganizationId property
        private Guid _OrganizationId;

        // RefOrganizationLocationTypeId -- (backing property for Address Type for Organization)
        private Guid? _RefOrganizationLocationTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="ILocation"/> model
        /// </summary>
        public Guid LocationId { get => _LocationId; set => SetProperty(ref _LocationId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganization"/> model
        /// </summary>
        public Guid OrganizationId { get => _OrganizationId; set => SetProperty(ref _OrganizationId, value); }

        /// <summary>
        /// Address Type for Organization
        /// <para>
        /// The type of address listed for an organization.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19644">Address Type for Organization</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefOrganizationLocationTypeId { get => _RefOrganizationLocationTypeId; set => SetProperty(ref _RefOrganizationLocationTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IOrganizationLocation model)
        {
            IsBusy = true;
            Id = model.Id;
            LocationId = model.LocationId; // 
            OrganizationId = model.OrganizationId; // 
            RefOrganizationLocationTypeId = model.RefOrganizationLocationTypeId; // Address Type for Organization
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }

        #region RefOrganizationLocationType List
        /// <summary>
        /// The complete <see cref="RefOrganizationLocationType"> List
        /// </summary>
        private static List<ReferenceModelBase> RefOrganizationLocationTypeList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("718bdbc7-12bd-49f8-9319-d30c4a7e998d"), Code="Mailing", Description="Mailing", Definition="Mailing is specified as the type of address listed for an organization.", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("fcf9d259-5177-46fb-b6ff-03dbec77575f"), Code="Physical", Description="Physical", Definition="Physical is specified as the type of address listed for an organization.", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("0e474f9a-e50e-4c6f-8952-a693c281bb8f"), Code="Shipping", Description="Shipping", Definition="Shipping is specified as the type of address listed for an organization.", SortOrder=Convert.ToDecimal("3.00") },
        };
        #endregion
    }
}
