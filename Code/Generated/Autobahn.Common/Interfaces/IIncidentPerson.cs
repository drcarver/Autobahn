//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IIncidentPerson.cs
//**********************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IIncidentPerson
     /// </summary>
    public partial interface IIncidentPerson : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Incident"/> model
        /// </summary>
        Guid IncidentId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="Person"/> model
        /// </summary>
        Guid PersonId { get; set; }

        /// <summary>
        /// Defines the IncidentPerson.Identifier non nullable property
        /// </summary>
        System.String Identifier { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefIncidentPersonRoleType"/> model
        /// </summary>
        Guid RefIncidentPersonRoleTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIncidentPersonType"/> model
        /// </summary>
        Guid? RefIncidentPersonTypeId { get; set; }

    }
}
