//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefRecordStatusType.cs
//**********************************************************

using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities.Common
{
    /// <summary>
    /// A process indicator of the level of stability, quality, and/or preparedness of the record.
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermxTopicId=57529">Record Status Type</a>
    /// </summary>
    [Table("RefRecordStatusType")]
    public partial class RefRecordStatusType : EntityReferenceBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RefRecordStatusType()
        {
            //RecordStatusHistories = new HashSet<RecordStatusHistory>();
        }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<RecordStatusHistory> RecordStatusHistories { get; set; }
    }
}
