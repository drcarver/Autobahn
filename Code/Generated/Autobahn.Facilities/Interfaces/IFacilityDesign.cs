//***************************************************************************
//* DomainName: Facilities Interfaces (used by both models and View Models
//* FileName:   IFacilityDesign.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Facilities.Interfaces
{
     /// <summary>
     /// The IFacilityDesign Interface
     /// </summary>
    public partial interface IFacilityDesign : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
         BuildingArchitectName { get; set; }

        /// <summary>
        /// 
        /// </summary>
         BuildingArchitecturalFirmName { get; set; }

        /// <summary>
        /// 
        /// </summary>
         BuildingDateOfCertificateOfOccupancy { get; set; }

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
        Guid? RefBuildingDesignTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefBuildingEnvOrEnergyPerformanceRatingCatId { get; set; }

    }
}
