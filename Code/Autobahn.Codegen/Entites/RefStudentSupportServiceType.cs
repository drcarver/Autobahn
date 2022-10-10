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
    [Table("RefStudentSupportServiceType", Schema = "Organization")]
    public partial class RefStudentSupportServiceType
    {
        public RefStudentSupportServiceType()
        {
            IndividualizedPrograms = new HashSet<IndividualizedProgram>();
            OrganizationServices = new HashSet<OrganizationService>();
            ServiceProvideds = new HashSet<ServiceProvided>();
        }

        /// <summary>
        /// Surrogate Key
        /// </summary>
        [Key]
        public int RefStudentSupportServiceTypeId { get; set; }
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
        [InverseProperty("RefStudentSupportServiceTypes")]
        public virtual Organization? RefJurisdiction { get; set; }
        [InverseProperty("RefStudentSupportServiceType")]
        public virtual ICollection<IndividualizedProgram> IndividualizedPrograms { get; set; }
        [InverseProperty("RefStudentSupportServiceType")]
        public virtual ICollection<OrganizationService> OrganizationServices { get; set; }
        [InverseProperty("RefStudentSupportServiceType")]
        public virtual ICollection<ServiceProvided> ServiceProvideds { get; set; }
    }
}
