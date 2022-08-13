//**********************************************************
//* DomainName: Facilities
//* FileName:   FacilityMandateModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The FacilityMandate Model
     /// </summary>
    public partial class FacilityMandateModel : AutobahnBase, Interfaces.IFacilityMandate
    {
        /// <summary>
        /// The particular federal law, regulation, or standard that pertains to a school facility.
        /// </summary>
        public Guid FacilityId { get; set; }

        /// <summary>
        /// The particular federal law, regulation, or standard that pertains to a school facility.
        /// </summary>
        public System.String FacilityStateOrLocalMandateName { get; set; }

        /// <summary>
        /// The particular federal law, regulation, or standard that pertains to a school facility.
        /// </summary>
        public Guid? RefFacilitiesMandateAuthorityTypeId { get; set; }

        /// <summary>
        /// The particular federal law, regulation, or standard that pertains to a school facility.
        /// </summary>
        public Guid? RefFacilityApplicableFederalMandateTypeId { get; set; }

        /// <summary>
        /// The particular federal law, regulation, or standard that pertains to a school facility.
        /// </summary>
        public Guid? RefFacilityFederalMandateInterestTypeId { get; set; }

        /// <summary>
        /// The particular federal law, regulation, or standard that pertains to a school facility.
        /// </summary>
        public Guid? RefFacilityStateOrLocalMandateInterestTypeId { get; set; }

    }
}
