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
    [Table("RefCountry", Schema = "Core")]
    public partial class RefCountry
    {
        public RefCountry()
        {
            LocationAddresses = new HashSet<LocationAddress>();
            PersonAddresses = new HashSet<PersonAddress>();
            PersonBirthplaces = new HashSet<PersonBirthplace>();
            ProgramParticipationMigrants = new HashSet<ProgramParticipationMigrant>();
        }

        /// <summary>
        /// Surrogate Key
        /// </summary>
        [Key]
        public int RefCountryId { get; set; }
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
        /// <summary>
        /// See the CEDS_Def_Desc extended property.
        /// </summary>
        [StringLength(4000)]
        public string? Definition { get; set; }
        /// <summary>
        /// Surrogate key from Organization identifying the publisher of the reference value.
        /// </summary>
        public int? RefJurisdictionId { get; set; }
        /// <summary>
        /// See the CEDS_Def_Desc extended property.
        /// </summary>
        [Column(TypeName = "decimal(5, 2)")]
        public decimal? SortOrder { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? RecordStartDateTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? RecordEndDateTime { get; set; }

        [ForeignKey("RefJurisdictionId")]
        [InverseProperty("RefCountries")]
        public virtual Organization? RefJurisdiction { get; set; }
        [InverseProperty("RefCountry")]
        public virtual ICollection<LocationAddress> LocationAddresses { get; set; }
        [InverseProperty("RefCountry")]
        public virtual ICollection<PersonAddress> PersonAddresses { get; set; }
        [InverseProperty("RefCountry")]
        public virtual ICollection<PersonBirthplace> PersonBirthplaces { get; set; }
        [InverseProperty("RefQualifyingMoveFromCountry")]
        public virtual ICollection<ProgramParticipationMigrant> ProgramParticipationMigrants { get; set; }
    }
}
