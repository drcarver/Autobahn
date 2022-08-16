//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12SchoolModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The K12School Model
     /// </summary>
    public partial class K12SchoolModel : AutobahnBase, Interfaces.IK12School
    {
        /// <summary>
        /// 
        /// </summary>
        public  AccreditationAgencyName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  CharterSchoolApprovalYear { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  CharterSchoolContractApprovalDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  CharterSchoolContractIdNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  CharterSchoolContractRenewalDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  CharterSchoolIndicator { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  CharterSchoolOpenEnrollmentIndicator { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  K12CharterSchoolApprovalAgencyId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  K12CharterSchoolManagementOrganizationId { get; set; }

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
        public Guid? RefAdministrativeFundingControlId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefCharterSchoolTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefIncreasedLearningTimeTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefSchoolLevelId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefSchoolTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefStatePovertyDesignationId { get; set; }

    }
}
