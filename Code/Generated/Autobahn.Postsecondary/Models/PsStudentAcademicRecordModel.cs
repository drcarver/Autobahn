//**********************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   PsStudentAcademicRecordModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Postsecondary.Models
{
     /// <summary>
     /// The PsStudentAcademicRecord Model
     /// </summary>
    public partial class PsStudentAcademicRecordModel : AutobahnBase, Interfaces.IPsStudentAcademicRecord
    {
        /// <summary>
        /// The number of credits awarded a student by the postsecondary institution based on successful completion of advanced placement courses and/or advanced placement tests. 
        /// </summary>
        public System.String AcademicYearDesignator { get; set; }

        /// <summary>
        /// The number of credits awarded a student by the postsecondary institution based on successful completion of advanced placement courses and/or advanced placement tests. 
        /// </summary>
        public System.Int32? AdvancedPlacementCreditsAwarded { get; set; }

        /// <summary>
        /// The number of credits awarded a student by the postsecondary institution based on successful completion of advanced placement courses and/or advanced placement tests. 
        /// </summary>
        public System.Int32? CourseTotal { get; set; }

        /// <summary>
        /// The number of credits awarded a student by the postsecondary institution based on successful completion of advanced placement courses and/or advanced placement tests. 
        /// </summary>
        public System.Decimal? CreditsAttemptedCumulative { get; set; }

        /// <summary>
        /// The number of credits awarded a student by the postsecondary institution based on successful completion of advanced placement courses and/or advanced placement tests. 
        /// </summary>
        public System.Decimal? CreditsEarnedCumulative { get; set; }

        /// <summary>
        /// The number of credits awarded a student by the postsecondary institution based on successful completion of advanced placement courses and/or advanced placement tests. 
        /// </summary>
        public System.String DiplomaOrCredentialAwardDate { get; set; }

        /// <summary>
        /// The number of credits awarded a student by the postsecondary institution based on successful completion of advanced placement courses and/or advanced placement tests. 
        /// </summary>
        public System.Decimal? DualCreditDualEnrollmentCredits { get; set; }

        /// <summary>
        /// The number of credits awarded a student by the postsecondary institution based on successful completion of advanced placement courses and/or advanced placement tests. 
        /// </summary>
        public System.String EnteringTerm { get; set; }

        /// <summary>
        /// The number of credits awarded a student by the postsecondary institution based on successful completion of advanced placement courses and/or advanced placement tests. 
        /// </summary>
        public System.Decimal? GradePointAverage { get; set; }

        /// <summary>
        /// The number of credits awarded a student by the postsecondary institution based on successful completion of advanced placement courses and/or advanced placement tests. 
        /// </summary>
        public System.Decimal? GradePointAverageCumulative { get; set; }

        /// <summary>
        /// The number of credits awarded a student by the postsecondary institution based on successful completion of advanced placement courses and/or advanced placement tests. 
        /// </summary>
        public System.Decimal? NumberOfCreditsAttempted { get; set; }

        /// <summary>
        /// The number of credits awarded a student by the postsecondary institution based on successful completion of advanced placement courses and/or advanced placement tests. 
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// The number of credits awarded a student by the postsecondary institution based on successful completion of advanced placement courses and/or advanced placement tests. 
        /// </summary>
        public Guid? RefAcademicTermDesignatorId { get; set; }

        /// <summary>
        /// The number of credits awarded a student by the postsecondary institution based on successful completion of advanced placement courses and/or advanced placement tests. 
        /// </summary>
        public Guid? RefCreditHoursAppliedOtherProgramId { get; set; }

        /// <summary>
        /// The number of credits awarded a student by the postsecondary institution based on successful completion of advanced placement courses and/or advanced placement tests. 
        /// </summary>
        public Guid? RefProfessionalTechCredentialTypeId { get; set; }

    }
}
