using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ScafoldADatabase.Entities
{
    /// <summary>
    /// See the CEDS_Def_Desc extended property.
    /// </summary>
    [Table("IEPAuthorization", Schema = "K12")]
    public partial class IEPAuthorization
    {
        public IEPAuthorization()
        {
            IEPAuthorizationRejecteds = new HashSet<IEPAuthorizationRejected>();
        }

        [Key]
        public int IEPAuthorizationId { get; set; }
        public int AuthorizationDocumentId { get; set; }
        public int IndividualizedProgramId { get; set; }
        public int? RefIEPAuthorizationDocumentTypeId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? RecordStartDateTime { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? RecordEndDateTime { get; set; }
        public int? RecordStatusId { get; set; }
        public int? DataCollectionId { get; set; }

        [ForeignKey("AuthorizationDocumentId")]
        [InverseProperty("Iepauthorizations")]
        public virtual AuthorizationDocument AuthorizationDocument { get; set; } = null!;
        [ForeignKey("DataCollectionId")]
        [InverseProperty("Iepauthorizations")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("IndividualizedProgramId")]
        [InverseProperty("Iepauthorizations")]
        public virtual IndividualizedProgram IndividualizedProgram { get; set; } = null!;
        [ForeignKey("RecordStatusId")]
        [InverseProperty("Iepauthorizations")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefIEPAuthorizationDocumentTypeId")]
        [InverseProperty("Iepauthorizations")]
        public virtual RefIEPAuthorizationDocumentType? RefIEPAuthorizationDocumentType { get; set; }
        [InverseProperty("Iepauthorization")]
        public virtual ICollection<IEPAuthorizationRejected> IEPAuthorizationRejecteds { get; set; }
    }
}
