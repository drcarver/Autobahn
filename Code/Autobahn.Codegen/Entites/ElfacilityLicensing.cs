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
    [Table("ELFacilityLicensing")]
    public partial class ElfacilityLicensing
    {
        /// <summary>
        /// Surrogate Key
        /// </summary>
        [Key]
        [Column("ELFacilityLicensingId")]
        public int ElfacilityLicensingId { get; set; }
        /// <summary>
        /// Surrogate key from Organization
        /// </summary>
        public int OrganizationId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column("RefELFacilityLicensingStatusId")]
        public int? RefElfacilityLicensingStatusId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? StateLicensedFacilityCapacity { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "date")]
        public DateTime? InitialLicensingDate { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "date")]
        public DateTime? ContinuingLicenseDate { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefLicenseExemptId { get; set; }
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
        [InverseProperty("ElfacilityLicensings")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("OrganizationId")]
        [InverseProperty("ElfacilityLicensings")]
        public virtual Organization Organization { get; set; } = null!;
        [ForeignKey("RecordStatusId")]
        [InverseProperty("ElfacilityLicensings")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefElfacilityLicensingStatusId")]
        [InverseProperty("ElfacilityLicensings")]
        public virtual RefElfacilityLicensingStatus? RefElfacilityLicensingStatus { get; set; }
        [ForeignKey("RefLicenseExemptId")]
        [InverseProperty("ElfacilityLicensings")]
        public virtual RefLicenseExempt? RefLicenseExempt { get; set; }
    }
}
