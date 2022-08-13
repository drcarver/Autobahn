//**********************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   PsStudentFinancialAidModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Postsecondary.Models
{
     /// <summary>
     /// The PsStudentFinancialAid Model
     /// </summary>
    public partial class PsStudentFinancialAidModel : AutobahnBase, Interfaces.IPsStudentFinancialAid
    {
        /// <summary>
        /// A person who receives Title IV aid.  Title IV aid includes grant aid, work study aid, and loan aid such as: Federal Pell Grant, Federal Supplemental Educational Opportunity Grant (FSEOG), Teacher Education Assistance for College and Higher Education (TEACH) Grant, Federal Work-Study, Federal Perkins Loan, Subsidized Direct or FFEL Stafford Loan, and Unsubsidized Direct or FFEL Stafford Loan.  Title IV aid specifications are defined by the instructions for the IPEDS Student Financial Aid survey.
        /// </summary>
        public System.Boolean? FinancialAidApplicant { get; set; }

        /// <summary>
        /// A person who receives Title IV aid.  Title IV aid includes grant aid, work study aid, and loan aid such as: Federal Pell Grant, Federal Supplemental Educational Opportunity Grant (FSEOG), Teacher Education Assistance for College and Higher Education (TEACH) Grant, Federal Work-Study, Federal Perkins Loan, Subsidized Direct or FFEL Stafford Loan, and Unsubsidized Direct or FFEL Stafford Loan.  Title IV aid specifications are defined by the instructions for the IPEDS Student Financial Aid survey.
        /// </summary>
        public System.Decimal? FinancialAidIncomeLevel { get; set; }

        /// <summary>
        /// A person who receives Title IV aid.  Title IV aid includes grant aid, work study aid, and loan aid such as: Federal Pell Grant, Federal Supplemental Educational Opportunity Grant (FSEOG), Teacher Education Assistance for College and Higher Education (TEACH) Grant, Federal Work-Study, Federal Perkins Loan, Subsidized Direct or FFEL Stafford Loan, and Unsubsidized Direct or FFEL Stafford Loan.  Title IV aid specifications are defined by the instructions for the IPEDS Student Financial Aid survey.
        /// </summary>
        public System.Decimal? FinancialNeed { get; set; }

        /// <summary>
        /// A person who receives Title IV aid.  Title IV aid includes grant aid, work study aid, and loan aid such as: Federal Pell Grant, Federal Supplemental Educational Opportunity Grant (FSEOG), Teacher Education Assistance for College and Higher Education (TEACH) Grant, Federal Work-Study, Federal Perkins Loan, Subsidized Direct or FFEL Stafford Loan, and Unsubsidized Direct or FFEL Stafford Loan.  Title IV aid specifications are defined by the instructions for the IPEDS Student Financial Aid survey.
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// A person who receives Title IV aid.  Title IV aid includes grant aid, work study aid, and loan aid such as: Federal Pell Grant, Federal Supplemental Educational Opportunity Grant (FSEOG), Teacher Education Assistance for College and Higher Education (TEACH) Grant, Federal Work-Study, Federal Perkins Loan, Subsidized Direct or FFEL Stafford Loan, and Unsubsidized Direct or FFEL Stafford Loan.  Title IV aid specifications are defined by the instructions for the IPEDS Student Financial Aid survey.
        /// </summary>
        public Guid? RefFinancialAidVeteransBenefitStatusId { get; set; }

        /// <summary>
        /// A person who receives Title IV aid.  Title IV aid includes grant aid, work study aid, and loan aid such as: Federal Pell Grant, Federal Supplemental Educational Opportunity Grant (FSEOG), Teacher Education Assistance for College and Higher Education (TEACH) Grant, Federal Work-Study, Federal Perkins Loan, Subsidized Direct or FFEL Stafford Loan, and Unsubsidized Direct or FFEL Stafford Loan.  Title IV aid specifications are defined by the instructions for the IPEDS Student Financial Aid survey.
        /// </summary>
        public Guid? RefFinancialAidVeteransBenefitTypeId { get; set; }

        /// <summary>
        /// A person who receives Title IV aid.  Title IV aid includes grant aid, work study aid, and loan aid such as: Federal Pell Grant, Federal Supplemental Educational Opportunity Grant (FSEOG), Teacher Education Assistance for College and Higher Education (TEACH) Grant, Federal Work-Study, Federal Perkins Loan, Subsidized Direct or FFEL Stafford Loan, and Unsubsidized Direct or FFEL Stafford Loan.  Title IV aid specifications are defined by the instructions for the IPEDS Student Financial Aid survey.
        /// </summary>
        public Guid? RefNeedDeterminationMethodId { get; set; }

        /// <summary>
        /// A person who receives Title IV aid.  Title IV aid includes grant aid, work study aid, and loan aid such as: Federal Pell Grant, Federal Supplemental Educational Opportunity Grant (FSEOG), Teacher Education Assistance for College and Higher Education (TEACH) Grant, Federal Work-Study, Federal Perkins Loan, Subsidized Direct or FFEL Stafford Loan, and Unsubsidized Direct or FFEL Stafford Loan.  Title IV aid specifications are defined by the instructions for the IPEDS Student Financial Aid survey.
        /// </summary>
        public System.Boolean? TitleIVParticipantAndRecipient { get; set; }

    }
}
