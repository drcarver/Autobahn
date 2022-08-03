//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IPerson.cs
//**********************************************************

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IPerson
     /// </summary>
    public partial interface IPerson
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="PersonMaster"/> model
        /// </summary>
        Guid? PersonMasterId { get; set; }

        /// <summary>
        /// Defines the Person.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the Person.RecordEndDateTime nullable property
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
