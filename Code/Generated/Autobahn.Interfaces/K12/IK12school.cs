//***************************************************************************
//* DomainName: Elementary and Secondary (K12) Interfaces (used by both models and View Models
//* FileName:   IK12school.cs
//***************************************************************************

using Autobahn.Interfaces.Common;

namespace Autobahn.Interfaces.K12
{
     /// <summary>
     /// The IK12school Interface
     /// </summary>
    public partial interface IK12school : IAutobahnBase
    {
        System.String AccreditationAgencyName { get; set; }

        System.String CharterSchoolApprovalYear { get; set; }

        DateTime? CharterSchoolContractApprovalDate { get; set; }

        System.String CharterSchoolContractIdNumber { get; set; }

        DateTime? CharterSchoolContractRenewalDate { get; set; }

        Boolean? CharterSchoolIndicator { get; set; }

        Boolean? CharterSchoolOpenEnrollmentIndicator { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IK12charterSchoolAuthorizerAgency"/> model
        /// </summary>
        Guid? K12charterSchoolAuthorizerAgencyId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IK12charterSchoolManagementOrganization"/> model
        /// </summary>
        Guid? K12charterSchoolManagementOrganizationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganization"/> model
        /// </summary>
        Guid OrganizationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAdministrativeFundingControl"/> model
        /// </summary>
        Guid? RefAdministrativeFundingControlId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCharterSchoolType"/> model
        /// </summary>
        Guid? RefCharterSchoolTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIncreasedLearningTimeType"/> model
        /// </summary>
        Guid? RefIncreasedLearningTimeTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefSchoolLevel"/> model
        /// </summary>
        Guid? RefSchoolLevelId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefSchoolType"/> model
        /// </summary>
        Guid? RefSchoolTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefStatePovertyDesignation"/> model
        /// </summary>
        Guid? RefStatePovertyDesignationId { get; set; }

    }
}
