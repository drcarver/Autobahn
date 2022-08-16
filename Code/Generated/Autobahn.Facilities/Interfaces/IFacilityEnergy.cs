//***************************************************************************
//* DomainName: Facilities Interfaces (used by both models and View Models
//* FileName:   IFacilityEnergy.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Facilities.Interfaces
{
     /// <summary>
     /// The IFacilityEnergy Interface
     /// </summary>
    public partial interface IFacilityEnergy : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
        Guid? BuildingEnergyServiceCompanyName { get; set; }

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
         RefBuildingEnergySourceTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefFacilityUtilityProviderTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefFacilityUtilityTypeId { get; set; }

    }
}
