//**********************************************************
//* DomainName: Common Models
//* FileName:   CourseSectionLocationModel.cs
//* Name:       Classroom Identifier
//* Definition: A unique number or alphanumeric code assigned to a room by a school, school system, state, or other agency or entity.
//***************************************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// A unique number or alphanumeric code assigned to a room by a school, school system, state, or other agency or entity.
     /// </summary>
    public partial class CourseSectionLocationModel : AutobahnBase, Interfaces.ICourseSectionLocation
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IClassroom"/> model
        /// </summary>
        public Guid ClassroomId { get; set; }

        /// <summary>
        /// Available Carnegie Unit Credit
        /// <para>
        /// Measured in Carnegie units, the amount of credit available to a student who successfully meets the objectives of the course. A course meeting every day for one period of the school day over the span of a school year offers one Carnegie unit. A Carnegie unit is thus a measure of "seat time" rather than a measure of attainment of the course objectives.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19030">Available Carnegie Unit Credit</a>
        /// </para>
        /// </summary>
        public Guid CourseSectionId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefInstructionLocationType"/> model
        /// </summary>
        public Guid? RefInstructionLocationTypeId { get; set; }

    }
}
