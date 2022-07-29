namespace Autobahn.Entities
{
    public partial class K12Sea
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public K12Sea()
        {
            K12SeaFederalFunds = new HashSet<K12SeaFederalFunds>();
        }

        public int K12SeaId { get; set; }

        public int OrganizationId { get; set; }

        public int? RefStateANSICodeId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual Organization Organization { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefStateANSICode RefStateANSICode { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<K12SeaFederalFunds> K12SeaFederalFunds { get; set; }
    }
}
