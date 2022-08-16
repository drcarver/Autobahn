//***************************************************************************
//* DomainName: Facilities Interfaces (used by both models and View Models
//* FileName:   IFacilitySite.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Facilities.Interfaces
{
     /// <summary>
     /// The IFacilitySite Interface
     /// </summary>
    public partial interface IFacilitySite : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
        Guid? FacilitySiteArea { get; set; }

        /// <summary>
        /// 
        /// </summary>
         FacilitySiteIdentifier { get; set; }

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
         RefBuildingSiteUseRestrictionsTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefFacilitySiteOutdoorAreaTypeId { get; set; }

    }
}
