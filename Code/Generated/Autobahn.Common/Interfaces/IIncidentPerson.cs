//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IIncidentPerson.cs
//**********************************************************

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IIncidentPerson
     /// </summary>
    public partial interface IIncidentPerson
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

        /// <summary>
        /// Defines the IncidentPerson.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the IncidentPerson.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatus"/> model
        /// </summary>
        Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        Guid? DataCollectionId { get; set; }

    }
}
