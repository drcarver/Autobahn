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
    [Table("K12SchoolCorrectiveAction", Schema = "K12")]
    public partial class K12SchoolCorrectiveAction
    {
        [Key]
        public int K12SchoolCorrectiveActionId { get; set; }
        public int K12SchoolId { get; set; }
        public int RefCorrectiveActionTypeId { get; set; }
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

        [ForeignKey("DataCollectionId")]
        [InverseProperty("K12schoolCorrectiveActions")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("K12schoolId")]
        [InverseProperty("K12schoolCorrectiveActions")]
        public virtual K12School K12school { get; set; } = null!;
        [ForeignKey("RecordStatusId")]
        [InverseProperty("K12schoolCorrectiveActions")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefCorrectiveActionTypeId")]
        [InverseProperty("K12schoolCorrectiveActions")]
        public virtual RefCorrectiveActionType RefCorrectiveActionType { get; set; } = null!;
    }
}
