//***************************************************************************
//* DomainName: Facilities Interfaces (used by both models and View Models
//* FileName:   IFacilityMandate.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Facilities.Interfaces
{
     /// <summary>
     /// The IFacilityMandate Interface
     /// </summary>
    public partial interface IFacilityMandate : IAutobahnBase
    {
        /// <summary>
        /// The particular federal law, regulation, or standard that pertains to a school facility.
        /// </summary>
        Guid? RefFacilityApplicableFederalMandateTypeId { get; set; }

    }
}
