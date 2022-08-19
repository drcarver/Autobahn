//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefRecordStatusCreatorEntity.cs
//**********************************************************

using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    /// <summary>
    /// The type of entity that created or indicated the Record Status Type
    /// </summary>
    [Table("RefRecordStatusCreatorEntity")]
    public partial class RefRecordStatusCreatorEntity : EntityReferenceBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RefRecordStatusCreatorEntity()
        {
            //RecordStatusHistories = new HashSet<RecordStatusHistory>();
        }

        /// <summary>
        /// The Id of the creator's organization
        /// </summary>
        [ForeignKey("Organization")]
        public Guid OrganizationId { get; set; }

        public virtual Organization Organization { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<RecordStatusHistory> RecordStatusHistories { get; set; }
    }
}
