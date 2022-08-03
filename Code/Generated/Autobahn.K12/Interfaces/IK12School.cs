//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   IK12School.cs
//**********************************************************

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The IK12School
     /// </summary>
    public partial interface IK12School
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Organization"/> model
        /// </summary>
        Guid OrganizationId { get; set; }

        /// <summary>
        /// Defines the K12School.CharterSchoolIndicator nullable property
        /// </summary>
        System.Boolean? CharterSchoolIndicator { get; set; }

        /// <summary>
        /// Defines the K12School.CharterSchoolApprovalYear non nullable property
        /// </summary>
        System.String CharterSchoolApprovalYear { get; set; }

        /// <summary>
        /// Defines the K12School.AccreditationAgencyName non nullable property
        /// </summary>
        System.String AccreditationAgencyName { get; set; }

        /// <summary>
        /// Defines the K12School.CharterSchoolOpenEnrollmentIndicator nullable property
        /// </summary>
        System.Boolean? CharterSchoolOpenEnrollmentIndicator { get; set; }

        /// <summary>
        /// Defines the K12School.CharterSchoolContractApprovalDate nullable property
        /// </summary>
        System.DateTime? CharterSchoolContractApprovalDate { get; set; }

        /// <summary>
        /// Defines the K12School.CharterSchoolContractIdNumber non nullable property
        /// </summary>
        System.String CharterSchoolContractIdNumber { get; set; }

        /// <summary>
        /// Defines the K12School.CharterSchoolContractRenewalDate nullable property
        /// </summary>
        System.DateTime? CharterSchoolContractRenewalDate { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="K12CharterSchoolManagementOrganization"/> model
        /// </summary>
        Guid? K12CharterSchoolManagementOrganizationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="K12CharterSchoolAuthorizerAgency"/> model
        /// </summary>
        Guid? K12CharterSchoolAuthorizerAgencyId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefSchoolType"/> model
        /// </summary>
        Guid? RefSchoolTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefSchoolLevel"/> model
        /// </summary>
        Guid? RefSchoolLevelId { get; set; }

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
        /// Reference to an optional instance of the <see cref="RefStatePovertyDesignation"/> model
        /// </summary>
        Guid? RefStatePovertyDesignationId { get; set; }

        /// <summary>
        /// Defines the K12School.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the K12School.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatus"/> model
        /// </summary>
        Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        Guid? DataCollectionId { get; set; }

    }
}
