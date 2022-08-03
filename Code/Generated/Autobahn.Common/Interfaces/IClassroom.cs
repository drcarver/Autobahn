//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IClassroom.cs
//**********************************************************

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IClassroom
     /// </summary>
    public partial interface IClassroom
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Location"/> model
        /// </summary>
        Guid LocationId { get; set; }

        /// <summary>
        /// Defines the Classroom.ClassroomIdentifier non nullable property
        /// </summary>
        System.String ClassroomIdentifier { get; set; }

        /// <summary>
        /// Defines the Classroom.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the Classroom.RecordEndDateTime nullable property
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
