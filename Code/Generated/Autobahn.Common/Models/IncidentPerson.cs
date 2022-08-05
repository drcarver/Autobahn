//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IncidentPerson.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The IncidentPerson
     /// </summary>
    public partial class IncidentPerson : AutobahnBase, Interfaces.IIncidentPerson
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Incident"/> model
        /// </summary>
        public Guid IncidentId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="Person"/> model
        /// </summary>
        public Guid PersonId { get; set; }

        /// <summary>
        /// Defines the IncidentPerson.Identifier non nullable property
        /// </summary>
        public System.String Identifier { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefIncidentPersonRoleType"/> model
        /// </summary>
        public Guid RefIncidentPersonRoleTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIncidentPersonType"/> model
        /// </summary>
        public Guid? RefIncidentPersonTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
