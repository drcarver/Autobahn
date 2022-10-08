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
    [Table("OrganizationEmployeeBenefit", Schema = "Organization")]
    public partial class OrganizationEmployeeBenefit
    {
        [Key]
        public int OrganizationEmployeeBenefitId { get; set; }
        public int OrganizationId { get; set; }
        public bool? FullTimeBenefitIndicator { get; set; }
        public bool? PartTimeBenefitIndicator { get; set; }
        public int? RefEmployeeBenefitId { get; set; }
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
        [InverseProperty("OrganizationEmployeeBenefits")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("OrganizationId")]
        [InverseProperty("OrganizationEmployeeBenefits")]
        public virtual Organization Organization { get; set; } = null!;
        [ForeignKey("RecordStatusId")]
        [InverseProperty("OrganizationEmployeeBenefits")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefEmployeeBenefitId")]
        [InverseProperty("OrganizationEmployeeBenefits")]
        public virtual RefEmployeeBenefit? RefEmployeeBenefit { get; set; }
    }
}
