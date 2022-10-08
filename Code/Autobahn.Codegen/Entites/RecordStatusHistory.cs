using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ScafoldADatabase.Entities
{
    [Table("RecordStatusHistory", Schema = "Common")]
    public partial class RecordStatusHistory
    {
        [Key]
        public int RecordStatusHistoryId { get; set; }
        public int RecordStatusId { get; set; }
        public int RecordId { get; set; }
        [Column("RecordPKColumn")]
        [StringLength(100)]
        public string RecordPkcolumn { get; set; } = null!;
        [StringLength(100)]
        public string RecordTable { get; set; } = null!;
        public int? RecordStatusCreatorOrganizationId { get; set; }
        public int? RecordStatusCreatorPersonId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? RecordStatusDate { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int RefRecordStatusTypeId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefRecordStatusCreatorEntityId { get; set; }

        [ForeignKey("RecordStatusId")]
        [InverseProperty("RecordStatusHistories")]
        public virtual RecordStatus RecordStatus { get; set; } = null!;
        [ForeignKey("RecordStatusCreatorOrganizationId")]
        [InverseProperty("RecordStatusHistories")]
        public virtual Organization? RecordStatusCreatorOrganization { get; set; }
        [ForeignKey("RecordStatusCreatorPersonId")]
        [InverseProperty("RecordStatusHistories")]
        public virtual Person? RecordStatusCreatorPerson { get; set; }
        [ForeignKey("RefRecordStatusCreatorEntityId")]
        [InverseProperty("RecordStatusHistories")]
        public virtual RefRecordStatusCreatorEntity? RefRecordStatusCreatorEntity { get; set; }
        [ForeignKey("RefRecordStatusTypeId")]
        [InverseProperty("RecordStatusHistories")]
        public virtual RefRecordStatusType RefRecordStatusType { get; set; } = null!;
    }
}
