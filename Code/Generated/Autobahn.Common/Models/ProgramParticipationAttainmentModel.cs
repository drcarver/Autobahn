//**********************************************************
//* DomainName: Common Models
//* FileName:   ProgramParticipationAttainmentModel.cs
//* Name:       Adult Education Credential Attainment Employed Indicator
//* Definition: An indication of whether the adult education participant received a secondary school diploma or its recognized equivalent while enrolled in the adult education program or within one year of exiting the adult education program and was employed within one year of exiting the adult education program.
//***************************************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// An indication of whether the adult education participant received a secondary school diploma or its recognized equivalent while enrolled in the adult education program or within one year of exiting the adult education program and was employed within one year of exiting the adult education program.
     /// </summary>
    public partial class ProgramParticipationAttainmentModel : AutobahnBase, Interfaces.IProgramParticipationAttainment
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
        public System.Boolean? AECredentialAttainmentEmployedIndicator { get; set; }

        /// <summary>
        /// Adult Education Credential Attainment Postsecondary Credential Indicator
        /// <para>
        /// An indication of whether the adult education participant received a postsecondary credential while enrolled in the adult education program or within one year of exiting the adult education program.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20913">Adult Education Credential Attainment Postsecondary Credential Indicator</a>
        /// </para>
        /// </summary>
        public System.Boolean? AECredentialAttainmentPSCredentialIndicator { get; set; }

        /// <summary>
        /// Adult Education Credential Attainment Postsecondary Enrollment Indicator
        /// <para>
        /// An indication of whether the adult education participant received a secondary school diploma or its recognized equivalent while enrolled in the adult education program or within one year of exiting the adult education program and entered into postsecondary education within one year of exiting the adult education program.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20914">Adult Education Credential Attainment Postsecondary Enrollment Indicator</a>
        /// </para>
        /// </summary>
        public System.Boolean? AECredentialAttainmentPSEnrollmentIndicator { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IPersonProgramParticipation"/> model
        /// </summary>
        public Guid PersonProgramParticipationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEdFactsAcademicOrCareerAndTechnicalOutcomeExitType"/> model
        /// </summary>
        public Guid? RefEdFactsAcademicOrCareerAndTechnicalOutcomeExitTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEdFactsAcademicOrCareerAndTechnicalOutcomeType"/> model
        /// </summary>
        public Guid? RefEdFactsAcademicOrCareerAndTechnicalOutcomeTypeId { get; set; }

    }
}
