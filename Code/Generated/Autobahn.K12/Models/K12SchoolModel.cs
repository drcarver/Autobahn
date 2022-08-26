//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12schoolModel.cs
//***************************************************************************

using Autobahn.Interfaces.K12;
using Autobahn.Interfaces.Common;
using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The K12school Model
     /// </summary>
    public partial class K12schoolModel : AutobahnBase, IK12school
    {
        public System.String AccreditationAgencyName { get; set; }

        public System.String CharterSchoolApprovalYear { get; set; }

        public DateTime? CharterSchoolContractApprovalDate { get; set; }

        public System.String CharterSchoolContractIdNumber { get; set; }

        public DateTime? CharterSchoolContractRenewalDate { get; set; }

        public Boolean? CharterSchoolIndicator { get; set; }

        public Boolean? CharterSchoolOpenEnrollmentIndicator { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IK12charterSchoolAuthorizerAgency"/> model
        /// </summary>
        public Guid? K12charterSchoolAuthorizerAgencyId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IK12charterSchoolManagementOrganization"/> model
        /// </summary>
        public Guid? K12charterSchoolManagementOrganizationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganization"/> model
        /// </summary>
        public Guid OrganizationId { get; set; }

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
        /// Reference to an optional instance of the <see cref="RefSchoolLevel"/> model
        /// </summary>
        public Guid? RefSchoolLevelId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefSchoolType"/> model
        /// </summary>
        public Guid? RefSchoolTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefStatePovertyDesignation"/> model
        /// </summary>
        public Guid? RefStatePovertyDesignationId { get; set; }

    }
}
