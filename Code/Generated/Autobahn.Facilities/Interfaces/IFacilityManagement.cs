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
        /// The type of real estate vehicle through which a public charter school has access and control of its building space.
        /// </summary>
        Guid FacilityId { get; set; }

        /// <summary>
        /// The type of real estate vehicle through which a public charter school has access and control of its building space.
        /// </summary>
        Guid? RefBuildingCharterSchoolRealtyAccessTypeId { get; set; }

        /// <summary>
        /// The type of real estate vehicle through which a public charter school has access and control of its building space.
        /// </summary>
        Guid? RefBuildingCleaningStandardTypeId { get; set; }

        /// <summary>
        /// The type of real estate vehicle through which a public charter school has access and control of its building space.
        /// </summary>
        Guid? RefFacilityCapitalProgramMgmtTypeId { get; set; }

        /// <summary>
        /// The type of real estate vehicle through which a public charter school has access and control of its building space.
        /// </summary>
        Guid? RefFacilityComplianceAgencyTypeId { get; set; }

        /// <summary>
        /// The type of real estate vehicle through which a public charter school has access and control of its building space.
        /// </summary>
        Guid? RefFacilityOperationsMgmtTypeId { get; set; }

    }
}
