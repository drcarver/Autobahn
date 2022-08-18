//***************************************************************************
//* DomainName: Postsecondary (PS) Interfaces (used by both models and View Models
//* FileName:   IPsStudentFinancialAid.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Postsecondary.Interfaces
{
     /// <summary>
     /// The IPsStudentFinancialAid Interface
     /// </summary>
    public partial interface IPsStudentFinancialAid : IAutobahnBase
    {
        /// <summary>
        /// Financial Aid Applicant
        /// <para>
        /// Any applicant who submits any one of the institutionally required financial aid applications/forms, such as the  Free Application for Federal Student Aid (FAFSA).
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19745">Financial Aid Applicant</a>
        /// </para>
        /// </summary>
        System.Boolean? FinancialAidApplicant { get; set; }

        /// <summary>
        /// Financial Aid Income Level
        /// <para>
        /// The income level of an individual that is used by an institution's financial aid office to determine an individual's Expected Family Contribution (EFC).  For dependent students this will include the parents' adjusted gross income and the student's adjusted gross income.  For independent students this will include the student's adjusted gross income.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20319">Financial Aid Income Level</a>
        /// </para>
        /// </summary>
        System.Decimal? FinancialAidIncomeLevel { get; set; }

        /// <summary>
        /// Financial Need
        /// <para>
        /// The amount of financial need as determined by an institution using the federal methodology and/or your institution's own standards.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19747">Financial Need</a>
        /// </para>
        /// </summary>
        System.Decimal? FinancialNeed { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
        /// </summary>
        Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFinancialAidVeteransBenefitStatus"/> model
        /// </summary>
        Guid? RefFinancialAidVeteransBenefitStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFinancialAidVeteransBenefitType"/> model
        /// </summary>
        Guid? RefFinancialAidVeteransBenefitTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefNeedDeterminationMethod"/> model
        /// </summary>
        Guid? RefNeedDeterminationMethodId { get; set; }

        /// <summary>
        /// Title IV Participant and Recipient
        /// <para>
        /// A person who receives Title IV aid.  Title IV aid includes grant aid, work study aid, and loan aid such as: Federal Pell Grant, Federal Supplemental Educational Opportunity Grant (FSEOG), Teacher Education Assistance for College and Higher Education (TEACH) Grant, Federal Work-Study, Federal Perkins Loan, Subsidized Direct or FFEL Stafford Loan, and Unsubsidized Direct or FFEL Stafford Loan.  Title IV aid specifications are defined by the instructions for the IPEDS Student Financial Aid survey.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19292">Title IV Participant and Recipient</a>
        /// </para>
        /// </summary>
        System.Boolean? TitleIVParticipantAndRecipient { get; set; }

    }
}
