//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   IncidentPersonModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Authorization.Models
{
     /// <summary>
     /// The IncidentPerson Model
     /// </summary>
    public partial class IncidentPersonModel : AutobahnBase, Interfaces.IIncidentPerson
    {
        /// <summary>
        /// Identifies the perpetrator of the incident by use of a pre-existing unique identifier assigned to a student or staff member by a school or district.
        /// </summary>
        public System.String Identifier { get; set; }

        /// <summary>
        /// Identifies the perpetrator of the incident by use of a pre-existing unique identifier assigned to a student or staff member by a school or district.
        /// </summary>
        public Guid IncidentId { get; set; }

        /// <summary>
        /// Identifies the perpetrator of the incident by use of a pre-existing unique identifier assigned to a student or staff member by a school or district.
        /// </summary>
        public Guid PersonId { get; set; }

        /// <summary>
        /// Identifies the perpetrator of the incident by use of a pre-existing unique identifier assigned to a student or staff member by a school or district.
        /// </summary>
        public Guid RefIncidentPersonRoleTypeId { get; set; }

        /// <summary>
        /// Identifies the perpetrator of the incident by use of a pre-existing unique identifier assigned to a student or staff member by a school or district.
        /// </summary>
        public Guid? RefIncidentPersonTypeId { get; set; }

    }
}
