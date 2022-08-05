//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IClassroom.cs
//**********************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IClassroom
     /// </summary>
    public partial interface IClassroom : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Location"/> model
        /// </summary>
        Guid LocationId { get; set; }

        /// <summary>
        /// Defines the Classroom.ClassroomIdentifier non nullable property
        /// </summary>
        System.String ClassroomIdentifier { get; set; }

    }
}
