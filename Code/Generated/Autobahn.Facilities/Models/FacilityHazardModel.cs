//**********************************************************
//* DomainName: Facilities
//* FileName:   FacilityHazardModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The FacilityHazard Model
     /// </summary>
    public partial class FacilityHazardModel : AutobahnBase, Interfaces.IFacilityHazard
    {
        /// <summary>
        /// 
        /// </summary>
        public  FacilityHazardousCondExpectedRemediationDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? FacilityLocationOfHazardousMaterials { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  FacilityNearbyEnvHazardDescription { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  HazardousMaterialOrConditionDescription { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  HazardousMaterialOrConditionTestingDate { get; set; }

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
        public  RefFacilityHazardousMaterialsOrCondTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefFacilityNaturallyOccurringHazardTypeId { get; set; }

    }
}
