//***************************************************************************
//* DomainName: Authentication and Authorization Interfaces (used by both models and View Models
//* FileName:   IProfessionalDevelopmentRequirement.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Authorization.Interfaces
{
     /// <summary>
     /// The IProfessionalDevelopmentRequirement Interface
     /// </summary>
    public partial interface IProfessionalDevelopmentRequirement : IAutobahnBase
    {
        /// <summary>
        /// Number of clock hours of training required for providers to meet requirements of the state.
        /// </summary>
        Guid? CompetencySetId { get; set; }

        /// <summary>
        /// Number of clock hours of training required for providers to meet requirements of the state.
        /// </summary>
        Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Number of clock hours of training required for providers to meet requirements of the state.
        /// </summary>
        System.Decimal? RequiredTrainingClockHours { get; set; }

    }
}
