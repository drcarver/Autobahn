//***************************************************************************
//* DomainName: Authentication and Authorization Interfaces (used by both models and View Models
//* FileName:   IIndividualizedProgramEligibility.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Authorization.Interfaces
{
     /// <summary>
     /// The IIndividualizedProgramEligibility Interface
     /// </summary>
    public partial interface IIndividualizedProgramEligibility : IAutobahnBase
    {
        /// <summary>
        /// Indication parent agreed to evaluate student.
        /// </summary>
        System.DateTime? ConsentToEvaluateDate { get; set; }

        /// <summary>
        /// Indication parent agreed to evaluate student.
        /// </summary>
        System.Boolean? ConsentToEvaluateIndicator { get; set; }

        /// <summary>
        /// Indication parent agreed to evaluate student.
        /// </summary>
        Guid IndividualizedProgramId { get; set; }

        /// <summary>
        /// Indication parent agreed to evaluate student.
        /// </summary>
        System.String ParentObservations { get; set; }

    }
}
