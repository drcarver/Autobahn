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
        /// Building Area
        /// <para>
        /// The sum of the areas at each floor level included within the principal outside faces of exterior walls, including roofed areas with finished floors that may not have exterior walls, but are connected to the main building. This sum should include all stories or areas having floor surfaces with clear standing head room (6.5 feet or 1.98 meters) but omit architectural setbacks or projections.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20745">Building Area</a>
        /// </para>
        /// </summary>
        Guid FacilityId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingCharterSchoolRealtyAccessType"/> model
        /// </summary>
        Guid? RefBuildingCharterSchoolRealtyAccessTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingCleaningStandardType"/> model
        /// </summary>
        Guid? RefBuildingCleaningStandardTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilityCapitalProgramMgmtType"/> model
        /// </summary>
        Guid? RefFacilityCapitalProgramMgmtTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilityComplianceAgencyType"/> model
        /// </summary>
        Guid? RefFacilityComplianceAgencyTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilityOperationsMgmtType"/> model
        /// </summary>
        Guid? RefFacilityOperationsMgmtTypeId { get; set; }

    }
}
