//***************************************************************************
//* DomainName: Elementary and Secondary (K12) Interfaces (used by both models and View Models
//* FileName:   IK12School.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The IK12School Interface
     /// </summary>
    public partial interface IK12School : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
         AccreditationAgencyName { get; set; }

        /// <summary>
        /// 
        /// </summary>
         CharterSchoolApprovalYear { get; set; }

        /// <summary>
        /// 
        /// </summary>
         CharterSchoolContractApprovalDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
         CharterSchoolContractIdNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
         CharterSchoolContractRenewalDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
         CharterSchoolIndicator { get; set; }

        /// <summary>
        /// 
        /// </summary>
         CharterSchoolOpenEnrollmentIndicator { get; set; }

        /// <summary>
        /// 
        /// </summary>
         K12CharterSchoolApprovalAgencyId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         K12CharterSchoolManagementOrganizationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordStartDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        Guid? RefAdministrativeFundingControlId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefCharterSchoolTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefIncreasedLearningTimeTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefSchoolLevelId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefSchoolTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefStatePovertyDesignationId { get; set; }

    }
}
