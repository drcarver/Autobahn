//***************************************************************************
//* DomainName: Facilities Interfaces (used by both models and View Models
//* FileName:   IBuildingSystemComponent.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Facilities.Interfaces
{
     /// <summary>
     /// The IBuildingSystemComponent Interface
     /// </summary>
    public partial interface IBuildingSystemComponent : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
         BuildingInstitutionalEquipmentDescription { get; set; }

        /// <summary>
        /// 
        /// </summary>
         ComponentOrFixtureUsefulLife { get; set; }

        /// <summary>
        /// 
        /// </summary>
         Identifier { get; set; }

        /// <summary>
        /// 
        /// </summary>
         InstallationDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
         LifecycleCost { get; set; }

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
         RefFacilityFurnishingsTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        Guid? RefFacilitySystemOrComponentConditionId { get; set; }

    }
}
