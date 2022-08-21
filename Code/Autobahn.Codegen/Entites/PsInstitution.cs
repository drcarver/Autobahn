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
    [Table("PsInstitution")]
    public partial class PsInstitution
    {
        public PsInstitution()
        {
            PsPriceOfAttendances = new HashSet<PsPriceOfAttendance>();
        }

        [Key]
        public int PsInstitutionId { get; set; }
        /// <summary>
        /// See the CEDS_Def_Desc extended property.
        /// </summary>
        public int OrganizationId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public bool? VirtualIndicator { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public bool? InstitutionallyControlledHousingStatus { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefCarnegieBasicClassificationId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefControlOfInstitutionId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefLevelOfInstitutionId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefPredominantCalendarSystemId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefTenureSystemId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefAdmissionConsiderationLevelId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefAdmissionConsiderationTypeId { get; set; }
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
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefAdministrativeFundingControlId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefIncreasedLearningTimeTypeId { get; set; }
        public int? RecordStatusId { get; set; }
        public int? DataCollectionId { get; set; }

        [ForeignKey("DataCollectionId")]
        [InverseProperty("PsInstitutions")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("OrganizationId")]
        [InverseProperty("PsInstitutions")]
        public virtual Organization Organization { get; set; } = null!;
        [ForeignKey("RecordStatusId")]
        [InverseProperty("PsInstitutions")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefAdministrativeFundingControlId")]
        [InverseProperty("PsInstitutions")]
        public virtual RefAdministrativeFundingControl? RefAdministrativeFundingControl { get; set; }
        [ForeignKey("RefAdmissionConsiderationLevelId")]
        [InverseProperty("PsInstitutions")]
        public virtual RefAdmissionConsiderationLevel? RefAdmissionConsiderationLevel { get; set; }
        [ForeignKey("RefAdmissionConsiderationTypeId")]
        [InverseProperty("PsInstitutions")]
        public virtual RefAdmissionConsiderationType? RefAdmissionConsiderationType { get; set; }
        [ForeignKey("RefCarnegieBasicClassificationId")]
        [InverseProperty("PsInstitutions")]
        public virtual RefCarnegieBasicClassification? RefCarnegieBasicClassification { get; set; }
        [ForeignKey("RefControlOfInstitutionId")]
        [InverseProperty("PsInstitutions")]
        public virtual RefControlOfInstitution? RefControlOfInstitution { get; set; }
        [ForeignKey("RefIncreasedLearningTimeTypeId")]
        [InverseProperty("PsInstitutions")]
        public virtual RefIncreasedLearningTimeType? RefIncreasedLearningTimeType { get; set; }
        [ForeignKey("RefLevelOfInstitutionId")]
        [InverseProperty("PsInstitutions")]
        public virtual RefLevelOfInstitution? RefLevelOfInstitution { get; set; }
        [ForeignKey("RefPredominantCalendarSystemId")]
        [InverseProperty("PsInstitutions")]
        public virtual RefPredominantCalendarSystem? RefPredominantCalendarSystem { get; set; }
        [ForeignKey("RefTenureSystemId")]
        [InverseProperty("PsInstitutions")]
        public virtual RefTenureSystem? RefTenureSystem { get; set; }
        [InverseProperty("PsInstitution")]
        public virtual ICollection<PsPriceOfAttendance> PsPriceOfAttendances { get; set; }
    }
}
