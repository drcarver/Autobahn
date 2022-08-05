//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   Classroom.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The Classroom
     /// </summary>
    public partial class Classroom : AutobahnBase, Interfaces.IClassroom
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Location"/> model
        /// </summary>
        public Guid LocationId { get; set; }

        /// <summary>
        /// Defines the Classroom.ClassroomIdentifier non nullable property
        /// </summary>
        public System.String ClassroomIdentifier { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
