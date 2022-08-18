//***************************************************************************
//* DomainName: Postsecondary (PS) Interfaces (used by both models and View Models
//* FileName:   IPsStudentAcademicRecord.cs
//* Name:       Academic Year Designator
//* Definition: 
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Postsecondary.Interfaces
{
     /// <summary>
     /// 
     /// </summary>
    public partial interface IPsStudentAcademicRecord : IAutobahnBase
    {
        /// <summary>
        /// Academic Year Designator
        /// <para>
        /// The academic year for which the data apply.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19702">Academic Year Designator</a>
        /// </para>
        /// </summary>
        System.String AcademicYearDesignator { get; set; }

        /// <summary>
        /// Advanced Placement Credits Awarded
        /// <para>
        /// The number of credits awarded a student by the postsecondary institution based on successful completion of advanced placement courses and/or advanced placement tests. 
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19018">Advanced Placement Credits Awarded</a>
        /// </para>
        /// </summary>
        System.Int32? AdvancedPlacementCreditsAwarded { get; set; }

        /// <summary>
        /// Course Total
        /// <para>
        /// The total number of courses listed on a transcript. Used as a check digit for integrity purposes.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20282">Course Total</a>
        /// </para>
        /// </summary>
        System.Int32? CourseTotal { get; set; }

        /// <summary>
        /// Credits Attempted Cumulative
        /// <para>
        /// The cumulative number of credits a person attempts to earn by taking courses during their enrollment in their current education institution as well as those credits transferred from an education institution in which the person had been previously enrolled.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19073">Credits Attempted Cumulative</a>
        /// </para>
        /// </summary>
        System.Decimal? CreditsAttemptedCumulative { get; set; }

        /// <summary>
        /// Credits Earned Cumulative
        /// <para>
        /// The cumulative number of credits a person earns by completing courses or examinations during their enrollment in the current education institution as well as those credits transferred from an education institution in which the person had been previously enrolled.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19074">Credits Earned Cumulative</a>
        /// </para>
        /// </summary>
        System.Decimal? CreditsEarnedCumulative { get; set; }

        /// <summary>
        /// Diploma or Credential Award Date
        /// <para>
        /// The month and year on which the diploma/credential is awarded to a student in recognition of his/her completion of the curricular requirements.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19081">Diploma or Credential Award Date</a>
        /// </para>
        /// </summary>
        System.String DiplomaOrCredentialAwardDate { get; set; }

        /// <summary>
        /// Dual Credit Dual Enrollment Credits Awarded
        /// <para>
        /// The number of credits awarded a student by the postsecondary institution based on successful completion of dual credit/dual enrollment courses. 
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19085">Dual Credit Dual Enrollment Credits Awarded</a>
        /// </para>
        /// </summary>
        System.Decimal? DualCreditDualEnrollmentCredits { get; set; }

        /// <summary>
        /// Postsecondary Student Entering Term
        /// <para>
        /// The term and year of the initial enrollment of an individual in credit bearing courses or developmental/remedial courses at an institution after completing high school or a high school equivalency program (e.g., GED, Adult High School Diploma).
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20396">Postsecondary Student Entering Term</a>
        /// </para>
        /// </summary>
        System.String EnteringTerm { get; set; }

        /// <summary>
        /// Grade Point Average
        /// <para>
        /// The value of the total quality points divided by the Credit Hours for Grade Point Average. 
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19127">Grade Point Average</a>
        /// </para>
        /// </summary>
        System.Decimal? GradePointAverage { get; set; }

        /// <summary>
        /// Grade Point Average Cumulative
        /// <para>
        /// A measure of average performance in all courses taken by a person during his or her school career as determined for record-keeping purposes. This is obtained by dividing the total grade points received by the total number of credits attempted. This usually includes grade points received and credits attempted in his or her current school as well as those transferred from schools in which the person was previously enrolled.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19128">Grade Point Average Cumulative</a>
        /// </para>
        /// </summary>
        System.Decimal? GradePointAverageCumulative { get; set; }

        /// <summary>
        /// Number of Credits Attempted
        /// <para>
        /// The number of credits that a student can earn for enrolling in and completing a given course.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19199">Number of Credits Attempted</a>
        /// </para>
        /// </summary>
        System.Decimal? NumberOfCreditsAttempted { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
        /// </summary>
        Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAcademicTermDesignator"/> model
        /// </summary>
        Guid? RefAcademicTermDesignatorId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCreditHoursAppliedOtherProgram"/> model
        /// </summary>
        Guid? RefCreditHoursAppliedOtherProgramId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefProfessionalTechCredentialType"/> model
        /// </summary>
        Guid? RefProfessionalTechCredentialTypeId { get; set; }

    }
}
