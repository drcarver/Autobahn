//**********************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   PsStudentApplicationModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Postsecondary.Models
{
     /// <summary>
     /// The PsStudentApplication Model
     /// </summary>
    public partial class PsStudentApplicationModel : AutobahnBase, Interfaces.IPsStudentApplication
    {
        /// <summary>
        /// Grade Point Average Cumulative
        /// <para>
        /// A measure of average performance in all courses taken by a person during his or her school career as determined for record-keeping purposes. This is obtained by dividing the total grade points received by the total number of credits attempted. This usually includes grade points received and credits attempted in his or her current school as well as those transferred from schools in which the person was previously enrolled.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19128">Grade Point Average Cumulative</a>
        /// </para>
        /// </summary>
        public System.Decimal? GradePointAverageCumulative { get; set; }

        /// <summary>
        /// Size of High School Graduating Class
        /// <para>
        /// The total number of students in the student's high school graduating class.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19294">Size of High School Graduating Class</a>
        /// </para>
        /// </summary>
        public System.Int32? HighSchoolGraduatingClassSize { get; set; }

        /// <summary>
        /// High School Percentile
        /// <para>
        /// The High School Rank divided by the Size of High School Graduating Class expressed as a percentage.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19740">High School Percentile</a>
        /// </para>
        /// </summary>
        public System.Decimal? HighSchoolPercentile { get; set; }

        /// <summary>
        /// High School Student Class Rank
        /// <para>
        /// The academic rank of a student in relation to his or her high school graduating class (e.g., 1, 2, 3) based on high school GPA.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19041">High School Student Class Rank</a>
        /// </para>
        /// </summary>
        public System.Int32? HighSchoolStudentClassRank { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Postsecondary Applicant
        /// <para>
        /// An individual who has fulfilled the institution's requirements to be considered for admission (including payment or waiving of the application fee, if any) and who has been notified of one of the following actions: admission, nonadmission, placement on waiting list, or application withdrawn (by applicant or institution). Include early decision, early action, and students who began studies during summer in this cohort.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19735">Postsecondary Applicant</a>
        /// </para>
        /// </summary>
        public System.Boolean? PostsecondaryApplicant { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAdmittedStudent"/> model
        /// </summary>
        public Guid? RefAdmittedStudentId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefGpaWeightedIndicator"/> model
        /// </summary>
        public Guid? RefGpaWeightedIndicatorId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefGradePointAverageDomain"/> model
        /// </summary>
        public Guid? RefGradePointAverageDomainId { get; set; }

        /// <summary>
        /// Wait Listed Student
        /// <para>
        /// A person who meets the admission requirements but will only be offered a place in the class if space becomes available.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19738">Wait Listed Student</a>
        /// </para>
        /// </summary>
        public System.Boolean? WaitListedStudent { get; set; }

    }
}
