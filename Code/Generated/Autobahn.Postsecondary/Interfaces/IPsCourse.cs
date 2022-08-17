//***************************************************************************
//* DomainName: Postsecondary (PS) Interfaces (used by both models and View Models
//* FileName:   IPsCourse.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Postsecondary.Interfaces
{
     /// <summary>
     /// The IPsCourse Interface
     /// </summary>
    public partial interface IPsCourse : IAutobahnBase
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
        Guid CourseId { get; set; }

        /// <summary>
        /// Course Number
        /// <para>
        /// The official reference number portion of a course identifier.  This number normally designates the level of the course as well as the level of the individual expected to enroll in the course.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20280">Course Number</a>
        /// </para>
        /// </summary>
        System.String CourseNumber { get; set; }

        /// <summary>
        /// National Collegiate Athletic Association Eligibility
        /// <para>
        /// An indication that the course is approved for determining NCAA eligibility.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20382">National Collegiate Athletic Association Eligibility</a>
        /// </para>
        /// </summary>
        System.Int32? NCAAEligibilityInd { get; set; }

        /// <summary>
        /// Original Course Identifier
        /// <para>
        /// The course identifier as it was listed when the credit was earned (e.g. before a system conversion) to show consistency between present transcripts and older ones.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20389">Original Course Identifier</a>
        /// </para>
        /// </summary>
        System.String OriginalCourseIdentifier { get; set; }

        /// <summary>
        /// Override School Course Number
        /// <para>
        /// An indication of the way an academic course was identified at an educational institution.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20391">Override School Course Number</a>
        /// </para>
        /// </summary>
        System.String OverrideSchoolCourseNumber { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefCipCode"/> model
        /// </summary>
        Guid? RefCipCodeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefCourseCreditBasisType"/> model
        /// </summary>
        Guid? RefCourseCreditBasisTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefCourseCreditLevelType"/> model
        /// </summary>
        Guid? RefCourseCreditLevelTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefNCESCollegeCourseMapCode"/> model
        /// </summary>
        Guid? RefNCESCollegeCourseMapCodeId { get; set; }

    }
}
