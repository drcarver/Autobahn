//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   PsStudentFinancialAid.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Postsecondary.Models
{
     /// <summary>
     /// The PsStudentFinancialAid
     /// </summary>
    public partial class PsStudentFinancialAid : AutobahnBase, Interfaces.IPsStudentFinancialAid
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Defines the PsStudentFinancialAid.FinancialAidApplicant nullable property
        /// </summary>
        public System.Boolean? FinancialAidApplicant { get; set; }

        /// <summary>
        /// Defines the PsStudentFinancialAid.FinancialNeed nullable property
        /// </summary>
        public System.Decimal? FinancialNeed { get; set; }

        /// <summary>
        /// Defines the PsStudentFinancialAid.TitleIVParticipantAndRecipient nullable property
        /// </summary>
        public System.Boolean? TitleIVParticipantAndRecipient { get; set; }

        /// <summary>
        /// Defines the PsStudentFinancialAid.FinancialAidIncomeLevel nullable property
        /// </summary>
        public System.Decimal? FinancialAidIncomeLevel { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefNeedDeterminationMethod"/> model
        /// </summary>
        public Guid? RefNeedDeterminationMethodId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFinancialAidVeteransBenefitStatus"/> model
        /// </summary>
        public Guid? RefFinancialAidVeteransBenefitStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFinancialAidVeteransBenefitType"/> model
        /// </summary>
        public Guid? RefFinancialAidVeteransBenefitTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
