//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   IPsStudentFinancialAid.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Postsecondary.Interfaces
{
     /// <summary>
     /// The IPsStudentFinancialAid
     /// </summary>
    public partial interface IPsStudentFinancialAid : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Defines the PsStudentFinancialAid.FinancialAidApplicant nullable property
        /// </summary>
        System.Boolean? FinancialAidApplicant { get; set; }

        /// <summary>
        /// Defines the PsStudentFinancialAid.FinancialNeed nullable property
        /// </summary>
        System.Decimal? FinancialNeed { get; set; }

        /// <summary>
        /// Defines the PsStudentFinancialAid.TitleIVParticipantAndRecipient nullable property
        /// </summary>
        System.Boolean? TitleIVParticipantAndRecipient { get; set; }

        /// <summary>
        /// Defines the PsStudentFinancialAid.FinancialAidIncomeLevel nullable property
        /// </summary>
        System.Decimal? FinancialAidIncomeLevel { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefNeedDeterminationMethod"/> model
        /// </summary>
        Guid? RefNeedDeterminationMethodId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFinancialAidVeteransBenefitStatus"/> model
        /// </summary>
        Guid? RefFinancialAidVeteransBenefitStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFinancialAidVeteransBenefitType"/> model
        /// </summary>
        Guid? RefFinancialAidVeteransBenefitTypeId { get; set; }

    }
}
