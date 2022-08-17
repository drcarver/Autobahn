//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IClassroom.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IClassroom Interface
     /// </summary>
    public partial interface IClassroom : IAutobahnBase
    {
        /// <summary>
        /// Classroom Identifier
        /// <para>
        /// A unique number or alphanumeric code assigned to a room by a school, school system, state, or other agency or entity.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19507">Classroom Identifier</a>
        /// </para>
        /// </summary>
        System.String ClassroomIdentifier { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="ILocation"/> model
        /// </summary>
        Guid LocationId { get; set; }

    }
}
