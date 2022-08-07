//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   ClassroomModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The Classroom Model
     /// </summary>
    public partial class ClassroomModel : AutobahnBase, Interfaces.IClassroomModel
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
