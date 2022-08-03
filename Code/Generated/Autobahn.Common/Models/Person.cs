//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   Person.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The Person
     /// </summary>
    public partial class Person : IPerson
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="PersonMaster"/> model
        /// </summary>
        public Guid? PersonMasterId { get; set; }

        /// <summary>
        /// Defines the Person.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the Person.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatus"/> model
        /// </summary>
        public Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
