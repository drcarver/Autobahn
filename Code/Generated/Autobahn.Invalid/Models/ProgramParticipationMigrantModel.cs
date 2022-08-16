//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   ProgramParticipationMigrantModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Invalid.Models
{
     /// <summary>
     /// The ProgramParticipationMigrant Model
     /// </summary>
    public partial class ProgramParticipationMigrantModel : AutobahnBase, Interfaces.IProgramParticipationMigrant
    {
        /// <summary>
        /// 
        /// </summary>
        public  BirthdateVerification { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  ContinuationOfServicesStatus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  DesignatedGraduationSchoolId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  ImmunizationRecordFlag { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? LastQualifyingMoveDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  MepEligibilityExpirationDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  MigrantStudentQualifyingArrivalDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  PrioritizedForServices { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  QualifyingMoveFromCity { get; set; }

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
        public  RefContinuationOfServicesReasonId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefMepEnrollmentTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefMepProjectBasedId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefMepServiceTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefQualifyingMoveFromCountryId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefQualifyingMoveFromStateId { get; set; }

    }
}
