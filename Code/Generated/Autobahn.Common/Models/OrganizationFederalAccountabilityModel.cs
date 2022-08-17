//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationFederalAccountabilityModel.cs
//* Name:       Accountability Report Title
//* Definition: The title of the accountability report.
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The title of the accountability report.
     /// </summary>
    public partial class OrganizationFederalAccountabilityModel : AutobahnBase, Interfaces.IOrganizationFederalAccountability
    {
        /// <summary>
        /// Accountability Report Title
        /// <para>
        /// The title of the accountability report.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19005">Accountability Report Title</a>
        /// </para>
        /// </summary>
        public System.String AccountabilityReportTitle { get; set; }

        /// <summary>
        /// Alternate Adequate Yearly Progress Approach Indicator
        /// <para>
        /// An indication of whether the district or school used an approved alternate approach for calculating Adequate Yearly Progress (AYP).
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19014">Alternate Adequate Yearly Progress Approach Indicator</a>
        /// </para>
        /// </summary>
        public System.Boolean? AlternateAypApproachIndicator { get; set; }

        /// <summary>
        /// Annual Measurable Achievement Objective AYP Progress Attainment Status for LEP Students
        /// <para>
        /// An indication of whether the state or district met the annual measurable objectives for the Limited English Proficient (LEP) student subgroup in mathematics and reading/language arts.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19572">Annual Measurable Achievement Objective AYP Progress Attainment Status for LEP Students</a>
        /// </para>
        /// </summary>
        public System.Int32? AmaoAypProgressAttainmentLepStudents { get; set; }

        /// <summary>
        /// Annual Measurable Achievement Objective Proficiency Attainment Status for LEP Students
        /// <para>
        /// An indication whether the state, district or school met the Annual Measurable Achievement Objectives (AMAO) for attaining English proficiency for limited English proficient (LEP) students under Title III of ESEA.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19535">Annual Measurable Achievement Objective Proficiency Attainment Status for LEP Students</a>
        /// </para>
        /// </summary>
        public System.Int32? AmaoProficiencyAttainmentLepStudents { get; set; }

        /// <summary>
        /// Annual Measurable Achievement Objective Progress Attainment Status for LEP Students
        /// <para>
        /// An indication whether the state, district, or school met the Annual Measurable Achievement Objective (AMAO) for making progress in learning English for limited English proficient (LEP) students under Title III of ESEA as amended.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19545">Annual Measurable Achievement Objective Progress Attainment Status for LEP Students</a>
        /// </para>
        /// </summary>
        public System.Int32? AmaoProgressAttainmentLepStudents { get; set; }

        /// <summary>
        /// Adequate Yearly Progress Appeal Changed Designation
        /// <para>
        /// An indication that the appeal resulted in a change in a school or district's AYP designation.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19433">Adequate Yearly Progress Appeal Changed Designation</a>
        /// </para>
        /// </summary>
        public System.Boolean? AypAppealChangedDesignation { get; set; }

        /// <summary>
        /// Adequate Yearly Progress Appeal Process Date
        /// <para>
        /// The last date that an appeal of an AYP designation was processed.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19434">Adequate Yearly Progress Appeal Process Date</a>
        /// </para>
        /// </summary>
        public System.DateTime? AypAppealProcessDate { get; set; }

        /// <summary>
        /// Appealed Adequate Yearly Progress Designation
        /// <para>
        /// An indication that a school or district appealed its AYP designation.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19432">Appealed Adequate Yearly Progress Designation</a>
        /// </para>
        /// </summary>
        public System.Boolean? AypAppealProcessDesignation { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganization"/> model
        /// </summary>
        public Guid OrganizationId { get; set; }

        /// <summary>
        /// Persistently Dangerous Status
        /// <para>
        /// An indication of whether the school is identified as persistently dangerous in accordance with state definition.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19210">Persistently Dangerous Status</a>
        /// </para>
        /// </summary>
        public System.Boolean? PersistentlyDangerousStatus { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefAdditionalTargetedSupportAndImprovementStatus"/> model
        /// </summary>
        public Guid? RefAdditionalTargetedSupportAndImprovementStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefAypStatus"/> model
        /// </summary>
        public Guid? RefAypStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefComprehensiveSupportAndImprovementStatus"/> model
        /// </summary>
        public Guid? RefComprehensiveSupportAndImprovementStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefCteGraduationRateInclusion"/> model
        /// </summary>
        public Guid? RefCteGraduationRateInclusionId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefElementaryMiddleAdditional"/> model
        /// </summary>
        public Guid? RefElementaryMiddleAdditionalId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefGunFreeSchoolsActReportingStatus"/> model
        /// </summary>
        public Guid? RefGunFreeSchoolsActReportingStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefHighSchoolGraduationRateIndicator"/> model
        /// </summary>
        public Guid? RefHighSchoolGraduationRateIndicatorId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefParticipationStatusMath"/> model
        /// </summary>
        public Guid? RefParticipationStatusMathId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefParticipationStatusRla"/> model
        /// </summary>
        public Guid? RefParticipationStatusRlaId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefProficiencyTargetStatusMath"/> model
        /// </summary>
        public Guid? RefProficiencyTargetStatusMathId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefProficiencyTargetStatusRLA"/> model
        /// </summary>
        public Guid? RefProficiencyTargetStatusRLAId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefReconstitutedStatus"/> model
        /// </summary>
        public Guid? RefReconstitutedStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefTargetedSupportAndImprovementStatus"/> model
        /// </summary>
        public Guid? RefTargetedSupportAndImprovementStatusId { get; set; }

    }
}
