//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   PersonDigitalAccess.cs
//**********************************************************

using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities.Common
{
    [Table("PersonDigitalAccess")]
    public partial class PersonDigitalAccess : EntityBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PersonDigitalAccess()
        {
            PersonDigitalAccessSpeeds = new HashSet<PersonDigitalAccessSpeed>();
        }

        [ForeignKey("Person")]
        public Guid PersonId { get; set; }

        public bool? InternetAccessInResidence { get; set; }

        [ForeignKey("PersonAddress")]
        public Guid? PersonAddressId { get; set; }

        [ForeignKey("RefBarrierToInternetAccessInResidence")]
        public Guid? RefBarrierToInternetAccessInResidenceId { get; set; }

        [ForeignKey("RefInternetAccessTypeInResidence")]
        public Guid? RefInternetAccessTypeInResidenceId { get; set; }

        [ForeignKey("RefInternetPerformanceInResidence")]
        public Guid? RefInternetPerformanceInResidenceId { get; set; }

        public virtual Person Person { get; set; }

        public virtual PersonAddress PersonAddress { get; set; }

        public virtual RefBarrierToInternetAccessInResidence RefBarrierToInternetAccessInResidence { get; set; }

        public virtual RefInternetAccessTypeInResidence RefInternetAccessTypeInResidence { get; set; }

        public virtual RefInternetPerformanceInResidence RefInternetPerformanceInResidence { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PersonDigitalAccessSpeed> PersonDigitalAccessSpeeds { get; set; }
    }
}
