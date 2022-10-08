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
    [Table("K12Lea", Schema = "K12")]
    public partial class K12Lea
    {
        public K12Lea()
        {
            K12leaFederalReportings = new HashSet<K12LeaFederalReporting>();
            K12leaGradeLevelsApproveds = new HashSet<K12LeaGradeLevelsApproved>();
            K12leaGradeOffereds = new HashSet<K12LeaGradeOffered>();
            K12leaPreKeligibilities = new HashSet<K12LeaPreKEligibility>();
            K12leaPreKeligibleAgesIdeas = new HashSet<K12leaPreKeligibleAgesIdea>();
            K12leaSafeDrugFrees = new HashSet<K12LeaSafeDrugFree>();
            K12leaTitleIiiprofessionalDevelopments = new HashSet<K12LeaTitleIIIProfessionalDevelopment>();
            K12leaTitleIsupportServices = new HashSet<K12LeaTitleISupportService>();
        }

        [Key]
        public int K12LeaId { get; set; }
        /// <summary>
        /// See the CEDS_Def_Desc extended property.
        /// </summary>
        public int OrganizationId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(3)]
        public string? SupervisoryUnionIdentificationNumber { get; set; }
        public bool? CharterSchoolIndicator { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefLeaTypeId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefLeaImprovementStatusId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefPublicSchoolChoiceStatusId { get; set; }
        public int? RefCharterLeaStatusId { get; set; }
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
        [InverseProperty("K12leas")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("OrganizationId")]
        [InverseProperty("K12leas")]
        public virtual Organization Organization { get; set; } = null!;
        [ForeignKey("RecordStatusId")]
        [InverseProperty("K12leas")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefCharterLeaStatusId")]
        [InverseProperty("K12leas")]
        public virtual RefCharterLeaStatus? RefCharterLeaStatus { get; set; }
        [ForeignKey("RefLeaImprovementStatusId")]
        [InverseProperty("K12leas")]
        public virtual RefLeaImprovementStatus? RefLeaImprovementStatus { get; set; }
        [ForeignKey("RefLeaTypeId")]
        [InverseProperty("K12leas")]
        public virtual RefLeaType? RefLeaType { get; set; }
        [ForeignKey("RefPublicSchoolChoiceStatusId")]
        [InverseProperty("K12leas")]
        public virtual RefPublicSchoolChoiceStatus? RefPublicSchoolChoiceStatus { get; set; }
        [InverseProperty("K12lea")]
        public virtual ICollection<K12LeaFederalReporting> K12leaFederalReportings { get; set; }
        [InverseProperty("K12lea")]
        public virtual ICollection<K12LeaGradeLevelsApproved> K12leaGradeLevelsApproveds { get; set; }
        [InverseProperty("K12lea")]
        public virtual ICollection<K12LeaGradeOffered> K12leaGradeOffereds { get; set; }
        [InverseProperty("K12lea")]
        public virtual ICollection<K12LeaPreKEligibility> K12leaPreKeligibilities { get; set; }
        [InverseProperty("K12lea")]
        public virtual ICollection<K12leaPreKeligibleAgesIdea> K12leaPreKeligibleAgesIdeas { get; set; }
        [InverseProperty("K12lea")]
        public virtual ICollection<K12LeaSafeDrugFree> K12leaSafeDrugFrees { get; set; }
        [InverseProperty("K12lea")]
        public virtual ICollection<K12LeaTitleIIIProfessionalDevelopment> K12leaTitleIiiprofessionalDevelopments { get; set; }
        [InverseProperty("K12lea")]
        public virtual ICollection<K12LeaTitleISupportService> K12leaTitleIsupportServices { get; set; }
    }
}
