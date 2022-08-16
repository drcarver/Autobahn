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
        /// 
        /// </summary>
        public  AcademicYearDesignator { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? AdvancedPlacementCreditsAwarded { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  CourseTotal { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  CreditsAttemptedCumulative { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  CreditsEarnedCumulative { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  DiplomaOrCredentialAwardDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  DualCreditDualEnrollmentCredits { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  EnteringTerm { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  GradePointAverage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  GradePointAverageCumulative { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  NumberOfCreditsAttempted { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordStartDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefAcademicTermDesignatorId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefCreditHoursAppliedOtherProgramId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefProfessionalTechCredentialTypeId { get; set; }

    }
}
