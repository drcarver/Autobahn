//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IClassroomModel.cs
//**********************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IClassroomModel Interface
     /// </summary>
    public partial interface IClassroomModel : IAutobahnBase
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
