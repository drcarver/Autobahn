//***************************************************************************
//* DomainName: Elementary and Secondary (K12) Interfaces (used by both models and View Models
//* FileName:   IK12SchoolImprovement.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The IK12SchoolImprovement Interface
     /// </summary>
    public partial interface IK12SchoolImprovement : IAutobahnBase
    {
        /// <summary>
        /// An indication of whether the school received funds under Section 1003 of ESEA, as amended.
        /// </summary>
        Guid K12SchoolId { get; set; }

        /// <summary>
        /// An indication of whether the school received funds under Section 1003 of ESEA, as amended.
        /// </summary>
        Guid? RefSchoolImprovementFundsId { get; set; }

        /// <summary>
        /// An indication of whether the school received funds under Section 1003 of ESEA, as amended.
        /// </summary>
        Guid? RefSchoolImprovementStatusId { get; set; }

        /// <summary>
        /// An indication of whether the school received funds under Section 1003 of ESEA, as amended.
        /// </summary>
        Guid? RefSigInterventionTypeId { get; set; }

        /// <summary>
        /// An indication of whether the school received funds under Section 1003 of ESEA, as amended.
        /// </summary>
        System.DateTime? SchoolImprovementExitDate { get; set; }

    }
}
