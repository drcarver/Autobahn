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
        /// The type of education institution as classified by its funding source.
        /// </summary>
        public System.String AccreditationAgencyName { get; set; }

        /// <summary>
        /// The type of education institution as classified by its funding source.
        /// </summary>
        public System.String CharterSchoolApprovalYear { get; set; }

        /// <summary>
        /// The type of education institution as classified by its funding source.
        /// </summary>
        public System.DateTime? CharterSchoolContractApprovalDate { get; set; }

        /// <summary>
        /// The type of education institution as classified by its funding source.
        /// </summary>
        public System.String CharterSchoolContractIdNumber { get; set; }

        /// <summary>
        /// The type of education institution as classified by its funding source.
        /// </summary>
        public System.DateTime? CharterSchoolContractRenewalDate { get; set; }

        /// <summary>
        /// The type of education institution as classified by its funding source.
        /// </summary>
        public System.Boolean? CharterSchoolIndicator { get; set; }

        /// <summary>
        /// The type of education institution as classified by its funding source.
        /// </summary>
        public System.Boolean? CharterSchoolOpenEnrollmentIndicator { get; set; }

        /// <summary>
        /// The type of education institution as classified by its funding source.
        /// </summary>
        public Guid? K12CharterSchoolAuthorizerAgencyId { get; set; }

        /// <summary>
        /// The type of education institution as classified by its funding source.
        /// </summary>
        public Guid? K12CharterSchoolManagementOrganizationId { get; set; }

        /// <summary>
        /// The type of education institution as classified by its funding source.
        /// </summary>
        public Guid OrganizationId { get; set; }

        /// <summary>
        /// The type of education institution as classified by its funding source.
        /// </summary>
        public Guid? RefAdministrativeFundingControlId { get; set; }

        /// <summary>
        /// The type of education institution as classified by its funding source.
        /// </summary>
        public Guid? RefCharterSchoolTypeId { get; set; }

        /// <summary>
        /// The type of education institution as classified by its funding source.
        /// </summary>
        public Guid? RefIncreasedLearningTimeTypeId { get; set; }

        /// <summary>
        /// The type of education institution as classified by its funding source.
        /// </summary>
        public Guid? RefSchoolLevelId { get; set; }

        /// <summary>
        /// The type of education institution as classified by its funding source.
        /// </summary>
        public Guid? RefSchoolTypeId { get; set; }

        /// <summary>
        /// The type of education institution as classified by its funding source.
        /// </summary>
        public Guid? RefStatePovertyDesignationId { get; set; }

    }
}
