//***************************************************************************
//* DomainName: Authentication and Authorization Interfaces (used by both models and View Models
//* FileName:   IClassroom.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Authorization.Interfaces
{
     /// <summary>
     /// The IClassroom Interface
     /// </summary>
    public partial interface IClassroom : IAutobahnBase
    {
        /// <summary>
        /// A unique number or alphanumeric code assigned to a room by a school, school system, state, or other agency or entity.
        /// </summary>
        System.String ClassroomIdentifier { get; set; }

        /// <summary>
        /// A unique number or alphanumeric code assigned to a room by a school, school system, state, or other agency or entity.
        /// </summary>
        Guid LocationId { get; set; }

    }
}
