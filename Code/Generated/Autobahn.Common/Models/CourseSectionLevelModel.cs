//**********************************************************
//* DomainName: Common Models
//* FileName:   CourseSectionLevelModel.cs
//***************************************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The CourseSectionLevel Model
     /// </summary>
    public partial class CourseSectionLevelModel : AutobahnBase, Interfaces.ICourseSectionLevel
    {
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
        /// Reference to an optional instance of the <see cref="RefCourseLevelType"/> model
        /// </summary>
        public Guid RefCourseLevelTypeId { get; set; }

    }
}
