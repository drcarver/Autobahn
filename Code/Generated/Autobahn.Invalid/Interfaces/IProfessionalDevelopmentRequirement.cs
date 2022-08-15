//***************************************************************************
//* DomainName: Invalid or Unreferenced Models Interfaces (used by both models and View Models
//* FileName:   IProfessionalDevelopmentRequirement.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Invalid.Interfaces
{
     /// <summary>
     /// The IProfessionalDevelopmentRequirement Interface
     /// </summary>
    public partial interface IProfessionalDevelopmentRequirement : IAutobahnBase
    {
        /// <summary>
        /// Number of clock hours of training required for providers to meet requirements of the state.
        /// </summary>
        System.Decimal? RequiredTrainingClockHours { get; set; }

    }
}
