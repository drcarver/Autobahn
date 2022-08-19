using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("PsStudentFinancialAid")]
    public partial class PsStudentFinancialAid
    {
        public int PsStudentFinancialAidId { get; set; }

        public int OrganizationPersonRoleId { get; set; }

        public bool? FinancialAidApplicant { get; set; }

        public decimal? FinancialNeed { get; set; }

        public bool? TitleIVParticipantAndRecipient { get; set; }

        public decimal? FinancialAidIncomeLevel { get; set; }

        public int? RefNeedDeterminationMethodId { get; set; }

        public int? RefFinancialAidVeteransBenefitStatusId { get; set; }

        public int? RefFinancialAidVeteransBenefitTypeId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public Guid? RecordStatusId { get; set; }

        public Guid? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual OrganizationPersonRole OrganizationPersonRole { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefFinancialAidVeteransBenefitStatus RefFinancialAidVeteransBenefitStatus { get; set; }

        public virtual RefFinancialAidVeteransBenefitType RefFinancialAidVeteransBenefitType { get; set; }

        public virtual RefNeedDeterminationMethod RefNeedDeterminationMethod { get; set; }
    }
}
