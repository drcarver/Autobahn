//***************************************************************************
//* DomainName: Facilities Interfaces (used by both models and View Models
//* FileName:   IFacilityManagement.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Facilities.Interfaces
{
     /// <summary>
     /// The IFacilityManagement Interface
     /// </summary>
    public partial interface IFacilityManagement : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
         RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordStartDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        Guid? RefBuildingCharterSchoolRealtyAccessTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefBuildingCleaningStandardTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefFacilityCapitalProgramMgmtTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefFacilityComplianceAgencyTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefFacilityOperationsMgmtTypeId { get; set; }

    }
}
