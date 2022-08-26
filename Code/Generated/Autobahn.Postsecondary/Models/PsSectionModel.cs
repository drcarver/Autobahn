//**********************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   PsSectionModel.cs
//***************************************************************************

using Autobahn.Interfaces.Postsecondary;
using Autobahn.Interfaces.Common;
using Autobahn.Common.Models;

namespace Autobahn.Postsecondary.Models
{
     /// <summary>
     /// The PsSection Model
     /// </summary>
    public partial class PsSectionModel : AutobahnBase, IPsSection
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="ICourseSection"/> model
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
        /// Classification of Instructional Program Code
        /// <para>
        /// A six-digit code in the form xx.xxxx that identifies instructional program specialties within educational institutions.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19043">Classification of Instructional Program Code</a>
        /// </para>
        /// </summary>
        public Guid? RefCipCodeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCourseGpaapplicability"/> model
        /// </summary>
        public Guid? RefCourseGpaapplicabilityId { get; set; }

        /// <summary>
        /// Course Honors Type
        /// <para>
        /// An indication that the course is or can be counted as an honors course.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20273">Course Honors Type</a>
        /// </para>
        /// </summary>
        public Guid? RefCourseHonorsTypeId { get; set; }

        /// <summary>
        /// Course Instruction Method
        /// <para>
        /// The primary method of instruction used for the course.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20274">Course Instruction Method</a>
        /// </para>
        /// </summary>
        public Guid? RefCourseInstructionMethodId { get; set; }

        /// <summary>
        /// Course Level Type
        /// <para>
        /// The level of work which is reflected in the credits associated with the academic course being described or the level of the typical individual taking the academic course.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20278">Course Level Type</a>
        /// </para>
        /// </summary>
        public Guid? RefCourseLevelTypeId { get; set; }

        /// <summary>
        /// Developmental Education Type
        /// <para>
        /// An indicator of the category of developmental education.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20568">Developmental Education Type</a>
        /// </para>
        /// </summary>
        public Guid? RefDevelopmentalEducationTypeId { get; set; }

        /// <summary>
        /// Work-based Learning Opportunity Type
        /// <para>
        /// The type of work-based learning opportunity a student participated in.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20471">Work-based Learning Opportunity Type</a>
        /// </para>
        /// </summary>
        public Guid? RefWorkbasedLearningOpportunityTypeId { get; set; }

    }
}
