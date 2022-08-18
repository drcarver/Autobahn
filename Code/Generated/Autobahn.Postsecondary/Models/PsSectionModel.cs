//**********************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   PsSectionModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Postsecondary.Models
{
     /// <summary>
     /// The PsSection Model
     /// </summary>
    public partial class PsSectionModel : AutobahnBase, Interfaces.IPsSection
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
        /// Course Academic Grade Scale Code
        /// <para>
        /// The grading scale used by an academic educational institution for an academic course.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20264">Course Academic Grade Scale Code</a>
        /// </para>
        /// </summary>
        public System.String GradeValueQualifier { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCipCode"/> model
        /// </summary>
        public Guid? RefCipCodeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCourseGPAApplicability"/> model
        /// </summary>
        public Guid? RefCourseGPAApplicabilityId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCourseHonorsType"/> model
        /// </summary>
        public Guid? RefCourseHonorsTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCourseInstructionMethod"/> model
        /// </summary>
        public Guid? RefCourseInstructionMethodId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCourseLevelType"/> model
        /// </summary>
        public Guid? RefCourseLevelTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefDevelopmentalEducationType"/> model
        /// </summary>
        public Guid? RefDevelopmentalEducationTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefWorkbasedLearningOpportunityType"/> model
        /// </summary>
        public Guid? RefWorkbasedLearningOpportunityTypeId { get; set; }

    }
}
