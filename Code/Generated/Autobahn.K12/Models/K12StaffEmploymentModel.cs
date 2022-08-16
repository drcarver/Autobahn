//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12StaffEmploymentModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The K12StaffEmployment Model
     /// </summary>
    public partial class K12StaffEmploymentModel : AutobahnBase, Interfaces.IK12StaffEmployment
    {
        /// <summary>
        /// 
        /// </summary>
        public Guid? ContractDaysOfServicePerYear { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  MepPersonnelIndicator { get; set; }

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
        public  RefEmploymentStatusId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefK12StaffClassificationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  SalaryForTeachingAssignmentOnlyIndicator { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  TitleITargetedAssistanceStaffFunded { get; set; }

    }
}
