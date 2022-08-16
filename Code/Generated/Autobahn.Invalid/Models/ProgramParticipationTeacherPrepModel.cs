//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   ProgramParticipationTeacherPrepModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Invalid.Models
{
     /// <summary>
     /// The ProgramParticipationTeacherPrep Model
     /// </summary>
    public partial class ProgramParticipationTeacherPrepModel : AutobahnBase, Interfaces.IProgramParticipationTeacherPrep
    {
        /// <summary>
        /// 
        /// </summary>
        public  ClinicalExperienceClockHours { get; set; }

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
        public  RefAltRouteToCertificationOrLicensureId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefCriticalTeacherShortageCandidateId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefSupervisedClinicalExperienceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefTeacherPrepCompleterStatusId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefTeacherPrepEnrollmentStatusId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? RefTeachingCredentialBasisId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefTeachingCredentialTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  SchoolAgeEducationPSCredits { get; set; }

    }
}
