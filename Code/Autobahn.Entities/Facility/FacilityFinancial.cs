//**********************************************************
//* DomainName: Autobahn.Facility
//* FileName:   FacilityFinancial.cs
//**********************************************************

using System.ComponentModel.DataAnnotations.Schema;
using Autobahn.Entities.Financial;
using Autobahn.Interfaces.Facility;

namespace Autobahn.Entities.Facility
{
    [Table("FacilityFinancial", Schema = "Facility")]
    public partial class FacilityFinancial : EntityBase, IFacilityFinancial
    {
        [ForeignKey("OrganizationFinancial")]
        public Guid OrganizationFinancialId { get; set; }

        [ForeignKey("FacilityLease")]
        public Guid? FacilityLeaseId { get; set; }

        [ForeignKey("FacilityMortgage")]
        public Guid? FacilityMortgageId { get; set; }

        [ForeignKey("FacilityMortgageFee")]
        public Guid? FacilityMortgageFeeId { get; set; }

        public virtual FacilityLease FacilityLease { get; set; }

        public virtual FacilityMortgage FacilityMortgage { get; set; }

        public virtual FacilityMortgageFee FacilityMortgageFee { get; set; }

        public virtual OrganizationFinancial OrganizationFinancial { get; set; }
    }
}
