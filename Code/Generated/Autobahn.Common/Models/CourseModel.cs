//**********************************************************
//* DomainName: Common Models
//* FileName:   CourseModel.cs
//* Name:       Course Certification Description
//* Definition: A description of the certification or recognition associated with this course (ex. Networking, CAD, etc.)
//***************************************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// A description of the certification or recognition associated with this course (ex. Networking, CAD, etc.)
     /// </summary>
    public partial class CourseModel : AutobahnBase, Interfaces.ICourse
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
        public System.String CertificationDescription { get; set; }

        /// <summary>
        /// Credit Value
        /// <para>
        /// The amount of credit available to the student who successfully meets the objectives of the course or learning opportunity based on the units defined by Credit Unit Type.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19058">Credit Value</a>
        /// </para>
        /// </summary>
        public System.Decimal? CreditValue { get; set; }

        /// <summary>
        /// Instructional Minutes
        /// <para>
        /// The total number of instruction minutes in a given session, as determined by time in class, time on task (e.g., engaged in a class), or as estimated by a qualified course designer.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19490">Instructional Minutes</a>
        /// </para>
        /// </summary>
        public System.Int32? InstructionalMinutes { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganization"/> model
        /// </summary>
        public Guid OrganizationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCourseApplicableEducationLevel"/> model
        /// </summary>
        public Guid? RefCourseApplicableEducationLevelId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCourseCreditUnit"/> model
        /// </summary>
        public Guid? RefCourseCreditUnitId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCourseLevelCharacteristics"/> model
        /// </summary>
        public Guid? RefCourseLevelCharacteristicsId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefInstructionLanguage"/> model
        /// </summary>
        public Guid? RefInstructionLanguageId { get; set; }

        /// <summary>
        /// Course Repeatability Maximum Number
        /// <para>
        /// The maximum number of times the course may be taken or completed for credit.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20648">Course Repeatability Maximum Number</a>
        /// </para>
        /// </summary>
        public System.Int32? RepeatabilityMaximumNumber { get; set; }

        /// <summary>
        /// School Courses for the Exchange of Data Sequence of Course
        /// <para>
        /// Where a specific course lies when it is part of a consecutive sequence of courses. This element should be interpreted as "part 'n' of 'm' parts.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19250">School Courses for the Exchange of Data Sequence of Course</a>
        /// </para>
        /// </summary>
        public System.String SCEDSequenceOfCourse { get; set; }

        /// <summary>
        /// Course Subject Abbreviation
        /// <para>
        /// The alphabetic abbreviation of the academic department or discipline offering the course. It is one part of the total course identifier number. 
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19066">Course Subject Abbreviation</a>
        /// </para>
        /// </summary>
        public System.String SubjectAbbreviation { get; set; }

    }
}
