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
    [Table("EarlyChildhoodCredential")]
    public partial class EarlyChildhoodCredential
    {
        [Key]
        public int EarlyChildhoodCredentialId { get; set; }
        /// <summary>
        /// Surrogate Key
        /// </summary>
        public int PersonCredentialId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int RefEarlyChildhoodCredentialId { get; set; }
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
        [InverseProperty("EarlyChildhoodCredentials")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("PersonCredentialId")]
        [InverseProperty("EarlyChildhoodCredentials")]
        public virtual PersonCredential PersonCredential { get; set; } = null!;
        [ForeignKey("RecordStatusId")]
        [InverseProperty("EarlyChildhoodCredentials")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefEarlyChildhoodCredentialId")]
        [InverseProperty("EarlyChildhoodCredentials")]
        public virtual RefEarlyChildhoodCredential RefEarlyChildhoodCredential { get; set; } = null!;
    }
}
