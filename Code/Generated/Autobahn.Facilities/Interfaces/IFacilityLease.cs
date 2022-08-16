//***************************************************************************
//* DomainName: Facilities Interfaces (used by both models and View Models
//* FileName:   IFacilityLease.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Facilities.Interfaces
{
     /// <summary>
     /// The IFacilityLease Interface
     /// </summary>
    public partial interface IFacilityLease : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
        Guid? FacilityLeaseAmount { get; set; }

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
         RefFacilityLeaseAmountCategoryId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefFacilityLeaseTypeId { get; set; }

    }
}
