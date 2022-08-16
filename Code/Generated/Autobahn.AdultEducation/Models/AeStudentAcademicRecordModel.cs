//**********************************************************
//* DomainName: Adult Education (AE)
//* FileName:   AeStudentAcademicRecordModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.AdultEducation.Models
{
     /// <summary>
     /// The AeStudentAcademicRecord Model
     /// </summary>
    public partial class AeStudentAcademicRecordModel : AutobahnBase, Interfaces.IAeStudentAcademicRecord
    {
        /// <summary>
        /// 
        /// </summary>
        public Guid? DiplomaOrCredentialAwardDate { get; set; }

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
        public  RefHighSchoolDiplomaTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefProfessionalTechnicalCredentialTypeId { get; set; }

    }
}
