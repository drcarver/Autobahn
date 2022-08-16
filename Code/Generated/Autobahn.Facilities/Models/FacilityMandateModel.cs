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
        /// 
        /// </summary>
        public  FacilityStateOrLocalMandateName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordStartDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefFacilitiesMandateAuthorityTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? RefFacilityApplicableFederalMandateTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefFacilityFederalMandateInterestTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefFacilityStateOrLocalMandateInterestTypeId { get; set; }

    }
}
