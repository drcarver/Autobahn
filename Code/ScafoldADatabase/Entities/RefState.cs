using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ScafoldADatabase.Entities
{
    /// <summary>
    /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
    /// </summary>
    [Table("RefState")]
    public partial class RefState
    {
        public RefState()
        {
            LocationAddresses = new HashSet<LocationAddress>();
            PersonAddresses = new HashSet<PersonAddress>();
            PersonBirthplaces = new HashSet<PersonBirthplace>();
            PersonCredentials = new HashSet<PersonCredential>();
            PersonDetails = new HashSet<PersonDetail>();
            ProgramParticipationMigrants = new HashSet<ProgramParticipationMigrant>();
        }

        /// <summary>
        /// Surrogate Key
        /// </summary>
        [Key]
        public int RefStateId { get; set; }
        /// <summary>
        /// See the CEDS_Def_Desc extended property.
        /// </summary>
        [StringLength(150)]
        public string Description { get; set; } = null!;
        /// <summary>
        /// See the CEDS_Def_Desc extended property.
        /// </summary>
        [StringLength(50)]
        public string? Code { get; set; }
        [StringLength(4000)]
        public string? Definition { get; set; }
        /// <summary>
        /// Surrogate key from Organization identifying the publisher of the reference value.
        /// </summary>
        public int? RefJurisdictionId { get; set; }
        [Column(TypeName = "decimal(5, 2)")]
        public decimal? SortOrder { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? RecordStartDateTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? RecordEndDateTime { get; set; }

        [ForeignKey("RefJurisdictionId")]
        [InverseProperty("RefStates")]
        public virtual Organization? RefJurisdiction { get; set; }
        [InverseProperty("RefState")]
        public virtual ICollection<LocationAddress> LocationAddresses { get; set; }
        [InverseProperty("RefState")]
        public virtual ICollection<PersonAddress> PersonAddresses { get; set; }
        [InverseProperty("RefState")]
        public virtual ICollection<PersonBirthplace> PersonBirthplaces { get; set; }
        [InverseProperty("RefIssuingState")]
        public virtual ICollection<PersonCredential> PersonCredentials { get; set; }
        [InverseProperty("RefStateOfResidence")]
        public virtual ICollection<PersonDetail> PersonDetails { get; set; }
        [InverseProperty("RefQualifyingMoveFromState")]
        public virtual ICollection<ProgramParticipationMigrant> ProgramParticipationMigrants { get; set; }
    }
}
