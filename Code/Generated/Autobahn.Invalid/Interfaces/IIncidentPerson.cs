//***************************************************************************
//* DomainName: Invalid or Unreferenced Models Interfaces (used by both models and View Models
//* FileName:   IIncidentPerson.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Invalid.Interfaces
{
     /// <summary>
     /// The IIncidentPerson Interface
     /// </summary>
    public partial interface IIncidentPerson : IAutobahnBase
    {
        /// <summary>
        /// Identifies the perpetrator of the incident by use of a pre-existing unique identifier assigned to a student or staff member by a school or district.
        /// </summary>
        System.String Identifier { get; set; }

        /// <summary>
        /// Identifies the perpetrator of the incident by use of a pre-existing unique identifier assigned to a student or staff member by a school or district.
        /// </summary>
        Guid IncidentId { get; set; }

        /// <summary>
        /// Identifies the perpetrator of the incident by use of a pre-existing unique identifier assigned to a student or staff member by a school or district.
        /// </summary>
        Guid PersonId { get; set; }

        /// <summary>
        /// Identifies the perpetrator of the incident by use of a pre-existing unique identifier assigned to a student or staff member by a school or district.
        /// </summary>
        Guid RefIncidentPersonRoleTypeId { get; set; }

        /// <summary>
        /// Identifies the perpetrator of the incident by use of a pre-existing unique identifier assigned to a student or staff member by a school or district.
        /// </summary>
        Guid? RefIncidentPersonTypeId { get; set; }

    }
}
