//**********************************************************
//* DomainName: Facilities
//* FileName:   FacilityManagementModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The FacilityManagement Model
     /// </summary>
    public partial class FacilityManagementModel : AutobahnBase, Interfaces.IFacilityManagement
    {
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
        public Guid? RefBuildingCharterSchoolRealtyAccessTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefBuildingCleaningStandardTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefFacilityCapitalProgramMgmtTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefFacilityComplianceAgencyTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefFacilityOperationsMgmtTypeId { get; set; }

    }
}
