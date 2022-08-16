//***************************************************************************
//* DomainName: Facilities Interfaces (used by both models and View Models
//* FileName:   IBuildingSystemCategory.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Facilities.Interfaces
{
     /// <summary>
     /// The IBuildingSystemCategory Interface
     /// </summary>
    public partial interface IBuildingSystemCategory : IAutobahnBase
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
        Guid? RefBuildingAirDistributionSystemTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefBuildingCommMgmtComponentSystemTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefBuildingCoolingGenerationSystemTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefBuildingElectricalSystemTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefBuildingFireProtectionSystemTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefBuildingHeatingGenerationSystemTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefBuildingHVACSystemTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefBuildingMechanicalConveyingSystemTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefBuildingMechanicalSystemTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefBuildingPlumbingSystemTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefBuildingSecuritySystemTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefBuildingSystemTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefBuildingTechnologyWiringSystemTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefBuildingVerticalTransportationSystemTypeId { get; set; }

    }
}
