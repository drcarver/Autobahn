//***************************************************************************
//* DomainName: Authentication and Authorization Interfaces (used by both models and View Models
//* FileName:   IIndividualizedProgramAccommodation.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Authorization.Interfaces
{
     /// <summary>
     /// The IIndividualizedProgramAccommodation Interface
     /// </summary>
    public partial interface IIndividualizedProgramAccommodation : IAutobahnBase
    {
        /// <summary>
        /// The specific accommodation necessary for assessment or instruction.
        /// </summary>
        System.String Applicability { get; set; }

        /// <summary>
        /// The specific accommodation necessary for assessment or instruction.
        /// </summary>
        Guid IndividualizedProgramId { get; set; }

        /// <summary>
        /// The specific accommodation necessary for assessment or instruction.
        /// </summary>
        Guid? RefAccommodationTypeId { get; set; }

    }
}
