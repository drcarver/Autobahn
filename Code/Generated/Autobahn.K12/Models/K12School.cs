//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   K12School.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The K12School
     /// </summary>
    public partial class K12School : AutobahnBase, Interfaces.IK12School
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Organization"/> model
        /// </summary>
        public Guid OrganizationId { get; set; }

        /// <summary>
        /// Defines the K12School.CharterSchoolIndicator nullable property
        /// </summary>
        public System.Boolean? CharterSchoolIndicator { get; set; }

        /// <summary>
        /// Defines the K12School.CharterSchoolApprovalYear non nullable property
        /// </summary>
        public System.String CharterSchoolApprovalYear { get; set; }

        /// <summary>
        /// Defines the K12School.AccreditationAgencyName non nullable property
        /// </summary>
        public System.String AccreditationAgencyName { get; set; }

        /// <summary>
        /// Defines the K12School.CharterSchoolOpenEnrollmentIndicator nullable property
        /// </summary>
        public System.Boolean? CharterSchoolOpenEnrollmentIndicator { get; set; }

        /// <summary>
        /// Defines the K12School.CharterSchoolContractApprovalDate nullable property
        /// </summary>
        public System.DateTime? CharterSchoolContractApprovalDate { get; set; }

        /// <summary>
        /// Defines the K12School.CharterSchoolContractIdNumber non nullable property
        /// </summary>
        public System.String CharterSchoolContractIdNumber { get; set; }

        /// <summary>
        /// Defines the K12School.CharterSchoolContractRenewalDate nullable property
        /// </summary>
        public System.DateTime? CharterSchoolContractRenewalDate { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="K12CharterSchoolManagementOrganization"/> model
        /// </summary>
        public Guid? K12CharterSchoolManagementOrganizationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="K12CharterSchoolAuthorizerAgency"/> model
        /// </summary>
        public Guid? K12CharterSchoolAuthorizerAgencyId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefSchoolType"/> model
        /// </summary>
        public Guid? RefSchoolTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefSchoolLevel"/> model
        /// </summary>
        public Guid? RefSchoolLevelId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAdministrativeFundingControl"/> model
        /// </summary>
        public Guid? RefAdministrativeFundingControlId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCharterSchoolType"/> model
        /// </summary>
        public Guid? RefCharterSchoolTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIncreasedLearningTimeType"/> model
        /// </summary>
        public Guid? RefIncreasedLearningTimeTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefStatePovertyDesignation"/> model
        /// </summary>
        public Guid? RefStatePovertyDesignationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
