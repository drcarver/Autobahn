//**********************************************************
//* DomainName: Adult Education (AE)
//* FileName:   AeStaffModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.AdultEducation.Models
{
     /// <summary>
     /// The AeStaff Model
     /// </summary>
    public partial class AeStaffModel : AutobahnBase, Interfaces.IAeStaff
    {
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
        public Guid? RefAeStaffClassificationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefAeStaffEmploymentStatusId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  YearsOfPriorAeTeachingExperience { get; set; }

    }
}
