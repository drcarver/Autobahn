//**********************************************************
//* DomainName: Facilities
//* FileName:   FacilityUtilizationModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The FacilityUtilization Model
     /// </summary>
    public partial class FacilityUtilizationModel : AutobahnBase, Interfaces.IFacilityUtilization
    {
        /// <summary>
        /// 
        /// </summary>
        public Guid? BuildingHoursOfPublicUsePerWeek { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  BuildingNetAreaOfInstructionalSpace { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  BuildingNumberOfTeachingStations { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  BuildingPublicUsePolicyDescription { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  FacilityEnrollmentCapacity { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordStartDateTime { get; set; }

    }
}
