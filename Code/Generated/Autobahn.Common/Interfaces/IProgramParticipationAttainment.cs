//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IProgramParticipationAttainment.cs
//* Name:       Adult Education Credential Attainment Employed Indicator
//* Definition: 
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// 
     /// </summary>
    public partial interface IProgramParticipationAttainment : IAutobahnBase
    {
        /// <summary>
        /// Adult Education Credential Attainment Employed Indicator
        /// <para>
        /// An indication of whether the adult education participant received a secondary school diploma or its recognized equivalent while enrolled in the adult education program or within one year of exiting the adult education program and was employed within one year of exiting the adult education program.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20912">Adult Education Credential Attainment Employed Indicator</a>
        /// </para>
        /// </summary>
        System.Boolean? AECredentialAttainmentEmployedIndicator { get; set; }

        /// <summary>
        /// Adult Education Credential Attainment Postsecondary Credential Indicator
        /// <para>
        /// An indication of whether the adult education participant received a postsecondary credential while enrolled in the adult education program or within one year of exiting the adult education program.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20913">Adult Education Credential Attainment Postsecondary Credential Indicator</a>
        /// </para>
        /// </summary>
        System.Boolean? AECredentialAttainmentPSCredentialIndicator { get; set; }

        /// <summary>
        /// Adult Education Credential Attainment Postsecondary Enrollment Indicator
        /// <para>
        /// An indication of whether the adult education participant received a secondary school diploma or its recognized equivalent while enrolled in the adult education program or within one year of exiting the adult education program and entered into postsecondary education within one year of exiting the adult education program.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20914">Adult Education Credential Attainment Postsecondary Enrollment Indicator</a>
        /// </para>
        /// </summary>
        System.Boolean? AECredentialAttainmentPSEnrollmentIndicator { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IPersonProgramParticipation"/> model
        /// </summary>
        Guid PersonProgramParticipationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefEdFactsAcademicOrCareerAndTechnicalOutcomeExitType"/> model
        /// </summary>
        Guid? RefEdFactsAcademicOrCareerAndTechnicalOutcomeExitTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefEdFactsAcademicOrCareerAndTechnicalOutcomeType"/> model
        /// </summary>
        Guid? RefEdFactsAcademicOrCareerAndTechnicalOutcomeTypeId { get; set; }

    }
}
