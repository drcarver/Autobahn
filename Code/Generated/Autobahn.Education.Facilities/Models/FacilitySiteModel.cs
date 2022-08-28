//**********************************************************
//* DomainName: Facilities
//* FileName:   FacilitySiteModel.cs
//***************************************************************************

using Autobahn.Education.Interfaces.Facilities;

namespace Autobahn.Education.Facilities.Models
{
     /// <summary>
     /// The FacilitySite Model
     /// </summary>
    public partial class FacilitySiteModel : IFacilitySite
    {
        // Concrete implementation of IAutobahnBase
        #region IAutobahnBase
        /// <summary>
        /// Gets the model's changed status.
        /// </summary>
        public bool IsChanged { get; private set; } = false;

        /// <summary>
        /// Resets the model's state to unchanged by accepting the modifications.
        /// </summary>
        public void AcceptChanges()
        {
             IsChanged = false;
             IsNew = false;
        }

        /// <summary>
        /// True if the model is new and unsaved.
        /// </summary>
        public bool IsNew { get; set; } =  false;

        /// <summary>
        /// Is it a deleted model?
        /// </summary>
        public bool IsDeleted { get; set; } = false;

        /// <summary>
        /// The Id of the Model
        /// </summary>
        public Guid Id { get; set; } = Guid.NewGuid();
        #endregion

        #region IFacilitySite
        /// <summary>
        /// Reference to an optional instance of the <see cref="IFacility"/> model
        /// </summary>
        public Guid FacilityId { get; set; }

        /// <summary>
        /// Facility Site Area
        /// <para>
        /// The total number of acres in a continuous piece of land, to the nearest tenth, including undeveloped areas as well as areas occupied by buildings, walks, drives, parking facilities, and other improvements.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20754">Facility Site Area</a>
        /// </para>
        /// </summary>
        public Decimal? FacilitySiteArea { get; set; }

        /// <summary>
        /// Facility Site Identifier
        /// <para>
        /// The lot and square number, or equivalent unique municipal number identification, of a parcel of land.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20767">Facility Site Identifier</a>
        /// </para>
        /// </summary>
        public System.String FacilitySiteIdentifier { get; set; }

        /// <summary>
        /// Building Site Use Restrictions Type
        /// <para>
        /// A characterization of a site that would define restrictions or opportunities.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20841">Building Site Use Restrictions Type</a>
        /// </para>
        /// </summary>
        public Guid? RefBuildingSiteUseRestrictionsTypeId { get; set; }

        /// <summary>
        /// Facility Site Outdoor Area Type
        /// <para>
        /// The designated constructed outdoor area on a public school site.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20811">Facility Site Outdoor Area Type</a>
        /// </para>
        /// </summary>
        public Guid? RefFacilitySiteOutdoorAreaTypeId { get; set; }

        #endregion
    }
}
