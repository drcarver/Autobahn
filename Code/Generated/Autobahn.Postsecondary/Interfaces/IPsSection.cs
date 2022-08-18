//***************************************************************************
//* DomainName: Postsecondary (PS) Interfaces (used by both models and View Models
//* FileName:   IPsSection.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Postsecondary.Interfaces
{
     /// <summary>
     /// The IPsSection Interface
     /// </summary>
    public partial interface IPsSection : IAutobahnBase
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
        Guid CourseSectionId { get; set; }

        /// <summary>
        /// Course Academic Grade Scale Code
        /// <para>
        /// The grading scale used by an academic educational institution for an academic course.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20264">Course Academic Grade Scale Code</a>
        /// </para>
        /// </summary>
        System.String GradeValueQualifier { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCipCode"/> model
        /// </summary>
        Guid? RefCipCodeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCourseGPAApplicability"/> model
        /// </summary>
        Guid? RefCourseGPAApplicabilityId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCourseHonorsType"/> model
        /// </summary>
        Guid? RefCourseHonorsTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCourseInstructionMethod"/> model
        /// </summary>
        Guid? RefCourseInstructionMethodId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCourseLevelType"/> model
        /// </summary>
        Guid? RefCourseLevelTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefDevelopmentalEducationType"/> model
        /// </summary>
        Guid? RefDevelopmentalEducationTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefWorkbasedLearningOpportunityType"/> model
        /// </summary>
        Guid? RefWorkbasedLearningOpportunityTypeId { get; set; }

    }
}
