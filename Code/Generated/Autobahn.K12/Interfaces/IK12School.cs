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
        /// The type of education institution as classified by its funding source.
        /// </summary>
        System.String AccreditationAgencyName { get; set; }

        /// <summary>
        /// The type of education institution as classified by its funding source.
        /// </summary>
        System.String CharterSchoolApprovalYear { get; set; }

        /// <summary>
        /// The type of education institution as classified by its funding source.
        /// </summary>
        System.DateTime? CharterSchoolContractApprovalDate { get; set; }

        /// <summary>
        /// The type of education institution as classified by its funding source.
        /// </summary>
        System.String CharterSchoolContractIdNumber { get; set; }

        /// <summary>
        /// The type of education institution as classified by its funding source.
        /// </summary>
        System.DateTime? CharterSchoolContractRenewalDate { get; set; }

        /// <summary>
        /// The type of education institution as classified by its funding source.
        /// </summary>
        System.Boolean? CharterSchoolIndicator { get; set; }

        /// <summary>
        /// The type of education institution as classified by its funding source.
        /// </summary>
        System.Boolean? CharterSchoolOpenEnrollmentIndicator { get; set; }

        /// <summary>
        /// The type of education institution as classified by its funding source.
        /// </summary>
        Guid? K12CharterSchoolAuthorizerAgencyId { get; set; }

        /// <summary>
        /// The type of education institution as classified by its funding source.
        /// </summary>
        Guid? K12CharterSchoolManagementOrganizationId { get; set; }

        /// <summary>
        /// The type of education institution as classified by its funding source.
        /// </summary>
        Guid OrganizationId { get; set; }

        /// <summary>
        /// The type of education institution as classified by its funding source.
        /// </summary>
        Guid? RefAdministrativeFundingControlId { get; set; }

        /// <summary>
        /// The type of education institution as classified by its funding source.
        /// </summary>
        Guid? RefCharterSchoolTypeId { get; set; }

        /// <summary>
        /// The type of education institution as classified by its funding source.
        /// </summary>
        Guid? RefIncreasedLearningTimeTypeId { get; set; }

        /// <summary>
        /// The type of education institution as classified by its funding source.
        /// </summary>
        Guid? RefSchoolLevelId { get; set; }

        /// <summary>
        /// The type of education institution as classified by its funding source.
        /// </summary>
        Guid? RefSchoolTypeId { get; set; }

        /// <summary>
        /// The type of education institution as classified by its funding source.
        /// </summary>
        Guid? RefStatePovertyDesignationId { get; set; }

    }
}
