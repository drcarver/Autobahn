//***************************************************************************
//* DomainName: Authentication and Authorization Interfaces (used by both models and View Models
//* FileName:   IProgram.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Authorization.Interfaces
{
     /// <summary>
     /// The IProgram Interface
     /// </summary>
    public partial interface IProgram : IAutobahnBase
    {
        /// <summary>
        /// The total number of credits required for a student to graduate from the school of enrollment or complete a program.
        /// </summary>
        System.Decimal? CreditsRequired { get; set; }

        /// <summary>
        /// The total number of credits required for a student to graduate from the school of enrollment or complete a program.
        /// </summary>
        Guid OrganizationId { get; set; }

    }
}
