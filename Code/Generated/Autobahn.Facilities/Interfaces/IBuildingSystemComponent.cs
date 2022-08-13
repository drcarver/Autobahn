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
        /// The rating of the system or component functions under the demands of its regular operation.
        /// </summary>
        System.String BuildingInstitutionalEquipmentDescription { get; set; }

        /// <summary>
        /// The rating of the system or component functions under the demands of its regular operation.
        /// </summary>
        System.Int32? ComponentOrFixtureUsefulLife { get; set; }

        /// <summary>
        /// The rating of the system or component functions under the demands of its regular operation.
        /// </summary>
        Guid FacilityId { get; set; }

        /// <summary>
        /// The rating of the system or component functions under the demands of its regular operation.
        /// </summary>
        System.String Identifier { get; set; }

        /// <summary>
        /// The rating of the system or component functions under the demands of its regular operation.
        /// </summary>
        System.String InstallationDate { get; set; }

        /// <summary>
        /// The rating of the system or component functions under the demands of its regular operation.
        /// </summary>
        System.Decimal? LifecycleCost { get; set; }

        /// <summary>
        /// The rating of the system or component functions under the demands of its regular operation.
        /// </summary>
        Guid? RefFacilityFurnishingsTypeId { get; set; }

        /// <summary>
        /// The rating of the system or component functions under the demands of its regular operation.
        /// </summary>
        Guid? RefFacilitySystemOrComponentConditionId { get; set; }

    }
}
