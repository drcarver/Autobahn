//***************************************************************************
//* DomainName: Elementary and Secondary (K12) Interfaces (used by both models and View Models
//* FileName:   IK12StudentAcademicRecord.cs
//* Name:       Class Ranking Date
//* Definition: 
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// 
     /// </summary>
    public partial interface IK12StudentAcademicRecord : IAutobahnBase
    {
        /// <summary>
        /// Class Ranking Date
        /// <para>
        /// The date class ranking was determined.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19042">Class Ranking Date</a>
        /// </para>
        /// </summary>
        System.DateTime? ClassRankingDate { get; set; }

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
        System.DateTime? DiplomaOrCredentialAwardDate { get; set; }

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
        /// Grade Points Earned Cumulative
        /// <para>
        /// The cumulative number of grade points a person earns by successfully completing courses or examinations during his or her enrollment in the current school as well as those transferred from schools in which the person had been previously enrolled.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19130">Grade Points Earned Cumulative</a>
        /// </para>
        /// </summary>
        System.Decimal? GradePointsEarnedCumulative { get; set; }

        /// <summary>
        /// High School Student Class Rank
        /// <para>
        /// The academic rank of a student in relation to his or her high school graduating class (e.g., 1, 2, 3) based on high school GPA.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19041">High School Student Class Rank</a>
        /// </para>
        /// </summary>
        System.Int32? HighSchoolStudentClassRank { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
        /// </summary>
        Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Projected Graduation Date
        /// <para>
        /// The year and month the student is projected to graduate.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19226">Projected Graduation Date</a>
        /// </para>
        /// </summary>
        System.DateTime? ProjectedGraduationDate { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefGpaWeightedIndicator"/> model
        /// </summary>
        Guid? RefGpaWeightedIndicatorId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefHighSchoolDiplomaDistinctionType"/> model
        /// </summary>
        Guid? RefHighSchoolDiplomaDistinctionTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefHighSchoolDiplomaType"/> model
        /// </summary>
        Guid? RefHighSchoolDiplomaTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPreAndPostTestIndicator"/> model
        /// </summary>
        Guid? RefPreAndPostTestIndicatorId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefProfessionalTechnicalCredentialType"/> model
        /// </summary>
        Guid? RefProfessionalTechnicalCredentialTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefProgressLevel"/> model
        /// </summary>
        Guid? RefProgressLevelId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPsEnrollmentAction"/> model
        /// </summary>
        Guid? RefPsEnrollmentActionId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTechnologyLiteracyStatus"/> model
        /// </summary>
        Guid? RefTechnologyLiteracyStatusId { get; set; }

        /// <summary>
        /// Size of High School Graduating Class
        /// <para>
        /// The total number of students in the student's high school graduating class.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19294">Size of High School Graduating Class</a>
        /// </para>
        /// </summary>
        System.Int32? TotalNumberInClass { get; set; }

    }
}
