//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12SchoolModel.cs
//* Name:       Accreditation Agency Name
//* Definition: The full name of an agency that accredited a school.
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The full name of an agency that accredited a school.
     /// </summary>
    public partial class K12SchoolModel : AutobahnBase, Interfaces.IK12School
    {
        /// <summary>
        /// Accreditation Agency Name
        /// <para>
        /// The full name of an agency that accredited a school.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20500">Accreditation Agency Name</a>
        /// </para>
        /// </summary>
        public System.String AccreditationAgencyName { get; set; }

        /// <summary>
        /// Charter School Approval Year
        /// <para>
        /// The school year in which a charter school was initially approved.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20259">Charter School Approval Year</a>
        /// </para>
        /// </summary>
        public System.String CharterSchoolApprovalYear { get; set; }

        /// <summary>
        /// Charter School Contract Approval Date
        /// <para>
        /// The effective date of the contract (or charter) that an approved charter school authorizer authorized the charter school to operate in the state under the state's charter school legislation.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20633">Charter School Contract Approval Date</a>
        /// </para>
        /// </summary>
        public System.DateTime? CharterSchoolContractApprovalDate { get; set; }

        /// <summary>
        /// Charter School Contract Id Number
        /// <para>
        /// The unique number the SEA assigns to the contract (or charter) that authorizes the charter school to operate in the state under the state's charter school legislation.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20632">Charter School Contract Id Number</a>
        /// </para>
        /// </summary>
        public System.String CharterSchoolContractIdNumber { get; set; }

        /// <summary>
        /// Charter School Contract Renewal Date
        /// <para>
        /// The date by which the charter school must renew its contract (or charter) with an approved charter school authorizer in order to continue to operate in the state under the state's charter school legislation.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20634">Charter School Contract Renewal Date</a>
        /// </para>
        /// </summary>
        public System.DateTime? CharterSchoolContractRenewalDate { get; set; }

        /// <summary>
        /// Charter School Indicator
        /// <para>
        /// An indication that a public school provides free public elementary and/or secondary education to eligible students under a specific charter executed, pursuant to a state charter school law, by an authorized chartering agency/authority and that is designated by such authority to be a public charter school.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19039">Charter School Indicator</a>
        /// </para>
        /// </summary>
        public System.Boolean? CharterSchoolIndicator { get; set; }

        /// <summary>
        /// Charter School Open Enrollment Indicator
        /// <para>
        /// Indicates that the charter school offers open enrollment.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20524">Charter School Open Enrollment Indicator</a>
        /// </para>
        /// </summary>
        public System.Boolean? CharterSchoolOpenEnrollmentIndicator { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IK12CharterSchoolAuthorizerAgency"/> model
        /// </summary>
        public Guid? K12CharterSchoolAuthorizerAgencyId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IK12CharterSchoolManagementOrganization"/> model
        /// </summary>
        public Guid? K12CharterSchoolManagementOrganizationId { get; set; }

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
