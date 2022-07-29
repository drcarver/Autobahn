using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("FinancialAidApplication")]
    public partial class FinancialAidApplication
    {
        public int FinancialAidApplicationId { get; set; }

        public int OrganizationPersonRoleId { get; set; }

        public int RefFinancialAidApplicationTypeId { get; set; }

        [StringLength(9)]
        public string FinancialAidYearDesignator { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual OrganizationPersonRole OrganizationPersonRole { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefFinancialAidApplicationType RefFinancialAidApplicationType { get; set; }
    }
}
