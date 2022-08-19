using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("IEPAuthorization")]
    public partial class IEPAuthorization
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public IEPAuthorization()
        {
            IEPAuthorizationRejecteds = new HashSet<IEPAuthorizationRejected>();
        }

        public int IEPAuthorizationId { get; set; }

        public int AuthorizationDocumentId { get; set; }

        public int IndividualizedProgramId { get; set; }

        public int? RefIEPAuthorizationDocumentTypeId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public Guid? RecordStatusId { get; set; }

        public Guid? DataCollectionId { get; set; }

        public virtual AuthorizationDocument AuthorizationDocument { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual IndividualizedProgram IndividualizedProgram { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefIEPAuthorizationDocumentType RefIEPAuthorizationDocumentType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IEPAuthorizationRejected> IEPAuthorizationRejecteds { get; set; }
    }
}
