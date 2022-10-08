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
    [Table("Incident", Schema = "Incident")]
    public partial class Incident
    {
        public Incident()
        {
            IncidentPeople = new HashSet<IncidentPerson>();
            K12studentDisciplines = new HashSet<K12StudentDiscipline>();
        }

        /// <summary>
        /// Surrogate Key
        /// </summary>
        [Key]
        public int IncidentId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(40)]
        public string? IncidentIdentifier { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "date")]
        public DateTime? IncidentDate { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public TimeSpan? IncidentTime { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefIncidentTimeDescriptionCodeId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public string? IncidentDescription { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefIncidentBehaviorId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefIncidentBehaviorSecondaryId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefIncidentInjuryTypeId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefWeaponTypeId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(30)]
        public string? IncidentCost { get; set; }
        /// <summary>
        /// Foreign key - OrganizationPersonRoleId.
        /// </summary>
        public int? OrganizationPersonRoleId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? IncidentReporterId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefIncidentReporterTypeId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefIncidentLocationId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefFirearmTypeId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(100)]
        public string? RegulationViolatedDescription { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public bool? RelatedToDisabilityManifestationInd { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public bool? ReportedToLawEnforcementInd { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefIncidentMultipleOffenseTypeId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefIncidentPerpetratorInjuryTypeId { get; set; }
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
        [InverseProperty("Incidents")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("IncidentReporterId")]
        [InverseProperty("Incidents")]
        public virtual Person? IncidentReporter { get; set; }
        [ForeignKey("OrganizationPersonRoleId")]
        [InverseProperty("Incidents")]
        public virtual OrganizationPersonRole? OrganizationPersonRole { get; set; }
        [ForeignKey("RecordStatusId")]
        [InverseProperty("Incidents")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefFirearmTypeId")]
        [InverseProperty("Incidents")]
        public virtual RefFirearmType? RefFirearmType { get; set; }
        [ForeignKey("RefIncidentBehaviorId")]
        [InverseProperty("Incidents")]
        public virtual RefIncidentBehavior? RefIncidentBehavior { get; set; }
        [ForeignKey("RefIncidentBehaviorSecondaryId")]
        [InverseProperty("Incidents")]
        public virtual RefIncidentBehaviorSecondary? RefIncidentBehaviorSecondary { get; set; }
        [ForeignKey("RefIncidentInjuryTypeId")]
        [InverseProperty("Incidents")]
        public virtual RefIncidentInjuryType? RefIncidentInjuryType { get; set; }
        [ForeignKey("RefIncidentLocationId")]
        [InverseProperty("Incidents")]
        public virtual RefIncidentLocation? RefIncidentLocation { get; set; }
        [ForeignKey("RefIncidentMultipleOffenseTypeId")]
        [InverseProperty("Incidents")]
        public virtual RefIncidentMultipleOffenseType? RefIncidentMultipleOffenseType { get; set; }
        [ForeignKey("RefIncidentPerpetratorInjuryTypeId")]
        [InverseProperty("Incidents")]
        public virtual RefIncidentPerpetratorInjuryType? RefIncidentPerpetratorInjuryType { get; set; }
        [ForeignKey("RefIncidentReporterTypeId")]
        [InverseProperty("Incidents")]
        public virtual RefIncidentReporterType? RefIncidentReporterType { get; set; }
        [ForeignKey("RefIncidentTimeDescriptionCodeId")]
        [InverseProperty("Incidents")]
        public virtual RefIncidentTimeDescriptionCode? RefIncidentTimeDescriptionCode { get; set; }
        [ForeignKey("RefWeaponTypeId")]
        [InverseProperty("Incidents")]
        public virtual RefWeaponType? RefWeaponType { get; set; }
        [InverseProperty("Incident")]
        public virtual ICollection<IncidentPerson> IncidentPeople { get; set; }
        [InverseProperty("Incident")]
        public virtual ICollection<K12StudentDiscipline> K12studentDisciplines { get; set; }
    }
}
