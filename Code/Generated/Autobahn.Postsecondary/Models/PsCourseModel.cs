//**********************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   PsCourseModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Postsecondary.Models
{
     /// <summary>
     /// The PsCourse Model
     /// </summary>
    public partial class PsCourseModel : AutobahnBase, Interfaces.IPsCourse
    {
        /// <summary>
        /// Course Certification Description
        /// <para>
        /// A description of the certification or recognition associated with this course (ex. Networking, CAD, etc.)
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20268">Course Certification Description</a>
        /// </para>
        /// </summary>
        public Guid CourseId { get; set; }

        /// <summary>
        /// Course Number
        /// <para>
        /// The official reference number portion of a course identifier.  This number normally designates the level of the course as well as the level of the individual expected to enroll in the course.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20280">Course Number</a>
        /// </para>
        /// </summary>
        public System.String CourseNumber { get; set; }

        /// <summary>
        /// National Collegiate Athletic Association Eligibility
        /// <para>
        /// An indication that the course is approved for determining NCAA eligibility.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20382">National Collegiate Athletic Association Eligibility</a>
        /// </para>
        /// </summary>
        public System.Int32? NCAAEligibilityInd { get; set; }

        /// <summary>
        /// Original Course Identifier
        /// <para>
        /// The course identifier as it was listed when the credit was earned (e.g. before a system conversion) to show consistency between present transcripts and older ones.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20389">Original Course Identifier</a>
        /// </para>
        /// </summary>
        public System.String OriginalCourseIdentifier { get; set; }

        /// <summary>
        /// Override School Course Number
        /// <para>
        /// An indication of the way an academic course was identified at an educational institution.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20391">Override School Course Number</a>
        /// </para>
        /// </summary>
        public System.String OverrideSchoolCourseNumber { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCipCode"/> model
        /// </summary>
        public Guid? RefCipCodeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCourseCreditBasisType"/> model
        /// </summary>
        public Guid? RefCourseCreditBasisTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCourseCreditLevelType"/> model
        /// </summary>
        public Guid? RefCourseCreditLevelTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefNCESCollegeCourseMapCode"/> model
        /// </summary>
        public Guid? RefNCESCollegeCourseMapCodeId { get; set; }

    }
}
