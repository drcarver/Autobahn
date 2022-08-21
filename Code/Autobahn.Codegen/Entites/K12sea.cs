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
    [Table("K12Sea")]
    public partial class K12sea
    {
        public K12sea()
        {
            K12seaFederalFunds = new HashSet<K12seaFederalFund>();
        }

        [Key]
        [Column("K12SeaId")]
        public int K12seaId { get; set; }
        /// <summary>
        /// See the CEDS_Def_Desc extended property.
        /// </summary>
        public int OrganizationId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column("RefStateANSICodeId")]
        public int? RefStateAnsicodeId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? RecordStartDateTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? RecordEndDateTime { get; set; }
        public int? RecordStatusId { get; set; }
        public int? DataCollectionId { get; set; }

        [ForeignKey("DataCollectionId")]
        [InverseProperty("K12seas")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("OrganizationId")]
        [InverseProperty("K12seas")]
        public virtual Organization Organization { get; set; } = null!;
        [ForeignKey("RecordStatusId")]
        [InverseProperty("K12seas")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefStateAnsicodeId")]
        [InverseProperty("K12seas")]
        public virtual RefStateAnsicode? RefStateAnsicode { get; set; }
        [InverseProperty("K12sea")]
        public virtual ICollection<K12seaFederalFund> K12seaFederalFunds { get; set; }
    }
}
