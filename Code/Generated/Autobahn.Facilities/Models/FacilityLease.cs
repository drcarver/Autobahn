//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   FacilityLease.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The FacilityLease
     /// </summary>
    public partial class FacilityLease : AutobahnBase, Interfaces.IFacilityLease
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Facility"/> model
        /// </summary>
        public Guid FacilityId { get; set; }

        /// <summary>
        /// Defines the FacilityLease.FacilityLeaseAmount nullable property
        /// </summary>
        public System.Decimal? FacilityLeaseAmount { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilityLeaseAmountCategory"/> model
        /// </summary>
        public Guid? RefFacilityLeaseAmountCategoryId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilityLeaseType"/> model
        /// </summary>
        public Guid? RefFacilityLeaseTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
