using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("FacilityMortgage")]
    public partial class FacilityMortgage
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FacilityMortgage()
        {
            FacilityFinancials = new HashSet<FacilityFinancial>();
            FacilityMortgageFees = new HashSet<FacilityMortgageFee>();
        }

        public int FacilityMortgageId { get; set; }

        public int FacilityId { get; set; }

        public decimal? FacilityMortgageInterestAmount { get; set; }

        public decimal? FacilityTotalAssessedValue { get; set; }

        public int? RefFacilityMortgageInterestTypeId { get; set; }

        public int? RefFacilityMortgageTypeId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public Guid? RecordStatusId { get; set; }

        public Guid? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual Facility Facility { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FacilityFinancial> FacilityFinancials { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefFacilityMortgageInterestType RefFacilityMortgageInterestType { get; set; }

        public virtual RefFacilityMortgageType RefFacilityMortgageType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FacilityMortgageFee> FacilityMortgageFees { get; set; }
    }
}
