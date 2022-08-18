//**********************************************************
//* DomainName: Facilities
//* FileName:   FacilitySiteViewModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Facilities.ViewModels
{
     /// <summary>
     /// The FacilitySite View Model
     /// </summary>
    public partial class FacilitySiteViewModel : ViewModelBase, Interfaces.IFacilitySite
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from FacilitySite";

        // member variable for the FacilityId property
        private Guid _FacilityId;

        // FacilitySiteArea -- (backing property for Facility Site Area)
        private System.Decimal? _FacilitySiteArea;

        // FacilitySiteIdentifier -- (backing property for Facility Site Identifier)
        private System.String _FacilitySiteIdentifier;

        // RefBuildingSiteUseRestrictionsTypeId -- (backing property for Building Site Use Restrictions Type)
        private Guid? _RefBuildingSiteUseRestrictionsTypeId;

        // RefFacilitySiteOutdoorAreaTypeId -- (backing property for Facility Site Outdoor Area Type)
        private Guid? _RefFacilitySiteOutdoorAreaTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IFacility"/> model
        /// </summary>
        public Guid FacilityId { get => _FacilityId; set => SetProperty(ref _FacilityId, value); }

        /// <summary>
        /// Facility Site Area
        /// <para>
        /// The total number of acres in a continuous piece of land, to the nearest tenth, including undeveloped areas as well as areas occupied by buildings, walks, drives, parking facilities, and other improvements.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20754">Facility Site Area</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Decimal? FacilitySiteArea { get => _FacilitySiteArea; set => SetProperty(ref _FacilitySiteArea, value); }

        /// <summary>
        /// Facility Site Identifier
        /// <para>
        /// The lot and square number, or equivalent unique municipal number identification, of a parcel of land.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20767">Facility Site Identifier</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String FacilitySiteIdentifier { get => _FacilitySiteIdentifier; set => SetProperty(ref _FacilitySiteIdentifier, value); }

        /// <summary>
        /// Building Site Use Restrictions Type
        /// <para>
        /// A characterization of a site that would define restrictions or opportunities.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20841">Building Site Use Restrictions Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefBuildingSiteUseRestrictionsTypeId { get => _RefBuildingSiteUseRestrictionsTypeId; set => SetProperty(ref _RefBuildingSiteUseRestrictionsTypeId, value); }

        /// <summary>
        /// Facility Site Outdoor Area Type
        /// <para>
        /// The designated constructed outdoor area on a public school site.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20811">Facility Site Outdoor Area Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefFacilitySiteOutdoorAreaTypeId { get => _RefFacilitySiteOutdoorAreaTypeId; set => SetProperty(ref _RefFacilitySiteOutdoorAreaTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IFacilitySite model)
        {
            IsBusy = true;
            Id = model.Id;
            FacilityId = model.FacilityId; // 
            FacilitySiteArea = model.FacilitySiteArea; // Facility Site Area
            FacilitySiteIdentifier = model.FacilitySiteIdentifier; // Facility Site Identifier
            RefBuildingSiteUseRestrictionsTypeId = model.RefBuildingSiteUseRestrictionsTypeId; // Building Site Use Restrictions Type
            RefFacilitySiteOutdoorAreaTypeId = model.RefFacilitySiteOutdoorAreaTypeId; // Facility Site Outdoor Area Type
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
