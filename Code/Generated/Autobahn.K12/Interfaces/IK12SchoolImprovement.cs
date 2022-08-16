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
        Guid? RefSchoolImprovementFundsId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefSchoolImprovementStatusId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefSigInterventionTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         SchoolImprovementExitDate { get; set; }

    }
}
