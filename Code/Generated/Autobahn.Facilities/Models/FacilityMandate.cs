//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   FacilityMandate.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The FacilityMandate
     /// </summary>
    public partial class FacilityMandate : AutobahnBase, Interfaces.IFacilityMandate
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Facility"/> model
        /// </summary>
        public Guid FacilityId { get; set; }

        /// <summary>
        /// Defines the FacilityMandate.FacilityStateOrLocalMandateName non nullable property
        /// </summary>
        public System.String FacilityStateOrLocalMandateName { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilitiesMandateAuthorityType"/> model
        /// </summary>
        public Guid? RefFacilitiesMandateAuthorityTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilityApplicableFederalMandateType"/> model
        /// </summary>
        public Guid? RefFacilityApplicableFederalMandateTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilityFederalMandateInterestType"/> model
        /// </summary>
        public Guid? RefFacilityFederalMandateInterestTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilityStateOrLocalMandateInterestType"/> model
        /// </summary>
        public Guid? RefFacilityStateOrLocalMandateInterestTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
