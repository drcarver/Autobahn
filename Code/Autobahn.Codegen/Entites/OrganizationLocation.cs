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
    [Table("OrganizationLocation", Schema = "Organization")]
    public partial class OrganizationLocation
    {
        /// <summary>
        /// Surrogate Key
        /// </summary>
        [Key]
        public int OrganizationLocationId { get; set; }
        /// <summary>
        /// Foreign key - Organization.
        /// </summary>
        public int OrganizationId { get; set; }
        /// <summary>
        /// Foreign key - Location.
        /// </summary>
        public int LocationId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefOrganizationLocationTypeId { get; set; }
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
        [InverseProperty("OrganizationLocations")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("LocationId")]
        [InverseProperty("OrganizationLocations")]
        public virtual Location Location { get; set; } = null!;
        [ForeignKey("OrganizationId")]
        [InverseProperty("OrganizationLocations")]
        public virtual Organization Organization { get; set; } = null!;
        [ForeignKey("RecordStatusId")]
        [InverseProperty("OrganizationLocations")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefOrganizationLocationTypeId")]
        [InverseProperty("OrganizationLocations")]
        public virtual RefOrganizationLocationType? RefOrganizationLocationType { get; set; }
    }
}
