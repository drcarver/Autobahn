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
    [Table("QuarterlyEmploymentRecord")]
    public partial class QuarterlyEmploymentRecord
    {
        /// <summary>
        /// Surrogate Key
        /// </summary>
        [Key]
        public int QuarterlyEmploymentRecordId { get; set; }
        /// <summary>
        /// Foreign key - Person
        /// </summary>
        public int PersonId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "decimal(9, 2)")]
        public decimal? Earnings { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column("EmploymentNAICSCode")]
        [StringLength(50)]
        public string? EmploymentNaicscode { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "date")]
        public DateTime? ReferencePeriodStartDate { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "date")]
        public DateTime? ReferencePeriodEndDate { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column("RefERAdministrativeDataSourceId")]
        public int? RefEradministrativeDataSourceId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefEmploymentLocationId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefEmployedPriorToEnrollmentId { get; set; }
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
        [InverseProperty("QuarterlyEmploymentRecords")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("PersonId")]
        [InverseProperty("QuarterlyEmploymentRecords")]
        public virtual Person Person { get; set; } = null!;
        [ForeignKey("RecordStatusId")]
        [InverseProperty("QuarterlyEmploymentRecords")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefEmployedPriorToEnrollmentId")]
        [InverseProperty("QuarterlyEmploymentRecords")]
        public virtual RefEmployedPriorToEnrollment? RefEmployedPriorToEnrollment { get; set; }
        [ForeignKey("RefEmploymentLocationId")]
        [InverseProperty("QuarterlyEmploymentRecords")]
        public virtual RefEmploymentLocation? RefEmploymentLocation { get; set; }
        [ForeignKey("RefEradministrativeDataSourceId")]
        [InverseProperty("QuarterlyEmploymentRecords")]
        public virtual RefEradministrativeDataSource? RefEradministrativeDataSource { get; set; }
    }
}
