//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   IK12School.cs
//**********************************************************

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The IK12School
     /// </summary>
    public partial Interface IK12School
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="K12School"/> model
        /// </summary>
        Guid K12SchoolId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="Organization"/> model
        /// </summary>
        Guid OrganizationId { get; set; }

        /// <summary>
        /// An indication that a public school provides free public elementary and/or secondary education to eligible students under a specific charter executed, pursuant to a state charter school law, by an authorized chartering agency/authority and that is designated by such authority to be a public charter school.
        /// </summary>
    System.Boolean? CharterSchoolIndicator { get; set; }

        /// <summary>
        /// The school year in which a charter school was initially approved.
        /// </summary>
    System.String CharterSchoolApprovalYear { get; set; }

        /// <summary>
        /// The full name of an agency that accredited a school.
        /// </summary>
    System.String AccreditationAgencyName { get; set; }

        /// <summary>
        /// Indicates that the charter school offers open enrollment.
        /// </summary>
    System.Boolean? CharterSchoolOpenEnrollmentIndicator { get; set; }

        /// <summary>
        /// The effective date of the contract (or charter) that an approved charter school authorizer authorized the charter school to operate in the state under the state's charter school legislation.
        /// </summary>
    System.DateTime? CharterSchoolContractApprovalDate { get; set; }

        /// <summary>
        /// The unique number the SEA assigns to the contract (or charter) that authorizes the charter school to operate in the state under the state's charter school legislation.
        /// </summary>
    System.String CharterSchoolContractIdNumber { get; set; }

        /// <summary>
        /// The date by which the charter school must renew its contract (or charter) with an approved charter school authorizer in order to continue to operate in the state under the state's charter school legislation.
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
