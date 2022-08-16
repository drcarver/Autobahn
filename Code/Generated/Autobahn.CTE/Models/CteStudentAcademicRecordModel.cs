//**********************************************************
//* DomainName: Career and Technical Education (CTE)
//* FileName:   CteStudentAcademicRecordModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.CTE.Models
{
     /// <summary>
     /// The CteStudentAcademicRecord Model
     /// </summary>
    public partial class CteStudentAcademicRecordModel : AutobahnBase, Interfaces.ICteStudentAcademicRecord
    {
        /// <summary>
        /// 
        /// </summary>
        public Guid? CreditsAttemptedCumulative { get; set; }

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
        public  RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordStartDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefProfessionalTechnicalCredentialTypeId { get; set; }

    }
}
