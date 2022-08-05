//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   Person.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The Person
     /// </summary>
    public partial class Person : AutobahnBase, Interfaces.IPerson
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="PersonMaster"/> model
        /// </summary>
        public Guid? PersonMasterId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
